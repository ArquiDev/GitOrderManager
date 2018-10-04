using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OrderManager.UI.Views
{
    public partial class ErrorMessage : DevExpress.XtraEditors.XtraForm
    {
        public ErrorMessage(string message)
        {
            InitializeComponent();
            this.labelControl1.Text = message;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}