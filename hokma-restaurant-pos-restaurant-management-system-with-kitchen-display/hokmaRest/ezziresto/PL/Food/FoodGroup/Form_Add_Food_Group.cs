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

namespace ezziresto.PL.Food.FoodGroup
{
    public partial class Form_Add_Food_Group : DevExpress.XtraEditors.XtraForm
    {
        BL.FoodGroup.FoodGroup food_group = new BL.FoodGroup.FoodGroup();
        Form_Food_Group form_food_group = null;

        public Form_Add_Food_Group()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }

        public void setObject(Form_Food_Group form_food_group)
        {
            this.form_food_group = form_food_group;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                food_group.add_food_group(txtName.Text, txtName.Text, DateTime.Now, DateTime.Now);
                txtName.Clear();
                txtName.Select();
                sqlDataSource1.FillAsync();

                if (this.form_food_group != null)
                    this.form_food_group.asyncData();

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