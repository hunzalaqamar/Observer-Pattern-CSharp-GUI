namespace SCD_LAB_W14
{
    partial class UserMainForm
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_addNewsType = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_newstype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_subtopics = new System.Windows.Forms.ListView();
            this.rtb_headlines = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(690, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(334, 629);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // btn_addNewsType
            // 
            this.btn_addNewsType.Location = new System.Drawing.Point(814, 162);
            this.btn_addNewsType.Name = "btn_addNewsType";
            this.btn_addNewsType.Size = new System.Drawing.Size(98, 48);
            this.btn_addNewsType.TabIndex = 15;
            this.btn_addNewsType.Text = "Subscribe";
            this.btn_addNewsType.UseVisualStyleBackColor = true;
            this.btn_addNewsType.Click += new System.EventHandler(this.btn_addNewsType_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(729, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "Subscribe to Topics";
            // 
            // cb_newstype
            // 
            this.cb_newstype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_newstype.FormattingEnabled = true;
            this.cb_newstype.Location = new System.Drawing.Point(729, 103);
            this.cb_newstype.Name = "cb_newstype";
            this.cb_newstype.Size = new System.Drawing.Size(267, 36);
            this.cb_newstype.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(739, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Subscribed Topics";
            // 
            // lv_subtopics
            // 
            this.lv_subtopics.Location = new System.Drawing.Point(711, 315);
            this.lv_subtopics.Name = "lv_subtopics";
            this.lv_subtopics.Size = new System.Drawing.Size(301, 212);
            this.lv_subtopics.TabIndex = 18;
            this.lv_subtopics.UseCompatibleStateImageBehavior = false;
            this.lv_subtopics.View = System.Windows.Forms.View.Tile;
            this.lv_subtopics.DoubleClick += new System.EventHandler(this.lv_subtopics_DoubleClick);
            // 
            // rtb_headlines
            // 
            this.rtb_headlines.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_headlines.Location = new System.Drawing.Point(12, 63);
            this.rtb_headlines.Name = "rtb_headlines";
            this.rtb_headlines.ReadOnly = true;
            this.rtb_headlines.Size = new System.Drawing.Size(664, 554);
            this.rtb_headlines.TabIndex = 19;
            this.rtb_headlines.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(263, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 38);
            this.label2.TabIndex = 20;
            this.label2.Text = "Headlines";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(694, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Double Click to unsubcribe any topic";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(745, 559);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(242, 48);
            this.btn_logout.TabIndex = 22;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(521, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 23;
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 629);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_headlines);
            this.Controls.Add(this.lv_subtopics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_newstype);
            this.Controls.Add(this.btn_addNewsType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitter1);
            this.Name = "UserMainForm";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Splitter splitter1;
        private Button btn_addNewsType;
        private Label label4;
        private ComboBox cb_newstype;
        private Label label1;
        private ListView lv_subtopics;
        private RichTextBox rtb_headlines;
        private Label label2;
        private Label label3;
        private Button btn_logout;
        private Label label5;
    }
}