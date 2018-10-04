using Ninject;
using OrderManager.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManager.UI.Views;

namespace OrderManager.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.Run(new MainOrderManager());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                StringBuilder msg = new StringBuilder();
                Exception ex = (Exception)e.ExceptionObject;
                msg.Append("An application error occurred. Please contact the adminstrator ")
                    .Append("with the following information:").AppendLine().AppendLine();

                msg.Append(ex.Message);
                var tempEx = ex;
                while ((tempEx = tempEx.InnerException) != null)
                {
                    msg.Append($". {tempEx.Message}");
                }
                msg.AppendLine().Append("Stack Trace: ").Append(ex.StackTrace);
                var form = new ErrorMessage(msg.ToString());
                form.ShowDialog();
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
}
