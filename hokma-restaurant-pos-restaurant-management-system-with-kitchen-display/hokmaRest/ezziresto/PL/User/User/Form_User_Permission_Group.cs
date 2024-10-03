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

namespace ezziresto.PL.User.User
{
    public partial class Form_User_Permission_Group : DevExpress.XtraEditors.XtraForm
    {
        BL.User.User user = new BL.User.User();
        int user_id = 0;

        public Form_User_Permission_Group()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource
            sqlDataSourceGroups.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource
            sqlDataSource1.Fill();
        }

        public void loadData()
        {
            DataTable tb = user.get_user(this.user_id);
            if (tb.Rows.Count > 0)
            {
                txtName.Text = tb.Rows[0]["name"].ToString();
            }

            this.getUserPermissionGroups();
        }

        public void getUserPermissionGroups()
        {
            gridControlPermissionGroups.DataSource = user.get_user_permission_groups(this.user_id);
        }

        public void setID(int user_id)
        {
            this.user_id = user_id;
        }

        private void Form_Edit_Permission_Load_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtPermissionGroup_EditValueChanged(object sender, EventArgs e)
        {
            if (txtPermissionGroup.EditValue != null)
            {
                user.add_permission_group(this.user_id, Convert.ToInt32(txtPermissionGroup.EditValue.ToString()), txtPermissionGroup.Text, DateTime.Now, DateTime.Now);
                this.getUserPermissionGroups();

                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"c:\toggle.wav");
                    simpleSound.Play();
                }
            }
        }
    }
}