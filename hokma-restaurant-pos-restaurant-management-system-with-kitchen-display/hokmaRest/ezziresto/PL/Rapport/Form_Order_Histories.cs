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

namespace ezziresto.PL.Rapport
{
    public partial class Form_Order_Histories : DevExpress.XtraEditors.XtraForm
    {
        BL.Rapport.Rapport rapport = new BL.Rapport.Rapport();
        BL.Pos.Pos pos = new BL.Pos.Pos();
        string whichOne = "";
        bool FromPos = false;

        public Form_Order_Histories()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceClients.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceSattled.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceSubmitted.FillAsync();
        }

        public void setWhichOne(string whichOne)
        {
            this.whichOne = whichOne;
        }
        public void setFromPos(bool FromPos)
        {
            this.FromPos = FromPos;
        }

        private void txtClient_EditValueChanged(object sender, EventArgs e)
        {
            gridControlSettled.DataSource = pos.get_food_orders_by_client(Convert.ToInt32(txtClient.EditValue));
            gridControlSubmitted.DataSource = pos.get_food_orders_by_client(Convert.ToInt32(txtClient.EditValue));
        }

        private void textPeriodeDate_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void startDate_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void endDate_EditValueChanged(object sender, EventArgs e)
        {

        }


        private void btnPos_Click(object sender, EventArgs e)
        {
            if (this.FromPos)
            {
                this.Close();
            }
            else
            {
                PL.Pos.Form_Pos pos = new PL.Pos.Form_Pos();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textPeriodeDate.EditValue = "";
            startDate.Text = DateTime.Now.ToString();
            endDate.Text = DateTime.Now.ToString();
            if (Properties.Settings.Default.sound == "yes")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Wrong.wav");
                simpleSound.Play();
            }
        }

        private void Form_Order_Histories_Load(object sender, EventArgs e)
        {
            totalPriceCurency.Text = Properties.Settings.Default.currency;
            alertTotalProfitSettledScreen.Text = rapport.get_total_sale_profit_settled();
            alertTotalProfitSubmittedScreen.Text = rapport.get_total_sale_profit_settled();

            if (this.whichOne == "Settled")
            {
                this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup1;
            }
        }
    }
}