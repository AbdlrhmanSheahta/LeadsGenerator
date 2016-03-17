namespace Leads_Generator
{
    partial class ReportCriteriaForm
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
            this.closeBar1 = new Tools.Close_Bar.CloseBar();
            this.chkbxlst = new System.Windows.Forms.CheckedListBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.closeBar1.TLP_MAIN.SuspendLayout();
            this.closeBar1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBar1
            // 
            this.closeBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            // 
            // closeBar1.BTN_CLOSE
            // 
            this.closeBar1.BTN_CLOSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBar1.BTN_CLOSE.FlatAppearance.BorderSize = 0;
            this.closeBar1.BTN_CLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBar1.BTN_CLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeBar1.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBar1.BTN_CLOSE.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBar1.BTN_CLOSE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeBar1.BTN_CLOSE.Location = new System.Drawing.Point(277, 0);
            this.closeBar1.BTN_CLOSE.Margin = new System.Windows.Forms.Padding(0);
            this.closeBar1.BTN_CLOSE.Name = "BTN_CLOSE";
            this.closeBar1.BTN_CLOSE.Size = new System.Drawing.Size(34, 43);
            this.closeBar1.BTN_CLOSE.TabIndex = 2;
            this.closeBar1.BTN_CLOSE.TabStop = false;
            this.closeBar1.BTN_CLOSE.Text = "x";
            this.closeBar1.BTN_CLOSE.UseVisualStyleBackColor = true;
            // 
            // closeBar1.BTN_MAX
            // 
            this.closeBar1.BTN_MAX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBar1.BTN_MAX.FlatAppearance.BorderSize = 0;
            this.closeBar1.BTN_MAX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.closeBar1.BTN_MAX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.closeBar1.BTN_MAX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBar1.BTN_MAX.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBar1.BTN_MAX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeBar1.BTN_MAX.Location = new System.Drawing.Point(243, 0);
            this.closeBar1.BTN_MAX.Margin = new System.Windows.Forms.Padding(0);
            this.closeBar1.BTN_MAX.Name = "BTN_MAX";
            this.closeBar1.BTN_MAX.Size = new System.Drawing.Size(34, 43);
            this.closeBar1.BTN_MAX.TabIndex = 1;
            this.closeBar1.BTN_MAX.TabStop = false;
            this.closeBar1.BTN_MAX.Text = "□";
            this.closeBar1.BTN_MAX.UseVisualStyleBackColor = true;
            // 
            // closeBar1.BTN_MIN
            // 
            this.closeBar1.BTN_MIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBar1.BTN_MIN.FlatAppearance.BorderSize = 0;
            this.closeBar1.BTN_MIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.closeBar1.BTN_MIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.closeBar1.BTN_MIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBar1.BTN_MIN.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBar1.BTN_MIN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeBar1.BTN_MIN.Location = new System.Drawing.Point(209, 0);
            this.closeBar1.BTN_MIN.Margin = new System.Windows.Forms.Padding(0);
            this.closeBar1.BTN_MIN.Name = "BTN_MIN";
            this.closeBar1.BTN_MIN.Size = new System.Drawing.Size(34, 43);
            this.closeBar1.BTN_MIN.TabIndex = 0;
            this.closeBar1.BTN_MIN.TabStop = false;
            this.closeBar1.BTN_MIN.Text = "_";
            this.closeBar1.BTN_MIN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeBar1.BTN_MIN.UseVisualStyleBackColor = true;
            this.closeBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.closeBar1.IMG_SIZE = 0F;
            // 
            // closeBar1.LBL_IMG
            // 
            this.closeBar1.LBL_IMG.AutoSize = true;
            this.closeBar1.LBL_IMG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBar1.LBL_IMG.Location = new System.Drawing.Point(3, 3);
            this.closeBar1.LBL_IMG.Margin = new System.Windows.Forms.Padding(3);
            this.closeBar1.LBL_IMG.Name = "LBL_IMG";
            this.closeBar1.LBL_IMG.Size = new System.Drawing.Size(1, 37);
            this.closeBar1.LBL_IMG.TabIndex = 4;
            // 
            // closeBar1.LBL_TITLE
            // 
            this.closeBar1.LBL_TITLE.AutoSize = true;
            this.closeBar1.LBL_TITLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.closeBar1.LBL_TITLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBar1.LBL_TITLE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBar1.LBL_TITLE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeBar1.LBL_TITLE.Location = new System.Drawing.Point(3, 3);
            this.closeBar1.LBL_TITLE.Margin = new System.Windows.Forms.Padding(3);
            this.closeBar1.LBL_TITLE.Name = "LBL_TITLE";
            this.closeBar1.LBL_TITLE.Size = new System.Drawing.Size(203, 37);
            this.closeBar1.LBL_TITLE.TabIndex = 3;
            this.closeBar1.LBL_TITLE.Text = "Report Criteria";
            this.closeBar1.LBL_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBar1.Location = new System.Drawing.Point(0, 0);
            this.closeBar1.Name = "closeBar1";
            this.closeBar1.Size = new System.Drawing.Size(311, 43);
            this.closeBar1.TabIndex = 0;
            // 
            // closeBar1.TLP_MAIN
            // 
            this.closeBar1.TLP_MAIN.ColumnCount = 5;
            this.closeBar1.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.closeBar1.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.closeBar1.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.closeBar1.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.closeBar1.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.closeBar1.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.closeBar1.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.closeBar1.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.closeBar1.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.closeBar1.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.closeBar1.TLP_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBar1.TLP_MAIN.Location = new System.Drawing.Point(0, 0);
            this.closeBar1.TLP_MAIN.Name = "TLP_MAIN";
            this.closeBar1.TLP_MAIN.RowCount = 1;
            this.closeBar1.TLP_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.closeBar1.TLP_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.closeBar1.TLP_MAIN.Size = new System.Drawing.Size(311, 43);
            this.closeBar1.TLP_MAIN.TabIndex = 0;
            // 
            // chkbxlst
            // 
            this.chkbxlst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkbxlst.CheckOnClick = true;
            this.chkbxlst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkbxlst.FormattingEnabled = true;
            this.chkbxlst.Location = new System.Drawing.Point(3, 3);
            this.chkbxlst.Name = "chkbxlst";
            this.chkbxlst.Size = new System.Drawing.Size(305, 150);
            this.chkbxlst.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.chkbxlst);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 94);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(3);
            this.panel.Size = new System.Drawing.Size(311, 156);
            this.panel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btn_confirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 51);
            this.panel1.TabIndex = 3;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_confirm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.Orange;
            this.btn_confirm.Location = new System.Drawing.Point(0, 0);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(90, 51);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // ReportCriteriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 250);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeBar1);
            this.Name = "ReportCriteriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportCriteriaForm";
            this.Load += new System.EventHandler(this.ReportCriteriaForm_Load);
            this.closeBar1.TLP_MAIN.ResumeLayout(false);
            this.closeBar1.TLP_MAIN.PerformLayout();
            this.closeBar1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Tools.Close_Bar.CloseBar closeBar1;
        private System.Windows.Forms.CheckedListBox chkbxlst;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_confirm;
    }
}