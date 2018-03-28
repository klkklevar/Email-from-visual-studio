namespace Email_from__c_sharp
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.smtp = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Smtp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Message:";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(132, 27);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(100, 20);
            this.from.TabIndex = 7;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(132, 53);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(100, 20);
            this.to.TabIndex = 8;
            // 
            // smtp
            // 
            this.smtp.Location = new System.Drawing.Point(132, 82);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(100, 20);
            this.smtp.TabIndex = 9;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(132, 112);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 10;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(132, 136);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 11;
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(132, 165);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(100, 20);
            this.subject.TabIndex = 12;
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(39, 209);
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(226, 69);
            this.body.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Subject:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.body);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.smtp);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox smtp;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;

        public System.EventHandler label6_Click { get; set; }
    }
}

