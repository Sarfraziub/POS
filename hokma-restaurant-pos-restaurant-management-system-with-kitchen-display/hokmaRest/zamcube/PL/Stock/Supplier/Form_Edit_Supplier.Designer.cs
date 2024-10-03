
namespace ezziresto.PL.Stock.Supplier
{
    partial class Form_Edit_Supplier
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Edit_Supplier));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.sqlDataSourceSupplier = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.gridControlSupplier = new DevExpress.XtraGrid.GridControl();
            this.gridViewSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSourceSupplier
            // 
            this.sqlDataSourceSupplier.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceSupplier.Name = "sqlDataSourceSupplier";
            columnExpression1.ColumnName = "id";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"243\" />";
            table1.Name = "ezziresto.suppliers";
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
            selectQuery1.Name = "ezziresto_suppliers";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSourceSupplier.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSourceSupplier.ResultSchemaSerializable = resources.GetString("sqlDataSourceSupplier.ResultSchemaSerializable");
            // 
            // layoutControl1
            // 
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            // 
            // layoutControl2
            // 
            resources.ApplyResources(this.layoutControl2, "layoutControl2");
            this.layoutControl2.Controls.Add(this.txtPhone);
            this.layoutControl2.Controls.Add(this.txtEmail);
            this.layoutControl2.Controls.Add(this.gridControlSupplier);
            this.layoutControl2.Controls.Add(this.searchControl1);
            this.layoutControl2.Controls.Add(this.txtName);
            this.layoutControl2.Controls.Add(this.btnAdd);
            this.layoutControl2.Controls.Add(this.txtAddress);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtPhone.Properties.Appearance.Font")));
            this.txtPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.Appearance.Options.UseForeColor = true;
            this.txtPhone.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPhone.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPhone.Properties.AutoHeight = ((bool)(resources.GetObject("txtPhone.Properties.AutoHeight")));
            this.txtPhone.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPhone.StyleController = this.layoutControl2;
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtEmail.Properties.Appearance.Font")));
            this.txtEmail.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.Appearance.Options.UseForeColor = true;
            this.txtEmail.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEmail.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtEmail.Properties.AutoHeight = ((bool)(resources.GetObject("txtEmail.Properties.AutoHeight")));
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.StyleController = this.layoutControl2;
            // 
            // gridControlSupplier
            // 
            resources.ApplyResources(this.gridControlSupplier, "gridControlSupplier");
            this.gridControlSupplier.DataSource = this.sqlDataSourceSupplier;
            this.gridControlSupplier.EmbeddedNavigator.AccessibleDescription = resources.GetString("gridControlSupplier.EmbeddedNavigator.AccessibleDescription");
            this.gridControlSupplier.EmbeddedNavigator.AccessibleName = resources.GetString("gridControlSupplier.EmbeddedNavigator.AccessibleName");
            this.gridControlSupplier.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gridControlSupplier.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gridControlSupplier.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gridControlSupplier.EmbeddedNavigator.Anchor")));
            this.gridControlSupplier.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridControlSupplier.EmbeddedNavigator.BackgroundImage")));
            this.gridControlSupplier.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gridControlSupplier.EmbeddedNavigator.BackgroundImageLayout")));
            this.gridControlSupplier.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gridControlSupplier.EmbeddedNavigator.ImeMode")));
            this.gridControlSupplier.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gridControlSupplier.EmbeddedNavigator.MaximumSize")));
            this.gridControlSupplier.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gridControlSupplier.EmbeddedNavigator.TextLocation")));
            this.gridControlSupplier.EmbeddedNavigator.ToolTip = resources.GetString("gridControlSupplier.EmbeddedNavigator.ToolTip");
            this.gridControlSupplier.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gridControlSupplier.EmbeddedNavigator.ToolTipIconType")));
            this.gridControlSupplier.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridControlSupplier.EmbeddedNavigator.ToolTipTitle");
            this.gridControlSupplier.MainView = this.gridViewSupplier;
            this.gridControlSupplier.Name = "gridControlSupplier";
            this.gridControlSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSupplier});
            // 
            // gridViewSupplier
            // 
            resources.ApplyResources(this.gridViewSupplier, "gridViewSupplier");
            this.gridViewSupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.colid,
            this.colcreated_at});
            this.gridViewSupplier.GridControl = this.gridControlSupplier;
            this.gridViewSupplier.Name = "gridViewSupplier";
            this.gridViewSupplier.OptionsView.ShowGroupPanel = false;
            // 
            // colname
            // 
            resources.ApplyResources(this.colname, "colname");
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            // 
            // colid
            // 
            resources.ApplyResources(this.colid, "colid");
            this.colid.AppearanceCell.Options.UseTextOptions = true;
            this.colid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcreated_at
            // 
            resources.ApplyResources(this.colcreated_at, "colcreated_at");
            this.colcreated_at.FieldName = "created_at";
            this.colcreated_at.Name = "colcreated_at";
            // 
            // searchControl1
            // 
            resources.ApplyResources(this.searchControl1, "searchControl1");
            this.searchControl1.Client = this.gridControlSupplier;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("searchControl1.Properties.Appearance.Font")));
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControlSupplier;
            this.searchControl1.Properties.FindDelay = 200;
            this.searchControl1.StyleController = this.layoutControl2;
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtName.Properties.Appearance.Font")));
            this.txtName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.Appearance.Options.UseForeColor = true;
            this.txtName.Properties.Appearance.Options.UseTextOptions = true;
            this.txtName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtName.Properties.AutoHeight = ((bool)(resources.GetObject("txtName.Properties.AutoHeight")));
            this.txtName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.StyleController = this.layoutControl2;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtName, conditionValidationRule1);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnAdd.Appearance.Font")));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.StyleController = this.layoutControl2;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtAddress.Properties.Appearance.Font")));
            this.txtAddress.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Properties.Appearance.Options.UseForeColor = true;
            this.txtAddress.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAddress.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtAddress.Properties.AutoHeight = ((bool)(resources.GetObject("txtAddress.Properties.AutoHeight")));
            this.txtAddress.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress.StyleController = this.layoutControl2;
            // 
            // layoutControlGroup1
            // 
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(493, 544);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            resources.ApplyResources(this.layoutControlGroup2, "layoutControlGroup2");
            this.layoutControlGroup2.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup2.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup2.AppearanceGroup.Font")));
            this.layoutControlGroup2.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlGroup2.CaptionImageOptions.SvgImage")));
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 257);
            this.layoutControlGroup2.Name = "layoutControlGroup1";
            this.layoutControlGroup2.Size = new System.Drawing.Size(467, 261);
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
            this.layoutControlItem4.Size = new System.Drawing.Size(435, 41);
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(67, 35);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            resources.ApplyResources(this.layoutControlItem6, "layoutControlItem6");
            this.layoutControlItem6.Control = this.gridControlSupplier;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(435, 147);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            resources.ApplyResources(this.layoutControlGroup3, "layoutControlGroup3");
            this.layoutControlGroup3.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup3.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup3.AppearanceGroup.Font")));
            this.layoutControlGroup3.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem8,
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(467, 257);
            // 
            // layoutControlItem1
            // 
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem1.AppearanceItemCaption.Font")));
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(435, 36);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(80, 16);
            // 
            // layoutControlItem3
            // 
            resources.ApplyResources(this.layoutControlItem3, "layoutControlItem3");
            this.layoutControlItem3.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem3.AppearanceItemCaption.Font")));
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtEmail;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(435, 36);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(80, 16);
            // 
            // layoutControlItem8
            // 
            resources.ApplyResources(this.layoutControlItem8, "layoutControlItem8");
            this.layoutControlItem8.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem8.AppearanceItemCaption.Font")));
            this.layoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem8.Control = this.txtPhone;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(435, 36);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(80, 16);
            // 
            // layoutControlItem7
            // 
            resources.ApplyResources(this.layoutControlItem7, "layoutControlItem7");
            this.layoutControlItem7.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem7.AppearanceItemCaption.Font")));
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.txtAddress;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(435, 36);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(80, 16);
            // 
            // layoutControlItem2
            // 
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.Control = this.btnAdd;
            this.layoutControlItem2.Location = new System.Drawing.Point(265, 144);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(92, 47);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(170, 54);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            resources.ApplyResources(this.emptySpaceItem1, "emptySpaceItem1");
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 144);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(265, 54);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Root
            // 
            resources.ApplyResources(this.Root, "Root");
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(525, 576);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            resources.ApplyResources(this.layoutControlItem5, "layoutControlItem5");
            this.layoutControlItem5.Control = this.layoutControl2;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(499, 550);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // Form_Edit_Supplier
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.Name = "Form_Edit_Supplier";
            this.Load += new System.EventHandler(this.Form_Edit_Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceSupplier;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraGrid.GridControl gridControlSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_at;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    }
}