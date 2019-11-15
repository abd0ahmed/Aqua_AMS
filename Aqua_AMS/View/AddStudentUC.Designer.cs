namespace Aqua_AMS.View
{
    partial class AddStudentUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataPanel = new System.Windows.Forms.SplitContainer();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DpDop = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DDGrade = new Bunifu.Framework.UI.BunifuDropdown();
            this.DDtimeP = new Bunifu.Framework.UI.BunifuDropdown();
            this.DDclass = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtstuName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AddparentPanel = new System.Windows.Forms.Panel();
            this.txtaddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnSaveParent = new Bunifu.Framework.UI.BunifuTileButton();
            this.txtparentName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSsn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtphone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtsubmitSsn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PtnAddParent = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnSaveStudent = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnAddStudent = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.aMS_DataDataSet = new Aqua_AMS.AMS_DataDataSet();
            this.aMSDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sClassDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_ClassDataTableAdapter = new Aqua_AMS.AMS_DataDataSetTableAdapters.S_ClassDataTableAdapter();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).BeginInit();
            this.DataPanel.Panel1.SuspendLayout();
            this.DataPanel.Panel2.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.AddparentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aMS_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sClassDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DataPanel);
            this.panel3.Controls.Add(this.BtnSaveStudent);
            this.panel3.Controls.Add(this.BtnAddStudent);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 358);
            this.panel3.TabIndex = 0;
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataPanel.Enabled = false;
            this.DataPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.DataPanel.Location = new System.Drawing.Point(303, 3);
            this.DataPanel.Name = "DataPanel";
            // 
            // DataPanel.Panel1
            // 
            this.DataPanel.Panel1.Controls.Add(this.bunifuCustomLabel7);
            this.DataPanel.Panel1.Controls.Add(this.DpDop);
            this.DataPanel.Panel1.Controls.Add(this.bunifuCustomLabel5);
            this.DataPanel.Panel1.Controls.Add(this.bunifuCustomLabel6);
            this.DataPanel.Panel1.Controls.Add(this.bunifuCustomLabel3);
            this.DataPanel.Panel1.Controls.Add(this.bunifuCustomLabel2);
            this.DataPanel.Panel1.Controls.Add(this.bunifuCustomLabel1);
            this.DataPanel.Panel1.Controls.Add(this.DDGrade);
            this.DataPanel.Panel1.Controls.Add(this.DDtimeP);
            this.DataPanel.Panel1.Controls.Add(this.DDclass);
            this.DataPanel.Panel1.Controls.Add(this.txtstuName);
            this.DataPanel.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataPanel.Panel1MinSize = 30;
            // 
            // DataPanel.Panel2
            // 
            this.DataPanel.Panel2.Controls.Add(this.AddparentPanel);
            this.DataPanel.Panel2.Controls.Add(this.bunifuCustomLabel4);
            this.DataPanel.Panel2.Controls.Add(this.txtsubmitSsn);
            this.DataPanel.Panel2.Controls.Add(this.PtnAddParent);
            this.DataPanel.Panel2.Controls.Add(this.bunifuCustomLabel8);
            this.DataPanel.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataPanel.Panel2MinSize = 20;
            this.DataPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataPanel.Size = new System.Drawing.Size(566, 349);
            this.DataPanel.SplitterDistance = 270;
            this.DataPanel.SplitterWidth = 2;
            this.DataPanel.TabIndex = 8;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(198, 2);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(67, 17);
            this.bunifuCustomLabel7.TabIndex = 28;
            this.bunifuCustomLabel7.Text = "بيانات الطالب";
            // 
            // DpDop
            // 
            this.DpDop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DpDop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.DpDop.BorderRadius = 2;
            this.DpDop.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DpDop.ForeColor = System.Drawing.Color.White;
            this.DpDop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DpDop.FormatCustom = "dddd dd-MM-yyyy";
            this.DpDop.Location = new System.Drawing.Point(30, 208);
            this.DpDop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DpDop.Name = "DpDop";
            this.DpDop.Size = new System.Drawing.Size(163, 32);
            this.DpDop.TabIndex = 27;
            this.DpDop.Value = new System.DateTime(2010, 11, 15, 4, 51, 0, 0);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Lato Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(197, 219);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(63, 19);
            this.bunifuCustomLabel5.TabIndex = 22;
            this.bunifuCustomLabel5.Text = "تاريخ الميلاد:";
            this.bunifuCustomLabel5.UseCompatibleTextRendering = true;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Lato Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(209, 175);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(33, 19);
            this.bunifuCustomLabel6.TabIndex = 23;
            this.bunifuCustomLabel6.Text = "الفترة:";
            this.bunifuCustomLabel6.UseCompatibleTextRendering = true;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Lato Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(209, 132);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(37, 19);
            this.bunifuCustomLabel3.TabIndex = 24;
            this.bunifuCustomLabel3.Text = "الفصل:";
            this.bunifuCustomLabel3.UseCompatibleTextRendering = true;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Lato Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(214, 85);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(27, 19);
            this.bunifuCustomLabel2.TabIndex = 25;
            this.bunifuCustomLabel2.Text = "الفئة:";
            this.bunifuCustomLabel2.UseCompatibleTextRendering = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Lato Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(197, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(57, 19);
            this.bunifuCustomLabel1.TabIndex = 26;
            this.bunifuCustomLabel1.Text = "اسم الطالب:";
            this.bunifuCustomLabel1.UseCompatibleTextRendering = true;
            // 
            // DDGrade
            // 
            this.DDGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DDGrade.BackColor = System.Drawing.Color.Transparent;
            this.DDGrade.BorderRadius = 3;
            this.DDGrade.DisabledColor = System.Drawing.Color.Gray;
            this.DDGrade.ForeColor = System.Drawing.Color.White;
            this.DDGrade.Items = new string[0];
            this.DDGrade.Location = new System.Drawing.Point(30, 78);
            this.DDGrade.Name = "DDGrade";
            this.DDGrade.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.DDGrade.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.DDGrade.selectedIndex = -1;
            this.DDGrade.Size = new System.Drawing.Size(163, 31);
            this.DDGrade.TabIndex = 19;
            // 
            // DDtimeP
            // 
            this.DDtimeP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DDtimeP.BackColor = System.Drawing.Color.Transparent;
            this.DDtimeP.BorderRadius = 3;
            this.DDtimeP.DisabledColor = System.Drawing.Color.Gray;
            this.DDtimeP.ForeColor = System.Drawing.Color.White;
            this.DDtimeP.Items = new string[0];
            this.DDtimeP.Location = new System.Drawing.Point(30, 166);
            this.DDtimeP.Name = "DDtimeP";
            this.DDtimeP.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.DDtimeP.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.DDtimeP.selectedIndex = -1;
            this.DDtimeP.Size = new System.Drawing.Size(163, 31);
            this.DDtimeP.TabIndex = 20;
            // 
            // DDclass
            // 
            this.DDclass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DDclass.BackColor = System.Drawing.Color.Transparent;
            this.DDclass.BorderRadius = 3;
            this.DDclass.DisabledColor = System.Drawing.Color.Gray;
            this.DDclass.ForeColor = System.Drawing.Color.White;
            this.DDclass.Items = new string[0];
            this.DDclass.Location = new System.Drawing.Point(30, 123);
            this.DDclass.Name = "DDclass";
            this.DDclass.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.DDclass.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.DDclass.selectedIndex = -1;
            this.DDclass.Size = new System.Drawing.Size(163, 31);
            this.DDclass.TabIndex = 21;
            // 
            // txtstuName
            // 
            this.txtstuName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtstuName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtstuName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstuName.Font = new System.Drawing.Font("Lato Black", 10F, System.Drawing.FontStyle.Bold);
            this.txtstuName.ForeColor = System.Drawing.Color.White;
            this.txtstuName.HintForeColor = System.Drawing.Color.Silver;
            this.txtstuName.HintText = "";
            this.txtstuName.isPassword = false;
            this.txtstuName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtstuName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtstuName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtstuName.LineThickness = 3;
            this.txtstuName.Location = new System.Drawing.Point(30, 34);
            this.txtstuName.Margin = new System.Windows.Forms.Padding(4);
            this.txtstuName.Name = "txtstuName";
            this.txtstuName.Size = new System.Drawing.Size(163, 31);
            this.txtstuName.TabIndex = 18;
            this.txtstuName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddparentPanel
            // 
            this.AddparentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddparentPanel.Controls.Add(this.txtaddress);
            this.AddparentPanel.Controls.Add(this.BtnSaveParent);
            this.AddparentPanel.Controls.Add(this.txtparentName);
            this.AddparentPanel.Controls.Add(this.txtSsn);
            this.AddparentPanel.Controls.Add(this.txtphone);
            this.AddparentPanel.Location = new System.Drawing.Point(-1, 155);
            this.AddparentPanel.Name = "AddparentPanel";
            this.AddparentPanel.Size = new System.Drawing.Size(294, 189);
            this.AddparentPanel.TabIndex = 9;
            this.AddparentPanel.Visible = false;
            // 
            // txtaddress
            // 
            this.txtaddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtaddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.Font = new System.Drawing.Font("Lato Black", 10F, System.Drawing.FontStyle.Bold);
            this.txtaddress.ForeColor = System.Drawing.Color.White;
            this.txtaddress.HintForeColor = System.Drawing.Color.Silver;
            this.txtaddress.HintText = "العنوان";
            this.txtaddress.isPassword = false;
            this.txtaddress.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtaddress.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtaddress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtaddress.LineThickness = 3;
            this.txtaddress.Location = new System.Drawing.Point(127, 43);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtaddress.Size = new System.Drawing.Size(163, 56);
            this.txtaddress.TabIndex = 18;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnSaveParent
            // 
            this.BtnSaveParent.BackColor = System.Drawing.Color.Transparent;
            this.BtnSaveParent.color = System.Drawing.Color.Transparent;
            this.BtnSaveParent.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.BtnSaveParent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnSaveParent.Font = new System.Drawing.Font("Lato Black", 15.75F);
            this.BtnSaveParent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.BtnSaveParent.Image = ((System.Drawing.Image)(resources.GetObject("BtnSaveParent.Image")));
            this.BtnSaveParent.ImagePosition = 5;
            this.BtnSaveParent.ImageZoom = 40;
            this.BtnSaveParent.LabelPosition = 30;
            this.BtnSaveParent.LabelText = "حفظ";
            this.BtnSaveParent.Location = new System.Drawing.Point(5, 4);
            this.BtnSaveParent.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSaveParent.Name = "BtnSaveParent";
            this.BtnSaveParent.Size = new System.Drawing.Size(84, 75);
            this.BtnSaveParent.TabIndex = 3;
            this.BtnSaveParent.Click += new System.EventHandler(this.BtnSaveParent_Click);
            // 
            // txtparentName
            // 
            this.txtparentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtparentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtparentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtparentName.Font = new System.Drawing.Font("Lato Black", 10F, System.Drawing.FontStyle.Bold);
            this.txtparentName.ForeColor = System.Drawing.Color.White;
            this.txtparentName.HintForeColor = System.Drawing.Color.Silver;
            this.txtparentName.HintText = "الاسم";
            this.txtparentName.isPassword = false;
            this.txtparentName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtparentName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtparentName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtparentName.LineThickness = 3;
            this.txtparentName.Location = new System.Drawing.Point(127, 4);
            this.txtparentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtparentName.Name = "txtparentName";
            this.txtparentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtparentName.Size = new System.Drawing.Size(163, 31);
            this.txtparentName.TabIndex = 18;
            this.txtparentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSsn
            // 
            this.txtSsn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSsn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtSsn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSsn.Font = new System.Drawing.Font("Lato Black", 10F, System.Drawing.FontStyle.Bold);
            this.txtSsn.ForeColor = System.Drawing.Color.White;
            this.txtSsn.HintForeColor = System.Drawing.Color.Silver;
            this.txtSsn.HintText = "الرقم القومى";
            this.txtSsn.isPassword = false;
            this.txtSsn.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtSsn.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtSsn.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtSsn.LineThickness = 3;
            this.txtSsn.Location = new System.Drawing.Point(127, 146);
            this.txtSsn.Margin = new System.Windows.Forms.Padding(4);
            this.txtSsn.Name = "txtSsn";
            this.txtSsn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSsn.Size = new System.Drawing.Size(163, 31);
            this.txtSsn.TabIndex = 18;
            this.txtSsn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtphone
            // 
            this.txtphone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphone.Font = new System.Drawing.Font("Lato Black", 10F, System.Drawing.FontStyle.Bold);
            this.txtphone.ForeColor = System.Drawing.Color.White;
            this.txtphone.HintForeColor = System.Drawing.Color.Silver;
            this.txtphone.HintText = "رقم الهاتف";
            this.txtphone.isPassword = false;
            this.txtphone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtphone.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtphone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtphone.LineThickness = 3;
            this.txtphone.Location = new System.Drawing.Point(127, 107);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone.Name = "txtphone";
            this.txtphone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtphone.Size = new System.Drawing.Size(163, 31);
            this.txtphone.TabIndex = 18;
            this.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(212, 2);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(81, 17);
            this.bunifuCustomLabel4.TabIndex = 0;
            this.bunifuCustomLabel4.Text = "بيانات ولى الامر";
            // 
            // txtsubmitSsn
            // 
            this.txtsubmitSsn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsubmitSsn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtsubmitSsn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsubmitSsn.Font = new System.Drawing.Font("Lato Black", 10F, System.Drawing.FontStyle.Bold);
            this.txtsubmitSsn.ForeColor = System.Drawing.Color.White;
            this.txtsubmitSsn.HintForeColor = System.Drawing.Color.Silver;
            this.txtsubmitSsn.HintText = "الرقم القومى";
            this.txtsubmitSsn.isPassword = false;
            this.txtsubmitSsn.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtsubmitSsn.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtsubmitSsn.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtsubmitSsn.LineThickness = 3;
            this.txtsubmitSsn.Location = new System.Drawing.Point(125, 23);
            this.txtsubmitSsn.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubmitSsn.Name = "txtsubmitSsn";
            this.txtsubmitSsn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsubmitSsn.Size = new System.Drawing.Size(163, 31);
            this.txtsubmitSsn.TabIndex = 18;
            this.txtsubmitSsn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PtnAddParent
            // 
            this.PtnAddParent.BackColor = System.Drawing.Color.Transparent;
            this.PtnAddParent.color = System.Drawing.Color.Transparent;
            this.PtnAddParent.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.PtnAddParent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtnAddParent.Font = new System.Drawing.Font("Lato Black", 15.75F);
            this.PtnAddParent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.PtnAddParent.Image = ((System.Drawing.Image)(resources.GetObject("PtnAddParent.Image")));
            this.PtnAddParent.ImagePosition = 5;
            this.PtnAddParent.ImageZoom = 40;
            this.PtnAddParent.LabelPosition = 30;
            this.PtnAddParent.LabelText = "إضافة طالب";
            this.PtnAddParent.Location = new System.Drawing.Point(4, 5);
            this.PtnAddParent.Margin = new System.Windows.Forms.Padding(6);
            this.PtnAddParent.Name = "PtnAddParent";
            this.PtnAddParent.Size = new System.Drawing.Size(74, 66);
            this.PtnAddParent.TabIndex = 3;
            this.PtnAddParent.Click += new System.EventHandler(this.PtnAddParent_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Lato Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(257, 65);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(32, 19);
            this.bunifuCustomLabel8.TabIndex = 26;
            this.bunifuCustomLabel8.Text = "الاسم:";
            this.bunifuCustomLabel8.UseCompatibleTextRendering = true;
            // 
            // BtnSaveStudent
            // 
            this.BtnSaveStudent.BackColor = System.Drawing.Color.Transparent;
            this.BtnSaveStudent.color = System.Drawing.Color.Transparent;
            this.BtnSaveStudent.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.BtnSaveStudent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnSaveStudent.Font = new System.Drawing.Font("Lato Black", 15.75F);
            this.BtnSaveStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.BtnSaveStudent.Image = ((System.Drawing.Image)(resources.GetObject("BtnSaveStudent.Image")));
            this.BtnSaveStudent.ImagePosition = 5;
            this.BtnSaveStudent.ImageZoom = 50;
            this.BtnSaveStudent.LabelPosition = 30;
            this.BtnSaveStudent.LabelText = "حفظ";
            this.BtnSaveStudent.Location = new System.Drawing.Point(6, 6);
            this.BtnSaveStudent.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSaveStudent.Name = "BtnSaveStudent";
            this.BtnSaveStudent.Size = new System.Drawing.Size(108, 88);
            this.BtnSaveStudent.TabIndex = 3;
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddStudent.color = System.Drawing.Color.Transparent;
            this.BtnAddStudent.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.BtnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddStudent.Font = new System.Drawing.Font("Lato Black", 15.75F);
            this.BtnAddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.BtnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddStudent.Image")));
            this.BtnAddStudent.ImagePosition = 5;
            this.BtnAddStudent.ImageZoom = 50;
            this.BtnAddStudent.LabelPosition = 30;
            this.BtnAddStudent.LabelText = "إضافة طالب";
            this.BtnAddStudent.Location = new System.Drawing.Point(126, 6);
            this.BtnAddStudent.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Size = new System.Drawing.Size(105, 88);
            this.BtnAddStudent.TabIndex = 3;
            this.BtnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagrid1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 455);
            this.panel1.TabIndex = 1;
            // 
            // datagrid1
            // 
            this.datagrid1.AllowUserToAddRows = false;
            this.datagrid1.AllowUserToDeleteRows = false;
            this.datagrid1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid1.AutoGenerateColumns = false;
            this.datagrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.datagrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid1.ColumnHeadersHeight = 32;
            this.datagrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassName,
            this.sellprice});
            this.datagrid1.DataSource = this.sClassDataBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "(Empty)";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid1.DefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid1.DoubleBuffered = true;
            this.datagrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagrid1.EnableHeadersVisualStyles = false;
            this.datagrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.datagrid1.HeaderForeColor = System.Drawing.Color.White;
            this.datagrid1.Location = new System.Drawing.Point(0, 358);
            this.datagrid1.MultiSelect = false;
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.ReadOnly = true;
            this.datagrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagrid1.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.datagrid1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.datagrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid1.ShowCellErrors = false;
            this.datagrid1.ShowCellToolTips = false;
            this.datagrid1.ShowEditingIcon = false;
            this.datagrid1.ShowRowErrors = false;
            this.datagrid1.Size = new System.Drawing.Size(872, 97);
            this.datagrid1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 33);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "الفصول";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImage = global::Aqua_AMS.Properties.Resources.icons8_close_window_26;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.Transparent;
            this.BtnClose.Location = new System.Drawing.Point(842, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 33);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnClose.UseMnemonic = false;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // aMS_DataDataSet
            // 
            this.aMS_DataDataSet.DataSetName = "AMS_DataDataSet";
            this.aMS_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aMSDataDataSetBindingSource
            // 
            this.aMSDataDataSetBindingSource.DataSource = this.aMS_DataDataSet;
            this.aMSDataDataSetBindingSource.Position = 0;
            // 
            // sClassDataBindingSource
            // 
            this.sClassDataBindingSource.DataMember = "S_ClassData";
            this.sClassDataBindingSource.DataSource = this.aMS_DataDataSet;
            // 
            // s_ClassDataTableAdapter
            // 
            this.s_ClassDataTableAdapter.ClearBeforeFill = true;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassName.DataPropertyName = "ClassName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClassName.FillWeight = 64.3569F;
            this.ClassName.HeaderText = "اسم الفصل";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sellprice
            // 
            this.sellprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellprice.DataPropertyName = "count";
            this.sellprice.FillWeight = 20.86623F;
            this.sellprice.HeaderText = "عدد الطلاب";
            this.sellprice.MinimumWidth = 20;
            this.sellprice.Name = "sellprice";
            this.sellprice.ReadOnly = true;
            this.sellprice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddStudentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AddStudentUC";
            this.Size = new System.Drawing.Size(872, 488);
            this.panel3.ResumeLayout(false);
            this.DataPanel.Panel1.ResumeLayout(false);
            this.DataPanel.Panel1.PerformLayout();
            this.DataPanel.Panel2.ResumeLayout(false);
            this.DataPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).EndInit();
            this.DataPanel.ResumeLayout(false);
            this.AddparentPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aMS_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sClassDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuTileButton BtnAddStudent;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid datagrid1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuTileButton BtnSaveParent;
        private System.Windows.Forms.SplitContainer DataPanel;
        private Bunifu.Framework.UI.BunifuDatepicker DpDop;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown DDGrade;
        private Bunifu.Framework.UI.BunifuDropdown DDtimeP;
        private Bunifu.Framework.UI.BunifuDropdown DDclass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtstuName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuTileButton PtnAddParent;
        private System.Windows.Forms.Panel AddparentPanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtaddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtparentName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtphone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsubmitSsn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSsn;
        private Bunifu.Framework.UI.BunifuTileButton BtnSaveStudent;
        private System.Windows.Forms.BindingSource sClassDataBindingSource;
        private AMS_DataDataSet aMS_DataDataSet;
        private System.Windows.Forms.BindingSource aMSDataDataSetBindingSource;
        private AMS_DataDataSetTableAdapters.S_ClassDataTableAdapter s_ClassDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellprice;
    }
}
