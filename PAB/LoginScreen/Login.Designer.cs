namespace PAB
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new ReaLTaiizor.Controls.PoisonTextBox();
            this.txtPassword = new ReaLTaiizor.Controls.PoisonTextBox();
            this.bntLogin = new ReaLTaiizor.Controls.PoisonButton();
            this.metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(208, 2);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtId.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(151, 126);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(234, 28);
            this.txtId.TabIndex = 0;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(208, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPassword.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(151, 188);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(234, 28);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bntLogin
            // 
            this.bntLogin.Location = new System.Drawing.Point(202, 252);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(75, 23);
            this.bntLogin.TabIndex = 2;
            this.bntLogin.Text = "Log in";
            this.bntLogin.UseSelectable = true;
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // metroControlBox1
            // 
            this.metroControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            this.metroControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroControlBox1.ForeColor = System.Drawing.Color.White;
            this.metroControlBox1.IsDerivedStyle = true;
            this.metroControlBox1.Location = new System.Drawing.Point(456, 4);
            this.metroControlBox1.MaximizeBox = true;
            this.metroControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MinimizeBox = true;
            this.metroControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.Name = "metroControlBox1";
            this.metroControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroControlBox1.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            this.metroControlBox1.StyleManager = null;
            this.metroControlBox1.TabIndex = 3;
            this.metroControlBox1.Text = "metroControlBox1";
            this.metroControlBox1.ThemeAuthor = "Taiizor";
            this.metroControlBox1.ThemeName = "MetroDark";
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.poisonLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.poisonLabel1.Location = new System.Drawing.Point(256, 104);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(21, 19);
            this.poisonLabel1.TabIndex = 4;
            this.poisonLabel1.Text = "ID";
            this.poisonLabel1.UseCustomBackColor = true;
            this.poisonLabel1.UseCustomForeColor = true;
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.poisonLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.poisonLabel2.Location = new System.Drawing.Point(236, 166);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(41, 19);
            this.poisonLabel2.TabIndex = 5;
            this.poisonLabel2.Text = "Hasło";
            this.poisonLabel2.UseCustomBackColor = true;
            this.poisonLabel2.UseCustomForeColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(560, 338);
            this.Controls.Add(this.poisonLabel2);
            this.Controls.Add(this.poisonLabel1);
            this.Controls.Add(this.metroControlBox1);
            this.Controls.Add(this.bntLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(14, 60, 14, 15);
            this.Text = "Panel logowania";
            this.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonTextBox txtId;
        private ReaLTaiizor.Controls.PoisonTextBox txtPassword;
        private ReaLTaiizor.Controls.PoisonButton bntLogin;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
    }
}