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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonGen = new System.Windows.Forms.Button();
            this.buttonWybor = new System.Windows.Forms.Button();
            this.labelTablica = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(13, 31);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(115, 23);
            this.buttonGen.TabIndex = 0;
            this.buttonGen.Text = "Generuj Tablicę";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // buttonWybor
            // 
            this.buttonWybor.Location = new System.Drawing.Point(12, 60);
            this.buttonWybor.Name = "buttonWybor";
            this.buttonWybor.Size = new System.Drawing.Size(115, 48);
            this.buttonWybor.TabIndex = 1;
            this.buttonWybor.Text = "Sortowanie Przez Wybór";
            this.buttonWybor.UseVisualStyleBackColor = true;
            this.buttonWybor.Click += new System.EventHandler(this.buttonWybor_Click);
            // 
            // labelTablica
            // 
            this.labelTablica.AutoSize = true;
            this.labelTablica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTablica.Location = new System.Drawing.Point(50, 662);
            this.labelTablica.Name = "labelTablica";
            this.labelTablica.Size = new System.Drawing.Size(85, 18);
            this.labelTablica.TabIndex = 3;
            this.labelTablica.Text = "pusta tablica";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labelTablica);
            this.panel1.Location = new System.Drawing.Point(134, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 740);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(22, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 70;
            this.dataGridView1.Size = new System.Drawing.Size(1172, 179);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 783);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonWybor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Button buttonWybor;
        private System.Windows.Forms.Label labelTablica;
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
    }
}

