﻿using DevExpress.XtraEditors;
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

namespace ezziresto.PL.Stock.FoodPurchase
{
    public partial class Form_Edit_Food_Purchase : DevExpress.XtraEditors.XtraForm
    {
        BL.FoodPurchase.FoodPurchase food_purchase = new BL.FoodPurchase.FoodPurchase();
        BL.TempFoodPurchase.TempFoodPurchase temp_food_purchase = new BL.TempFoodPurchase.TempFoodPurchase();
        BL.FoodItem.FoodItem food_item = new BL.FoodItem.FoodItem();
        Form_Food_Purchase_List form_food_purchases_list = null;
        DataTable dt = new DataTable();
        DataTable tb = new DataTable();
        int food_purchase_id = 0;
        int current_product = 0;
        int order_id = 0;
        int row = 0;
        Decimal total_price = 0;

        public Form_Edit_Food_Purchase()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceBranch.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceSupplier.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceFood.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceFood.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceBranch.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceSupplier.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }

        public void setOrderID(int order_id)
        {
            this.order_id = order_id;

            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("Food ID", typeof(string));
                dt.Columns.Add("Product Name", typeof(string));
                dt.Columns.Add("Product Qty", typeof(string));
                dt.Columns.Add("Sale Price", typeof(string));
                dt.Columns.Add("Discount", typeof(string));
                dt.Columns.Add("Total", typeof(string));
            }
            Show();
        }

        private void Show()
        {
            total_price = 0;
            btnAdd.Enabled = false;
            dt.Clear();

            if( row == 0 )
                tb = food_purchase.get_food_purchase(this.order_id);
            
            if (tb.Rows.Count <= 0)
            {
                MessageBox.Show("There is no data in this page");
            }
            else
            {
                //txtSalePrice.Enabled = false;
                //txtQtyUpdate.Enabled = false;
                //txtProdUnit.Enabled = false;
                //txtDiscount.Enabled = false;
                //btnDelete.Enabled = false;

                txtBranch.EditValue = tb.Rows[row]["branch_id"];
                fieldNameSupplier.EditValue = tb.Rows[row]["supplier_id"];
                purchaseDate.EditValue = tb.Rows[row]["purchase_date"];
                txtDesc.Text = tb.Rows[row]["description"].ToString();
                txtPaymentType.EditValue = tb.Rows[row]["payment_id"];

                DataTable order_details;

                if (row == 0)
                    order_details = food_purchase.get_food_purchases_histories_by_id(this.order_id);
                else
                    order_details = food_purchase.get_food_purchases_histories_by_id(Convert.ToInt32(tb.Rows[row]["id"]));

                for (int i = 0; i < order_details.Rows.Count; i++)
                {
                    DataTable data = food_item.get_food_item(Convert.ToInt32(order_details.Rows[i]["food_id"]));

                    if (data.Rows.Count > 0)
                    {
                        DataRow NewRow = dt.NewRow();

                        NewRow[0] = data.Rows[0]["id"];
                        NewRow[1] = data.Rows[0]["name"];
                        NewRow[2] = order_details.Rows[0]["qty"]; 
                        NewRow[3] = data.Rows[0]["price"];
                        NewRow[4] = 0;
                        NewRow[5] = tb.Rows[0]["total_bill"];

                        total_price += Math.Round(Convert.ToDecimal(tb.Rows[0]["total_bill"]), 2);

                        dt.Rows.Add(NewRow);
                        gridControlPurchase.DataSource = dt;

                        if (Properties.Settings.Default.sound == "yes")
                        {
                            SoundPlayer simpleSound = new SoundPlayer(@"c:\toggle.wav");
                            simpleSound.Play();
                        }
                    }
                }

                txtFinalPrice.Text = total_price.ToString() + " DA";
                alertTotalPriceScreen.Text = total_price.ToString();
                txtTotal.Text = total_price.ToString();
                paidAmount.Text = total_price.ToString();
            }
        }

        public void loadData()
        {
            temp_food_purchase.delete();

            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("Food ID", typeof(string));
                dt.Columns.Add("Product Name", typeof(string));
                dt.Columns.Add("Product Qty", typeof(string));
                dt.Columns.Add("Sale Price", typeof(string));
                dt.Columns.Add("Discount", typeof(string));
                dt.Columns.Add("Total", typeof(string));
            }

            DataTable tb = food_purchase.get_food_purchase(this.food_purchase_id);

            if (tb.Rows.Count > 0)
            {
                txtBranch.EditValue = tb.Rows[0]["branch_id"];
                fieldNameSupplier.EditValue = tb.Rows[0]["supplier_id"];
                purchaseDate.EditValue = tb.Rows[0]["purchase_date"];
                txtDesc.Text = tb.Rows[0]["description"].ToString();
                txtPaymentType.EditValue = tb.Rows[0]["payment_id"];
            }

            if (tb.Rows.Count > 0)
            {
                temp_food_purchase.add_temp_food_purchase(Convert.ToInt32(tb.Rows[0]["branch_id"]), Convert.ToInt32(tb.Rows[0]["supplier_id"]), Convert.ToInt32(tb.Rows[0]["payment_id"]), tb.Rows[0]["supplier_name"].ToString(), Convert.ToInt32(tb.Rows[0]["invoice_number"]), Convert.ToDateTime(tb.Rows[0]["purchase_date"]), tb.Rows[0]["description"].ToString(), tb.Rows[0]["payment_type"].ToString(), Convert.ToDecimal(tb.Rows[0]["total_bill"]), Convert.ToDecimal(tb.Rows[0]["paid_amount"]), Convert.ToDecimal(tb.Rows[0]["credit_amount"]), Convert.ToDateTime(tb.Rows[0]["created_at"]), Convert.ToDateTime(tb.Rows[0]["updated_at"]));

                DataTable items = food_purchase.get_food_purchases_histories_by_id(Convert.ToInt32(tb.Rows[0]["id"]));

                for (int i = 0; i < items.Rows.Count; i++)
                {
                    DataTable data = food_item.get_food_item(Convert.ToInt32(items.Rows[i]["food_id"]));

                    DataRow NewRow = dt.NewRow();
                    NewRow[0] = items.Rows[i]["food_id"];
                    NewRow[1] = items.Rows[i]["food_name"];
                    NewRow[2] = Convert.ToInt32(items.Rows[i]["qty"]);
                    NewRow[3] = data.Rows[0]["price"];
                    NewRow[4] = Convert.ToInt32(items.Rows[i]["rate"]);
                    NewRow[5] = items.Rows[i]["rate"];

                    dt.Rows.Add(NewRow);
                    gridControlPurchase.DataSource = dt;

                    decimal total = Convert.ToInt32(items.Rows[i]["qty"]) * Convert.ToDecimal(data.Rows[0]["price"]);

                    total_price += Math.Round(total, 2);
                    txtFinalPrice.Text = total_price.ToString();
                    txtTotal.Text = total_price.ToString();
                    alertTotalPriceScreen.Text = total_price.ToString();
                    paidAmount.Text = total_price.ToString();

                    temp_food_purchase.add_temp_food_purchase_history(Convert.ToInt32(items.Rows[i]["branch_id"]), Convert.ToInt32(items.Rows[i]["food_purchase_id"]), Convert.ToInt32(items.Rows[i]["food_id"]), items.Rows[i]["food_name"].ToString(), Convert.ToInt32(items.Rows[i]["qty"]), Convert.ToInt32(items.Rows[i]["rate"]), Convert.ToInt32(items.Rows[i]["rate"]), Convert.ToDateTime(items.Rows[i]["created_at"]), Convert.ToDateTime(items.Rows[i]["updated_at"]));
                }
            }
        }

        public void setObject(Form_Food_Purchase_List form_food_purchases_list)
        {
            this.form_food_purchases_list = form_food_purchases_list;
        }

        public void setID(int food_purchase_id)
        {
            this.food_purchase_id = food_purchase_id;
        }

        private void Form_Edit_Food_Purchase_Load(object sender, EventArgs e)
        {
            totalPriceCurency.Text = Properties.Settings.Default.currency;
            loadData();
        }

        private void btnShftLeft_Click_1(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tb.Clear();
                tb = food_purchase.get_food_purchases();
                row = Convert.ToInt32(tb.Rows.Count) - 1;
                Show();
            }
            else
            {
                row--;
                Show();
            }
        }

        private void btnShftRight_Click_1(object sender, EventArgs e)
        {
            tb.Clear();
            tb = food_purchase.get_food_purchases();
            if (Convert.ToInt32(tb.Rows.Count) - 1 == row)
            {
                row = 0;
                Show();
            }
            else
            {
                row++;
                Show();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.sound == "yes")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Added.wav");
                simpleSound.Play();
            }
            Food.Form_Add_New_Item food = new Food.Form_Add_New_Item();
            food.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.print();
        }

        public void print()
        {
            DocumentsViewer.Form_DocViewer frmDoc = new DocumentsViewer.Form_DocViewer();
            frmDoc.printInvoiceFoodPurchase();
            frmDoc.ShowDialog();
        }

        private void Form_Edit_Food_Purchase_FormClosed(object sender, FormClosedEventArgs e)
        {
            temp_food_purchase.delete();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}