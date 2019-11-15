namespace Aqua_AMS.View
{
    partial class GradesUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradesUC));
            this.datagrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnAddGrade = new Bunifu.Framework.UI.BunifuTileButton();
            this.txtsearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid1
            // 
            this.datagrid1.AllowUserToAddRows = false;
            this.datagrid1.AllowUserToDeleteRows = false;
            this.datagrid1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.ID,
            this.ClassName,
            this.sellprice,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = "(Empty)";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.datagrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid1.DoubleBuffered = true;
            this.datagrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagrid1.EnableHeadersVisualStyles = false;
            this.datagrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.datagrid1.HeaderForeColor = System.Drawing.Color.White;
            this.datagrid1.Location = new System.Drawing.Point(0, 167);
            this.datagrid1.MultiSelect = false;
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.ReadOnly = true;
            this.datagrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagrid1.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.datagrid1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.datagrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid1.ShowCellErrors = false;
            this.datagrid1.ShowCellToolTips = false;
            this.datagrid1.ShowEditingIcon = false;
            this.datagrid1.ShowRowErrors = false;
            this.datagrid1.Size = new System.Drawing.Size(791, 264);
            this.datagrid1.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.FillWeight = 10.40239F;
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClassName.FillWeight = 64.3569F;
            this.ClassName.HeaderText = "الفئة";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sellprice
            // 
            this.sellprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellprice.FillWeight = 20.86623F;
            this.sellprice.HeaderText = "عدد الطلاب";
            this.sellprice.MinimumWidth = 20;
            this.sellprice.Name = "sellprice";
            this.sellprice.ReadOnly = true;
            this.sellprice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edit.FillWeight = 8.321911F;
            this.Edit.HeaderText = "";
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.DataPropertyName = "qua_POS.Properties.Resources.icons8_delete_16";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "qua_POS.Properties.Resources.icons8_delete_16";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.Delete.FillWeight = 8.321911F;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagrid1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 431);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnAddGrade);
            this.panel3.Controls.Add(this.txtsearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 167);
            this.panel3.TabIndex = 0;
            // 
            // BtnAddGrade
            // 
            this.BtnAddGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddGrade.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddGrade.color = System.Drawing.Color.Transparent;
            this.BtnAddGrade.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.BtnAddGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddGrade.Font = new System.Drawing.Font("Lato Black", 15.75F);
            this.BtnAddGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.BtnAddGrade.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddGrade.Image")));
            this.BtnAddGrade.ImagePosition = 5;
            this.BtnAddGrade.ImageZoom = 50;
            this.BtnAddGrade.LabelPosition = 30;
            this.BtnAddGrade.LabelText = "إضافة فئة";
            this.BtnAddGrade.Location = new System.Drawing.Point(680, 4);
            this.BtnAddGrade.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAddGrade.Name = "BtnAddGrade";
            this.BtnAddGrade.Size = new System.Drawing.Size(105, 88);
            this.BtnAddGrade.TabIndex = 3;
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.Font = new System.Drawing.Font("Lato Black", 10F, System.Drawing.FontStyle.Bold);
            this.txtsearch.ForeColor = System.Drawing.Color.White;
            this.txtsearch.HintForeColor = System.Drawing.Color.Silver;
            this.txtsearch.HintText = "بحث";
            this.txtsearch.isPassword = false;
            this.txtsearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtsearch.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.txtsearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtsearch.LineThickness = 3;
            this.txtsearch.Location = new System.Drawing.Point(563, 113);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(224, 33);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 33);
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
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "الفئات التعليمية";
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
            this.BtnClose.Location = new System.Drawing.Point(761, 0);
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
            // GradesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "GradesUC";
            this.Size = new System.Drawing.Size(791, 464);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid datagrid1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuTileButton BtnAddGrade;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellprice;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
