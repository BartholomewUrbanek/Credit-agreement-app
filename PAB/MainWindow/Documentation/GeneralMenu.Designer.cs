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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDokuUzytkownicy = new ReaLTaiizor.Controls.PoisonButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClientSearch = new ReaLTaiizor.Controls.PoisonButton();
            this.cbClientColumn = new ReaLTaiizor.Controls.PoisonComboBox();
            this.tbClientValue = new ReaLTaiizor.Controls.PoisonTextBox();
            this.dgClient = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.lvDokumentacja = new ReaLTaiizor.Controls.PoisonListView();
            this.btnGeneruj = new ReaLTaiizor.Controls.PoisonButton();
            this.btnZakonczone = new ReaLTaiizor.Controls.PoisonButton();
            this.btnWTrakcie = new ReaLTaiizor.Controls.PoisonButton();
            this.btnOczekujace = new ReaLTaiizor.Controls.PoisonButton();
            this.tbcDocumentation = new ReaLTaiizor.Controls.MetroTabControl();
            this.btnUmowyStatus = new ReaLTaiizor.Controls.PoisonButton();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tbcDocumentation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.tabPage3.Controls.Add(this.btnUmowyStatus);
            this.tabPage3.Controls.Add(this.btnDokuUzytkownicy);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(962, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Raportowanie";
            // 
            // btnDokuUzytkownicy
            // 
            this.btnDokuUzytkownicy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDokuUzytkownicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnDokuUzytkownicy.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.btnDokuUzytkownicy.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnDokuUzytkownicy.Location = new System.Drawing.Point(21, 21);
            this.btnDokuUzytkownicy.Name = "btnDokuUzytkownicy";
            this.btnDokuUzytkownicy.Size = new System.Drawing.Size(256, 53);
            this.btnDokuUzytkownicy.TabIndex = 1;
            this.btnDokuUzytkownicy.Text = "Użytkownicy/Dokumentacje";
            this.btnDokuUzytkownicy.UseCustomBackColor = true;
            this.btnDokuUzytkownicy.UseCustomForeColor = true;
            this.btnDokuUzytkownicy.UseSelectable = true;
            this.btnDokuUzytkownicy.UseVisualStyleBackColor = false;
            this.btnDokuUzytkownicy.Click += new System.EventHandler(this.btnDokuUzytkownicy_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(297, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(647, 495);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.tabPage2.Controls.Add(this.btnClientSearch);
            this.tabPage2.Controls.Add(this.cbClientColumn);
            this.tabPage2.Controls.Add(this.tbClientValue);
            this.tabPage2.Controls.Add(this.dgClient);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(962, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Klienci";
            // 
            // btnClientSearch
            // 
            this.btnClientSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnClientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnClientSearch.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.btnClientSearch.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnClientSearch.Location = new System.Drawing.Point(436, 6);
            this.btnClientSearch.Name = "btnClientSearch";
            this.btnClientSearch.Size = new System.Drawing.Size(213, 29);
            this.btnClientSearch.TabIndex = 3;
            this.btnClientSearch.Text = "Wyszukaj";
            this.btnClientSearch.UseCustomBackColor = true;
            this.btnClientSearch.UseCustomForeColor = true;
            this.btnClientSearch.UseSelectable = true;
            this.btnClientSearch.UseVisualStyleBackColor = false;
            this.btnClientSearch.Click += new System.EventHandler(this.btnClientSearch_Click);
            // 
            // cbClientColumn
            // 
            this.cbClientColumn.FormattingEnabled = true;
            this.cbClientColumn.ItemHeight = 23;
            this.cbClientColumn.Location = new System.Drawing.Point(221, 6);
            this.cbClientColumn.Name = "cbClientColumn";
            this.cbClientColumn.Size = new System.Drawing.Size(209, 29);
            this.cbClientColumn.TabIndex = 2;
            this.cbClientColumn.UseSelectable = true;
            // 
            // tbClientValue
            // 
            // 
            // 
            // 
            this.tbClientValue.CustomButton.Image = null;
            this.tbClientValue.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.tbClientValue.CustomButton.Name = "";
            this.tbClientValue.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbClientValue.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tbClientValue.CustomButton.TabIndex = 1;
            this.tbClientValue.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tbClientValue.CustomButton.UseSelectable = true;
            this.tbClientValue.CustomButton.Visible = false;
            this.tbClientValue.Lines = new string[0];
            this.tbClientValue.Location = new System.Drawing.Point(6, 6);
            this.tbClientValue.MaxLength = 32767;
            this.tbClientValue.Name = "tbClientValue";
            this.tbClientValue.PasswordChar = '\0';
            this.tbClientValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbClientValue.SelectedText = "";
            this.tbClientValue.SelectionLength = 0;
            this.tbClientValue.SelectionStart = 0;
            this.tbClientValue.ShortcutsEnabled = true;
            this.tbClientValue.Size = new System.Drawing.Size(209, 28);
            this.tbClientValue.TabIndex = 1;
            this.tbClientValue.UseSelectable = true;
            this.tbClientValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbClientValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgClient
            // 
            this.dgClient.AllowUserToResizeRows = false;
            this.dgClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgClient.EnableHeadersVisualStyles = false;
            this.dgClient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgClient.Location = new System.Drawing.Point(6, 52);
            this.dgClient.Name = "dgClient";
            this.dgClient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgClient.RowTemplate.Height = 25;
            this.dgClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClient.Size = new System.Drawing.Size(950, 449);
            this.dgClient.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.tabPage1.Controls.Add(this.poisonLabel1);
            this.tabPage1.Controls.Add(this.lvDokumentacja);
            this.tabPage1.Controls.Add(this.btnGeneruj);
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
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.poisonLabel1.Location = new System.Drawing.Point(37, 30);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(117, 25);
            this.poisonLabel1.TabIndex = 6;
            this.poisonLabel1.Text = "Status umowy";
            this.poisonLabel1.UseCustomBackColor = true;
            this.poisonLabel1.UseCustomForeColor = true;
            // 
            // lvDokumentacja
            // 
            this.lvDokumentacja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvDokumentacja.FullRowSelect = true;
            this.lvDokumentacja.GridLines = true;
            this.lvDokumentacja.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDokumentacja.HideSelection = true;
            this.lvDokumentacja.Location = new System.Drawing.Point(223, 30);
            this.lvDokumentacja.Name = "lvDokumentacja";
            this.lvDokumentacja.OwnerDraw = true;
            this.lvDokumentacja.Size = new System.Drawing.Size(733, 471);
            this.lvDokumentacja.TabIndex = 5;
            this.lvDokumentacja.UseCompatibleStateImageBehavior = false;
            this.lvDokumentacja.UseSelectable = true;
            this.lvDokumentacja.View = System.Windows.Forms.View.Details;
            this.lvDokumentacja.SelectedIndexChanged += new System.EventHandler(this.lvDokumentacja_SelectedIndexChanged);
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnGeneruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnGeneruj.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.btnGeneruj.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnGeneruj.Location = new System.Drawing.Point(26, 437);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(138, 48);
            this.btnGeneruj.TabIndex = 4;
            this.btnGeneruj.Text = "Generuj umowę";
            this.btnGeneruj.UseCustomBackColor = true;
            this.btnGeneruj.UseCustomForeColor = true;
            this.btnGeneruj.UseSelectable = true;
            this.btnGeneruj.UseVisualStyleBackColor = false;
            this.btnGeneruj.Visible = false;
            this.btnGeneruj.Click += new System.EventHandler(this.btnGeneruj_Click);
            // 
            // btnZakonczone
            // 
            this.btnZakonczone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnZakonczone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnZakonczone.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.btnZakonczone.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnZakonczone.Location = new System.Drawing.Point(26, 259);
            this.btnZakonczone.Name = "btnZakonczone";
            this.btnZakonczone.Size = new System.Drawing.Size(138, 48);
            this.btnZakonczone.TabIndex = 2;
            this.btnZakonczone.Text = "Gotowa";
            this.btnZakonczone.UseCustomBackColor = true;
            this.btnZakonczone.UseCustomForeColor = true;
            this.btnZakonczone.UseSelectable = true;
            this.btnZakonczone.UseVisualStyleBackColor = false;
            this.btnZakonczone.Click += new System.EventHandler(this.btnZakonczone_Click);
            // 
            // btnWTrakcie
            // 
            this.btnWTrakcie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnWTrakcie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnWTrakcie.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.btnWTrakcie.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnWTrakcie.Location = new System.Drawing.Point(26, 169);
            this.btnWTrakcie.Name = "btnWTrakcie";
            this.btnWTrakcie.Size = new System.Drawing.Size(138, 48);
            this.btnWTrakcie.TabIndex = 1;
            this.btnWTrakcie.Text = "W toku";
            this.btnWTrakcie.UseCustomBackColor = true;
            this.btnWTrakcie.UseCustomForeColor = true;
            this.btnWTrakcie.UseSelectable = true;
            this.btnWTrakcie.UseVisualStyleBackColor = false;
            this.btnWTrakcie.Click += new System.EventHandler(this.btnWTrakcie_Click);
            // 
            // btnOczekujace
            // 
            this.btnOczekujace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnOczekujace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnOczekujace.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.btnOczekujace.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnOczekujace.Location = new System.Drawing.Point(26, 79);
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
            this.tbcDocumentation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
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
            // btnUmowyStatus
            // 
            this.btnUmowyStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnUmowyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnUmowyStatus.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.btnUmowyStatus.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnUmowyStatus.Location = new System.Drawing.Point(21, 93);
            this.btnUmowyStatus.Name = "btnUmowyStatus";
            this.btnUmowyStatus.Size = new System.Drawing.Size(256, 53);
            this.btnUmowyStatus.TabIndex = 2;
            this.btnUmowyStatus.Text = "Umowy/Status";
            this.btnUmowyStatus.UseCustomBackColor = true;
            this.btnUmowyStatus.UseCustomForeColor = true;
            this.btnUmowyStatus.UseSelectable = true;
            this.btnUmowyStatus.UseVisualStyleBackColor = false;
            this.btnUmowyStatus.Click += new System.EventHandler(this.btnUmowyStatus_Click);
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
            this.Load += new System.EventHandler(this.GeneralMenu_Load);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private ReaLTaiizor.Controls.PoisonButton btnGeneruj;
        private ReaLTaiizor.Controls.PoisonListView lvDokumentacja;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonTextBox tbClientValue;
        private ReaLTaiizor.Controls.PoisonDataGridView dgClient;
        private ReaLTaiizor.Controls.PoisonComboBox cbClientColumn;
        private ReaLTaiizor.Controls.PoisonButton btnClientSearch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ReaLTaiizor.Controls.PoisonButton btnDokuUzytkownicy;
        private ReaLTaiizor.Controls.PoisonButton btnUmowyStatus;
    }
}