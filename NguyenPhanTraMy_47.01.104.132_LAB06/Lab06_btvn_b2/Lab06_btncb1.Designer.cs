namespace Lab06_btvn_b2
{
    partial class Lab06_btncb1
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
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHọcViênMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnSangLớpAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnSangLớpBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHọcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtThúcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grA = new System.Windows.Forms.GroupBox();
            this.ls_A = new System.Windows.Forms.ListBox();
            this.grB = new System.Windows.Forms.GroupBox();
            this.ls_B = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.grA.SuspendLayout();
            this.grB.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtToolStripMenuItem,
            this.kếtThúcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpHọcViênMớiToolStripMenuItem,
            this.chuyểnSangLớpAToolStripMenuItem,
            this.chuyểnSangLớpBToolStripMenuItem,
            this.xóaHọcViênToolStripMenuItem});
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            // 
            // nhậpHọcViênMớiToolStripMenuItem
            // 
            this.nhậpHọcViênMớiToolStripMenuItem.Name = "nhậpHọcViênMớiToolStripMenuItem";
            this.nhậpHọcViênMớiToolStripMenuItem.Size = new System.Drawing.Size(278, 32);
            this.nhậpHọcViênMớiToolStripMenuItem.Text = "Nhập học viên mới";
            this.nhậpHọcViênMớiToolStripMenuItem.Click += new System.EventHandler(this.nhậpHọcViênMớiToolStripMenuItem_Click);
            // 
            // chuyểnSangLớpAToolStripMenuItem
            // 
            this.chuyểnSangLớpAToolStripMenuItem.Name = "chuyểnSangLớpAToolStripMenuItem";
            this.chuyểnSangLớpAToolStripMenuItem.Size = new System.Drawing.Size(278, 32);
            this.chuyểnSangLớpAToolStripMenuItem.Text = "Chuyển sang lớp B";
            this.chuyểnSangLớpAToolStripMenuItem.Click += new System.EventHandler(this.chuyểnSangLớpAToolStripMenuItem_Click);
            // 
            // chuyểnSangLớpBToolStripMenuItem
            // 
            this.chuyểnSangLớpBToolStripMenuItem.Name = "chuyểnSangLớpBToolStripMenuItem";
            this.chuyểnSangLớpBToolStripMenuItem.Size = new System.Drawing.Size(278, 32);
            this.chuyểnSangLớpBToolStripMenuItem.Text = "Chuyển sang lớp A";
            this.chuyểnSangLớpBToolStripMenuItem.Click += new System.EventHandler(this.chuyểnSangLớpBToolStripMenuItem_Click);
            // 
            // xóaHọcViênToolStripMenuItem
            // 
            this.xóaHọcViênToolStripMenuItem.Name = "xóaHọcViênToolStripMenuItem";
            this.xóaHọcViênToolStripMenuItem.Size = new System.Drawing.Size(278, 32);
            this.xóaHọcViênToolStripMenuItem.Text = "Xóa học viên";
            this.xóaHọcViênToolStripMenuItem.Click += new System.EventHandler(this.xóaHọcViênToolStripMenuItem_Click);
            // 
            // kếtThúcToolStripMenuItem
            // 
            this.kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            this.kếtThúcToolStripMenuItem.Size = new System.Drawing.Size(106, 32);
            this.kếtThúcToolStripMenuItem.Text = "Kết thúc";
            this.kếtThúcToolStripMenuItem.Click += new System.EventHandler(this.kếtThúcToolStripMenuItem_Click);
            // 
            // grA
            // 
            this.grA.Controls.Add(this.ls_A);
            this.grA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grA.Location = new System.Drawing.Point(47, 76);
            this.grA.Name = "grA";
            this.grA.Size = new System.Drawing.Size(236, 246);
            this.grA.TabIndex = 1;
            this.grA.TabStop = false;
            this.grA.Text = "Lớp A";
            // 
            // ls_A
            // 
            this.ls_A.FormattingEnabled = true;
            this.ls_A.ItemHeight = 25;
            this.ls_A.Location = new System.Drawing.Point(6, 24);
            this.ls_A.Name = "ls_A";
            this.ls_A.Size = new System.Drawing.Size(224, 204);
            this.ls_A.TabIndex = 0;
            // 
            // grB
            // 
            this.grB.Controls.Add(this.ls_B);
            this.grB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grB.Location = new System.Drawing.Point(311, 76);
            this.grB.Name = "grB";
            this.grB.Size = new System.Drawing.Size(236, 246);
            this.grB.TabIndex = 2;
            this.grB.TabStop = false;
            this.grB.Text = "Lớp B";
            // 
            // ls_B
            // 
            this.ls_B.FormattingEnabled = true;
            this.ls_B.ItemHeight = 25;
            this.ls_B.Location = new System.Drawing.Point(6, 24);
            this.ls_B.Name = "ls_B";
            this.ls_B.Size = new System.Drawing.Size(224, 204);
            this.ls_B.TabIndex = 0;
            // 
            // Lab06_btncb1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 370);
            this.Controls.Add(this.grB);
            this.Controls.Add(this.grA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab06_btncb1";
            this.Text = "Quản lí học viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lab06_btncb1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grA.ResumeLayout(false);
            this.grB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtThúcToolStripMenuItem;
        private System.Windows.Forms.GroupBox grA;
        private System.Windows.Forms.ListBox ls_A;
        private System.Windows.Forms.GroupBox grB;
        private System.Windows.Forms.ListBox ls_B;
        private System.Windows.Forms.ToolStripMenuItem nhậpHọcViênMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnSangLớpAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnSangLớpBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHọcViênToolStripMenuItem;
    }
}