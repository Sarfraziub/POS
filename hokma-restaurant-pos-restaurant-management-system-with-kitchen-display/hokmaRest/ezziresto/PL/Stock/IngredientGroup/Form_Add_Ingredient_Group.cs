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

namespace ezziresto.PL.Stock.IngredientGroup
{
    public partial class Form_Add_Ingredient_Group : DevExpress.XtraEditors.XtraForm
    {
        BL.IngredientGroup.IngredientGroup ingredient_group = new BL.IngredientGroup.IngredientGroup();
        Form_Ingredient_Group form_ingredient_group = null;
     
        public Form_Add_Ingredient_Group()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceIngredientGroup.FillAsync();
        }

        public void setObject(Form_Ingredient_Group form_ingredient_group)
        {
            this.form_ingredient_group = form_ingredient_group;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                ingredient_group.add_ingredient_group(txtName.Text, txtName.Text, DateTime.Now, DateTime.Now);
                txtName.Clear();
                txtName.Select();

                sqlDataSourceIngredientGroup.FillAsync();

                if (this.form_ingredient_group != null)
                    this.form_ingredient_group.asyncData();

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
    }
}