
namespace ezziresto.PL.Rapport
{
    partial class Form_Order_Histories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Order_Histories));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchControl2 = new DevExpress.XtraEditors.SearchControl();
            this.gridControlSettled = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSourceSattled = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewSettled = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbranch_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcustomer_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltable_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_guest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwaiter_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.gridControlSubmitted = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSourceSubmitted = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewISubmitted = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbranch_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_at1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcustomer_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltable_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_guest1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwaiter_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.endDate = new DevExpress.XtraEditors.DateEdit();
            this.startDate = new DevExpress.XtraEditors.DateEdit();
            this.btnPos = new DevExpress.XtraEditors.SimpleButton();
            this.textPeriodeDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtClient = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ezziresto_customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceClients = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup51 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.alertTotalProfitSettledScreen = new DevExpress.XtraLayout.SimpleLabelItem();
            this.totalPriceCurency = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControl41 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup511 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.alertTotalProfitSubmittedScreen = new DevExpress.XtraLayout.SimpleLabelItem();
            this.totalPriceCurency1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabOrder = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSettled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSettled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubmitted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewISubmitted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPeriodeDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertTotalProfitSettledScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceCurency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup511)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertTotalProfitSubmittedScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceCurency1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Controls.Add(this.searchControl2);
            this.layoutControl1.Controls.Add(this.searchControl1);
            this.layoutControl1.Controls.Add(this.gridControlSubmitted);
            this.layoutControl1.Controls.Add(this.gridControlSettled);
            this.layoutControl1.Controls.Add(this.endDate);
            this.layoutControl1.Controls.Add(this.startDate);
            this.layoutControl1.Controls.Add(this.btnPos);
            this.layoutControl1.Controls.Add(this.textPeriodeDate);
            this.layoutControl1.Controls.Add(this.txtClient);
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.layoutControl4);
            this.layoutControl1.Controls.Add(this.layoutControl41);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(880, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            // 
            // searchControl2
            // 
            resources.ApplyResources(this.searchControl2, "searchControl2");
            this.searchControl2.Client = this.gridControlSettled;
            this.searchControl2.Name = "searchControl2";
            this.searchControl2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl2.Properties.Client = this.gridControlSettled;
            this.searchControl2.Properties.FindDelay = 200;
            this.searchControl2.StyleController = this.layoutControl1;
            // 
            // gridControlSettled
            // 
            resources.ApplyResources(this.gridControlSettled, "gridControlSettled");
            this.gridControlSettled.DataSource = this.sqlDataSourceSattled;
            this.gridControlSettled.EmbeddedNavigator.AccessibleDescription = resources.GetString("gridControlSettled.EmbeddedNavigator.AccessibleDescription");
            this.gridControlSettled.EmbeddedNavigator.AccessibleName = resources.GetString("gridControlSettled.EmbeddedNavigator.AccessibleName");
            this.gridControlSettled.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gridControlSettled.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gridControlSettled.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gridControlSettled.EmbeddedNavigator.Anchor")));
            this.gridControlSettled.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridControlSettled.EmbeddedNavigator.BackgroundImage")));
            this.gridControlSettled.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gridControlSettled.EmbeddedNavigator.BackgroundImageLayout")));
            this.gridControlSettled.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gridControlSettled.EmbeddedNavigator.ImeMode")));
            this.gridControlSettled.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gridControlSettled.EmbeddedNavigator.MaximumSize")));
            this.gridControlSettled.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gridControlSettled.EmbeddedNavigator.TextLocation")));
            this.gridControlSettled.EmbeddedNavigator.ToolTip = resources.GetString("gridControlSettled.EmbeddedNavigator.ToolTip");
            this.gridControlSettled.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gridControlSettled.EmbeddedNavigator.ToolTipIconType")));
            this.gridControlSettled.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridControlSettled.EmbeddedNavigator.ToolTipTitle");
            this.gridControlSettled.MainView = this.gridViewSettled;
            this.gridControlSettled.Name = "gridControlSettled";
            this.gridControlSettled.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSettled});
            // 
            // sqlDataSourceSattled
            // 
            this.sqlDataSourceSattled.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceSattled.Name = "sqlDataSourceSattled";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSourceSattled.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSourceSattled.ResultSchemaSerializable = resources.GetString("sqlDataSourceSattled.ResultSchemaSerializable");
            // 
            // gridViewSettled
            // 
            resources.ApplyResources(this.gridViewSettled, "gridViewSettled");
            this.gridViewSettled.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridViewSettled.Appearance.Row.Font")));
            this.gridViewSettled.Appearance.Row.Options.UseFont = true;
            this.gridViewSettled.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbranch_name,
            this.colcreated_at,
            this.colcustomer_name,
            this.colid,
            this.coltable_name,
            this.coltotal_guest,
            this.coluser_name,
            this.colwaiter_name});
            this.gridViewSettled.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewSettled.GridControl = this.gridControlSettled;
            this.gridViewSettled.Name = "gridViewSettled";
            this.gridViewSettled.OptionsBehavior.Editable = false;
            this.gridViewSettled.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewSettled.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewSettled.OptionsView.ShowGroupPanel = false;
            // 
            // colbranch_name
            // 
            resources.ApplyResources(this.colbranch_name, "colbranch_name");
            this.colbranch_name.FieldName = "branch_name";
            this.colbranch_name.Name = "colbranch_name";
            // 
            // colcreated_at
            // 
            resources.ApplyResources(this.colcreated_at, "colcreated_at");
            this.colcreated_at.FieldName = "created_at";
            this.colcreated_at.Name = "colcreated_at";
            // 
            // colcustomer_name
            // 
            resources.ApplyResources(this.colcustomer_name, "colcustomer_name");
            this.colcustomer_name.FieldName = "customer_name";
            this.colcustomer_name.Name = "colcustomer_name";
            // 
            // colid
            // 
            resources.ApplyResources(this.colid, "colid");
            this.colid.AppearanceHeader.Options.UseTextOptions = true;
            this.colid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coltable_name
            // 
            resources.ApplyResources(this.coltable_name, "coltable_name");
            this.coltable_name.FieldName = "table_name";
            this.coltable_name.Name = "coltable_name";
            // 
            // coltotal_guest
            // 
            resources.ApplyResources(this.coltotal_guest, "coltotal_guest");
            this.coltotal_guest.FieldName = "total_guest";
            this.coltotal_guest.Name = "coltotal_guest";
            // 
            // coluser_name
            // 
            resources.ApplyResources(this.coluser_name, "coluser_name");
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.Name = "coluser_name";
            // 
            // colwaiter_name
            // 
            resources.ApplyResources(this.colwaiter_name, "colwaiter_name");
            this.colwaiter_name.FieldName = "waiter_name";
            this.colwaiter_name.Name = "colwaiter_name";
            // 
            // searchControl1
            // 
            resources.ApplyResources(this.searchControl1, "searchControl1");
            this.searchControl1.Client = this.gridControlSubmitted;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControlSubmitted;
            this.searchControl1.Properties.FindDelay = 200;
            this.searchControl1.StyleController = this.layoutControl1;
            // 
            // gridControlSubmitted
            // 
            resources.ApplyResources(this.gridControlSubmitted, "gridControlSubmitted");
            this.gridControlSubmitted.DataSource = this.sqlDataSourceSubmitted;
            this.gridControlSubmitted.EmbeddedNavigator.AccessibleDescription = resources.GetString("gridControlSubmitted.EmbeddedNavigator.AccessibleDescription");
            this.gridControlSubmitted.EmbeddedNavigator.AccessibleName = resources.GetString("gridControlSubmitted.EmbeddedNavigator.AccessibleName");
            this.gridControlSubmitted.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gridControlSubmitted.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gridControlSubmitted.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gridControlSubmitted.EmbeddedNavigator.Anchor")));
            this.gridControlSubmitted.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridControlSubmitted.EmbeddedNavigator.BackgroundImage")));
            this.gridControlSubmitted.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gridControlSubmitted.EmbeddedNavigator.BackgroundImageLayout")));
            this.gridControlSubmitted.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gridControlSubmitted.EmbeddedNavigator.ImeMode")));
            this.gridControlSubmitted.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gridControlSubmitted.EmbeddedNavigator.MaximumSize")));
            this.gridControlSubmitted.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gridControlSubmitted.EmbeddedNavigator.TextLocation")));
            this.gridControlSubmitted.EmbeddedNavigator.ToolTip = resources.GetString("gridControlSubmitted.EmbeddedNavigator.ToolTip");
            this.gridControlSubmitted.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gridControlSubmitted.EmbeddedNavigator.ToolTipIconType")));
            this.gridControlSubmitted.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridControlSubmitted.EmbeddedNavigator.ToolTipTitle");
            this.gridControlSubmitted.MainView = this.gridViewISubmitted;
            this.gridControlSubmitted.Name = "gridControlSubmitted";
            this.gridControlSubmitted.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewISubmitted});
            // 
            // sqlDataSourceSubmitted
            // 
            this.sqlDataSourceSubmitted.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceSubmitted.Name = "sqlDataSourceSubmitted";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSourceSubmitted.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSourceSubmitted.ResultSchemaSerializable = resources.GetString("sqlDataSourceSubmitted.ResultSchemaSerializable");
            // 
            // gridViewISubmitted
            // 
            resources.ApplyResources(this.gridViewISubmitted, "gridViewISubmitted");
            this.gridViewISubmitted.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridViewISubmitted.Appearance.Row.Font")));
            this.gridViewISubmitted.Appearance.Row.Options.UseFont = true;
            this.gridViewISubmitted.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbranch_name1,
            this.colcreated_at1,
            this.colcustomer_name1,
            this.colid1,
            this.coltable_name1,
            this.coltotal_guest1,
            this.coluser_name1,
            this.colwaiter_name1});
            this.gridViewISubmitted.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewISubmitted.GridControl = this.gridControlSubmitted;
            this.gridViewISubmitted.Name = "gridViewISubmitted";
            this.gridViewISubmitted.OptionsBehavior.Editable = false;
            this.gridViewISubmitted.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewISubmitted.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewISubmitted.OptionsView.ShowGroupPanel = false;
            // 
            // colbranch_name1
            // 
            resources.ApplyResources(this.colbranch_name1, "colbranch_name1");
            this.colbranch_name1.FieldName = "branch_name";
            this.colbranch_name1.Name = "colbranch_name1";
            // 
            // colcreated_at1
            // 
            resources.ApplyResources(this.colcreated_at1, "colcreated_at1");
            this.colcreated_at1.FieldName = "created_at";
            this.colcreated_at1.Name = "colcreated_at1";
            // 
            // colcustomer_name1
            // 
            resources.ApplyResources(this.colcustomer_name1, "colcustomer_name1");
            this.colcustomer_name1.FieldName = "customer_name";
            this.colcustomer_name1.Name = "colcustomer_name1";
            // 
            // colid1
            // 
            resources.ApplyResources(this.colid1, "colid1");
            this.colid1.AppearanceHeader.Options.UseTextOptions = true;
            this.colid1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coltable_name1
            // 
            resources.ApplyResources(this.coltable_name1, "coltable_name1");
            this.coltable_name1.FieldName = "table_name";
            this.coltable_name1.Name = "coltable_name1";
            // 
            // coltotal_guest1
            // 
            resources.ApplyResources(this.coltotal_guest1, "coltotal_guest1");
            this.coltotal_guest1.FieldName = "total_guest";
            this.coltotal_guest1.Name = "coltotal_guest1";
            // 
            // coluser_name1
            // 
            resources.ApplyResources(this.coluser_name1, "coluser_name1");
            this.coluser_name1.FieldName = "user_name";
            this.coluser_name1.Name = "coluser_name1";
            // 
            // colwaiter_name1
            // 
            resources.ApplyResources(this.colwaiter_name1, "colwaiter_name1");
            this.colwaiter_name1.FieldName = "waiter_name";
            this.colwaiter_name1.Name = "colwaiter_name1";
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
            this.endDate.EditValueChanged += new System.EventHandler(this.endDate_EditValueChanged);
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
            this.startDate.EditValueChanged += new System.EventHandler(this.startDate_EditValueChanged);
            // 
            // btnPos
            // 
            resources.ApplyResources(this.btnPos, "btnPos");
            this.btnPos.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnPos.Appearance.Font")));
            this.btnPos.Appearance.Options.UseFont = true;
            this.btnPos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPos.ImageOptions.SvgImage")));
            this.btnPos.Name = "btnPos";
            this.btnPos.StyleController = this.layoutControl1;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
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
            this.textPeriodeDate.StyleController = this.layoutControl1;
            this.textPeriodeDate.EditValueChanged += new System.EventHandler(this.textPeriodeDate_EditValueChanged);
            // 
            // txtClient
            // 
            resources.ApplyResources(this.txtClient, "txtClient");
            this.txtClient.Name = "txtClient";
            this.txtClient.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtClient.Properties.Appearance.Font")));
            this.txtClient.Properties.Appearance.Options.UseFont = true;
            this.txtClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtClient.Properties.Buttons"))))});
            this.txtClient.Properties.DataSource = this.ezziresto_customersBindingSource;
            this.txtClient.Properties.DisplayFormat.FormatString = "d";
            this.txtClient.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtClient.Properties.EditFormat.FormatString = "d";
            this.txtClient.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtClient.Properties.NullText = resources.GetString("txtClient.Properties.NullText");
            this.txtClient.Properties.PopupView = this.searchLookUpEdit1View;
            this.txtClient.StyleController = this.layoutControl1;
            this.txtClient.EditValueChanged += new System.EventHandler(this.txtClient_EditValueChanged);
            // 
            // ezziresto_customersBindingSource
            // 
            this.ezziresto_customersBindingSource.DataMember = "ezziresto_customers";
            this.ezziresto_customersBindingSource.DataSource = this.sqlDataSourceClients;
            // 
            // sqlDataSourceClients
            // 
            this.sqlDataSourceClients.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceClients.Name = "sqlDataSourceClients";
            columnExpression1.ColumnName = "id";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"263\" />";
            table1.Name = "ezziresto.customers";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "name";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "phn_no";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "created_at";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Name = "ezziresto_customers";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSourceClients.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSourceClients.ResultSchemaSerializable = resources.GetString("sqlDataSourceClients.ResultSchemaSerializable");
            // 
            // searchLookUpEdit1View
            // 
            resources.ApplyResources(this.searchLookUpEdit1View, "searchLookUpEdit1View");
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // layoutControl4
            // 
            resources.ApplyResources(this.layoutControl4, "layoutControl4");
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.Root = this.layoutControlGroup51;
            // 
            // layoutControlGroup51
            // 
            resources.ApplyResources(this.layoutControlGroup51, "layoutControlGroup51");
            this.layoutControlGroup51.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(142)))), ((int)(((byte)(231)))));
            this.layoutControlGroup51.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup51.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup51.GroupBordersVisible = false;
            this.layoutControlGroup51.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.alertTotalProfitSettledScreen,
            this.totalPriceCurency});
            this.layoutControlGroup51.Name = "layoutControlGroup51";
            this.layoutControlGroup51.Size = new System.Drawing.Size(431, 105);
            this.layoutControlGroup51.TextVisible = false;
            // 
            // alertTotalProfitSettledScreen
            // 
            resources.ApplyResources(this.alertTotalProfitSettledScreen, "alertTotalProfitSettledScreen");
            this.alertTotalProfitSettledScreen.AllowHotTrack = false;
            this.alertTotalProfitSettledScreen.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("alertTotalProfitSettledScreen.AppearanceItemCaption.Font")));
            this.alertTotalProfitSettledScreen.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.alertTotalProfitSettledScreen.AppearanceItemCaption.Options.UseFont = true;
            this.alertTotalProfitSettledScreen.AppearanceItemCaption.Options.UseForeColor = true;
            this.alertTotalProfitSettledScreen.AppearanceItemCaption.Options.UseTextOptions = true;
            this.alertTotalProfitSettledScreen.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.alertTotalProfitSettledScreen.Location = new System.Drawing.Point(0, 0);
            this.alertTotalProfitSettledScreen.MaxSize = new System.Drawing.Size(0, 79);
            this.alertTotalProfitSettledScreen.MinSize = new System.Drawing.Size(154, 79);
            this.alertTotalProfitSettledScreen.Name = "alertTotalProfitSettledScreen";
            this.alertTotalProfitSettledScreen.Size = new System.Drawing.Size(304, 79);
            this.alertTotalProfitSettledScreen.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.alertTotalProfitSettledScreen.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.alertTotalProfitSettledScreen.TextSize = new System.Drawing.Size(140, 55);
            // 
            // totalPriceCurency
            // 
            resources.ApplyResources(this.totalPriceCurency, "totalPriceCurency");
            this.totalPriceCurency.AllowHotTrack = false;
            this.totalPriceCurency.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("totalPriceCurency.AppearanceItemCaption.Font")));
            this.totalPriceCurency.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.totalPriceCurency.AppearanceItemCaption.Options.UseFont = true;
            this.totalPriceCurency.AppearanceItemCaption.Options.UseForeColor = true;
            this.totalPriceCurency.AppearanceItemCaption.Options.UseTextOptions = true;
            this.totalPriceCurency.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totalPriceCurency.AutoSizeMode = DevExpress.XtraLayout.SimpleLabelAutoSizeMode.None;
            this.totalPriceCurency.Location = new System.Drawing.Point(304, 0);
            this.totalPriceCurency.Name = "totalPriceCurency";
            this.totalPriceCurency.Size = new System.Drawing.Size(101, 79);
            this.totalPriceCurency.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.totalPriceCurency.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.totalPriceCurency.TextSize = new System.Drawing.Size(69, 55);
            // 
            // layoutControl41
            // 
            resources.ApplyResources(this.layoutControl41, "layoutControl41");
            this.layoutControl41.Name = "layoutControl41";
            this.layoutControl41.Root = this.layoutControlGroup511;
            // 
            // layoutControlGroup511
            // 
            resources.ApplyResources(this.layoutControlGroup511, "layoutControlGroup511");
            this.layoutControlGroup511.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(142)))), ((int)(((byte)(231)))));
            this.layoutControlGroup511.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup511.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup511.GroupBordersVisible = false;
            this.layoutControlGroup511.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.alertTotalProfitSubmittedScreen,
            this.totalPriceCurency1});
            this.layoutControlGroup511.Name = "layoutControlGroup511";
            this.layoutControlGroup511.Size = new System.Drawing.Size(432, 105);
            this.layoutControlGroup511.TextVisible = false;
            // 
            // alertTotalProfitSubmittedScreen
            // 
            resources.ApplyResources(this.alertTotalProfitSubmittedScreen, "alertTotalProfitSubmittedScreen");
            this.alertTotalProfitSubmittedScreen.AllowHotTrack = false;
            this.alertTotalProfitSubmittedScreen.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("alertTotalProfitSubmittedScreen.AppearanceItemCaption.Font")));
            this.alertTotalProfitSubmittedScreen.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.alertTotalProfitSubmittedScreen.AppearanceItemCaption.Options.UseFont = true;
            this.alertTotalProfitSubmittedScreen.AppearanceItemCaption.Options.UseForeColor = true;
            this.alertTotalProfitSubmittedScreen.AppearanceItemCaption.Options.UseTextOptions = true;
            this.alertTotalProfitSubmittedScreen.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.alertTotalProfitSubmittedScreen.Location = new System.Drawing.Point(0, 0);
            this.alertTotalProfitSubmittedScreen.MaxSize = new System.Drawing.Size(0, 79);
            this.alertTotalProfitSubmittedScreen.MinSize = new System.Drawing.Size(154, 79);
            this.alertTotalProfitSubmittedScreen.Name = "alertTotalProfitSubmittedScreen";
            this.alertTotalProfitSubmittedScreen.Size = new System.Drawing.Size(305, 79);
            this.alertTotalProfitSubmittedScreen.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.alertTotalProfitSubmittedScreen.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.alertTotalProfitSubmittedScreen.TextSize = new System.Drawing.Size(140, 55);
            // 
            // totalPriceCurency1
            // 
            resources.ApplyResources(this.totalPriceCurency1, "totalPriceCurency1");
            this.totalPriceCurency1.AllowHotTrack = false;
            this.totalPriceCurency1.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("totalPriceCurency1.AppearanceItemCaption.Font")));
            this.totalPriceCurency1.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.totalPriceCurency1.AppearanceItemCaption.Options.UseFont = true;
            this.totalPriceCurency1.AppearanceItemCaption.Options.UseForeColor = true;
            this.totalPriceCurency1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.totalPriceCurency1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totalPriceCurency1.AutoSizeMode = DevExpress.XtraLayout.SimpleLabelAutoSizeMode.None;
            this.totalPriceCurency1.Location = new System.Drawing.Point(305, 0);
            this.totalPriceCurency1.Name = "totalPriceCurency1";
            this.totalPriceCurency1.Size = new System.Drawing.Size(101, 79);
            this.totalPriceCurency1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.totalPriceCurency1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.totalPriceCurency1.TextSize = new System.Drawing.Size(69, 55);
            // 
            // Root
            // 
            resources.ApplyResources(this.Root, "Root");
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1,
            this.layoutControlGroup2,
            this.layoutControlGroup4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1419, 844);
            this.Root.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            resources.ApplyResources(this.tabbedControlGroup1, "tabbedControlGroup1");
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 116);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup1;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(1393, 702);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabOrder,
            this.layoutControlGroup1});
            this.tabbedControlGroup1.TextLocation = DevExpress.Utils.Locations.Bottom;
            // 
            // layoutControlGroup1
            // 
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            this.layoutControlGroup1.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup1.AppearanceGroup.Font")));
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.AppearanceTabPage.Header.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup1.AppearanceTabPage.Header.Font")));
            this.layoutControlGroup1.AppearanceTabPage.Header.Options.UseFont = true;
            this.layoutControlGroup1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlGroup1.CaptionImageOptions.SvgImage")));
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1361, 628);
            // 
            // layoutControlGroup5
            // 
            resources.ApplyResources(this.layoutControlGroup5, "layoutControlGroup5");
            this.layoutControlGroup5.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup5.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem12,
            this.layoutControlItem5,
            this.emptySpaceItem4,
            this.layoutControlItem22});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(1361, 628);
            // 
            // layoutControlItem12
            // 
            resources.ApplyResources(this.layoutControlItem12, "layoutControlItem12");
            this.layoutControlItem12.Control = this.gridControlSettled;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(892, 528);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            resources.ApplyResources(this.layoutControlItem5, "layoutControlItem5");
            this.layoutControlItem5.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem5.AppearanceItemCaption.Font")));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.searchControl2;
            this.layoutControlItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem5.ImageOptions.SvgImage")));
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(892, 41);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(75, 35);
            // 
            // emptySpaceItem4
            // 
            resources.ApplyResources(this.emptySpaceItem4, "emptySpaceItem4");
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(892, 111);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(437, 458);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem22
            // 
            resources.ApplyResources(this.layoutControlItem22, "layoutControlItem22");
            this.layoutControlItem22.Control = this.layoutControl4;
            this.layoutControlItem22.Location = new System.Drawing.Point(892, 0);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(437, 111);
            this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem22.TextVisible = false;
            // 
            // tabOrder
            // 
            resources.ApplyResources(this.tabOrder, "tabOrder");
            this.tabOrder.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("tabOrder.AppearanceGroup.Font")));
            this.tabOrder.AppearanceGroup.Options.UseFont = true;
            this.tabOrder.AppearanceTabPage.Header.Font = ((System.Drawing.Font)(resources.GetObject("tabOrder.AppearanceTabPage.Header.Font")));
            this.tabOrder.AppearanceTabPage.Header.Options.UseFont = true;
            this.tabOrder.AppearanceTabPage.HeaderActive.Font = ((System.Drawing.Font)(resources.GetObject("tabOrder.AppearanceTabPage.HeaderActive.Font")));
            this.tabOrder.AppearanceTabPage.HeaderActive.Options.UseFont = true;
            this.tabOrder.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabOrder.CaptionImageOptions.Image")));
            this.tabOrder.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.tabOrder.Location = new System.Drawing.Point(0, 0);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Size = new System.Drawing.Size(1361, 628);
            this.tabOrder.TextLocation = DevExpress.Utils.Locations.Bottom;
            // 
            // layoutControlGroup3
            // 
            resources.ApplyResources(this.layoutControlGroup3, "layoutControlGroup3");
            this.layoutControlGroup3.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup3.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem3,
            this.layoutControlItem9});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1361, 628);
            // 
            // layoutControlItem3
            // 
            resources.ApplyResources(this.layoutControlItem3, "layoutControlItem3");
            this.layoutControlItem3.Control = this.gridControlSubmitted;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(891, 528);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem4.AppearanceItemCaption.Font")));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.searchControl1;
            this.layoutControlItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem4.ImageOptions.SvgImage")));
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(891, 41);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 35);
            // 
            // emptySpaceItem3
            // 
            resources.ApplyResources(this.emptySpaceItem3, "emptySpaceItem3");
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(891, 111);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(438, 458);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            resources.ApplyResources(this.layoutControlItem9, "layoutControlItem9");
            this.layoutControlItem9.Control = this.layoutControl41;
            this.layoutControlItem9.Location = new System.Drawing.Point(891, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(438, 111);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            resources.ApplyResources(this.layoutControlGroup2, "layoutControlGroup2");
            this.layoutControlGroup2.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup2.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup2.AppearanceGroup.Font")));
            this.layoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.layoutControlGroup2.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.AppearanceGroup.Options.UseForeColor = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(980, 116);
            // 
            // layoutControlItem1
            // 
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem1.AppearanceItemCaption.Font")));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.textPeriodeDate;
            this.layoutControlItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem1.ImageOptions.SvgImage")));
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(251, 47);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(68, 35);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            resources.ApplyResources(this.layoutControlItem6, "layoutControlItem6");
            this.layoutControlItem6.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem6.AppearanceItemCaption.Font")));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.startDate;
            this.layoutControlItem6.Location = new System.Drawing.Point(251, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(291, 47);
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(30, 16);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // emptySpaceItem2
            // 
            resources.ApplyResources(this.emptySpaceItem2, "emptySpaceItem2");
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 47);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(948, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem2.AppearanceItemCaption.Font")));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.endDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(542, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(298, 40);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(298, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(298, 47);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(30, 16);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem8
            // 
            resources.ApplyResources(this.layoutControlItem8, "layoutControlItem8");
            this.layoutControlItem8.Control = this.btnRefresh;
            this.layoutControlItem8.Location = new System.Drawing.Point(840, 0);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(49, 47);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(108, 47);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            resources.ApplyResources(this.layoutControlGroup4, "layoutControlGroup4");
            this.layoutControlGroup4.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup4.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup4.AppearanceGroup.Font")));
            this.layoutControlGroup4.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup4.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem11,
            this.emptySpaceItem1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(980, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(413, 116);
            // 
            // layoutControlItem7
            // 
            resources.ApplyResources(this.layoutControlItem7, "layoutControlItem7");
            this.layoutControlItem7.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem7.AppearanceItemCaption.Font")));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.txtClient;
            this.layoutControlItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem7.ImageOptions.SvgImage")));
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(256, 47);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(75, 35);
            // 
            // layoutControlItem11
            // 
            resources.ApplyResources(this.layoutControlItem11, "layoutControlItem11");
            this.layoutControlItem11.Control = this.btnPos;
            this.layoutControlItem11.Location = new System.Drawing.Point(256, 0);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(76, 47);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(125, 47);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            resources.ApplyResources(this.emptySpaceItem1, "emptySpaceItem1");
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 47);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(381, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Form_Order_Histories
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.Name = "Form_Order_Histories";
            this.Load += new System.EventHandler(this.Form_Order_Histories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSettled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSettled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubmitted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewISubmitted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPeriodeDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertTotalProfitSettledScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceCurency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup511)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertTotalProfitSubmittedScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceCurency1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SearchControl searchControl2;
        private DevExpress.XtraGrid.GridControl gridControlSettled;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSettled;
        private DevExpress.XtraGrid.Columns.GridColumn colbranch_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_at;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_name;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coltable_name;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_guest;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private DevExpress.XtraGrid.Columns.GridColumn colwaiter_name;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.GridControl gridControlSubmitted;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewISubmitted;
        private DevExpress.XtraGrid.Columns.GridColumn colbranch_name1;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_at1;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_name1;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coltable_name1;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_guest1;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name1;
        private DevExpress.XtraGrid.Columns.GridColumn colwaiter_name1;
        private DevExpress.XtraEditors.DateEdit endDate;
        private DevExpress.XtraEditors.DateEdit startDate;
        private DevExpress.XtraEditors.SimpleButton btnPos;
        private DevExpress.XtraEditors.ComboBoxEdit textPeriodeDate;
        private DevExpress.XtraEditors.SearchLookUpEdit txtClient;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup tabOrder;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource ezziresto_customersBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceClients;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceSattled;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceSubmitted;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup51;
        private DevExpress.XtraLayout.SimpleLabelItem alertTotalProfitSettledScreen;
        private DevExpress.XtraLayout.SimpleLabelItem totalPriceCurency;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.LayoutControl layoutControl41;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup511;
        private DevExpress.XtraLayout.SimpleLabelItem alertTotalProfitSubmittedScreen;
        private DevExpress.XtraLayout.SimpleLabelItem totalPriceCurency1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}