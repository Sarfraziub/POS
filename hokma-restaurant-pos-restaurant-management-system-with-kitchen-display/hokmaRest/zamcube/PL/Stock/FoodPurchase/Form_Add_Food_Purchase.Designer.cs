
namespace ezziresto.PL.Stock.FoodPurchase
{
    partial class Form_Add_Food_Purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Food_Purchase));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery4 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.gridControlPurchase = new DevExpress.XtraGrid.GridControl();
            this.gridViewPurchase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.paidAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtNet = new DevExpress.XtraEditors.TextEdit();
            this.txtFinalPrice = new DevExpress.XtraEditors.TextEdit();
            this.btnLeft = new DevExpress.XtraEditors.SimpleButton();
            this.txtPaymentType = new DevExpress.XtraEditors.LookUpEdit();
            this.ezziresto_payment_typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourcePaymentType = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.txtRemise = new DevExpress.XtraEditors.SpinEdit();
            this.txtTax = new DevExpress.XtraEditors.SpinEdit();
            this.txtProducts = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ezziresto_food_itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceFood = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.fieldNameSupplier = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ezziresto_suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceSupplier = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_at1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphn_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtBranch = new DevExpress.XtraEditors.LookUpEdit();
            this.ezziresto_branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceBranch = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnRight = new DevExpress.XtraEditors.SimpleButton();
            this.txtDesc = new DevExpress.XtraEditors.MemoEdit();
            this.purchaseDate = new DevExpress.XtraEditors.DateEdit();
            this.btnDeleteItem = new DevExpress.XtraEditors.SimpleButton();
            this.txtQty = new DevExpress.XtraEditors.SpinEdit();
            this.txtDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.txtPrice = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup51 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.alertTotalPriceScreen = new DevExpress.XtraLayout.SimpleLabelItem();
            this.totalPriceCurency = new DevExpress.XtraLayout.SimpleLabelItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.tabArticle = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtFinal2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup2 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem46 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem45 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem36 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_payment_typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemise.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_food_itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldNameSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertTotalPriceScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceCurency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchControl1);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.gridControlPurchase);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.txtTotal);
            this.layoutControl1.Controls.Add(this.paidAmount);
            this.layoutControl1.Controls.Add(this.txtNet);
            this.layoutControl1.Controls.Add(this.txtFinalPrice);
            this.layoutControl1.Controls.Add(this.btnLeft);
            this.layoutControl1.Controls.Add(this.txtPaymentType);
            this.layoutControl1.Controls.Add(this.txtRemise);
            this.layoutControl1.Controls.Add(this.txtTax);
            this.layoutControl1.Controls.Add(this.txtProducts);
            this.layoutControl1.Controls.Add(this.btnAddProduct);
            this.layoutControl1.Controls.Add(this.fieldNameSupplier);
            this.layoutControl1.Controls.Add(this.txtBranch);
            this.layoutControl1.Controls.Add(this.btnRight);
            this.layoutControl1.Controls.Add(this.txtDesc);
            this.layoutControl1.Controls.Add(this.purchaseDate);
            this.layoutControl1.Controls.Add(this.btnDeleteItem);
            this.layoutControl1.Controls.Add(this.txtQty);
            this.layoutControl1.Controls.Add(this.txtDiscount);
            this.layoutControl1.Controls.Add(this.txtPrice);
            this.layoutControl1.Controls.Add(this.layoutControl4);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(880, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControlPurchase;
            resources.ApplyResources(this.searchControl1, "searchControl1");
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControlPurchase;
            this.searchControl1.Properties.FindDelay = 200;
            this.searchControl1.StyleController = this.layoutControl1;
            // 
            // gridControlPurchase
            // 
            resources.ApplyResources(this.gridControlPurchase, "gridControlPurchase");
            this.gridControlPurchase.MainView = this.gridViewPurchase;
            this.gridControlPurchase.Name = "gridControlPurchase";
            this.gridControlPurchase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPurchase});
            // 
            // gridViewPurchase
            // 
            this.gridViewPurchase.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridViewPurchase.Appearance.Row.Font")));
            this.gridViewPurchase.Appearance.Row.Options.UseFont = true;
            this.gridViewPurchase.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewPurchase.GridControl = this.gridControlPurchase;
            this.gridViewPurchase.Name = "gridViewPurchase";
            this.gridViewPurchase.OptionsBehavior.Editable = false;
            this.gridViewPurchase.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPurchase.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewPurchase.OptionsView.ShowGroupPanel = false;
            this.gridViewPurchase.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPurchase_RowClick);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // paidAmount
            // 
            resources.ApplyResources(this.paidAmount, "paidAmount");
            this.paidAmount.Name = "paidAmount";
            this.paidAmount.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("paidAmount.Properties.Appearance.Font")));
            this.paidAmount.Properties.Appearance.Options.UseFont = true;
            this.paidAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.paidAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.paidAmount.StyleController = this.layoutControl1;
            // 
            // txtNet
            // 
            resources.ApplyResources(this.txtNet, "txtNet");
            this.txtNet.Name = "txtNet";
            this.txtNet.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtNet.Properties.Appearance.Font")));
            this.txtNet.Properties.Appearance.Options.UseFont = true;
            this.txtNet.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNet.Properties.ReadOnly = true;
            this.txtNet.Properties.UseReadOnlyAppearance = false;
            this.txtNet.StyleController = this.layoutControl1;
            // 
            // txtFinalPrice
            // 
            resources.ApplyResources(this.txtFinalPrice, "txtFinalPrice");
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtFinalPrice.Properties.Appearance.Font")));
            this.txtFinalPrice.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtFinalPrice.Properties.Appearance.Options.UseFont = true;
            this.txtFinalPrice.Properties.Appearance.Options.UseForeColor = true;
            this.txtFinalPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtFinalPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtFinalPrice.Properties.ReadOnly = true;
            this.txtFinalPrice.Properties.UseReadOnlyAppearance = false;
            this.txtFinalPrice.StyleController = this.layoutControl1;
            // 
            // btnLeft
            // 
            this.btnLeft.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLeft.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLeft.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnLeft, "btnLeft");
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.StyleController = this.layoutControl1;
            // 
            // txtPaymentType
            // 
            resources.ApplyResources(this.txtPaymentType, "txtPaymentType");
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.False;
            this.txtPaymentType.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtPaymentType.Properties.Appearance.Font")));
            this.txtPaymentType.Properties.Appearance.Options.UseFont = true;
            this.txtPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtPaymentType.Properties.Buttons"))))});
            this.txtPaymentType.Properties.DataSource = this.ezziresto_payment_typesBindingSource;
            this.txtPaymentType.Properties.DisplayMember = "name";
            this.txtPaymentType.Properties.NullText = resources.GetString("txtPaymentType.Properties.NullText");
            this.txtPaymentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtPaymentType.Properties.ValueMember = "id";
            this.txtPaymentType.StyleController = this.layoutControl1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtPaymentType, conditionValidationRule1);
            // 
            // ezziresto_payment_typesBindingSource
            // 
            this.ezziresto_payment_typesBindingSource.DataMember = "ezziresto_payment_types";
            this.ezziresto_payment_typesBindingSource.DataSource = this.sqlDataSourcePaymentType;
            // 
            // sqlDataSourcePaymentType
            // 
            this.sqlDataSourcePaymentType.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourcePaymentType.Name = "sqlDataSourcePaymentType";
            columnExpression1.ColumnName = "id";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"183\" />";
            table1.Name = "ezziresto.payment_types";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "name";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "created_at";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Name = "ezziresto_payment_types";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSourcePaymentType.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSourcePaymentType.ResultSchemaSerializable = resources.GetString("sqlDataSourcePaymentType.ResultSchemaSerializable");
            // 
            // txtRemise
            // 
            resources.ApplyResources(this.txtRemise, "txtRemise");
            this.txtRemise.Name = "txtRemise";
            this.txtRemise.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtRemise.Properties.Appearance.Font")));
            this.txtRemise.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRemise.Properties.Appearance.Options.UseFont = true;
            this.txtRemise.Properties.Appearance.Options.UseForeColor = true;
            this.txtRemise.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRemise.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRemise.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtRemise.Properties.Buttons"))))});
            this.txtRemise.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtRemise.StyleController = this.layoutControl1;
            // 
            // txtTax
            // 
            resources.ApplyResources(this.txtTax, "txtTax");
            this.txtTax.Name = "txtTax";
            this.txtTax.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtTax.Properties.Appearance.Font")));
            this.txtTax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTax.Properties.Appearance.Options.UseFont = true;
            this.txtTax.Properties.Appearance.Options.UseForeColor = true;
            this.txtTax.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTax.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtTax.Properties.Buttons"))))});
            this.txtTax.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtTax.StyleController = this.layoutControl1;
            // 
            // txtProducts
            // 
            resources.ApplyResources(this.txtProducts, "txtProducts");
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtProducts.Properties.Appearance.Font")));
            this.txtProducts.Properties.Appearance.Options.UseFont = true;
            this.txtProducts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtProducts.Properties.Buttons"))))});
            this.txtProducts.Properties.DataSource = this.ezziresto_food_itemsBindingSource;
            this.txtProducts.Properties.DisplayMember = "name";
            this.txtProducts.Properties.NullText = resources.GetString("txtProducts.Properties.NullText");
            this.txtProducts.Properties.PopupView = this.searchLookUpEdit1View;
            this.txtProducts.Properties.ValueMember = "id";
            this.txtProducts.StyleController = this.layoutControl1;
            this.txtProducts.EditValueChanged += new System.EventHandler(this.txtProducts_EditValueChanged);
            // 
            // ezziresto_food_itemsBindingSource
            // 
            this.ezziresto_food_itemsBindingSource.DataMember = "ezziresto_food_items";
            this.ezziresto_food_itemsBindingSource.DataSource = this.sqlDataSourceFood;
            // 
            // sqlDataSourceFood
            // 
            this.sqlDataSourceFood.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceFood.Name = "sqlDataSourceFood";
            columnExpression4.ColumnName = "id";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"303\" />";
            table2.Name = "ezziresto.food_items";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "name";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "price";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "created_at";
            columnExpression7.Table = table2;
            column7.Expression = columnExpression7;
            selectQuery2.Columns.Add(column4);
            selectQuery2.Columns.Add(column5);
            selectQuery2.Columns.Add(column6);
            selectQuery2.Columns.Add(column7);
            selectQuery2.Name = "ezziresto_food_items";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSourceFood.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSourceFood.ResultSchemaSerializable = resources.GetString("sqlDataSourceFood.ResultSchemaSerializable");
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.colunit,
            this.colid,
            this.colcreated_at});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colname
            // 
            resources.ApplyResources(this.colname, "colname");
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            // 
            // colunit
            // 
            resources.ApplyResources(this.colunit, "colunit");
            this.colunit.FieldName = "unit";
            this.colunit.Name = "colunit";
            // 
            // colid
            // 
            this.colid.AppearanceCell.Options.UseTextOptions = true;
            this.colid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colid, "colid");
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcreated_at
            // 
            resources.ApplyResources(this.colcreated_at, "colcreated_at");
            this.colcreated_at.FieldName = "created_at";
            this.colcreated_at.Name = "colcreated_at";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddProduct.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnAddProduct, "btnAddProduct");
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.StyleController = this.layoutControl1;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // fieldNameSupplier
            // 
            resources.ApplyResources(this.fieldNameSupplier, "fieldNameSupplier");
            this.fieldNameSupplier.Name = "fieldNameSupplier";
            this.fieldNameSupplier.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("fieldNameSupplier.Properties.Appearance.Font")));
            this.fieldNameSupplier.Properties.Appearance.Options.UseFont = true;
            this.fieldNameSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fieldNameSupplier.Properties.Buttons"))))});
            this.fieldNameSupplier.Properties.DataSource = this.ezziresto_suppliersBindingSource;
            this.fieldNameSupplier.Properties.DisplayMember = "name";
            this.fieldNameSupplier.Properties.NullText = resources.GetString("fieldNameSupplier.Properties.NullText");
            this.fieldNameSupplier.Properties.PopupView = this.gridView1;
            this.fieldNameSupplier.Properties.ValueMember = "id";
            this.fieldNameSupplier.StyleController = this.layoutControl1;
            this.fieldNameSupplier.Tag = "Client";
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.fieldNameSupplier, conditionValidationRule2);
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
            columnExpression8.ColumnName = "id";
            table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"243\" />";
            table3.Name = "ezziresto.suppliers";
            columnExpression8.Table = table3;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "name";
            columnExpression9.Table = table3;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "created_at";
            columnExpression10.Table = table3;
            column10.Expression = columnExpression10;
            selectQuery3.Columns.Add(column8);
            selectQuery3.Columns.Add(column9);
            selectQuery3.Columns.Add(column10);
            selectQuery3.Name = "ezziresto_suppliers";
            selectQuery3.Tables.Add(table3);
            this.sqlDataSourceSupplier.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery3});
            this.sqlDataSourceSupplier.ResultSchemaSerializable = resources.GetString("sqlDataSourceSupplier.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colcreated_at1,
            this.colname1,
            this.colphn_no});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.AppearanceCell.Options.UseTextOptions = true;
            this.colid1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colid1, "colid1");
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colcreated_at1
            // 
            resources.ApplyResources(this.colcreated_at1, "colcreated_at1");
            this.colcreated_at1.FieldName = "created_at";
            this.colcreated_at1.Name = "colcreated_at1";
            // 
            // colname1
            // 
            resources.ApplyResources(this.colname1, "colname1");
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            // 
            // colphn_no
            // 
            resources.ApplyResources(this.colphn_no, "colphn_no");
            this.colphn_no.FieldName = "phn_no";
            this.colphn_no.Name = "colphn_no";
            // 
            // txtBranch
            // 
            resources.ApplyResources(this.txtBranch, "txtBranch");
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtBranch.Properties.Appearance.Font")));
            this.txtBranch.Properties.Appearance.Options.UseFont = true;
            this.txtBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtBranch.Properties.Buttons"))))});
            this.txtBranch.Properties.DataSource = this.ezziresto_branchesBindingSource;
            this.txtBranch.Properties.DisplayMember = "name";
            this.txtBranch.Properties.NullText = resources.GetString("txtBranch.Properties.NullText");
            this.txtBranch.Properties.ValueMember = "id";
            this.txtBranch.StyleController = this.layoutControl1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtBranch, conditionValidationRule3);
            // 
            // ezziresto_branchesBindingSource
            // 
            this.ezziresto_branchesBindingSource.DataMember = "ezziresto_branches";
            this.ezziresto_branchesBindingSource.DataSource = this.sqlDataSourceBranch;
            // 
            // sqlDataSourceBranch
            // 
            this.sqlDataSourceBranch.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceBranch.Name = "sqlDataSourceBranch";
            columnExpression11.ColumnName = "name";
            table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"283\" />";
            table4.Name = "ezziresto.branches";
            columnExpression11.Table = table4;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "id";
            columnExpression12.Table = table4;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "created_at";
            columnExpression13.Table = table4;
            column13.Expression = columnExpression13;
            selectQuery4.Columns.Add(column11);
            selectQuery4.Columns.Add(column12);
            selectQuery4.Columns.Add(column13);
            selectQuery4.Name = "ezziresto_branches";
            selectQuery4.Tables.Add(table4);
            this.sqlDataSourceBranch.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery4});
            this.sqlDataSourceBranch.ResultSchemaSerializable = resources.GetString("sqlDataSourceBranch.ResultSchemaSerializable");
            // 
            // btnRight
            // 
            this.btnRight.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRight.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRight.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnRight, "btnRight");
            this.btnRight.Name = "btnRight";
            this.btnRight.StyleController = this.layoutControl1;
            this.btnRight.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // txtDesc
            // 
            resources.ApplyResources(this.txtDesc, "txtDesc");
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtDesc.Properties.Appearance.Font")));
            this.txtDesc.Properties.Appearance.Options.UseFont = true;
            this.txtDesc.StyleController = this.layoutControl1;
            // 
            // purchaseDate
            // 
            resources.ApplyResources(this.purchaseDate, "purchaseDate");
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("purchaseDate.Properties.Appearance.Font")));
            this.purchaseDate.Properties.Appearance.Options.UseFont = true;
            this.purchaseDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("purchaseDate.Properties.Buttons"))))});
            this.purchaseDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("purchaseDate.Properties.CalendarTimeProperties.Buttons"))))});
            this.purchaseDate.Properties.DisplayFormat.FormatString = "";
            this.purchaseDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.purchaseDate.Properties.EditFormat.FormatString = "";
            this.purchaseDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.purchaseDate.Properties.MaskSettings.Set("mask", "");
            this.purchaseDate.StyleController = this.layoutControl1;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.purchaseDate, conditionValidationRule4);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItem.ImageOptions.Image")));
            this.btnDeleteItem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            resources.ApplyResources(this.btnDeleteItem, "btnDeleteItem");
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.StyleController = this.layoutControl1;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // txtQty
            // 
            resources.ApplyResources(this.txtQty, "txtQty");
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtQty.Properties.Buttons"))))});
            this.txtQty.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtQty.Properties.MaskSettings.Set("mask", "d");
            this.txtQty.StyleController = this.layoutControl1;
            this.txtQty.EditValueChanged += new System.EventHandler(this.txtQty_EditValueChanged);
            // 
            // txtDiscount
            // 
            resources.ApplyResources(this.txtDiscount, "txtDiscount");
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDiscount.Properties.Buttons"))))});
            this.txtDiscount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtDiscount.Properties.MaskSettings.Set("mask", "d");
            this.txtDiscount.StyleController = this.layoutControl1;
            this.txtDiscount.EditValueChanged += new System.EventHandler(this.txtDiscount_EditValueChanged);
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtPrice.Properties.Buttons"))))});
            this.txtPrice.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtPrice.Properties.MaskSettings.Set("mask", "d");
            this.txtPrice.StyleController = this.layoutControl1;
            this.txtPrice.EditValueChanged += new System.EventHandler(this.txtPrice_EditValueChanged);
            // 
            // layoutControl4
            // 
            resources.ApplyResources(this.layoutControl4, "layoutControl4");
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.Root = this.layoutControlGroup51;
            // 
            // layoutControlGroup51
            // 
            this.layoutControlGroup51.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(142)))), ((int)(((byte)(231)))));
            this.layoutControlGroup51.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup51.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup51.GroupBordersVisible = false;
            this.layoutControlGroup51.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.alertTotalPriceScreen,
            this.totalPriceCurency});
            this.layoutControlGroup51.Name = "layoutControlGroup51";
            this.layoutControlGroup51.Size = new System.Drawing.Size(328, 105);
            this.layoutControlGroup51.TextVisible = false;
            // 
            // alertTotalPriceScreen
            // 
            this.alertTotalPriceScreen.AllowHotTrack = false;
            this.alertTotalPriceScreen.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("alertTotalPriceScreen.AppearanceItemCaption.Font")));
            this.alertTotalPriceScreen.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.alertTotalPriceScreen.AppearanceItemCaption.Options.UseFont = true;
            this.alertTotalPriceScreen.AppearanceItemCaption.Options.UseForeColor = true;
            this.alertTotalPriceScreen.AppearanceItemCaption.Options.UseTextOptions = true;
            this.alertTotalPriceScreen.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.alertTotalPriceScreen.Location = new System.Drawing.Point(0, 0);
            this.alertTotalPriceScreen.MaxSize = new System.Drawing.Size(0, 79);
            this.alertTotalPriceScreen.MinSize = new System.Drawing.Size(154, 79);
            this.alertTotalPriceScreen.Name = "alertTotalPriceScreen";
            this.alertTotalPriceScreen.Size = new System.Drawing.Size(227, 79);
            this.alertTotalPriceScreen.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            resources.ApplyResources(this.alertTotalPriceScreen, "alertTotalPriceScreen");
            this.alertTotalPriceScreen.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.alertTotalPriceScreen.TextSize = new System.Drawing.Size(140, 55);
            // 
            // totalPriceCurency
            // 
            this.totalPriceCurency.AllowHotTrack = false;
            this.totalPriceCurency.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("totalPriceCurency.AppearanceItemCaption.Font")));
            this.totalPriceCurency.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.totalPriceCurency.AppearanceItemCaption.Options.UseFont = true;
            this.totalPriceCurency.AppearanceItemCaption.Options.UseForeColor = true;
            this.totalPriceCurency.AppearanceItemCaption.Options.UseTextOptions = true;
            this.totalPriceCurency.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totalPriceCurency.AutoSizeMode = DevExpress.XtraLayout.SimpleLabelAutoSizeMode.None;
            this.totalPriceCurency.Location = new System.Drawing.Point(227, 0);
            this.totalPriceCurency.Name = "totalPriceCurency";
            this.totalPriceCurency.Size = new System.Drawing.Size(75, 79);
            this.totalPriceCurency.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            resources.ApplyResources(this.totalPriceCurency, "totalPriceCurency");
            this.totalPriceCurency.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.totalPriceCurency.TextSize = new System.Drawing.Size(69, 55);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1,
            this.layoutControlGroup4,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1179, 802);
            this.Root.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 123);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.tabArticle;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(1153, 653);
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
            this.layoutControlItem10,
            this.layoutControlItem13,
            this.txtFinal2,
            this.layoutControlItem9,
            this.layoutControlItem15,
            this.tabbedControlGroup2,
            this.layoutControlItem11,
            this.emptySpaceItem3,
            this.layoutControlGroup5,
            this.layoutControlGroup6});
            this.tabArticle.Location = new System.Drawing.Point(0, 0);
            this.tabArticle.Name = "tabArticle";
            this.tabArticle.Size = new System.Drawing.Size(1121, 579);
            resources.ApplyResources(this.tabArticle, "tabArticle");
            this.tabArticle.TextLocation = DevExpress.Utils.Locations.Bottom;
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
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 459);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(424, 40);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(95, 19);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem13.AppearanceItemCaption.Font")));
            this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem13.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem13.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem13.Control = this.txtNet;
            resources.ApplyResources(this.layoutControlItem13, "layoutControlItem13");
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 499);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(424, 40);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(95, 19);
            // 
            // txtFinal2
            // 
            this.txtFinal2.AppearanceItemCaption.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtFinal2.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("txtFinal2.AppearanceItemCaption.Font")));
            this.txtFinal2.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.txtFinal2.AppearanceItemCaption.Options.UseBackColor = true;
            this.txtFinal2.AppearanceItemCaption.Options.UseFont = true;
            this.txtFinal2.AppearanceItemCaption.Options.UseForeColor = true;
            this.txtFinal2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.txtFinal2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtFinal2.Control = this.txtFinalPrice;
            resources.ApplyResources(this.txtFinal2, "txtFinal2");
            this.txtFinal2.Location = new System.Drawing.Point(0, 539);
            this.txtFinal2.Name = "txtFinal2";
            this.txtFinal2.Size = new System.Drawing.Size(424, 40);
            this.txtFinal2.TextSize = new System.Drawing.Size(95, 19);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem9.AppearanceItemCaption.Font")));
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.Control = this.txtRemise;
            resources.ApplyResources(this.layoutControlItem9, "layoutControlItem9");
            this.layoutControlItem9.Location = new System.Drawing.Point(424, 459);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(331, 40);
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
            this.layoutControlItem15.Location = new System.Drawing.Point(424, 499);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(331, 40);
            this.layoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem15.TextSize = new System.Drawing.Size(31, 19);
            this.layoutControlItem15.TextToControlDistance = 16;
            // 
            // tabbedControlGroup2
            // 
            this.tabbedControlGroup2.Location = new System.Drawing.Point(755, 0);
            this.tabbedControlGroup2.Name = "tabbedControlGroup2";
            this.tabbedControlGroup2.SelectedTabPage = this.layoutControlGroup3;
            this.tabbedControlGroup2.Size = new System.Drawing.Size(366, 579);
            this.tabbedControlGroup2.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup3.AppearanceGroup.Font")));
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImageOptions.Image")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem12,
            this.layoutControlItem1,
            this.layoutControlItem18,
            this.layoutControlItem3,
            this.layoutControlItem22});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(334, 518);
            resources.ApplyResources(this.layoutControlGroup3, "layoutControlGroup3");
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem7.AppearanceItemCaption.Font")));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.fieldNameSupplier;
            resources.ApplyResources(this.layoutControlItem7, "layoutControlItem7");
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 191);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(334, 40);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem12.AppearanceItemCaption.Font")));
            this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem12.Control = this.txtBranch;
            resources.ApplyResources(this.layoutControlItem12, "layoutControlItem12");
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 111);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(334, 40);
            this.layoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(45, 16);
            this.layoutControlItem12.TextToControlDistance = 10;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem1.AppearanceItemCaption.Font")));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtDesc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 271);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(334, 247);
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem18.AppearanceItemCaption.Font")));
            this.layoutControlItem18.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem18.Control = this.txtPaymentType;
            resources.ApplyResources(this.layoutControlItem18, "layoutControlItem18");
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 231);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(334, 40);
            this.layoutControlItem18.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem3.AppearanceItemCaption.Font")));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.purchaseDate;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 151);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(334, 40);
            resources.ApplyResources(this.layoutControlItem3, "layoutControlItem3");
            this.layoutControlItem3.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.layoutControl4;
            resources.ApplyResources(this.layoutControlItem22, "layoutControlItem22");
            this.layoutControlItem22.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(334, 111);
            this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem22.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem11.AppearanceItemCaption.Font")));
            this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem11.Control = this.paidAmount;
            resources.ApplyResources(this.layoutControlItem11, "layoutControlItem11");
            this.layoutControlItem11.Location = new System.Drawing.Point(424, 539);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(331, 40);
            this.layoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(27, 16);
            this.layoutControlItem11.TextToControlDistance = 15;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 103);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(755, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup5.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup5.AppearanceGroup.Font")));
            this.layoutControlGroup5.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup5.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem17,
            this.layoutControlItem19});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(755, 103);
            resources.ApplyResources(this.layoutControlGroup5, "layoutControlGroup5");
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem6.AppearanceItemCaption.Font")));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.txtPrice;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(211, 44);
            resources.ApplyResources(this.layoutControlItem6, "layoutControlItem6");
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(28, 13);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem8.AppearanceItemCaption.Font")));
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.Control = this.txtQty;
            this.layoutControlItem8.Location = new System.Drawing.Point(211, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(256, 44);
            resources.ApplyResources(this.layoutControlItem8, "layoutControlItem8");
            this.layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(49, 13);
            this.layoutControlItem8.TextToControlDistance = 5;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem17.AppearanceItemCaption.Font")));
            this.layoutControlItem17.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem17.Control = this.txtDiscount;
            this.layoutControlItem17.Location = new System.Drawing.Point(467, 0);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(210, 44);
            resources.ApplyResources(this.layoutControlItem17, "layoutControlItem17");
            this.layoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem17.TextSize = new System.Drawing.Size(49, 13);
            this.layoutControlItem17.TextToControlDistance = 5;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.btnDeleteItem;
            this.layoutControlItem19.Location = new System.Drawing.Point(677, 0);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(46, 44);
            this.layoutControlItem19.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem19.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup6.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup6.AppearanceGroup.Font")));
            this.layoutControlGroup6.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup6.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem21,
            this.layoutControlItem4});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 113);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(755, 346);
            resources.ApplyResources(this.layoutControlGroup6, "layoutControlGroup6");
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem21.AppearanceItemCaption.Font")));
            this.layoutControlItem21.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem21.Control = this.searchControl1;
            this.layoutControlItem21.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(723, 34);
            resources.ApplyResources(this.layoutControlItem21, "layoutControlItem21");
            this.layoutControlItem21.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControlPurchase;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(723, 253);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup4.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup4.AppearanceGroup.Font")));
            this.layoutControlGroup4.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup4.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem14,
            this.layoutControlItem46,
            this.emptySpaceItem2,
            this.emptySpaceItem4});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(769, 123);
            resources.ApplyResources(this.layoutControlGroup4, "layoutControlGroup4");
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem14.AppearanceItemCaption.Font")));
            this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem14.ContentVertAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem14.Control = this.txtProducts;
            this.layoutControlItem14.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.layoutControlItem14.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem14.ImageOptions.SvgImage")));
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 10);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(679, 44);
            resources.ApplyResources(this.layoutControlItem14, "layoutControlItem14");
            this.layoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem14.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem14.TextSize = new System.Drawing.Size(79, 35);
            this.layoutControlItem14.TextToControlDistance = 5;
            // 
            // layoutControlItem46
            // 
            this.layoutControlItem46.Control = this.btnAddProduct;
            this.layoutControlItem46.Location = new System.Drawing.Point(679, 10);
            this.layoutControlItem46.MinSize = new System.Drawing.Size(46, 44);
            this.layoutControlItem46.Name = "layoutControlItem46";
            this.layoutControlItem46.Size = new System.Drawing.Size(58, 44);
            this.layoutControlItem46.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem46.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem46.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 54);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(737, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(737, 10);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup2.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup2.AppearanceGroup.Font")));
            this.layoutControlGroup2.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem45,
            this.layoutControlItem36,
            this.layoutControlItem2,
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(769, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(384, 123);
            resources.ApplyResources(this.layoutControlGroup2, "layoutControlGroup2");
            // 
            // layoutControlItem45
            // 
            this.layoutControlItem45.Control = this.btnAdd;
            this.layoutControlItem45.Location = new System.Drawing.Point(239, 0);
            this.layoutControlItem45.MinSize = new System.Drawing.Size(46, 44);
            this.layoutControlItem45.Name = "layoutControlItem45";
            this.layoutControlItem45.Size = new System.Drawing.Size(113, 64);
            this.layoutControlItem45.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem45.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem45.TextVisible = false;
            // 
            // layoutControlItem36
            // 
            this.layoutControlItem36.Control = this.btnRight;
            resources.ApplyResources(this.layoutControlItem36, "layoutControlItem36");
            this.layoutControlItem36.Location = new System.Drawing.Point(162, 0);
            this.layoutControlItem36.MinSize = new System.Drawing.Size(46, 44);
            this.layoutControlItem36.Name = "layoutControlItem36";
            this.layoutControlItem36.Size = new System.Drawing.Size(77, 64);
            this.layoutControlItem36.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem36.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem36.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnLeft;
            this.layoutControlItem2.Location = new System.Drawing.Point(86, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(46, 44);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(76, 64);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnPrint;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(57, 61);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(86, 64);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // Form_Add_Food_Purchase
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.Name = "Form_Add_Food_Purchase";
            this.Load += new System.EventHandler(this.Form_Add_Food_Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_payment_typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemise.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_food_itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldNameSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertTotalPriceScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceCurency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl gridControlPurchase;
        internal DevExpress.XtraGrid.Views.Grid.GridView gridViewPurchase;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit paidAmount;
        private DevExpress.XtraEditors.TextEdit txtNet;
        private DevExpress.XtraEditors.TextEdit txtFinalPrice;
        private DevExpress.XtraEditors.SimpleButton btnLeft;
        private DevExpress.XtraEditors.LookUpEdit txtPaymentType;
        private DevExpress.XtraEditors.SpinEdit txtRemise;
        private DevExpress.XtraEditors.SpinEdit txtTax;
        private DevExpress.XtraEditors.SearchLookUpEdit txtProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colunit;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_at;
        private DevExpress.XtraEditors.SimpleButton btnAddProduct;
        private DevExpress.XtraEditors.SearchLookUpEdit fieldNameSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_at1;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn colphn_no;
        private DevExpress.XtraEditors.LookUpEdit txtBranch;
        private DevExpress.XtraEditors.SimpleButton btnRight;
        private DevExpress.XtraEditors.MemoEdit txtDesc;
        private DevExpress.XtraEditors.DateEdit purchaseDate;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup tabArticle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem txtFinal2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem45;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem36;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem46;
        private System.Windows.Forms.BindingSource ezziresto_branchesBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceBranch;
        private System.Windows.Forms.BindingSource ezziresto_suppliersBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceSupplier;
        private System.Windows.Forms.BindingSource ezziresto_payment_typesBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourcePaymentType;
        private System.Windows.Forms.BindingSource ezziresto_food_itemsBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceFood;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraEditors.SimpleButton btnDeleteItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraEditors.SpinEdit txtQty;
        private DevExpress.XtraEditors.SpinEdit txtDiscount;
        private DevExpress.XtraEditors.SpinEdit txtPrice;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup51;
        private DevExpress.XtraLayout.SimpleLabelItem alertTotalPriceScreen;
        private DevExpress.XtraLayout.SimpleLabelItem totalPriceCurency;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
    }
}