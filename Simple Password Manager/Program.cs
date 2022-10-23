using SimplePM.Forms;
using SimplePM.Library.Assets.Processors;
using SimplePM.Library.Diagnostics;
using SimplePM.Library.Factories;
using SimplePM.Library.Networking;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SimplePM
{
    static class Program
    {
        private static IEntriesProcessor failureProcessor;
        private static IConnectivityClient connectivityClient;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += (sender, e) => OnApplicationExit();
            Application.ThreadException += new ThreadExceptionEventHandler(OnThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(OnUnhandledException);
            failureProcessor = EntriesProcessorFactory.Create();
            connectivityClient = ConnectivityClientFactory.Create();

            if (connectivityClient.IsServerReachable())
            {
                Properties.Settings.Default.IsStandalone = false;
                Properties.Settings.Default.Save();
                if (Properties.Settings.Default.IsFirstRun)
                {
                    Properties.Settings.Default.IsFirstRun = false;
                    Properties.Settings.Default.Save();
                    using FirstStartupForm firstStartupForm = new();
                    firstStartupForm.Show();
                    Application.Run();
                }
                else
                {
                    using StartupForm startupForm = new();
                    startupForm.Show();
                    Application.Run();
                }
            }
            else
            {
                MessageBox.Show("No available network connections detected. Proceeding in standalone mode", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Properties.Settings.Default.IsStandalone = true;
                Properties.Settings.Default.Save();
                using StartupForm startupForm = new();
                startupForm.Show();
                Application.Run();
            }
        }

        private static void OnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            DialogResult result = DialogResult.Cancel;
            try
            {
                result = ShowThreadExceptionDialog("Windows Forms Error", e.Exception);
                Logger.CreateExceptionEntry(e.Exception);
            }
            catch
            {
                try
                {
                    MessageBox.Show("Fatal Windows Forms Error",
                        "Fatal Windows Forms Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                }
                finally
                {
                    if (failureProcessor != null)
                    {
                        failureProcessor.SaveChanges();
                    }
                    Application.Exit();
                }
            }

            // Exits the program when the user clicks Abort.
            if (result == DialogResult.Abort)
                Application.Exit();
        }

        private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                Logger.CreateExceptionEntry(ex);
                if (failureProcessor != null)
                {
                    failureProcessor.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                try
                {
                    MessageBox.Show("Fatal Non-UI Error",
                        "Fatal Non-UI Error. Could not write the error to the event log. Reason: "
                        + exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }

        private static void OnApplicationExit()
        {
            try
            {
                if (failureProcessor != null)
                {
                    if ((!Properties.Settings.Default.IsStandalone) && Properties.Settings.Default.IsSignedIn)
                    {
                        failureProcessor.Synchronize(Properties.Settings.Default.AccountID);
                    }
                    failureProcessor.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    Logger.CreateExceptionEntry(ex);
                    if (failureProcessor != null)
                    {
                        failureProcessor.SaveChanges();
                    }
                }
                catch (Exception exc)
                {
                    try
                    {
                        MessageBox.Show("Fatal Non-UI Error",
                            "Fatal Non-UI Error. Could not write the error to the event log. Reason: "
                            + exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    finally
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private static DialogResult ShowThreadExceptionDialog(string title, Exception e)
        {
            string errorMsg = "An application error occurred. Please contact the adminstrator " +
                "with the following information:\n\n";
            errorMsg = errorMsg + e.Message + "\n\nStack Trace:\n" + e.StackTrace;
            return MessageBox.Show(errorMsg, title, MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Stop);
        }
    }
}
