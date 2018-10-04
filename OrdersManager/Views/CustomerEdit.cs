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
using OrderManager.Model;
using OrderManager.UI.ViewModels;

namespace OrderManager.UI.Views
{
    public partial class CustomerEdit : DevExpress.XtraEditors.XtraForm
    {
        public CustomerViewModel CustomerVM { get; set; }
        public CustomerEdit(Customer customer)
        {
            InitializeComponent();
            this.CustomerVM = new CustomerViewModel(customer);
            this.SetCustomerToForm(customer);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.SetCustomerFromForm();
            this.CustomerVM.SaveCurrent();
            this.DialogResult = DialogResult.OK; 
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.SetCustomerToForm(this.CustomerVM.OriginalCustomer);
        }

        private void SetCustomerToForm (Customer customer)
        {
            this.FirtsName.Text = customer.FirstName;
            this.LastName.Text = customer.LastName;
        }
        private void SetCustomerFromForm()
        {
            this.CustomerVM.CurrentCustomer = new Customer()
            {
                FirstName = this.FirtsName.Text,
                LastName = this.LastName.Text,
            };
        }

    }
}