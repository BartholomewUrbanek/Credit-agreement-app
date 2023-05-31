namespace PAB.MainWindow
{
    partial class GeneralMenu
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvDokumentacja = new ReaLTaiizor.Controls.PoisonListView();
            this.btnZakonczone = new ReaLTaiizor.Controls.PoisonButton();
            this.btnWTrakcie = new ReaLTaiizor.Controls.PoisonButton();
            this.btnOczekujace = new ReaLTaiizor.Controls.PoisonButton();
            this.tbcDocumentation = new ReaLTaiizor.Controls.MetroTabControl();
            this.tabPage1.SuspendLayout();
            this.tbcDocumentation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(962, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Raportowanie";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(962, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Klienci";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.tabPage1.Controls.Add(this.lvDokumentacja);
            this.tabPage1.Controls.Add(this.btnZakonczone);
            this.tabPage1.Controls.Add(this.btnWTrakcie);
            this.tabPage1.Controls.Add(this.btnOczekujace);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(962, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dokumentacja";
            // 
            // lvDokumentacja
            // 
            this.lvDokumentacja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvDokumentacja.FullRowSelect = true;
            this.lvDokumentacja.HideSelection = true;
            this.lvDokumentacja.Location = new System.Drawing.Point(187, 30);
            this.lvDokumentacja.Name = "lvDokumentacja";
            this.lvDokumentacja.OwnerDraw = true;
            this.lvDokumentacja.Size = new System.Drawing.Size(758, 455);
            this.lvDokumentacja.TabIndex = 3;
            this.lvDokumentacja.UseCompatibleStateImageBehavior = false;
            this.lvDokumentacja.UseCustomBackColor = true;
            this.lvDokumentacja.UseSelectable = true;
            // 
            // btnZakonczone
            // 
            this.btnZakonczone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnZakonczone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnZakonczone.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.btnZakonczone.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnZakonczone.Location = new System.Drawing.Point(26, 210);
            this.btnZakonczone.Name = "btnZakonczone";
            this.btnZakonczone.Size = new System.Drawing.Size(138, 48);
            this.btnZakonczone.TabIndex = 2;
            this.btnZakonczone.Text = "Zakończone";
            this.btnZakonczone.UseCustomBackColor = true;
            this.btnZakonczone.UseCustomForeColor = true;
            this.btnZakonczone.UseSelectable = true;
            this.btnZakonczone.UseVisualStyleBackColor = false;
            // 
            // btnWTrakcie
            // 
            this.btnWTrakcie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnWTrakcie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnWTrakcie.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.btnWTrakcie.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnWTrakcie.Location = new System.Drawing.Point(26, 120);
            this.btnWTrakcie.Name = "btnWTrakcie";
            this.btnWTrakcie.Size = new System.Drawing.Size(138, 48);
            this.btnWTrakcie.TabIndex = 1;
            this.btnWTrakcie.Text = "W trakcie";
            this.btnWTrakcie.UseCustomBackColor = true;
            this.btnWTrakcie.UseCustomForeColor = true;
            this.btnWTrakcie.UseSelectable = true;
            this.btnWTrakcie.UseVisualStyleBackColor = false;
            // 
            // btnOczekujace
            // 
            this.btnOczekujace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnOczekujace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnOczekujace.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.btnOczekujace.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnOczekujace.Location = new System.Drawing.Point(26, 30);
            this.btnOczekujace.Name = "btnOczekujace";
            this.btnOczekujace.Size = new System.Drawing.Size(138, 48);
            this.btnOczekujace.TabIndex = 0;
            this.btnOczekujace.Text = "Nowa";
            this.btnOczekujace.UseCustomBackColor = true;
            this.btnOczekujace.UseCustomForeColor = true;
            this.btnOczekujace.UseSelectable = true;
            this.btnOczekujace.UseVisualStyleBackColor = false;
            this.btnOczekujace.Click += new System.EventHandler(this.btnOczekujace_Click);
            // 
            // tbcDocumentation
            // 
            this.tbcDocumentation.AnimateEasingType = ReaLTaiizor.Enum.Metro.EasingType.CubeOut;
            this.tbcDocumentation.AnimateTime = 200;
            this.tbcDocumentation.BackgroundColor = System.Drawing.Color.Black;
            this.tbcDocumentation.Controls.Add(this.tabPage1);
            this.tbcDocumentation.Controls.Add(this.tabPage2);
            this.tbcDocumentation.Controls.Add(this.tabPage3);
            this.tbcDocumentation.ControlsVisible = true;
            this.tbcDocumentation.IsDerivedStyle = false;
            this.tbcDocumentation.ItemSize = new System.Drawing.Size(100, 38);
            this.tbcDocumentation.Location = new System.Drawing.Point(15, 115);
            this.tbcDocumentation.MCursor = System.Windows.Forms.Cursors.Hand;
            this.tbcDocumentation.Name = "tbcDocumentation";
            this.tbcDocumentation.SelectedIndex = 0;
            this.tbcDocumentation.SelectedTextColor = System.Drawing.Color.Black;
            this.tbcDocumentation.Size = new System.Drawing.Size(970, 553);
            this.tbcDocumentation.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcDocumentation.Speed = 100;
            this.tbcDocumentation.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.tbcDocumentation.StyleManager = null;
            this.tbcDocumentation.TabIndex = 0;
            this.tbcDocumentation.ThemeAuthor = "Taiizor";
            this.tbcDocumentation.ThemeName = "MetroLight";
            this.tbcDocumentation.UnselectedTextColor = System.Drawing.Color.WhiteSmoke;
            // 
            // GeneralMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1000, 768);
            this.Controls.Add(this.tbcDocumentation);
            this.Name = "GeneralMenu";
            this.Text = "Menu";
            this.TextColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.ResumeLayout(false);
            this.tbcDocumentation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage3;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private ReaLTaiizor.Controls.MetroTabControl tbcDocumentation;
        private ReaLTaiizor.Controls.PoisonButton btnOczekujace;
        private ReaLTaiizor.Controls.PoisonButton btnZakonczone;
        private ReaLTaiizor.Controls.PoisonButton btnWTrakcie;
        private ReaLTaiizor.Controls.PoisonListView lvDokumentacja;
    }
}