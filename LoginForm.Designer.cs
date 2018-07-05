namespace StegProject
{
    partial class LoginForm
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
            this.welcome_button = new System.Windows.Forms.Button();
            this.focus_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.exit_linkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // welcome_button
            // 
            this.welcome_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.welcome_button.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.welcome_button.Font = new System.Drawing.Font("Kunstler Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_button.ForeColor = System.Drawing.Color.White;
            this.welcome_button.Location = new System.Drawing.Point(48, 343);
            this.welcome_button.Name = "welcome_button";
            this.welcome_button.Size = new System.Drawing.Size(158, 30);
            this.welcome_button.TabIndex = 0;
            this.welcome_button.Text = "ВОЙТИ";
            this.welcome_button.UseVisualStyleBackColor = false;
            this.welcome_button.Click += new System.EventHandler(this.welcome_button_Click);
            // 
            // focus_textBox
            // 
            this.focus_textBox.Location = new System.Drawing.Point(31, -22);
            this.focus_textBox.Name = "focus_textBox";
            this.focus_textBox.Size = new System.Drawing.Size(100, 20);
            this.focus_textBox.TabIndex = 1;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Location = new System.Drawing.Point(48, 290);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(158, 19);
            this.password_textBox.TabIndex = 2;
            this.password_textBox.Text = "Введите пароль";
            this.password_textBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.password_textBox.Enter += new System.EventHandler(this.richTextBox1_Enter);
            this.password_textBox.Leave += new System.EventHandler(this.richTextBox1_Leave);
            // 
            // exit_linkLabel
            // 
            this.exit_linkLabel.ActiveLinkColor = System.Drawing.Color.Black;
            this.exit_linkLabel.AutoSize = true;
            this.exit_linkLabel.DisabledLinkColor = System.Drawing.Color.Black;
            this.exit_linkLabel.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_linkLabel.LinkColor = System.Drawing.Color.Black;
            this.exit_linkLabel.Location = new System.Drawing.Point(193, 9);
            this.exit_linkLabel.Name = "exit_linkLabel";
            this.exit_linkLabel.Size = new System.Drawing.Size(45, 16);
            this.exit_linkLabel.TabIndex = 3;
            this.exit_linkLabel.TabStop = true;
            this.exit_linkLabel.Text = "Выйти";
            this.exit_linkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.exit_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exit_linkLabel_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::StegProject.Properties.Resources.lck;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(250, 431);
            this.Controls.Add(this.exit_linkLabel);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.focus_textBox);
            this.Controls.Add(this.welcome_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button welcome_button;
        private System.Windows.Forms.TextBox focus_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.LinkLabel exit_linkLabel;
    }
}