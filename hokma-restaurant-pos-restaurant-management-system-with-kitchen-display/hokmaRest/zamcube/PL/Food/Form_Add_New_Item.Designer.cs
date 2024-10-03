
namespace ezziresto.PL.Food
{
    partial class Form_Add_New_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_New_Item));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.pictureFoodItem = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.isSpecial = new DevExpress.XtraEditors.CheckEdit();
            this.gridControlAddedVariants = new DevExpress.XtraGrid.GridControl();
            this.gridViewAddedVariants = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tokenVariante = new DevExpress.XtraEditors.TokenEdit();
            this.ezziresto_variationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceVariante = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.tokenProperty = new DevExpress.XtraEditors.TokenEdit();
            this.ezziresto_property_groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceProperty = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnAddExit = new DevExpress.XtraEditors.SimpleButton();
            this.hasVariants = new DevExpress.XtraEditors.CheckEdit();
            this.hasProperties = new DevExpress.XtraEditors.CheckEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.GroupItem = new DevExpress.XtraEditors.LookUpEdit();
            this.ezziresto_food_groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceGroup = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtBarCode = new DevExpress.XtraEditors.TextEdit();
            this.dxValidationProvider11 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoodItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isSpecial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAddedVariants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAddedVariants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenVariante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_variationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenProperty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_property_groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasVariants.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasProperties.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_food_groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureFoodItem
            // 
            resources.ApplyResources(this.pictureFoodItem, "pictureFoodItem");
            this.pictureFoodItem.Name = "pictureFoodItem";
            this.pictureFoodItem.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureFoodItem.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureFoodItem.StyleController = this.layoutControl1;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.pictureFoodItem, conditionValidationRule5);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.isSpecial);
            this.layoutControl1.Controls.Add(this.gridControlAddedVariants);
            this.layoutControl1.Controls.Add(this.tokenVariante);
            this.layoutControl1.Controls.Add(this.tokenProperty);
            this.layoutControl1.Controls.Add(this.btnAddExit);
            this.layoutControl1.Controls.Add(this.pictureFoodItem);
            this.layoutControl1.Controls.Add(this.hasVariants);
            this.layoutControl1.Controls.Add(this.hasProperties);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.txtPrice);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.GroupItem);
            this.layoutControl1.Controls.Add(this.txtBarCode);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            // 
            // isSpecial
            // 
            resources.ApplyResources(this.isSpecial, "isSpecial");
            this.isSpecial.Name = "isSpecial";
            this.isSpecial.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("isSpecial.Properties.Appearance.Font")));
            this.isSpecial.Properties.Appearance.Options.UseFont = true;
            this.isSpecial.Properties.Caption = resources.GetString("isSpecial.Properties.Caption");
            this.isSpecial.StyleController = this.layoutControl1;
            this.isSpecial.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // gridControlAddedVariants
            // 
            resources.ApplyResources(this.gridControlAddedVariants, "gridControlAddedVariants");
            this.gridControlAddedVariants.MainView = this.gridViewAddedVariants;
            this.gridControlAddedVariants.Name = "gridControlAddedVariants";
            this.gridControlAddedVariants.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAddedVariants});
            // 
            // gridViewAddedVariants
            // 
            this.gridViewAddedVariants.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridViewAddedVariants.GridControl = this.gridControlAddedVariants;
            this.gridViewAddedVariants.Name = "gridViewAddedVariants";
            this.gridViewAddedVariants.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            // 
            // gridColumn2
            // 
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.FieldName = "price";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.gridColumn3, "gridColumn3");
            this.gridColumn3.FieldName = "id";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            // 
            // tokenVariante
            // 
            resources.ApplyResources(this.tokenVariante, "tokenVariante");
            this.tokenVariante.Name = "tokenVariante";
            this.tokenVariante.Properties.DataSource = this.ezziresto_variationsBindingSource;
            this.tokenVariante.Properties.DisplayMember = "name";
            this.tokenVariante.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenVariante.Properties.ValueMember = "id";
            this.tokenVariante.Properties.TokenAdded += new DevExpress.XtraEditors.TokenEditTokenAddedEventHandler(this.tokenVariante_Properties_TokenAdded);
            this.tokenVariante.Properties.TokenRemoved += new DevExpress.XtraEditors.TokenEditTokenRemovedEventHandler(this.tokenVariante_Properties_TokenRemoved);
            this.tokenVariante.Properties.TokenClick += new DevExpress.XtraEditors.TokenEditTokenClickEventHandler(this.tokenEdit2_Properties_TokenClick);
            this.tokenVariante.StyleController = this.layoutControl1;
            this.tokenVariante.EditValueChanged += new System.EventHandler(this.tokenVariante_EditValueChanged);
            this.tokenVariante.Click += new System.EventHandler(this.tokenVariante_Click);
            this.tokenVariante.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tokenVariante_MouseClick);
            // 
            // ezziresto_variationsBindingSource
            // 
            this.ezziresto_variationsBindingSource.DataMember = "ezziresto_variations";
            this.ezziresto_variationsBindingSource.DataSource = this.sqlDataSourceVariante;
            // 
            // sqlDataSourceVariante
            // 
            this.sqlDataSourceVariante.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceVariante.Name = "sqlDataSourceVariante";
            columnExpression1.ColumnName = "id";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"163\" />";
            table1.Name = "ezziresto.variations";
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
            selectQuery1.Name = "ezziresto_variations";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSourceVariante.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSourceVariante.ResultSchemaSerializable = resources.GetString("sqlDataSourceVariante.ResultSchemaSerializable");
            // 
            // tokenProperty
            // 
            resources.ApplyResources(this.tokenProperty, "tokenProperty");
            this.tokenProperty.Name = "tokenProperty";
            this.tokenProperty.Properties.DataSource = this.ezziresto_property_groupsBindingSource;
            this.tokenProperty.Properties.DisplayMember = "name";
            this.tokenProperty.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenProperty.Properties.ValueMember = "id";
            this.tokenProperty.StyleController = this.layoutControl1;
            this.tokenProperty.SelectedItemsChanged += new System.ComponentModel.ListChangedEventHandler(this.tokenProperty_SelectedItemsChanged);
            this.tokenProperty.TokenCheckStateChanged += new System.EventHandler(this.tokenProperty_TokenCheckStateChanged);
            this.tokenProperty.EditValueChanged += new System.EventHandler(this.tokenProperty_EditValueChanged);
            this.tokenProperty.Click += new System.EventHandler(this.tokenProperty_Click);
            // 
            // ezziresto_property_groupsBindingSource
            // 
            this.ezziresto_property_groupsBindingSource.DataMember = "ezziresto_property_groups";
            this.ezziresto_property_groupsBindingSource.DataSource = this.sqlDataSourceProperty;
            // 
            // sqlDataSourceProperty
            // 
            this.sqlDataSourceProperty.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceProperty.Name = "sqlDataSourceProperty";
            columnExpression4.ColumnName = "id";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"163\" />";
            table2.Name = "ezziresto.property_groups";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "name";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "created_at";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            selectQuery2.Columns.Add(column4);
            selectQuery2.Columns.Add(column5);
            selectQuery2.Columns.Add(column6);
            selectQuery2.Name = "ezziresto_property_groups";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSourceProperty.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSourceProperty.ResultSchemaSerializable = resources.GetString("sqlDataSourceProperty.ResultSchemaSerializable");
            // 
            // btnAddExit
            // 
            this.btnAddExit.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnAddExit.Appearance.Font")));
            this.btnAddExit.Appearance.Options.UseFont = true;
            this.btnAddExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddExit.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnAddExit, "btnAddExit");
            this.btnAddExit.Name = "btnAddExit";
            this.btnAddExit.StyleController = this.layoutControl1;
            // 
            // hasVariants
            // 
            resources.ApplyResources(this.hasVariants, "hasVariants");
            this.hasVariants.Name = "hasVariants";
            this.hasVariants.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("hasVariants.Properties.Appearance.Font")));
            this.hasVariants.Properties.Appearance.Options.UseFont = true;
            this.hasVariants.Properties.Caption = resources.GetString("hasVariants.Properties.Caption");
            this.hasVariants.StyleController = this.layoutControl1;
            this.hasVariants.CheckedChanged += new System.EventHandler(this.checkEditVariant_CheckedChanged);
            // 
            // hasProperties
            // 
            resources.ApplyResources(this.hasProperties, "hasProperties");
            this.hasProperties.Name = "hasProperties";
            this.hasProperties.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("hasProperties.Properties.Appearance.Font")));
            this.hasProperties.Properties.Appearance.Options.UseFont = true;
            this.hasProperties.Properties.Caption = resources.GetString("hasProperties.Properties.Caption");
            this.hasProperties.StyleController = this.layoutControl1;
            this.hasProperties.CheckedChanged += new System.EventHandler(this.checkEditProp_CheckedChanged_1);
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtName.Properties.Appearance.Font")));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.NullValuePrompt = resources.GetString("txtName.Properties.NullValuePrompt");
            this.txtName.StyleController = this.layoutControl1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtName, conditionValidationRule1);
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtPrice.Properties.Appearance.Font")));
            this.txtPrice.Properties.Appearance.Options.UseFont = true;
            this.txtPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrice.Properties.MaskSettings.Set("mask", "f");
            this.txtPrice.Properties.MaskSettings.Set("hideInsignificantZeros", true);
            this.txtPrice.Properties.NullValuePrompt = resources.GetString("txtPrice.Properties.NullValuePrompt");
            this.txtPrice.StyleController = this.layoutControl1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtPrice, conditionValidationRule2);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnAdd.Appearance.Font")));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // GroupItem
            // 
            resources.ApplyResources(this.GroupItem, "GroupItem");
            this.GroupItem.Name = "GroupItem";
            this.GroupItem.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("GroupItem.Properties.Appearance.Font")));
            this.GroupItem.Properties.Appearance.Options.UseFont = true;
            this.GroupItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("GroupItem.Properties.Buttons"))))});
            this.GroupItem.Properties.DataSource = this.ezziresto_food_groupsBindingSource;
            this.GroupItem.Properties.DisplayMember = "name";
            this.GroupItem.Properties.NullText = resources.GetString("GroupItem.Properties.NullText");
            this.GroupItem.Properties.NullValuePrompt = resources.GetString("GroupItem.Properties.NullValuePrompt");
            this.GroupItem.Properties.PopupSizeable = false;
            this.GroupItem.Properties.ValueMember = "id";
            this.GroupItem.StyleController = this.layoutControl1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.GroupItem, conditionValidationRule3);
            // 
            // ezziresto_food_groupsBindingSource
            // 
            this.ezziresto_food_groupsBindingSource.DataMember = "ezziresto_food_groups";
            this.ezziresto_food_groupsBindingSource.DataSource = this.sqlDataSourceGroup;
            // 
            // sqlDataSourceGroup
            // 
            this.sqlDataSourceGroup.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceGroup.Name = "sqlDataSourceGroup";
            columnExpression7.ColumnName = "id";
            table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"163\" />";
            table3.Name = "ezziresto.food_groups";
            columnExpression7.Table = table3;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "name";
            columnExpression8.Table = table3;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "created_at";
            columnExpression9.Table = table3;
            column9.Expression = columnExpression9;
            selectQuery3.Columns.Add(column7);
            selectQuery3.Columns.Add(column8);
            selectQuery3.Columns.Add(column9);
            selectQuery3.Name = "ezziresto_food_groups";
            selectQuery3.Tables.Add(table3);
            this.sqlDataSourceGroup.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery3});
            this.sqlDataSourceGroup.ResultSchemaSerializable = resources.GetString("sqlDataSourceGroup.ResultSchemaSerializable");
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(865, 664);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup1.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup1.AppearanceGroup.Font")));
            this.layoutControlGroup1.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem9,
            this.emptySpaceItem4,
            this.layoutControlGroup2,
            this.emptySpaceItem7,
            this.layoutControlItem11,
            this.emptySpaceItem6,
            this.layoutControlItem12,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem13});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(839, 638);
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem1.AppearanceItemCaption.Font")));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.GroupItem;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(236, 58);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(633, 58);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(98, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem2.AppearanceItemCaption.Font")));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtName;
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(236, 58);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(633, 58);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(98, 16);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem9.AppearanceItemCaption.Font")));
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.Control = this.txtPrice;
            resources.ApplyResources(this.layoutControlItem9, "layoutControlItem9");
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 174);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(221, 36);
            this.layoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(61, 16);
            this.layoutControlItem9.TextToControlDistance = 5;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 210);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(106, 26);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(807, 26);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10});
            this.layoutControlGroup2.Location = new System.Drawing.Point(652, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(155, 210);
            resources.ApplyResources(this.layoutControlGroup2, "layoutControlGroup2");
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.pictureFoodItem;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(123, 151);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(633, 0);
            this.emptySpaceItem7.MaxSize = new System.Drawing.Size(19, 174);
            this.emptySpaceItem7.MinSize = new System.Drawing.Size(19, 174);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(19, 210);
            this.emptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnAdd;
            this.layoutControlItem11.Location = new System.Drawing.Point(704, 532);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(103, 47);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 532);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(537, 47);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnAddExit;
            this.layoutControlItem12.Location = new System.Drawing.Point(537, 532);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(167, 47);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem4.AppearanceItemCaption.Font")));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.tokenProperty;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 236);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(807, 34);
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.TextSize = new System.Drawing.Size(98, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem6.AppearanceItemCaption.Font")));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.tokenVariante;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 270);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(807, 34);
            resources.ApplyResources(this.layoutControlItem6, "layoutControlItem6");
            this.layoutControlItem6.TextSize = new System.Drawing.Size(98, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gridControlAddedVariants;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 304);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(807, 228);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.isSpecial;
            this.layoutControlItem8.Location = new System.Drawing.Point(221, 174);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(110, 36);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.hasProperties;
            this.layoutControlItem3.Location = new System.Drawing.Point(331, 174);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(154, 36);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.hasVariants;
            this.layoutControlItem5.Location = new System.Drawing.Point(485, 174);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(148, 36);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // txtBarCode
            // 
            resources.ApplyResources(this.txtBarCode, "txtBarCode");
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("textEdit1.Properties.Appearance.Font")));
            this.txtBarCode.Properties.Appearance.Options.UseFont = true;
            this.txtBarCode.Properties.NullValuePrompt = resources.GetString("textEdit1.Properties.NullValuePrompt");
            this.txtBarCode.StyleController = this.layoutControl1;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            this.dxValidationProvider11.SetValidationRule(this.txtBarCode, conditionValidationRule4);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem13.AppearanceItemCaption.Font")));
            this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem13.Control = this.txtBarCode;
            resources.ApplyResources(this.layoutControlItem13, "layoutControlItem13");
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 116);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(236, 58);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(633, 58);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem13.TextSize = new System.Drawing.Size(98, 16);
            // 
            // Form_Add_New_Item
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.Name = "Form_Add_New_Item";
            this.Load += new System.EventHandler(this.Form_Add_New_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoodItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isSpecial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAddedVariants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAddedVariants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenVariante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_variationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenProperty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_property_groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasVariants.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasProperties.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_food_groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PictureEdit pictureFoodItem;
        private DevExpress.XtraEditors.CheckEdit hasVariants;
        private DevExpress.XtraEditors.CheckEdit hasProperties;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraEditors.SimpleButton btnAddExit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.LookUpEdit GroupItem;
        private DevExpress.XtraEditors.TokenEdit tokenVariante;
        private DevExpress.XtraEditors.TokenEdit tokenProperty;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource ezziresto_property_groupsBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceProperty;
        private System.Windows.Forms.BindingSource ezziresto_variationsBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceVariante;
        private DevExpress.XtraGrid.GridControl gridControlAddedVariants;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAddedVariants;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.BindingSource ezziresto_food_groupsBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.CheckEdit isSpecial;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.TextEdit txtBarCode;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
    }
}