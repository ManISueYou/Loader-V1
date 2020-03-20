namespace Loader
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.logbutton = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.regbutton = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.labeltoken = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtUser.Location = new System.Drawing.Point(193, 34);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(254, 20);
            this.txtUser.TabIndex = 3;
            // 
            // logbutton
            // 
            this.logbutton.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbutton.ForeColor = System.Drawing.Color.Black;
            this.logbutton.Location = new System.Drawing.Point(475, 131);
            this.logbutton.Name = "logbutton";
            this.logbutton.Size = new System.Drawing.Size(129, 64);
            this.logbutton.TabIndex = 4;
            this.logbutton.Text = "Login";
            this.logbutton.UseVisualStyleBackColor = true;
            this.logbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtPass.Location = new System.Drawing.Point(193, 85);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(254, 20);
            this.txtPass.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(135, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(372, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // regbutton
            // 
            this.regbutton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbutton.Location = new System.Drawing.Point(475, 130);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(129, 65);
            this.regbutton.TabIndex = 9;
            this.regbutton.Text = "Register";
            this.regbutton.UseVisualStyleBackColor = true;
            this.regbutton.Visible = false;
            this.regbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(193, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 20);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Visible = false;
            // 
            // txtToken
            // 
            this.txtToken.BackColor = System.Drawing.SystemColors.Window;
            this.txtToken.Location = new System.Drawing.Point(193, 149);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(254, 20);
            this.txtToken.TabIndex = 11;
            this.txtToken.Visible = false;
            this.txtToken.TextChanged += new System.EventHandler(this.txtToken_TextChanged);
            // 
            // labeltoken
            // 
            this.labeltoken.AutoSize = true;
            this.labeltoken.ForeColor = System.Drawing.Color.White;
            this.labeltoken.Location = new System.Drawing.Point(67, 152);
            this.labeltoken.Name = "labeltoken";
            this.labeltoken.Size = new System.Drawing.Size(38, 13);
            this.labeltoken.TabIndex = 12;
            this.labeltoken.Text = "Token";
            this.labeltoken.Visible = false;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.ForeColor = System.Drawing.Color.White;
            this.labelemail.Location = new System.Drawing.Point(69, 130);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(32, 13);
            this.labelemail.TabIndex = 13;
            this.labelemail.Text = "Email";
            this.labelemail.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(616, 200);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labeltoken);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.regbutton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.logbutton);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Loader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button logbutton;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button regbutton;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label labeltoken;
        private System.Windows.Forms.Label labelemail;
    }
}

