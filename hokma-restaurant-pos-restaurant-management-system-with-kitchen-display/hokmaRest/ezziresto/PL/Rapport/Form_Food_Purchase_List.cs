﻿using DevExpress.Data;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezziresto.PL.Rapport
{
    public partial class Form_Food_Purchase_List : DevExpress.XtraEditors.XtraForm
    {
        BL.FoodPurchase.FoodPurchase food_purchase = new BL.FoodPurchase.FoodPurchase();
        BL.Rapport.Rapport rapport = new BL.Rapport.Rapport();
        DataTable tbl = new DataTable();
        int supp_id = 0;
        bool filter = true;
        decimal total_price = 0;

        public Form_Food_Purchase_List()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceFoodPurchases.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceSupplier.FillAsync();
            tbl = food_purchase.get_food_purchases();
            alertTotalProfitScreen.Text = "00000000";
        }


        public void asyncData()
        {
            sqlDataSourceFoodPurchases.FillAsync();
        }

        private void gridViewFoodPurchases_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void gridControlFoodPurchases_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form_Food_Purchase_List_Load(object sender, EventArgs e)
        {
            totalPriceCurency.Text = Properties.Settings.Default.currency;
            alertTotalProfitScreen.Text = rapport.get_total_purchase_profit_today();
        }

        private void textPeriodeDate_EditValueChanged(object sender, EventArgs e)
        {
            if (textPeriodeDate.EditValue.ToString() == "All")
            {
                gridViewFoodPurchases.ActiveFilterString = null;
            }
            else if (textPeriodeDate.EditValue.ToString() == "To Day")
            {
                gridViewFoodPurchases.ActiveFilterString = string.Format("IsOutlookIntervalToday([created_at])");
            }
            else if (textPeriodeDate.EditValue.ToString() == "This Week")
            {
                gridViewFoodPurchases.ActiveFilterString = string.Format("IsThisWeek([created_at])");
            }
            else if (textPeriodeDate.EditValue.ToString() == "Last Week")
            {
                gridViewFoodPurchases.ActiveFilterString = string.Format("IsOutlookIntervalLastWeek([created_at])");
            }
            else if (textPeriodeDate.EditValue.ToString() == "Newest")
            {
                gridViewFoodPurchases.Columns["id"].SortOrder = ColumnSortOrder.Ascending;
            }
            else if (textPeriodeDate.EditValue.ToString() == "Oldest")
            {
                gridViewFoodPurchases.Columns["id"].SortOrder = ColumnSortOrder.Descending;
            }
            else if (textPeriodeDate.EditValue.ToString() == "Between the dates")
            {
                startDate.Enabled = true;
                endDate.Enabled = true;
                gridViewFoodPurchases.ActiveFilterString = string.Format("[created_at] Between(#" + startDate.DateTime + "#, #" + endDate.DateTime + "#)");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.filter = false;
            tbl = food_purchase.get_food_purchases();
            gridControlFoodPurchases.DataSource = tbl;
            textPeriodeDate.EditValue = "";
            startDate.Text = DateTime.Now.ToString();
            endDate.Text = DateTime.Now.ToString();
            if (Properties.Settings.Default.sound == "yes")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Wrong.wav");
                simpleSound.Play();
            }
        }

        private void startDate_EditValueChanged(object sender, EventArgs e)
        {
            if (endDate.EditValue != null & this.filter)
                gridViewFoodPurchases.ActiveFilterString = string.Format("[created_at] Between(#" + startDate.DateTime + "#, #" + endDate.DateTime + "#)");
        }

        private void endDate_EditValueChanged(object sender, EventArgs e)
        {
            if (startDate.EditValue != null & this.filter)
                gridViewFoodPurchases.ActiveFilterString = string.Format("[created_at] Between(#" + startDate.DateTime + "#, #" + endDate.DateTime + "#)");
        }

        private void supplierID_EditValueChanged(object sender, EventArgs e)
        {
            if( supplierID.EditValue != null )
            {
                tbl = food_purchase.get_food_purchases_by_supplier(Convert.ToInt32(supplierID.EditValue.ToString()));
                gridControlFoodPurchases.DataSource = tbl;
            }
        }
    }
}