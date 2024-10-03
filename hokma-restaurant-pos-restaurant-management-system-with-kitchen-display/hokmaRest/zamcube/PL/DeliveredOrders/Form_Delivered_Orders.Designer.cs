
namespace ezziresto.PL.DeliveredOrders
{
    partial class Form_Delivered_Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Delivered_Orders));
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.gridControlOrders = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSourceOrders = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcreated_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcustomer_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltable_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.endDate = new DevExpress.XtraEditors.DateEdit();
            this.startDate = new DevExpress.XtraEditors.DateEdit();
            this.btnPos = new DevExpress.XtraEditors.SimpleButton();
            this.textPeriodeDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtClient = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ezziresto_customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceCustomer = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPeriodeDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Controls.Add(this.searchControl1);
            this.layoutControl1.Controls.Add(this.gridControlOrders);
            this.layoutControl1.Controls.Add(this.endDate);
            this.layoutControl1.Controls.Add(this.startDate);
            this.layoutControl1.Controls.Add(this.btnPos);
            this.layoutControl1.Controls.Add(this.textPeriodeDate);
            this.layoutControl1.Controls.Add(this.txtClient);
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(880, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            // 
            // searchControl1
            // 
            resources.ApplyResources(this.searchControl1, "searchControl1");
            this.searchControl1.Client = this.gridControlOrders;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControlOrders;
            this.searchControl1.Properties.FindDelay = 200;
            this.searchControl1.StyleController = this.layoutControl1;
            // 
            // gridControlOrders
            // 
            resources.ApplyResources(this.gridControlOrders, "gridControlOrders");
            this.gridControlOrders.DataSource = this.sqlDataSourceOrders;
            this.gridControlOrders.EmbeddedNavigator.AccessibleDescription = resources.GetString("gridControlOrders.EmbeddedNavigator.AccessibleDescription");
            this.gridControlOrders.EmbeddedNavigator.AccessibleName = resources.GetString("gridControlOrders.EmbeddedNavigator.AccessibleName");
            this.gridControlOrders.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gridControlOrders.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gridControlOrders.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gridControlOrders.EmbeddedNavigator.Anchor")));
            this.gridControlOrders.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridControlOrders.EmbeddedNavigator.BackgroundImage")));
            this.gridControlOrders.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gridControlOrders.EmbeddedNavigator.BackgroundImageLayout")));
            this.gridControlOrders.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gridControlOrders.EmbeddedNavigator.ImeMode")));
            this.gridControlOrders.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gridControlOrders.EmbeddedNavigator.MaximumSize")));
            this.gridControlOrders.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gridControlOrders.EmbeddedNavigator.TextLocation")));
            this.gridControlOrders.EmbeddedNavigator.ToolTip = resources.GetString("gridControlOrders.EmbeddedNavigator.ToolTip");
            this.gridControlOrders.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gridControlOrders.EmbeddedNavigator.ToolTipIconType")));
            this.gridControlOrders.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridControlOrders.EmbeddedNavigator.ToolTipTitle");
            this.gridControlOrders.MainView = this.gridViewOrders;
            this.gridControlOrders.Name = "gridControlOrders";
            this.gridControlOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrders});
            // 
            // sqlDataSourceOrders
            // 
            this.sqlDataSourceOrders.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceOrders.Name = "sqlDataSourceOrders";
            columnExpression1.ColumnName = "id";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"843\" />";
            table1.Name = "ezziresto.order_groups";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "user_name";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "customer_name";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "table_name";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "is_delivered";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "created_at";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.FilterString = "[ezziresto.order_groups.is_delivered] = 1s";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "ezziresto_order_groups";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSourceOrders.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSourceOrders.ResultSchemaSerializable = resources.GetString("sqlDataSourceOrders.ResultSchemaSerializable");
            // 
            // gridViewOrders
            // 
            resources.ApplyResources(this.gridViewOrders, "gridViewOrders");
            this.gridViewOrders.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridViewOrders.Appearance.Row.Font")));
            this.gridViewOrders.Appearance.Row.Options.UseFont = true;
            this.gridViewOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcreated_at,
            this.colcustomer_name,
            this.colid,
            this.coltable_name,
            this.coluser_name});
            this.gridViewOrders.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewOrders.GridControl = this.gridControlOrders;
            this.gridViewOrders.Name = "gridViewOrders";
            this.gridViewOrders.OptionsBehavior.Editable = false;
            this.gridViewOrders.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewOrders.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewOrders.OptionsView.ShowGroupPanel = false;
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
            // coluser_name
            // 
            resources.ApplyResources(this.coluser_name, "coluser_name");
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.Name = "coluser_name";
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
            // 
            // btnPos
            // 
            resources.ApplyResources(this.btnPos, "btnPos");
            this.btnPos.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnPos.Appearance.Font")));
            this.btnPos.Appearance.Options.UseFont = true;
            this.btnPos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPos.ImageOptions.SvgImage")));
            this.btnPos.Name = "btnPos";
            this.btnPos.StyleController = this.layoutControl1;
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
            // 
            // ezziresto_customersBindingSource
            // 
            this.ezziresto_customersBindingSource.DataMember = "ezziresto_customers";
            this.ezziresto_customersBindingSource.DataSource = this.sqlDataSourceCustomer;
            // 
            // sqlDataSourceCustomer
            // 
            this.sqlDataSourceCustomer.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceCustomer.Name = "sqlDataSourceCustomer";
            columnExpression7.ColumnName = "id";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"263\" />";
            table2.Name = "ezziresto.customers";
            columnExpression7.Table = table2;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "name";
            columnExpression8.Table = table2;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "phn_no";
            columnExpression9.Table = table2;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "created_at";
            columnExpression10.Table = table2;
            column10.Expression = columnExpression10;
            selectQuery2.Columns.Add(column7);
            selectQuery2.Columns.Add(column8);
            selectQuery2.Columns.Add(column9);
            selectQuery2.Columns.Add(column10);
            selectQuery2.Name = "ezziresto_customers";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSourceCustomer.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSourceCustomer.ResultSchemaSerializable = resources.GetString("sqlDataSourceCustomer.ResultSchemaSerializable");
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
            // Root
            // 
            resources.ApplyResources(this.Root, "Root");
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup1,
            this.layoutControlGroup3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1419, 844);
            this.Root.TextVisible = false;
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
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(962, 116);
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
            this.layoutControlItem1.Size = new System.Drawing.Size(266, 47);
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
            this.layoutControlItem6.Location = new System.Drawing.Point(266, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(317, 47);
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
            this.emptySpaceItem2.Size = new System.Drawing.Size(930, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem2.AppearanceItemCaption.Font")));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.endDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(583, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(298, 40);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(298, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(298, 47);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(30, 16);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.Control = this.btnRefresh;
            this.layoutControlItem4.Location = new System.Drawing.Point(881, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(49, 47);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            this.layoutControlGroup1.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup1.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup1.AppearanceGroup.Font")));
            this.layoutControlGroup1.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem12,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 116);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1393, 702);
            // 
            // layoutControlItem12
            // 
            resources.ApplyResources(this.layoutControlItem12, "layoutControlItem12");
            this.layoutControlItem12.Control = this.gridControlOrders;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(1361, 590);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            resources.ApplyResources(this.layoutControlItem3, "layoutControlItem3");
            this.layoutControlItem3.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem3.AppearanceItemCaption.Font")));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.searchControl1;
            this.layoutControlItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem3.ImageOptions.SvgImage")));
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1361, 41);
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 35);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // emptySpaceItem1
            // 
            resources.ApplyResources(this.emptySpaceItem1, "emptySpaceItem1");
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 41);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1361, 12);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            resources.ApplyResources(this.layoutControlGroup3, "layoutControlGroup3");
            this.layoutControlGroup3.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup3.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup3.AppearanceGroup.Font")));
            this.layoutControlGroup3.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem11,
            this.emptySpaceItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(962, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(431, 116);
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
            this.layoutControlItem7.Size = new System.Drawing.Size(278, 47);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(75, 35);
            // 
            // layoutControlItem11
            // 
            resources.ApplyResources(this.layoutControlItem11, "layoutControlItem11");
            this.layoutControlItem11.Control = this.btnPos;
            this.layoutControlItem11.Location = new System.Drawing.Point(278, 0);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(76, 47);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(121, 47);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            resources.ApplyResources(this.emptySpaceItem3, "emptySpaceItem3");
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 47);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(399, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Form_Delivered_Orders
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.Name = "Form_Delivered_Orders";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPeriodeDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControlOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrders;
        private DevExpress.XtraEditors.DateEdit endDate;
        private DevExpress.XtraEditors.DateEdit startDate;
        private DevExpress.XtraEditors.SimpleButton btnPos;
        private DevExpress.XtraEditors.ComboBoxEdit textPeriodeDate;
        private DevExpress.XtraEditors.SearchLookUpEdit txtClient;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private System.Windows.Forms.BindingSource ezziresto_customersBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceCustomer;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceOrders;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_at;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_name;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coltable_name;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}