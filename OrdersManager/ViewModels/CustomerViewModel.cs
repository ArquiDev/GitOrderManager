using OrderManager.Model;
using OrderManager.UI.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.UI.ViewModels
{
    public class CustomerViewModel
    {
        public Customer OriginalCustomer { get; }
        public Customer CurrentCustomer { get; set; }

        public CustomerViewModel(Customer customer) => this.OriginalCustomer = customer;

        public void SaveCurrent()
        {
            this.CurrentCustomer.Id = this.OriginalCustomer.Id;
            ManagerDataSource.Instance.SaveCustomer(this.CurrentCustomer);
        }
    }
}
