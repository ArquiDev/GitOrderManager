using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using OrderManager.UI.ViewModels;
using DevExpress.Utils.Filtering;
using OrderManager.Model;
using DevExpress.Data;
using OrderManager.UI.Views;

namespace OrderManager.UI
{
    public partial class MainOrderManager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public OrderCollectionViewModel OrderVM { get; set; }
        public List<Order> loaded;
        public MainOrderManager()
        {
            InitializeComponent();
            OrderVM = new OrderCollectionViewModel();
            bsiRecordsCount.Caption = "RECORDS : " + OrderVM.TotalOrders;
            

        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void virtualServerModeSource1_ConfigurationChanged(object sender, DevExpress.Data.VirtualServerModeRowsEventArgs e)
        {
            OrderVM.NewSearch(this.GetFilterFromForm());
            e.UserData = OrderVM.Orders;
        }

        private void virtualServerModeSource1_GetUniqueValues(object sender, DevExpress.Data.VirtualServerModeGetUniqueValuesEventArgs e)
        {
            e.UniqueValuesTask = new System.Threading.Tasks.Task<object[]>(() =>
            {
                switch (e.ValuesPropertyName)
                {
                    //case "ModelPrice":
                    //    return new object[] { 15000m, 150000m };
                    //case "Discount":
                    //    return new object[] { 0.00, 0.05, 0.10, 0.15 };
                    //case "SalesDate":
                    //    DateTime today = DateTime.Today;
                    //    DateTime sevenYearsAgo = new DateTime(today.Year - 7, 1, 1);
                    //    int totalDays = (int)Math.Ceiling(today.Subtract(sevenYearsAgo).TotalDays);
                    //    object[] days = new object[totalDays];
                    //    for (int i = 0; i < days.Length; i++)
                    //        days[i] = sevenYearsAgo.AddDays(i);
                    //    return days;
                    //case "Trademark":
                    //    return models.Select(m => m.Trademark).Distinct().Cast<object>().ToArray();
                    //case "Name":
                    //    return models.Select(m => m.Name).Distinct().Cast<object>().ToArray();
                    //case "Modification":
                    //    return models.Select(m => m.Modification).Distinct().Cast<object>().ToArray();
                    default:
                        return null;
                }
            }, e.CancellationToken);
        }

        private void virtualServerModeSource1_MoreRows(object sender, DevExpress.Data.VirtualServerModeRowsEventArgs e)
        {
            e.RowsTask = System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                this.OrderVM.GetNextBatch();
                return new VirtualServerModeRowsTaskResult(this.OrderVM.Orders, this.OrderVM.AreMore, this.OrderVM.Orders);
            }, e.CancellationToken);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl.RefreshDataSource();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.RefreshDataSource();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var customer = this.OrderVM.Orders[gridView.FocusedRowHandle]?.Customer;
            if (customer != null)
            {
                var edit = new CustomerEdit(customer);
                if (edit.ShowDialog() == DialogResult.OK)
                    gridControl.RefreshDataSource();
            }
        }

        private FilterOrderViewModel GetFilterFromForm()
        {
            FilterOrderViewModel filter = new FilterOrderViewModel();
            if (this.ValueFrom.Value > 0)
                filter.ValueFrom = this.ValueFrom.Value;
            if (this.ValueTo.Value > 0)
                filter.ValueTo = this.ValueTo.Value;
            if (this.DateFrom.DateTime != DateTime.MinValue)
                filter.DateFrom = this.DateFrom.DateTime;
            if (this.DateTo.DateTime != DateTime.MinValue)
                filter.DateTo = this.DateTo.DateTime;
            filter.Text = this.TextFind.Text;
            return filter;
        }
        
    }
    
}