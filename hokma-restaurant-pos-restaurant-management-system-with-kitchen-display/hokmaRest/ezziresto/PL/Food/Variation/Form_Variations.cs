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

namespace ezziresto.PL.Food.Variation
{

    public partial class Form_Variations : DevExpress.XtraEditors.XtraForm
    {
        BL.Variation.Variation variation = new BL.Variation.Variation();
        int variation_id = 0;
        bool filter = true;

        public Form_Variations()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceVariations.FillAsync();
        }

        public void asyncData()
        {
            sqlDataSourceVariations.FillAsync();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_Add_Variation variation = new Form_Add_Variation();
            variation.setObject(this);
            variation.ShowDialog();
        }

        private void gridViewVariation_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            object value = this.gridViewVariation.GetRowCellValue(this.gridViewVariation.FocusedRowHandle, "id");
            this.variation_id = Convert.ToInt32(value);
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void gridViewVariation_DoubleClick(object sender, EventArgs e)
        {
            object value = this.gridViewVariation.GetRowCellValue(this.gridViewVariation.FocusedRowHandle, "id");
            Form_Edit_Variation variation = new Form_Edit_Variation();
            variation.setID(Convert.ToInt32(value));
            variation.setObject(this);
            variation.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if( this.variation_id != 0 )
            {
                Form_Edit_Variation variation = new Form_Edit_Variation();
                variation.setID(this.variation_id);
                variation.setObject(this);
                variation.ShowDialog();
            }
        }

        private void Form_Variations_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.variation_id != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure,You Whant Delete This Item ?", "Delete This Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    variation.delete(this.variation_id);
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

        private void textPeriodeDate_EditValueChanged(object sender, EventArgs e)
        {
            if (textPeriodeDate.EditValue.ToString() == "All")
            {
                gridViewVariation.ActiveFilterString = null;
            }
            else if (textPeriodeDate.EditValue.ToString() == "To Day")
            {
                gridViewVariation.ActiveFilterString = string.Format("IsOutlookIntervalToday([created_at])");
            }
            else if (textPeriodeDate.EditValue.ToString() == "This Week")
            {
                gridViewVariation.ActiveFilterString = string.Format("IsThisWeek([created_at])");
            }
            else if (textPeriodeDate.EditValue.ToString() == "Last Week")
            {
                gridViewVariation.ActiveFilterString = string.Format("IsOutlookIntervalLastWeek([created_at])");
            }
            else if (textPeriodeDate.EditValue.ToString() == "Newest")
            {
                gridViewVariation.Columns["id"].SortOrder = ColumnSortOrder.Ascending;
            }
            else if (textPeriodeDate.EditValue.ToString() == "Oldest")
            {
                gridViewVariation.Columns["id"].SortOrder = ColumnSortOrder.Descending;
            }
            else if (textPeriodeDate.EditValue.ToString() == "Between the dates")
            {
                startDate.Enabled = true;
                endDate.Enabled = true;
                gridViewVariation.ActiveFilterString = string.Format("[created_at] Between(#" + startDate.DateTime + "#, #" + endDate.DateTime + "#)");
            }
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.filter = false;
            gridViewVariation.ClearSorting();
            gridViewVariation.ApplyFindFilter(string.Empty);
            textPeriodeDate.EditValue = "";
            startDate.Text = DateTime.Now.ToString();
            endDate.Text = DateTime.Now.ToString();

            if (Properties.Settings.Default.sound == "yes")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Wrong.wav");
                simpleSound.Play();
            }
        }

        private void startDate_EditValueChanged(object sender, EventArgs e)
        {
            if( endDate.EditValue != null & this.filter )
                gridViewVariation.ActiveFilterString = string.Format("[created_at] Between(#" + startDate.DateTime + "#, #" + endDate.DateTime + "#)");
        }

        private void endDate_EditValueChanged(object sender, EventArgs e)
        {
            if ( startDate.EditValue != null & this.filter )
                gridViewVariation.ActiveFilterString = string.Format("[created_at] Between(#" + startDate.DateTime + "#, #" + endDate.DateTime + "#)");
        }
    }
}