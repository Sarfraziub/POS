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

namespace ezziresto.PL.Restaurant.DepartmentTagList
{
    public partial class Form_Edit_Department_Tag : DevExpress.XtraEditors.XtraForm
    {
        BL.DepartmentTagList.DepartmentTagList department_tag_list = new BL.DepartmentTagList.DepartmentTagList();
        Form_Department_Tag_List form_department_tag_list = null;
        int department_tag_list_id = 0;

        public Form_Edit_Department_Tag()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceDepartmentTagList.FillAsync();
        }

        public void loadData()
        {
            DataTable tb = department_tag_list.get_department_tag_list(this.department_tag_list_id);
            if (tb.Rows.Count > 0)
            {
                txtName.Text = tb.Rows[0]["name"].ToString();
                txtCommission.Text = tb.Rows[0]["commission"].ToString();
            }
        }

        public void setObject(Form_Department_Tag_List form_department_tag_list)
        {
            this.form_department_tag_list = form_department_tag_list;
        }

        public void setID(int department_tag_list_id)
        {
            this.department_tag_list_id = department_tag_list_id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                department_tag_list.update_department_tag_list(this.department_tag_list_id, txtName.Text, txtName.Text, txtCommission.Text, DateTime.Now);
                txtName.Select();
                sqlDataSourceDepartmentTagList.FillAsync();

                if (this.form_department_tag_list != null)
                    this.form_department_tag_list.asyncData();

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

        private void Form_Edit_Department_Tag_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}