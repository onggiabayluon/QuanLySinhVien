﻿
namespace QuanLySinhVien
{
    partial class fDangKyHocPhan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCaNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuâtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchDKHP = new System.Windows.Forms.Button();
            this.txtSearchDKHP = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lvDKHP = new System.Windows.Forms.ListView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDangKyDKHP = new System.Windows.Forms.Button();
            this.btnHuyDangKyDKHP = new System.Windows.Forms.Button();
            this.dtgvDKHP = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDKHP)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTaiKhoanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTaiKhoanToolStripMenuItem
            // 
            this.thôngTinTaiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCaNhânToolStripMenuItem,
            this.đăngXuâtToolStripMenuItem});
            this.thôngTinTaiKhoanToolStripMenuItem.Name = "thôngTinTaiKhoanToolStripMenuItem";
            this.thôngTinTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCaNhânToolStripMenuItem
            // 
            this.thôngTinCaNhânToolStripMenuItem.Name = "thôngTinCaNhânToolStripMenuItem";
            this.thôngTinCaNhânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinCaNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCaNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCaNhânToolStripMenuItem_Click);
            // 
            // đăngXuâtToolStripMenuItem
            // 
            this.đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            this.đăngXuâtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuâtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 27);
            this.panel1.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(4, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(373, 21);
            this.cbCategory.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchDKHP);
            this.panel2.Controls.Add(this.txtSearchDKHP);
            this.panel2.Location = new System.Drawing.Point(398, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 27);
            this.panel2.TabIndex = 3;
            // 
            // btnSearchDKHP
            // 
            this.btnSearchDKHP.Location = new System.Drawing.Point(206, 4);
            this.btnSearchDKHP.Name = "btnSearchDKHP";
            this.btnSearchDKHP.Size = new System.Drawing.Size(75, 20);
            this.btnSearchDKHP.TabIndex = 1;
            this.btnSearchDKHP.Text = "Tìm Kiếm";
            this.btnSearchDKHP.UseVisualStyleBackColor = true;
            // 
            // txtSearchDKHP
            // 
            this.txtSearchDKHP.Location = new System.Drawing.Point(4, 4);
            this.txtSearchDKHP.Name = "txtSearchDKHP";
            this.txtSearchDKHP.Size = new System.Drawing.Size(196, 20);
            this.txtSearchDKHP.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvDKHP);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 332);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Môn Học";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lvDKHP);
            this.panel4.Location = new System.Drawing.Point(398, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 277);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn đã đăng ký";
            // 
            // lvDKHP
            // 
            this.lvDKHP.HideSelection = false;
            this.lvDKHP.Location = new System.Drawing.Point(0, 24);
            this.lvDKHP.Name = "lvDKHP";
            this.lvDKHP.Size = new System.Drawing.Size(286, 254);
            this.lvDKHP.TabIndex = 0;
            this.lvDKHP.UseCompatibleStateImageBehavior = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnHuyDangKyDKHP);
            this.panel5.Controls.Add(this.btnDangKyDKHP);
            this.panel5.Location = new System.Drawing.Point(399, 346);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 47);
            this.panel5.TabIndex = 6;
            // 
            // btnDangKyDKHP
            // 
            this.btnDangKyDKHP.Location = new System.Drawing.Point(205, 4);
            this.btnDangKyDKHP.Name = "btnDangKyDKHP";
            this.btnDangKyDKHP.Size = new System.Drawing.Size(75, 40);
            this.btnDangKyDKHP.TabIndex = 0;
            this.btnDangKyDKHP.Text = "Đăng ký";
            this.btnDangKyDKHP.UseVisualStyleBackColor = true;
            // 
            // btnHuyDangKyDKHP
            // 
            this.btnHuyDangKyDKHP.Location = new System.Drawing.Point(124, 4);
            this.btnHuyDangKyDKHP.Name = "btnHuyDangKyDKHP";
            this.btnHuyDangKyDKHP.Size = new System.Drawing.Size(75, 40);
            this.btnHuyDangKyDKHP.TabIndex = 0;
            this.btnHuyDangKyDKHP.Text = "Hủy đăng ký";
            this.btnHuyDangKyDKHP.UseVisualStyleBackColor = true;
            // 
            // dtgvDKHP
            // 
            this.dtgvDKHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDKHP.Location = new System.Drawing.Point(0, 24);
            this.dtgvDKHP.Name = "dtgvDKHP";
            this.dtgvDKHP.Size = new System.Drawing.Size(377, 305);
            this.dtgvDKHP.TabIndex = 2;
            // 
            // fDangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 416);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fDangKyHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký Học Phần";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDKHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCaNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchDKHP;
        private System.Windows.Forms.TextBox txtSearchDKHP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lvDKHP;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDangKyDKHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuyDangKyDKHP;
        private System.Windows.Forms.DataGridView dtgvDKHP;
    }
}