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

namespace ezziresto.PL.Kitchen
{
    public partial class Form_Order_Status : DevExpress.XtraEditors.XtraForm
    {
        Form_kitchen_List form_kitchen_list = new Form_kitchen_List();
        BL.Order.Order order = new BL.Order.Order();
        BL.Pos.Pos pos = new BL.Pos.Pos();
        int order_id = 0;
        DataTable dt = new DataTable();
        int is_accepted = 0;
        int is_cancelled = 0;
        int is_ready = 0;
        int is_delivered = 0;
        string etat = "";

        public Form_Order_Status()
        {
            InitializeComponent();
        }
        
        public void setObject(Form_kitchen_List form_kitchen_list)
        {
            this.form_kitchen_list = form_kitchen_list;
        }

        public void setOrderID(int order_id)
        {
            this.order_id = order_id;
        }

        public void setEtat(string etat)
        {
            this.etat = etat;
        }

        public void setLabels(string orderTokenLabel, string orderedAtLabel)
        {
            orderToken.Text = orderTokenLabel;
            orderedAt.Text = orderedAtLabel;
        }

        public void loadData()
        {
            DataTable tb = order.get_food_orders_by_id(this.order_id);

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                DataRow NewRow = dt.NewRow();
                NewRow[0] = tb.Rows[i]["food_item"];
                NewRow[1] = tb.Rows[i]["price"];
                NewRow[2] = 1;
                NewRow[3] = tb.Rows[i]["price"];
                NewRow[4] = tb.Rows[i]["id"];

                dt.Rows.Add(NewRow);
            }

            gridControlItemOrder.DataSource = dt;
        }

        public void btnStatus()
        {
            btnAcceptOrder.Enabled = false;
            btnOrderReady.Enabled = false;
            btnCancelOrder.Enabled = false;
            btnDelivred.Enabled = false;

            if (this.etat == "new")
            {
                btnAcceptOrder.Enabled = true;
                btnCancelOrder.Enabled = true;
            }

            if (this.etat == "accepted")
            {
                btnOrderReady.Enabled = true;
            }

            if (this.etat == "termined")
            {
                btnDelivred.Enabled = true;
            }
        }

        private void Form_Order_Status_Load(object sender, EventArgs e)
        {
            this.btnStatus(); 
            
            if (this.etat == "new")
            {
                btnReturnOrder.Enabled = false;
            }

            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("designation", typeof(string));
                dt.Columns.Add("price", typeof(string));
                dt.Columns.Add("qty", typeof(int));
                dt.Columns.Add("total", typeof(string));
                dt.Columns.Add("id", typeof(string));
            }

            this.loadData();
        }

        private void btnAcceptOrder_Click_1(object sender, EventArgs e)
        {
            pos.update_accept_order(this.order_id, 1, DateTime.Now);
            form_kitchen_list.refresh();
            this.btnStatus();
            btnAcceptOrder.Enabled = false;
            btnCancelOrder.Enabled = false;
            btnReturnOrder.Enabled = true;
            if (Properties.Settings.Default.sound == "yes")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Added.wav");
                simpleSound.Play();
            }
        }

        private void btnOrderReady_Click_1(object sender, EventArgs e)
        {
            pos.update_ready_order(this.order_id, 1, DateTime.Now);
            form_kitchen_list.refresh();
            this.btnStatus();
            btnOrderReady.Enabled = false;
            if (Properties.Settings.Default.sound == "yes")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Added.wav");
                simpleSound.Play();
            }
        }

        private void btnCancelOrder_Click_1(object sender, EventArgs e)
        {
            pos.update_cancelled_order(this.order_id, 1, DateTime.Now);
            form_kitchen_list.refresh();
            this.btnStatus();
            btnCancelOrder.Enabled = false;
            if (Properties.Settings.Default.sound == "yes")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Added.wav");
                simpleSound.Play();
            }
            this.Close();
        }

        private void btnDelivred_Click_1(object sender, EventArgs e)
        {
            pos.update_delivered_order(this.order_id, 1, DateTime.Now);
            form_kitchen_list.refresh();
            this.btnStatus();
            btnDelivred.Enabled = false;
            if (Properties.Settings.Default.sound == "yes")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Added.wav");
                simpleSound.Play();
            }
        }

        private void btnReturnOrder_Click(object sender, EventArgs e)
        {
            if (this.etat == "accepted" || this.etat == "new")
            {
                pos.update_accept_order(this.order_id, 0, DateTime.Now);
                btnReturnOrder.Enabled = false;
                btnCancelOrder.Enabled = false;
            } else if (this.etat == "termined")
            {
                pos.update_ready_order(this.order_id, 0, DateTime.Now);
                btnReturnOrder.Enabled = false;
            } else if (this.etat == "delivred")
            {
                pos.update_delivered_order(this.order_id, 0, DateTime.Now);
                btnReturnOrder.Enabled = false;
            } else
            {
                btnReturnOrder.Enabled = false;
            }

            this.form_kitchen_list.refresh();

            if (Properties.Settings.Default.sound == "yes")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Added.wav");
                simpleSound.Play();
            }

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}