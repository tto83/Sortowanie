namespace Sortowanie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonGen = new System.Windows.Forms.Button();
            this.buttonWybor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxWagaCenter = new System.Windows.Forms.PictureBox();
            this.labelWagaPrawa = new System.Windows.Forms.Label();
            this.labelWagaLewa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kol5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kol6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kol7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kol8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kol9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kol10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxAnimacja = new System.Windows.Forms.CheckBox();
            this.trackBarInterwalAnimacji = new System.Windows.Forms.TrackBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonWyjscie = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWagaCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInterwalAnimacji)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(14, 31);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(115, 46);
            this.buttonGen.TabIndex = 0;
            this.buttonGen.Text = "Generuj Tablicę";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // buttonWybor
            // 
            this.buttonWybor.Location = new System.Drawing.Point(14, 83);
            this.buttonWybor.Name = "buttonWybor";
            this.buttonWybor.Size = new System.Drawing.Size(115, 48);
            this.buttonWybor.TabIndex = 1;
            this.buttonWybor.Text = "Sortowanie Przez Wybór";
            this.buttonWybor.UseVisualStyleBackColor = true;
            this.buttonWybor.Click += new System.EventHandler(this.buttonWybor_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureBoxWagaCenter);
            this.panel1.Controls.Add(this.labelWagaPrawa);
            this.panel1.Controls.Add(this.labelWagaLewa);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(134, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 740);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBoxWagaCenter
            // 
            this.pictureBoxWagaCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxWagaCenter.Image = global::Sortowanie.Properties.Resources.scale;
            this.pictureBoxWagaCenter.Location = new System.Drawing.Point(450, 394);
            this.pictureBoxWagaCenter.Name = "pictureBoxWagaCenter";
            this.pictureBoxWagaCenter.Size = new System.Drawing.Size(323, 332);
            this.pictureBoxWagaCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWagaCenter.TabIndex = 9;
            this.pictureBoxWagaCenter.TabStop = false;
            this.pictureBoxWagaCenter.Click += new System.EventHandler(this.pictureBoxWagaCenter_Click);
            // 
            // labelWagaPrawa
            // 
            this.labelWagaPrawa.AutoSize = true;
            this.labelWagaPrawa.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.labelWagaPrawa.Location = new System.Drawing.Point(779, 451);
            this.labelWagaPrawa.Name = "labelWagaPrawa";
            this.labelWagaPrawa.Size = new System.Drawing.Size(0, 189);
            this.labelWagaPrawa.TabIndex = 8;
            // 
            // labelWagaLewa
            // 
            this.labelWagaLewa.AutoSize = true;
            this.labelWagaLewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.labelWagaLewa.Location = new System.Drawing.Point(178, 451);
            this.labelWagaLewa.Name = "labelWagaLewa";
            this.labelWagaLewa.Size = new System.Drawing.Size(0, 189);
            this.labelWagaLewa.TabIndex = 7;
            this.labelWagaLewa.Click += new System.EventHandler(this.labelWagaLewa_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(40, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1131, 164);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 70;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kol1,
            this.Kol2,
            this.Kol3,
            this.Kol4,
            this.Kol5,
            this.Kol6,
            this.Kol7,
            this.Kol8,
            this.Kol9,
            this.kol10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(40, 197);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 70;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 179);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Kol1
            // 
            this.Kol1.HeaderText = "i 1";
            this.Kol1.MinimumWidth = 6;
            this.Kol1.Name = "Kol1";
            this.Kol1.ReadOnly = true;
            this.Kol1.Width = 86;
            // 
            // Kol2
            // 
            this.Kol2.HeaderText = "i 2";
            this.Kol2.MinimumWidth = 6;
            this.Kol2.Name = "Kol2";
            this.Kol2.ReadOnly = true;
            this.Kol2.Width = 86;
            // 
            // Kol3
            // 
            this.Kol3.HeaderText = "i 3";
            this.Kol3.MinimumWidth = 6;
            this.Kol3.Name = "Kol3";
            this.Kol3.ReadOnly = true;
            this.Kol3.Width = 86;
            // 
            // Kol4
            // 
            this.Kol4.HeaderText = "i 4";
            this.Kol4.MinimumWidth = 6;
            this.Kol4.Name = "Kol4";
            this.Kol4.ReadOnly = true;
            this.Kol4.Width = 86;
            // 
            // Kol5
            // 
            this.Kol5.HeaderText = "i 5";
            this.Kol5.MinimumWidth = 6;
            this.Kol5.Name = "Kol5";
            this.Kol5.ReadOnly = true;
            this.Kol5.Width = 86;
            // 
            // Kol6
            // 
            this.Kol6.HeaderText = "i 6";
            this.Kol6.MinimumWidth = 6;
            this.Kol6.Name = "Kol6";
            this.Kol6.ReadOnly = true;
            this.Kol6.Width = 86;
            // 
            // Kol7
            // 
            this.Kol7.HeaderText = "i 7";
            this.Kol7.MinimumWidth = 6;
            this.Kol7.Name = "Kol7";
            this.Kol7.ReadOnly = true;
            this.Kol7.Width = 86;
            // 
            // Kol8
            // 
            this.Kol8.HeaderText = "i 8";
            this.Kol8.MinimumWidth = 6;
            this.Kol8.Name = "Kol8";
            this.Kol8.ReadOnly = true;
            this.Kol8.Width = 86;
            // 
            // Kol9
            // 
            this.Kol9.HeaderText = "i 9";
            this.Kol9.MinimumWidth = 6;
            this.Kol9.Name = "Kol9";
            this.Kol9.ReadOnly = true;
            this.Kol9.Width = 86;
            // 
            // kol10
            // 
            this.kol10.HeaderText = "i 10";
            this.kol10.MinimumWidth = 6;
            this.kol10.Name = "kol10";
            this.kol10.ReadOnly = true;
            this.kol10.Width = 107;
            // 
            // checkBoxAnimacja
            // 
            this.checkBoxAnimacja.AutoSize = true;
            this.checkBoxAnimacja.Location = new System.Drawing.Point(13, 589);
            this.checkBoxAnimacja.Name = "checkBoxAnimacja";
            this.checkBoxAnimacja.Size = new System.Drawing.Size(85, 20);
            this.checkBoxAnimacja.TabIndex = 7;
            this.checkBoxAnimacja.Text = "Animacja";
            this.checkBoxAnimacja.UseVisualStyleBackColor = true;
            // 
            // trackBarInterwalAnimacji
            // 
            this.trackBarInterwalAnimacji.Location = new System.Drawing.Point(12, 615);
            this.trackBarInterwalAnimacji.Maximum = 200;
            this.trackBarInterwalAnimacji.Minimum = 1;
            this.trackBarInterwalAnimacji.Name = "trackBarInterwalAnimacji";
            this.trackBarInterwalAnimacji.Size = new System.Drawing.Size(104, 56);
            this.trackBarInterwalAnimacji.TabIndex = 7;
            this.trackBarInterwalAnimacji.Value = 30;
            this.trackBarInterwalAnimacji.Scroll += new System.EventHandler(this.trackBarInterwalAnimacji_Scroll);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(14, 137);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(114, 48);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonWyjscie
            // 
            this.buttonWyjscie.Location = new System.Drawing.Point(14, 191);
            this.buttonWyjscie.Name = "buttonWyjscie";
            this.buttonWyjscie.Size = new System.Drawing.Size(114, 48);
            this.buttonWyjscie.TabIndex = 10;
            this.buttonWyjscie.Text = "Wyjście";
            this.buttonWyjscie.UseVisualStyleBackColor = true;
            this.buttonWyjscie.Click += new System.EventHandler(this.buttonWyjscie_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.toolStripMenuItem1.Text = "Informacje";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 26);
            this.toolStripMenuItem2.Text = "Wyjście";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 783);
            this.Controls.Add(this.buttonWyjscie);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.trackBarInterwalAnimacji);
            this.Controls.Add(this.checkBoxAnimacja);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonWybor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sorotwanie przez wstawianie APSL 2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWagaCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInterwalAnimacji)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Button buttonWybor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kol4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kol5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kol6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kol7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kol8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kol9;
        private System.Windows.Forms.DataGridViewTextBoxColumn kol10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxAnimacja;
        private System.Windows.Forms.TrackBar trackBarInterwalAnimacji;
        private System.Windows.Forms.Label labelWagaLewa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelWagaPrawa;
        private System.Windows.Forms.PictureBox pictureBoxWagaCenter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonWyjscie;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

