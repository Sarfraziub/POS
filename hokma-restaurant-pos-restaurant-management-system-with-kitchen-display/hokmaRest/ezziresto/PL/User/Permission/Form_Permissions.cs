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

namespace ezziresto.PL.User.Permission
{
    public partial class Form_Permissions : DevExpress.XtraEditors.XtraForm
    {
        BL.Permission.Permission permission = new BL.Permission.Permission();
        int permission_id = 0;
        bool filter = true;

        public Form_Permissions()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourcePermission.FillAsync();
        }

        public void asyncData()
        {
            sqlDataSourcePermission.FillAsync();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Form_Add_Permission permission = new Form_Add_Permission();
            permission.setObject(this);
            permission.ShowDialog();
        }

        private void gridViewProperty_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            object value = this.gridViewPermission.GetRowCellValue(this.gridViewPermission.FocusedRowHandle, "id");
            this.permission_id = Convert.ToInt32(value);
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void gridControlProperty_DoubleClick(object sender, EventArgs e)
        {
            object value = this.gridViewPermission.GetRowCellValue(this.gridViewPermission.FocusedRowHandle, "id");
            Form_Edit_Permission permission = new Form_Edit_Permission();
            permission.setID(Convert.ToInt32(value));
            permission.setObject(this);
            permission.ShowDialog();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (this.permission_id != 0)
            {
                Form_Edit_Permission permission = new Form_Edit_Permission();
                permission.setID(this.permission_id);
                permission.setObject(this);
                permission.ShowDialog();
            }
        }

        private void Form_Properties_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (this.permission_id != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure,You Whant Delete This Item ?", "Delete This Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    permission.delete(this.permission_id);
                    this.asyncData();
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    if (Properties.Settings.Default.sound == "yes")
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"c:\Deleted.wav");
                        simpleSound.Play();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    // do something
                }
            }
        }

        private void textPeriodeDate_EditValueChanged_1(object sender, EventArgs e)
        {
            if (textPeriodeDate.EditValue.ToString() == "All")
            {
                gridViewPermission.ActiveFilterString = null;
            }
            else if (textPeriodeDate.EditValue.ToString() == "To Day")
            {
                gridViewPermission.ActiveFilterString = string.Format("IsOutlookIntervalToday([created_at])");
            }
            else if (textPeriodeDate.EditValue.ToString() == "This Week")
            {
                gridViewPermission.ActiveFilterString = string.Format("IsThisWeek([created_at])");
            }
            else if (textPeriodeDate.EditValue.ToString() == "Last Week")
            {
                gridViewPermission.ActiveFilterString = string.Format("IsOutlookIntervalLastWeek([created_at])");
            }
            else if (textPeriodeDate.EditValue.ToString() == "Newest")
            {
                gridViewPermission.Columns["id"].SortOrder = ColumnSortOrder.Ascending;
            }
            else if (textPeriodeDate.EditValue.ToString() == "Oldest")
            {
                gridViewPermission.Columns["id"].SortOrder = ColumnSortOrder.Descending;
            }
            else if (textPeriodeDate.EditValue.ToString() == "Between the dates")
            {
                startDate.Enabled = true;
                endDate.Enabled = true;
                gridViewPermission.ActiveFilterString = string.Format("[created_at] Between(#" + startDate.DateTime + "#, #" + endDate.DateTime + "#)");
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            this.filter = false;
            gridViewPermission.ClearSorting();
            gridViewPermission.ApplyFindFilter(string.Empty);
            textPeriodeDate.EditValue = "";
            startDate.Text = DateTime.Now.ToString();
            endDate.Text = DateTime.Now.ToString();
            if (Properties.Settings.Default.sound == "yes")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Wrong.wav");
                simpleSound.Play();
            }
        }

        private void startDate_EditValueChanged_1(object sender, EventArgs e)
        {
            if ( endDate.EditValue != null & this.filter )
                gridViewPermission.ActiveFilterString = string.Format("[created_at] Between(#" + startDate.DateTime + "#, #" + endDate.DateTime + "#)");
        }

        private void endDate_EditValueChanged_1(object sender, EventArgs e)
        {
            if ( startDate.EditValue != null & this.filter )
                gridViewPermission.ActiveFilterString = string.Format("[created_at] Between(#" + startDate.DateTime + "#, #" + endDate.DateTime + "#)");
        }
    }
}