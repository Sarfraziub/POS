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

namespace ezziresto.PL.Stock.IngredientItem
{
    public partial class Form_Edit_Ingredient_Item : DevExpress.XtraEditors.XtraForm
    {
        BL.IngredientItem.IngredientItem ingredient_item = new BL.IngredientItem.IngredientItem();
        Form_Ingredient_Item form_ingredient_item = null;
        int ingredient_item_id = 0;

        public Form_Edit_Ingredient_Item()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceIngredientItem.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceIngredientGroup.FillAsync();
        }

        public void loadData()
        {
            DataTable tb = ingredient_item.get_ingredient_item(this.ingredient_item_id);
            if (tb.Rows.Count > 0)
            {
                txtName.Text = tb.Rows[0]["name"].ToString();
                txtIngGroup.EditValue = tb.Rows[0]["ingredient_group_id"];
                txtUnite.Text = tb.Rows[0]["unit"].ToString();
            }
        }

        public void setObject(Form_Ingredient_Item form_ingredient_item)
        {
            this.form_ingredient_item = form_ingredient_item;
        }

        public void setID(int ingredient_item_id)
        {
            this.ingredient_item_id = ingredient_item_id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                ingredient_item.update_ingredient_item(this.ingredient_item_id, Convert.ToInt32(txtIngGroup.EditValue), txtName.Text, txtName.Text, txtName.Text, txtUnite.Text, DateTime.Now);
                txtName.Select();

                sqlDataSourceIngredientItem.FillAsync();

                if (this.form_ingredient_item != null)
                    this.form_ingredient_item.asyncData();

                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"c:\Added.wav");
                    simpleSound.Play();
                }
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"c:\ValidationError.wav");
                    simpleSound.Play();
                }
            }
        }

        private void Form_Edit_Ingredient_Item_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}