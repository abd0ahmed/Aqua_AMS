namespace Aqua_AMS.View
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.BtnGrades = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnShifts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnClasses = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.StudentsPanel = new System.Windows.Forms.Panel();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAddStudent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sideinfopanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnInfo = new Bunifu.Framework.UI.BunifuTileButton();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnNormalScreen = new System.Windows.Forms.Button();
            this.BtnFullscreen = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sidepanel.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.StudentsPanel.SuspendLayout();
            this.sideinfopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.sidepanel.Controls.Add(this.AdminPanel);
            this.sidepanel.Controls.Add(this.bunifuFlatButton3);
            this.sidepanel.Controls.Add(this.bunifuFlatButton4);
            this.sidepanel.Controls.Add(this.bunifuFlatButton2);
            this.sidepanel.Controls.Add(this.StudentsPanel);
            this.sidepanel.Controls.Add(this.bunifuFlatButton1);
            this.sidepanel.Controls.Add(this.sideinfopanel);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(194, 527);
            this.sidepanel.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.AdminPanel.Controls.Add(this.BtnGrades);
            this.AdminPanel.Controls.Add(this.BtnShifts);
            this.AdminPanel.Controls.Add(this.BtnClasses);
            this.AdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminPanel.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPanel.Location = new System.Drawing.Point(0, 466);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(194, 127);
            this.AdminPanel.TabIndex = 5;
            this.AdminPanel.Visible = false;
            // 
            // BtnGrades
            // 
            this.BtnGrades.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.BtnGrades.BackColor = System.Drawing.Color.Transparent;
            this.BtnGrades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGrades.BorderRadius = 0;
            this.BtnGrades.ButtonText = "ادارة الفئأت";
            this.BtnGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrades.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGrades.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGrades.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGrades.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGrades.Iconimage")));
            this.BtnGrades.Iconimage_right = null;
            this.BtnGrades.Iconimage_right_Selected = null;
            this.BtnGrades.Iconimage_Selected = null;
            this.BtnGrades.IconMarginLeft = 0;
            this.BtnGrades.IconMarginRight = 0;
            this.BtnGrades.IconRightVisible = true;
            this.BtnGrades.IconRightZoom = 0D;
            this.BtnGrades.IconVisible = true;
            this.BtnGrades.IconZoom = 70D;
            this.BtnGrades.IsTab = false;
            this.BtnGrades.Location = new System.Drawing.Point(0, 82);
            this.BtnGrades.Name = "BtnGrades";
            this.BtnGrades.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnGrades.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.BtnGrades.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGrades.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.BtnGrades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnGrades.selected = false;
            this.BtnGrades.Size = new System.Drawing.Size(194, 41);
            this.BtnGrades.TabIndex = 6;
            this.BtnGrades.Text = "ادارة الفئأت";
            this.BtnGrades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGrades.Textcolor = System.Drawing.Color.White;
            this.BtnGrades.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrades.Click += new System.EventHandler(this.BtnGrades_Click);
            // 
            // BtnShifts
            // 
            this.BtnShifts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.BtnShifts.BackColor = System.Drawing.Color.Transparent;
            this.BtnShifts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnShifts.BorderRadius = 0;
            this.BtnShifts.ButtonText = "ادارة الفترات";
            this.BtnShifts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShifts.DisabledColor = System.Drawing.Color.Gray;
            this.BtnShifts.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnShifts.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnShifts.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnShifts.Iconimage")));
            this.BtnShifts.Iconimage_right = null;
            this.BtnShifts.Iconimage_right_Selected = null;
            this.BtnShifts.Iconimage_Selected = null;
            this.BtnShifts.IconMarginLeft = 0;
            this.BtnShifts.IconMarginRight = 0;
            this.BtnShifts.IconRightVisible = true;
            this.BtnShifts.IconRightZoom = 0D;
            this.BtnShifts.IconVisible = true;
            this.BtnShifts.IconZoom = 70D;
            this.BtnShifts.IsTab = false;
            this.BtnShifts.Location = new System.Drawing.Point(0, 41);
            this.BtnShifts.Name = "BtnShifts";
            this.BtnShifts.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnShifts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.BtnShifts.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnShifts.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.BtnShifts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnShifts.selected = false;
            this.BtnShifts.Size = new System.Drawing.Size(194, 41);
            this.BtnShifts.TabIndex = 5;
            this.BtnShifts.Text = "ادارة الفترات";
            this.BtnShifts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnShifts.Textcolor = System.Drawing.Color.White;
            this.BtnShifts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShifts.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // BtnClasses
            // 
            this.BtnClasses.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.BtnClasses.BackColor = System.Drawing.Color.Transparent;
            this.BtnClasses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClasses.BorderRadius = 0;
            this.BtnClasses.ButtonText = "ادارة الفصول";
            this.BtnClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClasses.DisabledColor = System.Drawing.Color.Gray;
            this.BtnClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClasses.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnClasses.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnClasses.Iconimage")));
            this.BtnClasses.Iconimage_right = null;
            this.BtnClasses.Iconimage_right_Selected = null;
            this.BtnClasses.Iconimage_Selected = null;
            this.BtnClasses.IconMarginLeft = 0;
            this.BtnClasses.IconMarginRight = 0;
            this.BtnClasses.IconRightVisible = true;
            this.BtnClasses.IconRightZoom = 0D;
            this.BtnClasses.IconVisible = true;
            this.BtnClasses.IconZoom = 70D;
            this.BtnClasses.IsTab = false;
            this.BtnClasses.Location = new System.Drawing.Point(0, 0);
            this.BtnClasses.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.BtnClasses.Name = "BtnClasses";
            this.BtnClasses.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnClasses.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.BtnClasses.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnClasses.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.BtnClasses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnClasses.selected = false;
            this.BtnClasses.Size = new System.Drawing.Size(194, 41);
            this.BtnClasses.TabIndex = 4;
            this.BtnClasses.Text = "ادارة الفصول";
            this.BtnClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnClasses.Textcolor = System.Drawing.Color.White;
            this.BtnClasses.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClasses.Click += new System.EventHandler(this.BtnClasses_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "الإدارة";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 5;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 70D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 425);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.bunifuFlatButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(194, 41);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Text = "الإدارة";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "التقارير";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 2;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 80D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 384);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(194, 41);
            this.bunifuFlatButton4.TabIndex = 3;
            this.bunifuFlatButton4.Text = "التقارير";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "طاقم العمل";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 5;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 343);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.bunifuFlatButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(194, 41);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "طاقم العمل";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // StudentsPanel
            // 
            this.StudentsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.StudentsPanel.Controls.Add(this.bunifuFlatButton7);
            this.StudentsPanel.Controls.Add(this.bunifuFlatButton5);
            this.StudentsPanel.Controls.Add(this.BtnAddStudent);
            this.StudentsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentsPanel.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsPanel.Location = new System.Drawing.Point(0, 212);
            this.StudentsPanel.Name = "StudentsPanel";
            this.StudentsPanel.Size = new System.Drawing.Size(194, 131);
            this.StudentsPanel.TabIndex = 6;
            this.StudentsPanel.Visible = false;
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "تسجيل حضور وغياب";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 70D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(0, 82);
            this.bunifuFlatButton7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.bunifuFlatButton7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(194, 41);
            this.bunifuFlatButton7.TabIndex = 8;
            this.bunifuFlatButton7.Text = "تسجيل حضور وغياب";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "ادارة بيانات الطلاب";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 70D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 41);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.bunifuFlatButton5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(194, 41);
            this.bunifuFlatButton5.TabIndex = 7;
            this.bunifuFlatButton5.Text = "ادارة بيانات الطلاب";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.BtnAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddStudent.BorderRadius = 0;
            this.BtnAddStudent.ButtonText = "تسجيل الطلاب";
            this.BtnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddStudent.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAddStudent.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAddStudent.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnAddStudent.Iconimage")));
            this.BtnAddStudent.Iconimage_right = null;
            this.BtnAddStudent.Iconimage_right_Selected = null;
            this.BtnAddStudent.Iconimage_Selected = null;
            this.BtnAddStudent.IconMarginLeft = 0;
            this.BtnAddStudent.IconMarginRight = 0;
            this.BtnAddStudent.IconRightVisible = true;
            this.BtnAddStudent.IconRightZoom = 0D;
            this.BtnAddStudent.IconVisible = true;
            this.BtnAddStudent.IconZoom = 70D;
            this.BtnAddStudent.IsTab = false;
            this.BtnAddStudent.Location = new System.Drawing.Point(0, 0);
            this.BtnAddStudent.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnAddStudent.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.BtnAddStudent.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAddStudent.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.BtnAddStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAddStudent.selected = false;
            this.BtnAddStudent.Size = new System.Drawing.Size(194, 41);
            this.BtnAddStudent.TabIndex = 6;
            this.BtnAddStudent.Text = "تسجيل الطلاب";
            this.BtnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddStudent.Textcolor = System.Drawing.Color.White;
            this.BtnAddStudent.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "الطلاب";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 5;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 171);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(127)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(194, 41);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "الطلاب";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // sideinfopanel
            // 
            this.sideinfopanel.Controls.Add(this.pictureBox1);
            this.sideinfopanel.Controls.Add(this.button3);
            this.sideinfopanel.Controls.Add(this.btnInfo);
            this.sideinfopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideinfopanel.Location = new System.Drawing.Point(0, 0);
            this.sideinfopanel.Name = "sideinfopanel";
            this.sideinfopanel.Size = new System.Drawing.Size(194, 171);
            this.sideinfopanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Aqua_AMS.Properties.Resources.Untitled_1;
            this.pictureBox1.InitialImage = global::Aqua_AMS.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Aqua_AMS.Properties.Resources.icons8_menu_rounded_96;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 36);
            this.button3.TabIndex = 6;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.btnInfo.color = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.btnInfo.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImagePosition = 20;
            this.btnInfo.ImageZoom = 50;
            this.btnInfo.LabelPosition = 41;
            this.btnInfo.LabelText = "Tile 1";
            this.btnInfo.Location = new System.Drawing.Point(0, 0);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(6);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(194, 171);
            this.btnInfo.TabIndex = 7;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.HeaderPanel.Controls.Add(this.BtnMinimize);
            this.HeaderPanel.Controls.Add(this.BtnNormalScreen);
            this.HeaderPanel.Controls.Add(this.BtnFullscreen);
            this.HeaderPanel.Controls.Add(this.BtnClose);
            this.HeaderPanel.Controls.Add(this.panel1);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(194, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(734, 36);
            this.HeaderPanel.TabIndex = 0;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.White;
            this.BtnMinimize.BackgroundImage = global::Aqua_AMS.Properties.Resources.icons8_minus_24__1_;
            this.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.Location = new System.Drawing.Point(613, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(25, 36);
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnMinimize.UseMnemonic = false;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnNormalScreen
            // 
            this.BtnNormalScreen.BackColor = System.Drawing.Color.White;
            this.BtnNormalScreen.BackgroundImage = global::Aqua_AMS.Properties.Resources.icons8_normal_screen_50__2_;
            this.BtnNormalScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNormalScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnNormalScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNormalScreen.ForeColor = System.Drawing.Color.White;
            this.BtnNormalScreen.Location = new System.Drawing.Point(638, 0);
            this.BtnNormalScreen.Name = "BtnNormalScreen";
            this.BtnNormalScreen.Size = new System.Drawing.Size(33, 36);
            this.BtnNormalScreen.TabIndex = 4;
            this.BtnNormalScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNormalScreen.UseMnemonic = false;
            this.BtnNormalScreen.UseVisualStyleBackColor = false;
            this.BtnNormalScreen.Visible = false;
            this.BtnNormalScreen.Click += new System.EventHandler(this.BtnNormalScreen_Click);
            // 
            // BtnFullscreen
            // 
            this.BtnFullscreen.BackColor = System.Drawing.Color.White;
            this.BtnFullscreen.BackgroundImage = global::Aqua_AMS.Properties.Resources.icons8_full_screen_24__1_;
            this.BtnFullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFullscreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFullscreen.ForeColor = System.Drawing.Color.White;
            this.BtnFullscreen.Location = new System.Drawing.Point(671, 0);
            this.BtnFullscreen.Name = "BtnFullscreen";
            this.BtnFullscreen.Size = new System.Drawing.Size(33, 36);
            this.BtnFullscreen.TabIndex = 4;
            this.BtnFullscreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnFullscreen.UseMnemonic = false;
            this.BtnFullscreen.UseVisualStyleBackColor = false;
            this.BtnFullscreen.Click += new System.EventHandler(this.BtnFullscreen_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.BackgroundImage = global::Aqua_AMS.Properties.Resources.icons8_close_window_26;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(704, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.BtnClose.Size = new System.Drawing.Size(30, 36);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnClose.UseMnemonic = false;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 36);
            this.panel1.TabIndex = 5;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(194, 508);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(734, 19);
            this.BottomPanel.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.sidepanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.HeaderPanel;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.pictureBox2);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(194, 36);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(734, 472);
            this.BodyPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Aqua_AMS.Properties.Resources.Untitled_12;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(734, 472);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 527);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFrm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFrm_KeyPress);
            this.sidepanel.ResumeLayout(false);
            this.AdminPanel.ResumeLayout(false);
            this.StudentsPanel.ResumeLayout(false);
            this.sideinfopanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel sideinfopanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnFullscreen;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnNormalScreen;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuTileButton btnInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BodyPanel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel AdminPanel;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGrades;
        private Bunifu.Framework.UI.BunifuFlatButton BtnShifts;
        private Bunifu.Framework.UI.BunifuFlatButton BtnClasses;
        private System.Windows.Forms.Panel StudentsPanel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAddStudent;
    }
}