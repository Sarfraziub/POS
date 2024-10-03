
namespace ezziresto.PL.User.User
{
    partial class Form_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_User));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery4 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery5 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery6 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression21 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression22 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnRoles = new DevExpress.XtraEditors.SimpleButton();
            this.btnPermissions = new DevExpress.XtraEditors.SimpleButton();
            this.txtPermissionGroup = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ezziresto_permission_groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourcePermissionGroup = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.memoAdress = new DevExpress.XtraEditors.MemoEdit();
            this.btnLeft2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnRight = new DevExpress.XtraEditors.SimpleButton();
            this.btnRight2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLeft = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.txtBranch = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ezziresto_branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceBranch = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureEditWaiter = new DevExpress.XtraEditors.PictureEdit();
            this.searchLookUpWaiter = new DevExpress.XtraEditors.LookUpEdit();
            this.ezziresto_usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceUser = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.isActive = new DevExpress.XtraEditors.ComboBoxEdit();
            this.isBanned = new DevExpress.XtraEditors.ComboBoxEdit();
            this.userType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNotes = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CustommerType = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPermissionGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_permission_groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditWaiter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpWaiter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isBanned.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustommerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnRoles);
            this.layoutControl1.Controls.Add(this.btnPermissions);
            this.layoutControl1.Controls.Add(this.txtPermissionGroup);
            this.layoutControl1.Controls.Add(this.txtPassword);
            this.layoutControl1.Controls.Add(this.txtEmail);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.txtID);
            this.layoutControl1.Controls.Add(this.txtPhone);
            this.layoutControl1.Controls.Add(this.memoAdress);
            this.layoutControl1.Controls.Add(this.btnLeft2);
            this.layoutControl1.Controls.Add(this.btnRight);
            this.layoutControl1.Controls.Add(this.btnRight2);
            this.layoutControl1.Controls.Add(this.btnLeft);
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnDeleteAll);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.btnExit);
            this.layoutControl1.Controls.Add(this.txtBranch);
            this.layoutControl1.Controls.Add(this.pictureEditWaiter);
            this.layoutControl1.Controls.Add(this.searchLookUpWaiter);
            this.layoutControl1.Controls.Add(this.isActive);
            this.layoutControl1.Controls.Add(this.isBanned);
            this.layoutControl1.Controls.Add(this.userType);
            this.layoutControl1.Controls.Add(this.txtNotes);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(862, 205, 1046, 612);
            this.layoutControl1.Root = this.Root;
            // 
            // btnRoles
            // 
            this.btnRoles.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnRoles.Appearance.Font")));
            this.btnRoles.Appearance.Options.UseFont = true;
            this.btnRoles.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRoles.ImageOptions.SvgImage = global::zamcube.Properties.Resources.work_authorisation;
            resources.ApplyResources(this.btnRoles, "btnRoles");
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.StyleController = this.layoutControl1;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnPermissions
            // 
            this.btnPermissions.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnPermissions.Appearance.Font")));
            this.btnPermissions.Appearance.Options.UseFont = true;
            this.btnPermissions.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPermissions.ImageOptions.SvgImage = global::zamcube.Properties.Resources.access_denied;
            resources.ApplyResources(this.btnPermissions, "btnPermissions");
            this.btnPermissions.Name = "btnPermissions";
            this.btnPermissions.StyleController = this.layoutControl1;
            this.btnPermissions.Click += new System.EventHandler(this.btnPermissions_Click);
            // 
            // txtPermissionGroup
            // 
            resources.ApplyResources(this.txtPermissionGroup, "txtPermissionGroup");
            this.txtPermissionGroup.Name = "txtPermissionGroup";
            this.txtPermissionGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtPermissionGroup.Properties.Buttons"))))});
            this.txtPermissionGroup.Properties.DataSource = this.ezziresto_permission_groupsBindingSource;
            this.txtPermissionGroup.Properties.DisplayMember = "name";
            this.txtPermissionGroup.Properties.NullText = resources.GetString("txtPermissionGroup.Properties.NullText");
            this.txtPermissionGroup.Properties.PopupView = this.gridView2;
            this.txtPermissionGroup.Properties.ValueMember = "id";
            this.txtPermissionGroup.StyleController = this.layoutControl1;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtPermissionGroup, conditionValidationRule5);
            // 
            // ezziresto_permission_groupsBindingSource
            // 
            this.ezziresto_permission_groupsBindingSource.DataMember = "ezziresto_permission_groups";
            this.ezziresto_permission_groupsBindingSource.DataSource = this.sqlDataSourcePermissionGroup;
            // 
            // sqlDataSourcePermissionGroup
            // 
            this.sqlDataSourcePermissionGroup.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourcePermissionGroup.Name = "sqlDataSourcePermissionGroup";
            columnExpression12.ColumnName = "id";
            table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"163\" />";
            table4.Name = "ezziresto.permission_groups";
            columnExpression12.Table = table4;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "name";
            columnExpression13.Table = table4;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "created_at";
            columnExpression14.Table = table4;
            column14.Expression = columnExpression14;
            selectQuery4.Columns.Add(column12);
            selectQuery4.Columns.Add(column13);
            selectQuery4.Columns.Add(column14);
            selectQuery4.Name = "ezziresto_permission_groups";
            selectQuery4.Tables.Add(table4);
            this.sqlDataSourcePermissionGroup.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery4});
            this.sqlDataSourcePermissionGroup.ResultSchemaSerializable = resources.GetString("sqlDataSourcePermissionGroup.ResultSchemaSerializable");
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.StyleController = this.layoutControl1;
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.StyleController = this.layoutControl1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtEmail, conditionValidationRule1);
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            this.txtName.StyleController = this.layoutControl1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtName, conditionValidationRule2);
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            this.txtID.StyleController = this.layoutControl1;
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.StyleController = this.layoutControl1;
            // 
            // memoAdress
            // 
            resources.ApplyResources(this.memoAdress, "memoAdress");
            this.memoAdress.Name = "memoAdress";
            this.memoAdress.StyleController = this.layoutControl1;
            // 
            // btnLeft2
            // 
            this.btnLeft2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnLeft2.Appearance.Font")));
            this.btnLeft2.Appearance.Options.UseFont = true;
            this.btnLeft2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnLeft2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLeft2.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnLeft2, "btnLeft2");
            this.btnLeft2.Name = "btnLeft2";
            this.btnLeft2.StyleController = this.layoutControl1;
            this.btnLeft2.Click += new System.EventHandler(this.btnLeft2_Click);
            // 
            // btnRight
            // 
            this.btnRight.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnRight.Appearance.Font")));
            this.btnRight.Appearance.Options.UseFont = true;
            this.btnRight.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnRight.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRight.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnRight, "btnRight");
            this.btnRight.Name = "btnRight";
            this.btnRight.StyleController = this.layoutControl1;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnRight2
            // 
            this.btnRight2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnRight2.Appearance.Font")));
            this.btnRight2.Appearance.Options.UseFont = true;
            this.btnRight2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnRight2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRight2.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnRight2, "btnRight2");
            this.btnRight2.Name = "btnRight2";
            this.btnRight2.StyleController = this.layoutControl1;
            this.btnRight2.Click += new System.EventHandler(this.btnRight2_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnLeft.Appearance.Font")));
            this.btnLeft.Appearance.Options.UseFont = true;
            this.btnLeft.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnLeft.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLeft.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnLeft, "btnLeft");
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.StyleController = this.layoutControl1;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnRefresh.Appearance.Font")));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnDelete.Appearance.Font")));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnSave.Appearance.Font")));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnDeleteAll.Appearance.Font")));
            this.btnDeleteAll.Appearance.Options.UseFont = true;
            this.btnDeleteAll.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteAll.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnDeleteAll, "btnDeleteAll");
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.StyleController = this.layoutControl1;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnAdd.Appearance.Font")));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnExit.Appearance.Font")));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.StyleController = this.layoutControl1;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBranch
            // 
            resources.ApplyResources(this.txtBranch, "txtBranch");
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtBranch.Properties.Buttons"))))});
            this.txtBranch.Properties.DataSource = this.ezziresto_branchesBindingSource;
            this.txtBranch.Properties.DisplayMember = "name";
            this.txtBranch.Properties.NullText = resources.GetString("txtBranch.Properties.NullText");
            this.txtBranch.Properties.PopupView = this.gridView1;
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
            columnExpression15.ColumnName = "id";
            table5.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"283\" />";
            table5.Name = "ezziresto.branches";
            columnExpression15.Table = table5;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "name";
            columnExpression16.Table = table5;
            column16.Expression = columnExpression16;
            columnExpression17.ColumnName = "created_at";
            columnExpression17.Table = table5;
            column17.Expression = columnExpression17;
            selectQuery5.Columns.Add(column15);
            selectQuery5.Columns.Add(column16);
            selectQuery5.Columns.Add(column17);
            selectQuery5.Name = "ezziresto_branches";
            selectQuery5.Tables.Add(table5);
            this.sqlDataSourceBranch.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery5});
            this.sqlDataSourceBranch.ResultSchemaSerializable = resources.GetString("sqlDataSourceBranch.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // pictureEditWaiter
            // 
            resources.ApplyResources(this.pictureEditWaiter, "pictureEditWaiter");
            this.pictureEditWaiter.Name = "pictureEditWaiter";
            this.pictureEditWaiter.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.pictureEditWaiter.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditWaiter.StyleController = this.layoutControl1;
            // 
            // searchLookUpWaiter
            // 
            resources.ApplyResources(this.searchLookUpWaiter, "searchLookUpWaiter");
            this.searchLookUpWaiter.Name = "searchLookUpWaiter";
            this.searchLookUpWaiter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("searchLookUpWaiter.Properties.Buttons"))))});
            this.searchLookUpWaiter.Properties.DataSource = this.ezziresto_usersBindingSource;
            this.searchLookUpWaiter.Properties.DisplayMember = "name";
            this.searchLookUpWaiter.Properties.ValueMember = "id";
            this.searchLookUpWaiter.StyleController = this.layoutControl1;
            this.searchLookUpWaiter.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.searchLookUpClient_ButtonClick);
            this.searchLookUpWaiter.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.searchLookUpClient_ButtonPressed);
            this.searchLookUpWaiter.EditValueChanged += new System.EventHandler(this.searchLookUpClient_EditValueChanged);
            // 
            // ezziresto_usersBindingSource
            // 
            this.ezziresto_usersBindingSource.DataMember = "ezziresto_users";
            this.ezziresto_usersBindingSource.DataSource = this.sqlDataSourceUser;
            // 
            // sqlDataSourceUser
            // 
            this.sqlDataSourceUser.ConnectionName = "desktop-d3k7toq\\sqlexpress.ezziresto.dbo";
            this.sqlDataSourceUser.Name = "sqlDataSourceUser";
            columnExpression18.ColumnName = "id";
            table6.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"423\" />";
            table6.Name = "ezziresto.users";
            columnExpression18.Table = table6;
            column18.Expression = columnExpression18;
            columnExpression19.ColumnName = "name";
            columnExpression19.Table = table6;
            column19.Expression = columnExpression19;
            columnExpression20.ColumnName = "created_at";
            columnExpression20.Table = table6;
            column20.Expression = columnExpression20;
            columnExpression21.ColumnName = "phn_no";
            columnExpression21.Table = table6;
            column21.Expression = columnExpression21;
            columnExpression22.ColumnName = "image";
            columnExpression22.Table = table6;
            column22.Expression = columnExpression22;
            selectQuery6.Columns.Add(column18);
            selectQuery6.Columns.Add(column19);
            selectQuery6.Columns.Add(column20);
            selectQuery6.Columns.Add(column21);
            selectQuery6.Columns.Add(column22);
            selectQuery6.Name = "ezziresto_users";
            selectQuery6.Tables.Add(table6);
            this.sqlDataSourceUser.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery6});
            this.sqlDataSourceUser.ResultSchemaSerializable = resources.GetString("sqlDataSourceUser.ResultSchemaSerializable");
            // 
            // isActive
            // 
            resources.ApplyResources(this.isActive, "isActive");
            this.isActive.Name = "isActive";
            this.isActive.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("isActive.Properties.Buttons"))))});
            this.isActive.Properties.Items.AddRange(new object[] {
            resources.GetString("isActive.Properties.Items"),
            resources.GetString("isActive.Properties.Items1")});
            this.isActive.StyleController = this.layoutControl1;
            // 
            // isBanned
            // 
            resources.ApplyResources(this.isBanned, "isBanned");
            this.isBanned.Name = "isBanned";
            this.isBanned.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("isBanned.Properties.Buttons"))))});
            this.isBanned.Properties.Items.AddRange(new object[] {
            resources.GetString("isBanned.Properties.Items"),
            resources.GetString("isBanned.Properties.Items1")});
            this.isBanned.StyleController = this.layoutControl1;
            // 
            // userType
            // 
            resources.ApplyResources(this.userType, "userType");
            this.userType.Name = "userType";
            this.userType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("userType.Properties.Buttons"))))});
            this.userType.Properties.Items.AddRange(new object[] {
            resources.GetString("userType.Properties.Items"),
            resources.GetString("userType.Properties.Items1")});
            this.userType.StyleController = this.layoutControl1;
            // 
            // txtNotes
            // 
            resources.ApplyResources(this.txtNotes, "txtNotes");
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.StyleController = this.layoutControl1;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4,
            this.layoutControlGroup3,
            this.layoutControlGroup5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(823, 709);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup4.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup4.AppearanceGroup.Font")));
            this.layoutControlGroup4.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup4.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem13,
            this.layoutControlItem23,
            this.CustommerType,
            this.layoutControlItem18,
            this.layoutControlItem21,
            this.layoutControlItem22,
            this.layoutControlItem1,
            this.emptySpaceItem5,
            this.layoutControlItem6,
            this.emptySpaceItem6,
            this.layoutControlItem4,
            this.layoutControlItem20,
            this.layoutControlItem19,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(797, 409);
            resources.ApplyResources(this.layoutControlGroup4, "layoutControlGroup4");
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(331, 180);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(11, 170);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.pictureEditWaiter;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 180);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(331, 170);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem23.AppearanceItemCaption.Font")));
            this.layoutControlItem23.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem23.Control = this.txtPermissionGroup;
            this.layoutControlItem23.Location = new System.Drawing.Point(342, 180);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(423, 34);
            resources.ApplyResources(this.layoutControlItem23, "layoutControlItem23");
            this.layoutControlItem23.TextSize = new System.Drawing.Size(111, 16);
            // 
            // CustommerType
            // 
            this.CustommerType.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("CustommerType.AppearanceItemCaption.Font")));
            this.CustommerType.AppearanceItemCaption.Options.UseFont = true;
            this.CustommerType.Control = this.txtBranch;
            this.CustommerType.Location = new System.Drawing.Point(342, 214);
            this.CustommerType.Name = "CustommerType";
            this.CustommerType.Size = new System.Drawing.Size(423, 34);
            resources.ApplyResources(this.CustommerType, "CustommerType");
            this.CustommerType.TextSize = new System.Drawing.Size(111, 16);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem18.AppearanceItemCaption.Font")));
            this.layoutControlItem18.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem18.Control = this.userType;
            this.layoutControlItem18.Location = new System.Drawing.Point(342, 248);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(423, 34);
            resources.ApplyResources(this.layoutControlItem18, "layoutControlItem18");
            this.layoutControlItem18.TextSize = new System.Drawing.Size(111, 16);
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem21.AppearanceItemCaption.Font")));
            this.layoutControlItem21.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem21.Control = this.isActive;
            this.layoutControlItem21.Location = new System.Drawing.Point(342, 282);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(423, 34);
            resources.ApplyResources(this.layoutControlItem21, "layoutControlItem21");
            this.layoutControlItem21.TextSize = new System.Drawing.Size(111, 16);
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem22.AppearanceItemCaption.Font")));
            this.layoutControlItem22.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem22.Control = this.isBanned;
            resources.ApplyResources(this.layoutControlItem22, "layoutControlItem22");
            this.layoutControlItem22.Location = new System.Drawing.Point(342, 316);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(423, 34);
            this.layoutControlItem22.TextSize = new System.Drawing.Size(111, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem1.AppearanceItemCaption.Font")));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtNotes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(331, 94);
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(37, 16);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 170);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(765, 10);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem6.AppearanceItemCaption.Font")));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.memoAdress;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(83, 34);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(331, 76);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            resources.ApplyResources(this.layoutControlItem6, "layoutControlItem6");
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(54, 16);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(331, 0);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(11, 170);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem4.AppearanceItemCaption.Font")));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtPhone;
            this.layoutControlItem4.Location = new System.Drawing.Point(342, 136);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(423, 34);
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.TextSize = new System.Drawing.Size(111, 16);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem20.AppearanceItemCaption.Font")));
            this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem20.Control = this.txtPassword;
            this.layoutControlItem20.Location = new System.Drawing.Point(342, 102);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(423, 34);
            resources.ApplyResources(this.layoutControlItem20, "layoutControlItem20");
            this.layoutControlItem20.TextSize = new System.Drawing.Size(111, 16);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem19.AppearanceItemCaption.Font")));
            this.layoutControlItem19.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem19.Control = this.txtEmail;
            this.layoutControlItem19.Location = new System.Drawing.Point(342, 68);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(423, 34);
            resources.ApplyResources(this.layoutControlItem19, "layoutControlItem19");
            this.layoutControlItem19.TextSize = new System.Drawing.Size(111, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem2.AppearanceItemCaption.Font")));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtName;
            this.layoutControlItem2.Location = new System.Drawing.Point(342, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(423, 34);
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.TextSize = new System.Drawing.Size(111, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlItem3.AppearanceItemCaption.Font")));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.txtID;
            this.layoutControlItem3.Location = new System.Drawing.Point(342, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(423, 34);
            resources.ApplyResources(this.layoutControlItem3, "layoutControlItem3");
            this.layoutControlItem3.TextSize = new System.Drawing.Size(111, 16);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup3.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup3.AppearanceGroup.Font")));
            this.layoutControlGroup3.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup3.AppearanceItemCaption.Font")));
            this.layoutControlGroup3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup3.AppearanceTabPage.Header.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup3.AppearanceTabPage.Header.Font")));
            this.layoutControlGroup3.AppearanceTabPage.Header.Options.UseFont = true;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.layoutControlItem16,
            this.layoutControlItem17,
            this.emptySpaceItem2,
            this.layoutControlItem10,
            this.layoutControlItem24,
            this.layoutControlItem25});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 409);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(797, 168);
            resources.ApplyResources(this.layoutControlGroup3, "layoutControlGroup3");
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnRefresh;
            this.layoutControlItem11.Location = new System.Drawing.Point(112, 62);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(119, 47);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnDelete;
            this.layoutControlItem12.Location = new System.Drawing.Point(380, 62);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(118, 47);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.btnExit;
            this.layoutControlItem14.Location = new System.Drawing.Point(657, 62);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(108, 47);
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.btnAdd;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(112, 47);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.btnDeleteAll;
            this.layoutControlItem16.Location = new System.Drawing.Point(498, 62);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(159, 47);
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextVisible = false;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.btnSave;
            this.layoutControlItem17.Location = new System.Drawing.Point(231, 62);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(149, 47);
            this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem17.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 47);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(765, 15);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.searchLookUpWaiter;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(647, 47);
            resources.ApplyResources(this.layoutControlItem10, "layoutControlItem10");
            this.layoutControlItem10.TextSize = new System.Drawing.Size(111, 16);
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.btnPermissions;
            this.layoutControlItem24.Location = new System.Drawing.Point(715, 0);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(50, 47);
            this.layoutControlItem24.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem24.TextVisible = false;
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.btnRoles;
            this.layoutControlItem25.Location = new System.Drawing.Point(647, 0);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(68, 47);
            this.layoutControlItem25.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem25.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.layoutControlGroup5.AppearanceGroup.Font = ((System.Drawing.Font)(resources.GetObject("layoutControlGroup5.AppearanceGroup.Font")));
            this.layoutControlGroup5.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup5.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem5,
            this.layoutControlItem8,
            this.layoutControlItem7});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 577);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(797, 106);
            resources.ApplyResources(this.layoutControlGroup5, "layoutControlGroup5");
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnLeft;
            this.layoutControlItem9.Location = new System.Drawing.Point(363, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(162, 47);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnLeft2;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(204, 47);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnRight2;
            this.layoutControlItem8.Location = new System.Drawing.Point(525, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(240, 47);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnRight;
            this.layoutControlItem7.Location = new System.Drawing.Point(204, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(159, 47);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // Form_User
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.Name = "Form_User";
            this.Load += new System.EventHandler(this.Form_Add_Waiter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPermissionGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_permission_groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditWaiter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpWaiter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezziresto_usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isBanned.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustommerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.MemoEdit memoAdress;
        private DevExpress.XtraEditors.SimpleButton btnLeft2;
        private DevExpress.XtraEditors.SimpleButton btnRight;
        private DevExpress.XtraEditors.SimpleButton btnRight2;
        private DevExpress.XtraEditors.SimpleButton btnLeft;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SearchLookUpEdit txtBranch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem CustommerType;
        private DevExpress.XtraEditors.PictureEdit pictureEditWaiter;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.LookUpEdit searchLookUpWaiter;
        private System.Windows.Forms.BindingSource ezziresto_usersBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceUser;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraEditors.ComboBoxEdit isActive;
        private DevExpress.XtraEditors.ComboBoxEdit isBanned;
        private DevExpress.XtraEditors.ComboBoxEdit userType;
        private System.Windows.Forms.BindingSource ezziresto_branchesBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceBranch;
        private DevExpress.XtraEditors.SearchLookUpEdit txtPermissionGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private System.Windows.Forms.BindingSource ezziresto_permission_groupsBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourcePermissionGroup;
        private DevExpress.XtraEditors.MemoEdit txtNotes;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraEditors.SimpleButton btnPermissions;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
        private DevExpress.XtraEditors.SimpleButton btnRoles;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
    }
}