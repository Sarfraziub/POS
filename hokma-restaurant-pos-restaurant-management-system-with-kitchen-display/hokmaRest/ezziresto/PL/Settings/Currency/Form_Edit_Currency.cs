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

namespace ezziresto.PL.Settings.Currency
{
    public partial class Form_Edit_Currency : DevExpress.XtraEditors.XtraForm
    {
        BL.Currency.Currency currency = new BL.Currency.Currency();
        Form_Currency_List form_currency_list = null;
        int currency_id = 0;

        public Form_Edit_Currency()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceCurrency.FillAsync();
        }

        public void loadData()
        {
            DataTable tb = currency.get_currency(this.currency_id);
            if (tb.Rows.Count > 0)
            {
                txtName.Text = tb.Rows[0]["name"].ToString();
                txtAllignment.Text = tb.Rows[0]["alignment"].ToString();
                txtCode.Text = tb.Rows[0]["code"].ToString();
                txtRate.Text = tb.Rows[0]["rate"].ToString();
                txtSymbol.Text = tb.Rows[0]["symbol"].ToString();
            }
        }

        public void setObject(Form_Currency_List form_currency_list)
        {
            this.form_currency_list = form_currency_list;
        }

        public void setID(int currency_id)
        {
            this.currency_id = currency_id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                currency.update_currency(this.currency_id, txtName.Text, txtSymbol.Text, Convert.ToDecimal(txtRate.Text), txtAllignment.Text, 0, txtCode.Text, DateTime.Now);
                txtName.Select();

                sqlDataSourceCurrency.FillAsync();

                if (this.form_currency_list != null)
                    this.form_currency_list.asyncData();

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

        private void Form_Edit_Currency_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSetDefaultLang_Click(object sender, EventArgs e)
        {
            currency.default_currency(this.currency_id, 1, DateTime.Now);
            Properties.Settings.Default.currency = txtSymbol.Text;
            if (Properties.Settings.Default.sound == "yes")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Added.wav");
                simpleSound.Play();
            }
        }
    }
}