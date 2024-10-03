
namespace ezziresto.PL.User.User
{
    partial class Form_User_Permissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_User_Permissions));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlPermissions = new DevExpress.XtraGrid.GridControl();
            this.gridViewPermissions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtPermission = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ezziresto_permissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourcePermission = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sqlDataSourceUserPermission = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.colpermission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPermission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_permissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.layoutControl2);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gridControlPermissions);
            this.layoutControl2.Controls.Add(this.txtName);
            this.layoutControl2.Controls.Add(this.txtPermission);
            resources.ApplyResources(this.layoutControl2, "layoutControl2");
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            // 
            // gridControlPermissions
            // 
            resources.ApplyResources(this.gridControlPermissions, "gridControlPermissions");
            this.gridControlPermissions.DataSource = this.sqlDataSourceUserPermission;
            this.gridControlPermissions.MainView = this.gridViewPermissions;
            this.gridControlPermissions.Name = "gridControlPermissions";
            this.gridControlPermissions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPermissions});
            // 
            // gridViewPermissions
            // 
            this.gridViewPermissions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpermission,
            this.colcreated_at,
            this.colid});
            this.gridViewPermissions.GridControl = this.gridControlPermissions;
            this.gridViewPermissions.Name = "gridViewPermissions";
            this.gridViewPermissions.OptionsView.ShowGroupPanel = false;
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
            // 
            // txtPermission
            // 
            resources.ApplyResources(this.txtPermission, "txtPermission");
            this.txtPermission.Name = "txtPermission";
            this.txtPermission.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtPermission.Properties.Appearance.Font")));
            this.txtPermission.Properties.Appearance.Options.UseFont = true;
            this.txtPermission.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtPermission.Properties.Buttons")))),
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtPermission.Properties.Buttons1"))))});
            this.txtPermission.Properties.DataSource = this.ezziresto_permissionsBindingSource;
            this.txtPermission.Properties.DisplayMember = "name";
            this.txtPermission.Properties.NullText = resources.GetString("txtPermission.Properties.NullText");
            this.txtPermission.Properties.PopupSizeable = false;
            this.txtPermission.Properties.PopupView = this.searchLookUpEdit1View;
            this.txtPermission.Properties.ValidateOnEnterKey = true;
            this.txtPermission.Properties.ValueMember = "id";
            this.txtPermission.StyleController = this.layoutControl2;
            this.txtPermission.EditValueChanged += new System.EventHandler(this.txtPermission_EditValueChanged);
            // 
            // ezziresto_permissionsBindingSource
            // 
            this.ezziresto_permissionsBindingSource.DataMember = "ezziresto_permissions";
            this.ezziresto_permissionsBindingSource.DataSource = this.sqlDataSourcePermission;
            // 
            // sqlDataSourcePermission
            // 
            this.sqlDataSourcePermission.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourcePermission.Name = "sqlDataSourcePermission";
            columnExpression7.ColumnName = "id";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"163\" />";
            table2.Name = "ezziresto.permissions";
            columnExpression7.Table = table2;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "name";
            columnExpression8.Table = table2;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "created_at";
            columnExpression9.Table = table2;
            column9.Expression = columnExpression9;
            selectQuery2.Columns.Add(column7);
            selectQuery2.Columns.Add(column8);
            selectQuery2.Columns.Add(column9);
            selectQuery2.Name = "ezziresto_permissions";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSourcePermission.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSourcePermission.ResultSchemaSerializable = resources.GetString("sqlDataSourcePermission.ResultSchemaSerializable");
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(493, 490);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup2.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup2.AppearanceGroup.Font")));
            this.layoutControlGroup2.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlGroup2.CaptionImageOptions.SvgImage")));
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 103);
            this.layoutControlGroup2.Name = "layoutControlGroup1";
            this.layoutControlGroup2.Size = new System.Drawing.Size(467, 361);
            resources.ApplyResources(this.layoutControlGroup2, "layoutControlGroup2");
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem4.AppearanceItemCaption.Font")));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtPermission;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(435, 36);
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridControlPermissions;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(435, 252);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup3.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup3.AppearanceGroup.Font")));
            this.layoutControlGroup3.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(467, 103);
            resources.ApplyResources(this.layoutControlGroup3, "layoutControlGroup3");
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem1.AppearanceItemCaption.Font")));
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(435, 44);
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(525, 522);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.layoutControl2;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(499, 496);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // sqlDataSourceUserPermission
            // 
            this.sqlDataSourceUserPermission.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceUserPermission.Name = "sqlDataSourceUserPermission";
            columnExpression1.ColumnName = "id";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"183\" />";
            table1.Name = "ezziresto.user_permissions";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "user_id";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "permission_id";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "permission";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "created_at";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "updated_at";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Name = "ezziresto_user_permissions";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSourceUserPermission.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSourceUserPermission.ResultSchemaSerializable = resources.GetString("sqlDataSourceUserPermission.ResultSchemaSerializable");
            // 
            // colpermission
            // 
            resources.ApplyResources(this.colpermission, "colpermission");
            this.colpermission.FieldName = "permission";
            this.colpermission.Name = "colpermission";
            // 
            // colcreated_at
            // 
            resources.ApplyResources(this.colcreated_at, "colcreated_at");
            this.colcreated_at.FieldName = "created_at";
            this.colcreated_at.Name = "colcreated_at";
            // 
            // colid
            // 
            resources.ApplyResources(this.colid, "colid");
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // Form_User_Permissions
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.Name = "Form_User_Permissions";
            this.Load += new System.EventHandler(this.Form_Edit_Permission_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPermission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_permissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gridControlPermissions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPermissions;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraEditors.SearchLookUpEdit txtPermission;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource ezziresto_permissionsBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourcePermission;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceUserPermission;
        private DevExpress.XtraGrid.Columns.GridColumn colpermission;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_at;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
    }
}