
namespace ezziresto.PL.Order
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabOrder = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(880, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            // 
            // searchControl2
            // 
            this.searchControl2.Client = this.gridControlSettled;
            resources.ApplyResources(this.searchControl2, "searchControl2");
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
            this.colid.AppearanceHeader.Options.UseTextOptions = true;
            this.colid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colid, "colid");
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
            this.searchControl1.Client = this.gridControlSubmitted;
            resources.ApplyResources(this.searchControl1, "searchControl1");
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
            this.colid1.AppearanceHeader.Options.UseTextOptions = true;
            this.colid1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colid1, "colid1");
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
            this.btnPos.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnPos.Appearance.Font")));
            this.btnPos.Appearance.Options.UseFont = true;
            this.btnPos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPos.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnPos, "btnPos");
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
            this.textPeriodeDate.Properties.Items.AddRange(new object[] {
            resources.GetString("textPeriodeDate.Properties.Items"),
            resources.GetString("textPeriodeDate.Properties.Items1"),
            resources.GetString("textPeriodeDate.Properties.Items2"),
            resources.GetString("textPeriodeDate.Properties.Items3"),
            resources.GetString("textPeriodeDate.Properties.Items4"),
            resources.GetString("textPeriodeDate.Properties.Items5"),
            resources.GetString("textPeriodeDate.Properties.Items6")});
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
            this.txtClient.Properties.DisplayMember = "name";
            this.txtClient.Properties.EditFormat.FormatString = "d";
            this.txtClient.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtClient.Properties.NullText = resources.GetString("txtClient.Properties.NullText");
            this.txtClient.Properties.PopupView = this.searchLookUpEdit1View;
            this.txtClient.Properties.ValueMember = "id";
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
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Root
            // 
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
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup5.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem12,
            this.layoutControlItem5});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(1361, 628);
            resources.ApplyResources(this.layoutControlGroup5, "layoutControlGroup5");
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.gridControlSettled;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(1329, 528);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem5.AppearanceItemCaption.Font")));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.searchControl2;
            this.layoutControlItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem5.ImageOptions.SvgImage")));
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1329, 41);
            resources.ApplyResources(this.layoutControlItem5, "layoutControlItem5");
            this.layoutControlItem5.TextSize = new System.Drawing.Size(83, 35);
            // 
            // tabOrder
            // 
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
            resources.ApplyResources(this.tabOrder, "tabOrder");
            this.tabOrder.TextLocation = DevExpress.Utils.Locations.Bottom;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup3.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1361, 628);
            resources.ApplyResources(this.layoutControlGroup3, "layoutControlGroup3");
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControlSubmitted;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1329, 528);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem4.AppearanceItemCaption.Font")));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.searchControl1;
            this.layoutControlItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem4.ImageOptions.SvgImage")));
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1329, 41);
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.TextSize = new System.Drawing.Size(83, 35);
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
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(959, 116);
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
            this.layoutControlItem1.Size = new System.Drawing.Size(285, 47);
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
            this.layoutControlItem6.Location = new System.Drawing.Point(285, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(280, 47);
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(30, 16);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 47);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(927, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem2.AppearanceItemCaption.Font")));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.endDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(565, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(298, 40);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(298, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(298, 47);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(30, 16);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnRefresh;
            this.layoutControlItem8.Location = new System.Drawing.Point(863, 0);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(49, 47);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(64, 47);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup4.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup4.AppearanceGroup.Font")));
            this.layoutControlGroup4.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup4.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem11,
            this.emptySpaceItem1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(959, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(434, 116);
            resources.ApplyResources(this.layoutControlGroup4, "layoutControlGroup4");
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem7.AppearanceItemCaption.Font")));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.txtClient;
            resources.ApplyResources(this.layoutControlItem7, "layoutControlItem7");
            this.layoutControlItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem7.ImageOptions.SvgImage")));
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(274, 47);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(83, 35);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnPos;
            this.layoutControlItem11.Location = new System.Drawing.Point(274, 0);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(76, 47);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(128, 47);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 47);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(402, 10);
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
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
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
    }
}