namespace OrderManager.UI.Views
{
    partial class CustomerEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEdit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.Save = new DevExpress.XtraEditors.SimpleButton();
            this.LastName = new DevExpress.XtraEditors.TextEdit();
            this.FirtsName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirtsName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Cancel);
            this.layoutControl1.Controls.Add(this.Save);
            this.layoutControl1.Controls.Add(this.LastName);
            this.layoutControl1.Controls.Add(this.FirtsName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1436, 270, 1300, 800);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1616, 217);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.ImageOptions.Image")));
            this.Cancel.Location = new System.Drawing.Point(12, 161);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(794, 44);
            this.Cancel.StyleController = this.layoutControl1;
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Save.ImageOptions.Image")));
            this.Save.Location = new System.Drawing.Point(810, 161);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(794, 44);
            this.Save.StyleController = this.layoutControl1;
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(116, 56);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(1488, 40);
            this.LastName.StyleController = this.layoutControl1;
            this.LastName.TabIndex = 5;
            // 
            // FirtsName
            // 
            this.FirtsName.Location = new System.Drawing.Point(116, 12);
            this.FirtsName.Name = "FirtsName";
            this.FirtsName.Size = new System.Drawing.Size(1488, 40);
            this.FirtsName.StyleController = this.layoutControl1;
            this.FirtsName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1616, 217);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.FirtsName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1596, 44);
            this.layoutControlItem1.Text = "Firts Name";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(101, 25);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.LastName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1596, 44);
            this.layoutControlItem2.Text = "Last Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(101, 25);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Save;
            this.layoutControlItem4.Location = new System.Drawing.Point(798, 149);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(798, 48);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Cancel;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 149);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(798, 48);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 88);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1596, 61);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // CustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 217);
            this.Controls.Add(this.layoutControl1);
            this.Name = "CustomerEdit";
            this.ShowIcon = false;
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirtsName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton Cancel;
        private DevExpress.XtraEditors.SimpleButton Save;
        private DevExpress.XtraEditors.TextEdit LastName;
        private DevExpress.XtraEditors.TextEdit FirtsName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}