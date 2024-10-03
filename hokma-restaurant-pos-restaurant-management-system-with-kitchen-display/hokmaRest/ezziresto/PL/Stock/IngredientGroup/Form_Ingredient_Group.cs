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

namespace ezziresto.PL.Stock.IngredientGroup
{
    public partial class Form_Ingredient_Group : DevExpress.XtraEditors.XtraForm
    {
        BL.IngredientGroup.IngredientGroup ingredient_group = new BL.IngredientGroup.IngredientGroup();
        int ingredient_group_id = 0;
        bool filter = true;

        public Form_Ingredient_Group()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSourceIngredientGroup.FillAsync();
        }

        public void asyncData()
        {
            sqlDataSourceIngredientGroup.FillAsync();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_Add_Ingredient_Group form_ingredient_group = new Form_Add_Ingredient_Group();
            form_ingredient_group.setObject(this);
            form_ingredient_group.ShowDialog();
        }

        private void gridViewIngredientGroup_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            object value = this.gridViewIngredientGroup.GetRowCellValue(this.gridViewIngredientGroup.FocusedRowHandle, "id");
            this.ingredient_group_id = Convert.ToInt32(value);
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void gridControlIngredientGroup_DoubleClick(object sender, EventArgs e)
        {
            object value = this.gridViewIngredientGroup.GetRowCellValue(this.gridViewIngredientGroup.FocusedRowHandle, "id");
            Form_Edit_Ingredient_Group form_ingredient_group = new Form_Edit_Ingredient_Group();
            form_ingredient_group.setID(Convert.ToInt32(value));
            form_ingredient_group.setObject(this);
            form_ingredient_group.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.ingredient_group_id != 0)
            {
                Form_Edit_Ingredient_Group form_ingredient_group = new Form_Edit_Ingredient_Group();
                form_ingredient_group.setID(this.ingredient_group_id);
                form_ingredient_group.setObject(this);
                form_ingredient_group.ShowDialog();
            }
        }

        private void Form_Ingredient_Group_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.ingredient_group_id != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure,You Whant Delete This Item ?", "Delete This Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ingredient_group.delete(this.ingredient_group_id);
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
                gridViewIngredientGroup.ActiveFilterString = null;
            }
            else if (textPeriodeDate.EditValue.ToString() == "To Day")
            {
                gridViewIngredientGroup.ActiveFilterString = string.Format("IsOutlookIntervalToday([created_at])");
            }
            else if (textPeriodeDate.EditValue.ToString() == "This Week")
            {
                gridViewIngredientGroup.ActiveFilterString = string.Format("IsThisWeek([created_at])");
            }
            else if (textPeriodeDate.EditValue.ToString() == "Last Week")
            {
                gridViewIngredientGroup.ActiveFilterString = string.Format("IsOutlookIntervalLastWeek([created_at])");
            }
            else if (textPeriodeDate.EditValue.ToString() == "Newest")
            {
                gridViewIngredientGroup.Columns["id"].SortOrder = ColumnSortOrder.Ascending;
            }
            else if (textPeriodeDate.EditValue.ToString() == "Oldest")
            {
                gridViewIngredientGroup.Columns["id"].SortOrder = ColumnSortOrder.Descending;
            }
            else if (textPeriodeDate.EditValue.ToString() == "Between the dates")
            {
                startDate.Enabled = true;
                endDate.Enabled = true;
                gridViewIngredientGroup.ActiveFilterString = string.Format("[created_at] Between(#" + startDate.DateTime + "#, #" + endDate.DateTime + "#)");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gridViewIngredientGroup.ActiveFilterString = null;
            this.filter = false;
            gridViewIngredientGroup.ClearSorting();
            gridViewIngredientGroup.ApplyFindFilter(string.Empty);
            textPeriodeDate.EditValue = "";
            startDate.Text = DateTime.Now.ToString();
            endDate.Text = DateTime.Now.ToString();
            if (Properties.Settings.Default.sound == "yes")
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\ValidationError.wav");
                simpleSound.Play();
            }
        }

        private void startDate_EditValueChanged(object sender, EventArgs e)
        {
            if (endDate.EditValue != null & this.filter)
                gridViewIngredientGroup.ActiveFilterString = string.Format("[created_at] Between(#" + startDate.DateTime + "#, #" + endDate.DateTime + "#)");
        }

        private void endDate_EditValueChanged(object sender, EventArgs e)
        {
            if (startDate.EditValue != null & this.filter)
                gridViewIngredientGroup.ActiveFilterString = string.Format("[created_at] Between(#" + startDate.DateTime + "#, #" + endDate.DateTime + "#)");
        }
    }
}