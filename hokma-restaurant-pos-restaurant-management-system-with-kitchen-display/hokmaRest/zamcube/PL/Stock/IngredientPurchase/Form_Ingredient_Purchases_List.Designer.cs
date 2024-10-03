
namespace ezziresto.PL.Stock.IngredientPurchase
{
    partial class Form_Ingredient_Purchases_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ingredient_Purchases_List));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.gridControlPurchases = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSourcePurchases = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewPurchases = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcredit_amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpaid_amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpayment_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpurchase_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsupplier_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_bill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtOrderSelectedRow = new DevExpress.XtraEditors.TextEdit();
            this.txtFinal = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalSelectedRow = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.endDate = new DevExpress.XtraEditors.DateEdit();
            this.startDate = new DevExpress.XtraEditors.DateEdit();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.txtRemise = new DevExpress.XtraEditors.SpinEdit();
            this.txtTax = new DevExpress.XtraEditors.SpinEdit();
            this.textPeriodeDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.supplierID = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ezziresto_suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceSupplier = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.tabArticle = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem34 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem33 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderSelectedRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSelectedRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemise.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPeriodeDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchControl1);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.gridControlPurchases);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton4);
            this.layoutControl1.Controls.Add(this.txtTotal);
            this.layoutControl1.Controls.Add(this.txtOrderSelectedRow);
            this.layoutControl1.Controls.Add(this.txtFinal);
            this.layoutControl1.Controls.Add(this.txtTotalSelectedRow);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.endDate);
            this.layoutControl1.Controls.Add(this.startDate);
            this.layoutControl1.Controls.Add(this.btnReset);
            this.layoutControl1.Controls.Add(this.txtRemise);
            this.layoutControl1.Controls.Add(this.txtTax);
            this.layoutControl1.Controls.Add(this.textPeriodeDate);
            this.layoutControl1.Controls.Add(this.supplierID);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(880, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControlPurchases;
            resources.ApplyResources(this.searchControl1, "searchControl1");
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControlPurchases;
            this.searchControl1.Properties.FindDelay = 200;
            this.searchControl1.StyleController = this.layoutControl1;
            // 
            // gridControlPurchases
            // 
            resources.ApplyResources(this.gridControlPurchases, "gridControlPurchases");
            this.gridControlPurchases.DataSource = this.sqlDataSourcePurchases;
            this.gridControlPurchases.MainView = this.gridViewPurchases;
            this.gridControlPurchases.Name = "gridControlPurchases";
            this.gridControlPurchases.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPurchases});
            this.gridControlPurchases.DoubleClick += new System.EventHandler(this.gridControlPurchases_DoubleClick);
            // 
            // sqlDataSourcePurchases
            // 
            this.sqlDataSourcePurchases.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourcePurchases.Name = "sqlDataSourcePurchases";
            columnExpression1.ColumnName = "supplier_name";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"323\" />";
            table1.Name = "ezziresto.ingredient_purchases";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "id";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "paid_amount";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "credit_amount";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "created_at";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "total_bill";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "payment_type";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "purchase_date";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Name = "ezziresto_ingredient_purchases";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSourcePurchases.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSourcePurchases.ResultSchemaSerializable = resources.GetString("sqlDataSourcePurchases.ResultSchemaSerializable");
            // 
            // gridViewPurchases
            // 
            this.gridViewPurchases.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridViewPurchases.Appearance.Row.Font")));
            this.gridViewPurchases.Appearance.Row.Options.UseFont = true;
            this.gridViewPurchases.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcredit_amount,
            this.colcreated_at,
            this.colid,
            this.colpaid_amount,
            this.colpayment_type,
            this.colpurchase_date,
            this.colsupplier_name,
            this.coltotal_bill});
            this.gridViewPurchases.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewPurchases.GridControl = this.gridControlPurchases;
            this.gridViewPurchases.Name = "gridViewPurchases";
            this.gridViewPurchases.OptionsBehavior.Editable = false;
            this.gridViewPurchases.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPurchases.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewPurchases.OptionsView.ShowGroupPanel = false;
            this.gridViewPurchases.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPurchases_RowClick);
            // 
            // colcredit_amount
            // 
            resources.ApplyResources(this.colcredit_amount, "colcredit_amount");
            this.colcredit_amount.FieldName = "credit_amount";
            this.colcredit_amount.Name = "colcredit_amount";
            // 
            // colcreated_at
            // 
            resources.ApplyResources(this.colcreated_at, "colcreated_at");
            this.colcreated_at.FieldName = "created_at";
            this.colcreated_at.Name = "colcreated_at";
            // 
            // colid
            // 
            this.colid.AppearanceCell.Options.UseTextOptions = true;
            this.colid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colid, "colid");
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colpaid_amount
            // 
            resources.ApplyResources(this.colpaid_amount, "colpaid_amount");
            this.colpaid_amount.FieldName = "paid_amount";
            this.colpaid_amount.Name = "colpaid_amount";
            // 
            // colpayment_type
            // 
            resources.ApplyResources(this.colpayment_type, "colpayment_type");
            this.colpayment_type.FieldName = "payment_type";
            this.colpayment_type.Name = "colpayment_type";
            // 
            // colpurchase_date
            // 
            resources.ApplyResources(this.colpurchase_date, "colpurchase_date");
            this.colpurchase_date.FieldName = "purchase_date";
            this.colpurchase_date.Name = "colpurchase_date";
            // 
            // colsupplier_name
            // 
            resources.ApplyResources(this.colsupplier_name, "colsupplier_name");
            this.colsupplier_name.FieldName = "supplier_name";
            this.colsupplier_name.Name = "colsupplier_name";
            // 
            // coltotal_bill
            // 
            resources.ApplyResources(this.coltotal_bill, "coltotal_bill");
            this.coltotal_bill.FieldName = "total_bill";
            this.coltotal_bill.Name = "coltotal_bill";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnEdit.Appearance.Font")));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnDelete.Appearance.Font")));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton2.Appearance.Font")));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.StyleController = this.layoutControl1;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton4.Appearance.Font")));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            resources.ApplyResources(this.simpleButton4, "simpleButton4");
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.StyleController = this.layoutControl1;
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtTotal.Properties.Appearance.Font")));
            this.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseForeColor = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Properties.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtTotal.Properties.UseMaskAsDisplayFormat")));
            this.txtTotal.Properties.UseReadOnlyAppearance = false;
            this.txtTotal.StyleController = this.layoutControl1;
            // 
            // txtOrderSelectedRow
            // 
            resources.ApplyResources(this.txtOrderSelectedRow, "txtOrderSelectedRow");
            this.txtOrderSelectedRow.Name = "txtOrderSelectedRow";
            this.txtOrderSelectedRow.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtOrderSelectedRow.Properties.Appearance.Font")));
            this.txtOrderSelectedRow.Properties.Appearance.Options.UseFont = true;
            this.txtOrderSelectedRow.StyleController = this.layoutControl1;
            // 
            // txtFinal
            // 
            resources.ApplyResources(this.txtFinal, "txtFinal");
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtFinal.Properties.Appearance.Font")));
            this.txtFinal.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtFinal.Properties.Appearance.Options.UseFont = true;
            this.txtFinal.Properties.Appearance.Options.UseForeColor = true;
            this.txtFinal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtFinal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtFinal.Properties.ReadOnly = true;
            this.txtFinal.Properties.UseReadOnlyAppearance = false;
            this.txtFinal.StyleController = this.layoutControl1;
            // 
            // txtTotalSelectedRow
            // 
            resources.ApplyResources(this.txtTotalSelectedRow, "txtTotalSelectedRow");
            this.txtTotalSelectedRow.Name = "txtTotalSelectedRow";
            this.txtTotalSelectedRow.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtTotalSelectedRow.Properties.Appearance.Font")));
            this.txtTotalSelectedRow.Properties.Appearance.Options.UseFont = true;
            this.txtTotalSelectedRow.StyleController = this.layoutControl1;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnAdd.Appearance.Font")));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // endDate
            // 
            resources.ApplyResources(this.endDate, "endDate");
            this.endDate.Name = "endDate";
            this.endDate.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("endDate.Properties.Appearance.Font")));
            this.endDate.Properties.Appearance.Options.UseFont = true;
            this.endDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("endDate.Properties.Buttons"))))});
            this.endDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("endDate.Properties.CalendarTimeProperties.Buttons"))))});
            this.endDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.endDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.endDate.StyleController = this.layoutControl1;
            this.endDate.EditValueChanged += new System.EventHandler(this.endDate_EditValueChanged_1);
            // 
            // startDate
            // 
            resources.ApplyResources(this.startDate, "startDate");
            this.startDate.Name = "startDate";
            this.startDate.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("startDate.Properties.Appearance.Font")));
            this.startDate.Properties.Appearance.Options.UseFont = true;
            this.startDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("startDate.Properties.Buttons"))))});
            this.startDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("startDate.Properties.CalendarTimeProperties.Buttons"))))});
            this.startDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.startDate.Properties.DisplayFormat.FormatString = "";
            this.startDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.startDate.Properties.EditFormat.FormatString = "";
            this.startDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.startDate.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.startDate.Properties.MaskSettings.Set("mask", "d");
            this.startDate.Properties.MaskSettings.Set("useAdvancingCaret", true);
            this.startDate.Properties.MaskSettings.Set("spinWithCarry", true);
            this.startDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.startDate.StyleController = this.layoutControl1;
            this.startDate.EditValueChanged += new System.EventHandler(this.startDate_EditValueChanged_1);
            // 
            // btnReset
            // 
            this.btnReset.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnReset.Appearance.Font")));
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReset.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnReset.StyleController = this.layoutControl1;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // txtRemise
            // 
            resources.ApplyResources(this.txtRemise, "txtRemise");
            this.txtRemise.Name = "txtRemise";
            this.txtRemise.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtRemise.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtRemise.Properties.Appearance.Font")));
            this.txtRemise.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRemise.Properties.Appearance.Options.UseFont = true;
            this.txtRemise.Properties.Appearance.Options.UseForeColor = true;
            this.txtRemise.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRemise.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRemise.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtRemise.Properties.Buttons"))))});
            this.txtRemise.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtRemise.Properties.NullValuePrompt = resources.GetString("txtRemise.Properties.NullValuePrompt");
            this.txtRemise.StyleController = this.layoutControl1;
            // 
            // txtTax
            // 
            resources.ApplyResources(this.txtTax, "txtTax");
            this.txtTax.Name = "txtTax";
            this.txtTax.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTax.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtTax.Properties.Appearance.Font")));
            this.txtTax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTax.Properties.Appearance.Options.UseFont = true;
            this.txtTax.Properties.Appearance.Options.UseForeColor = true;
            this.txtTax.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTax.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtTax.Properties.Buttons"))))});
            this.txtTax.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtTax.Properties.NullValuePrompt = resources.GetString("txtTax.Properties.NullValuePrompt");
            this.txtTax.StyleController = this.layoutControl1;
            // 
            // textPeriodeDate
            // 
            resources.ApplyResources(this.textPeriodeDate, "textPeriodeDate");
            this.textPeriodeDate.Name = "textPeriodeDate";
            this.textPeriodeDate.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("textPeriodeDate.Properties.Appearance.Font")));
            this.textPeriodeDate.Properties.Appearance.Options.UseFont = true;
            this.textPeriodeDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("textPeriodeDate.Properties.Buttons"))))});
            this.textPeriodeDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textPeriodeDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textPeriodeDate.Properties.Items.AddRange(new object[] {
            resources.GetString("textPeriodeDate.Properties.Items"),
            resources.GetString("textPeriodeDate.Properties.Items1"),
            resources.GetString("textPeriodeDate.Properties.Items2"),
            resources.GetString("textPeriodeDate.Properties.Items3"),
            resources.GetString("textPeriodeDate.Properties.Items4"),
            resources.GetString("textPeriodeDate.Properties.Items5"),
            resources.GetString("textPeriodeDate.Properties.Items6")});
            this.textPeriodeDate.StyleController = this.layoutControl1;
            this.textPeriodeDate.EditValueChanged += new System.EventHandler(this.textPeriodeDate_EditValueChanged_1);
            // 
            // supplierID
            // 
            resources.ApplyResources(this.supplierID, "supplierID");
            this.supplierID.Name = "supplierID";
            this.supplierID.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("supplierID.Properties.Appearance.Font")));
            this.supplierID.Properties.Appearance.Options.UseFont = true;
            this.supplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("supplierID.Properties.Buttons"))))});
            this.supplierID.Properties.DataSource = this.ezziresto_suppliersBindingSource;
            this.supplierID.Properties.DisplayFormat.FormatString = "d";
            this.supplierID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.supplierID.Properties.DisplayMember = "name";
            this.supplierID.Properties.EditFormat.FormatString = "d";
            this.supplierID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.supplierID.Properties.NullText = resources.GetString("supplierID.Properties.NullText");
            this.supplierID.Properties.PopupView = this.searchLookUpEdit1View;
            this.supplierID.Properties.ValueMember = "id";
            this.supplierID.StyleController = this.layoutControl1;
            this.supplierID.EditValueChanged += new System.EventHandler(this.supplierID_EditValueChanged);
            // 
            // ezziresto_suppliersBindingSource
            // 
            this.ezziresto_suppliersBindingSource.DataMember = "ezziresto_suppliers";
            this.ezziresto_suppliersBindingSource.DataSource = this.sqlDataSourceSupplier;
            // 
            // sqlDataSourceSupplier
            // 
            this.sqlDataSourceSupplier.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceSupplier.Name = "sqlDataSourceSupplier";
            columnExpression9.ColumnName = "id";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"243\" />";
            table2.Name = "ezziresto.suppliers";
            columnExpression9.Table = table2;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "name";
            columnExpression10.Table = table2;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "phn_no";
            columnExpression11.Table = table2;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "created_at";
            columnExpression12.Table = table2;
            column12.Expression = columnExpression12;
            selectQuery2.Columns.Add(column9);
            selectQuery2.Columns.Add(column10);
            selectQuery2.Columns.Add(column11);
            selectQuery2.Columns.Add(column12);
            selectQuery2.Name = "ezziresto_suppliers";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSourceSupplier.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSourceSupplier.ResultSchemaSerializable = resources.GetString("sqlDataSourceSupplier.ResultSchemaSerializable");
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1,
            this.layoutControlGroup2,
            this.layoutControlGroup5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1419, 844);
            this.Root.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 147);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.tabArticle;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(1393, 671);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabArticle});
            this.tabbedControlGroup1.TextLocation = DevExpress.Utils.Locations.Bottom;
            // 
            // tabArticle
            // 
            this.tabArticle.AppearanceTabPage.Header.Font = ((System.Drawing.Font)(resources.GetObject("tabArticle.AppearanceTabPage.Header.Font")));
            this.tabArticle.AppearanceTabPage.Header.Options.UseFont = true;
            this.tabArticle.AppearanceTabPage.HeaderActive.Font = ((System.Drawing.Font)(resources.GetObject("tabArticle.AppearanceTabPage.HeaderActive.Font")));
            this.tabArticle.AppearanceTabPage.HeaderActive.Options.UseFont = true;
            this.tabArticle.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabArticle.CaptionImageOptions.Image")));
            this.tabArticle.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem34,
            this.layoutControlItem33,
            this.emptySpaceItem8,
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.emptySpaceItem3,
            this.layoutControlItem8,
            this.layoutControlGroup6});
            this.tabArticle.Location = new System.Drawing.Point(0, 0);
            this.tabArticle.Name = "tabArticle";
            this.tabArticle.Size = new System.Drawing.Size(1361, 597);
            resources.ApplyResources(this.tabArticle, "tabArticle");
            this.tabArticle.TextLocation = DevExpress.Utils.Locations.Bottom;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton2;
            this.layoutControlItem3.Location = new System.Drawing.Point(1291, 289);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(70, 77);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(70, 77);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(70, 77);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton4;
            this.layoutControlItem5.Location = new System.Drawing.Point(1291, 136);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(70, 80);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(70, 80);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(70, 80);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem34
            // 
            this.layoutControlItem34.Control = this.btnDelete;
            this.layoutControlItem34.Location = new System.Drawing.Point(1291, 216);
            this.layoutControlItem34.MaxSize = new System.Drawing.Size(70, 73);
            this.layoutControlItem34.MinSize = new System.Drawing.Size(70, 73);
            this.layoutControlItem34.Name = "layoutControlItem34";
            this.layoutControlItem34.Size = new System.Drawing.Size(70, 73);
            this.layoutControlItem34.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem34.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem34.TextVisible = false;
            // 
            // layoutControlItem33
            // 
            this.layoutControlItem33.Control = this.btnAdd;
            this.layoutControlItem33.Location = new System.Drawing.Point(1291, 0);
            this.layoutControlItem33.MaxSize = new System.Drawing.Size(0, 72);
            this.layoutControlItem33.MinSize = new System.Drawing.Size(30, 72);
            this.layoutControlItem33.Name = "layoutControlItem33";
            this.layoutControlItem33.Size = new System.Drawing.Size(70, 72);
            this.layoutControlItem33.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem33.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem33.TextVisible = false;
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(1291, 458);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(70, 139);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem15});
            this.layoutControlGroup3.Location = new System.Drawing.Point(521, 458);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(770, 139);
            resources.ApplyResources(this.layoutControlGroup3, "layoutControlGroup3");
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem9.AppearanceItemCaption.Font")));
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.Control = this.txtRemise;
            resources.ApplyResources(this.layoutControlItem9, "layoutControlItem9");
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(738, 40);
            this.layoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(67, 19);
            this.layoutControlItem9.TextToControlDistance = 16;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem15.AppearanceItemCaption.Font")));
            this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem15.Control = this.txtTax;
            resources.ApplyResources(this.layoutControlItem15, "layoutControlItem15");
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(738, 40);
            this.layoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem15.TextSize = new System.Drawing.Size(31, 19);
            this.layoutControlItem15.TextToControlDistance = 16;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem14});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 458);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(521, 139);
            resources.ApplyResources(this.layoutControlGroup4, "layoutControlGroup4");
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.AppearanceItemCaption.BackColor = System.Drawing.Color.LimeGreen;
            this.layoutControlItem10.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem10.AppearanceItemCaption.Font")));
            this.layoutControlItem10.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.layoutControlItem10.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem10.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem10.Control = this.txtTotal;
            resources.ApplyResources(this.layoutControlItem10, "layoutControlItem10");
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(489, 40);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(130, 19);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.AppearanceItemCaption.BackColor = System.Drawing.Color.DodgerBlue;
            this.layoutControlItem14.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem14.AppearanceItemCaption.Font")));
            this.layoutControlItem14.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.layoutControlItem14.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem14.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem14.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem14.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem14.Control = this.txtFinal;
            resources.ApplyResources(this.layoutControlItem14, "layoutControlItem14");
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(489, 40);
            this.layoutControlItem14.TextSize = new System.Drawing.Size(130, 19);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(1291, 366);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(70, 92);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnEdit;
            this.layoutControlItem8.Location = new System.Drawing.Point(1291, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(70, 64);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup6.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup6.AppearanceGroup.Font")));
            this.layoutControlGroup6.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup6.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem13});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(1291, 458);
            resources.ApplyResources(this.layoutControlGroup6, "layoutControlGroup6");
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControlPurchases;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1259, 358);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem13.AppearanceItemCaption.Font")));
            this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem13.Control = this.searchControl1;
            this.layoutControlItem13.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem13.ImageOptions.SvgImage")));
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(1259, 41);
            resources.ApplyResources(this.layoutControlItem13, "layoutControlItem13");
            this.layoutControlItem13.TextSize = new System.Drawing.Size(130, 35);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup2.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup2.AppearanceGroup.Font")));
            this.layoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.layoutControlGroup2.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.AppearanceGroup.Options.UseForeColor = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem7,
            this.emptySpaceItem7,
            this.layoutControlItem11});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(951, 147);
            resources.ApplyResources(this.layoutControlGroup2, "layoutControlGroup2");
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem1.AppearanceItemCaption.Font")));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.textPeriodeDate;
            this.layoutControlItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem1.ImageOptions.SvgImage")));
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(294, 44);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(81, 35);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem6.AppearanceItemCaption.Font")));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.startDate;
            resources.ApplyResources(this.layoutControlItem6, "layoutControlItem6");
            this.layoutControlItem6.Location = new System.Drawing.Point(294, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(298, 40);
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(30, 16);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem2.AppearanceItemCaption.Font")));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.endDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(294, 40);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(298, 40);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(298, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(298, 48);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(30, 16);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 44);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(294, 44);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem7.AppearanceItemCaption.Font")));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.supplierID;
            resources.ApplyResources(this.layoutControlItem7, "layoutControlItem7");
            this.layoutControlItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem7.ImageOptions.SvgImage")));
            this.layoutControlItem7.Location = new System.Drawing.Point(592, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(327, 41);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(130, 35);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(592, 41);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(207, 47);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnReset;
            this.layoutControlItem11.Location = new System.Drawing.Point(799, 41);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(90, 47);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(120, 47);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup5.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup5.AppearanceGroup.Font")));
            this.layoutControlGroup5.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup5.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem17,
            this.layoutControlItem12});
            this.layoutControlGroup5.Location = new System.Drawing.Point(951, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(442, 147);
            resources.ApplyResources(this.layoutControlGroup5, "layoutControlGroup5");
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem17.AppearanceItemCaption.Font")));
            this.layoutControlItem17.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem17.Control = this.txtTotalSelectedRow;
            resources.ApplyResources(this.layoutControlItem17, "layoutControlItem17");
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(410, 48);
            this.layoutControlItem17.TextSize = new System.Drawing.Size(130, 16);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem12.AppearanceItemCaption.Font")));
            this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem12.Control = this.txtOrderSelectedRow;
            resources.ApplyResources(this.layoutControlItem12, "layoutControlItem12");
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(410, 40);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(130, 16);
            // 
            // Form_Ingredient_Purchases_List
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.Name = "Form_Ingredient_Purchases_List";
            this.Load += new System.EventHandler(this.Form_Ingredient_Purchases_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderSelectedRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSelectedRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemise.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPeriodeDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.GridControl gridControlPurchases;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourcePurchases;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPurchases;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtOrderSelectedRow;
        private DevExpress.XtraEditors.TextEdit txtFinal;
        private DevExpress.XtraEditors.TextEdit txtTotalSelectedRow;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.DateEdit endDate;
        private DevExpress.XtraEditors.DateEdit startDate;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SpinEdit txtRemise;
        private DevExpress.XtraEditors.SpinEdit txtTax;
        private DevExpress.XtraEditors.ComboBoxEdit textPeriodeDate;
        private DevExpress.XtraEditors.SearchLookUpEdit supplierID;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup tabArticle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem34;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem33;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraGrid.Columns.GridColumn colcredit_amount;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_at;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colpaid_amount;
        private DevExpress.XtraGrid.Columns.GridColumn colpayment_type;
        private DevExpress.XtraGrid.Columns.GridColumn colpurchase_date;
        private DevExpress.XtraGrid.Columns.GridColumn colsupplier_name;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_bill;
        private System.Windows.Forms.BindingSource ezziresto_suppliersBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceSupplier;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
    }
}