namespace SCD_LAB_W14.Admin
{
    partial class AdminMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_newstype = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_addNewsType = new System.Windows.Forms.TextBox();
            this.txt_newsdetails = new System.Windows.Forms.RichTextBox();
            this.btn_postNews = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_addNewsType = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(169, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Trending News";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "News Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "News Detail:";
            // 
            // cb_newstype
            // 
            this.cb_newstype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_newstype.FormattingEnabled = true;
            this.cb_newstype.Location = new System.Drawing.Point(196, 132);
            this.cb_newstype.Name = "cb_newstype";
            this.cb_newstype.Size = new System.Drawing.Size(351, 36);
            this.cb_newstype.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(605, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(334, 590);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(672, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "Add News Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(717, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "News Type:";
            // 
            // txt_addNewsType
            // 
            this.txt_addNewsType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_addNewsType.Location = new System.Drawing.Point(672, 153);
            this.txt_addNewsType.Name = "txt_addNewsType";
            this.txt_addNewsType.Size = new System.Drawing.Size(220, 34);
            this.txt_addNewsType.TabIndex = 7;
            // 
            // txt_newsdetails
            // 
            this.txt_newsdetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_newsdetails.Location = new System.Drawing.Point(196, 197);
            this.txt_newsdetails.Name = "txt_newsdetails";
            this.txt_newsdetails.Size = new System.Drawing.Size(351, 249);
            this.txt_newsdetails.TabIndex = 8;
            this.txt_newsdetails.Text = "";
            // 
            // btn_postNews
            // 
            this.btn_postNews.Location = new System.Drawing.Point(207, 488);
            this.btn_postNews.Name = "btn_postNews";
            this.btn_postNews.Size = new System.Drawing.Size(98, 48);
            this.btn_postNews.TabIndex = 9;
            this.btn_postNews.Text = "Post";
            this.btn_postNews.UseVisualStyleBackColor = true;
            this.btn_postNews.Click += new System.EventHandler(this.btn_postNews_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(429, 488);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 48);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_addNewsType
            // 
            this.btn_addNewsType.Location = new System.Drawing.Point(729, 209);
            this.btn_addNewsType.Name = "btn_addNewsType";
            this.btn_addNewsType.Size = new System.Drawing.Size(98, 48);
            this.btn_addNewsType.TabIndex = 11;
            this.btn_addNewsType.Text = "Add";
            this.btn_addNewsType.UseVisualStyleBackColor = true;
            this.btn_addNewsType.Click += new System.EventHandler(this.btn_addNewsType_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(662, 510);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(242, 48);
            this.btn_logout.TabIndex = 23;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 590);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_addNewsType);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_postNews);
            this.Controls.Add(this.txt_newsdetails);
            this.Controls.Add(this.txt_addNewsType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.cb_newstype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminMainForm";
            this.Text = "Admin Main";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cb_newstype;
        private Splitter splitter1;
        private Label label4;
        private Label label5;
        private TextBox txt_addNewsType;
        private RichTextBox txt_newsdetails;
        private Button btn_postNews;
        private Button btn_cancel;
        private Button btn_addNewsType;
        private Button btn_logout;
    }
}