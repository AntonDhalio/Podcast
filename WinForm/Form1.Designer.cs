
namespace WinForm
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataBoxAvsnitt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataBoxNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataBoxFrekvens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataBoxKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrenumerera = new System.Windows.Forms.Button();
            this.btnAndra = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lbAvsnitt = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.lbKategorier = new System.Windows.Forms.ListBox();
            this.btnLaggTill = new System.Windows.Forms.Button();
            this.btnAndra2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataBoxAvsnitt,
            this.DataBoxNamn,
            this.DataBoxFrekvens,
            this.DataBoxKategori});
            this.dataGridView1.Location = new System.Drawing.Point(17, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(545, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataBoxAvsnitt
            // 
            this.DataBoxAvsnitt.HeaderText = "Avsnitt";
            this.DataBoxAvsnitt.MinimumWidth = 6;
            this.DataBoxAvsnitt.Name = "DataBoxAvsnitt";
            this.DataBoxAvsnitt.Width = 70;
            // 
            // DataBoxNamn
            // 
            this.DataBoxNamn.HeaderText = "Namn";
            this.DataBoxNamn.MinimumWidth = 6;
            this.DataBoxNamn.Name = "DataBoxNamn";
            this.DataBoxNamn.Width = 200;
            // 
            // DataBoxFrekvens
            // 
            this.DataBoxFrekvens.HeaderText = "Frekvens";
            this.DataBoxFrekvens.MinimumWidth = 6;
            this.DataBoxFrekvens.Name = "DataBoxFrekvens";
            this.DataBoxFrekvens.Width = 125;
            // 
            // DataBoxKategori
            // 
            this.DataBoxKategori.HeaderText = "Kategori";
            this.DataBoxKategori.MinimumWidth = 6;
            this.DataBoxKategori.Name = "DataBoxKategori";
            this.DataBoxKategori.Width = 125;
            // 
            // btnPrenumerera
            // 
            this.btnPrenumerera.Location = new System.Drawing.Point(256, 304);
            this.btnPrenumerera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrenumerera.Name = "btnPrenumerera";
            this.btnPrenumerera.Size = new System.Drawing.Size(105, 31);
            this.btnPrenumerera.TabIndex = 1;
            this.btnPrenumerera.Text = "Prenumerera";
            this.btnPrenumerera.UseVisualStyleBackColor = true;
            // 
            // btnAndra
            // 
            this.btnAndra.Location = new System.Drawing.Point(376, 304);
            this.btnAndra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAndra.Name = "btnAndra";
            this.btnAndra.Size = new System.Drawing.Size(86, 31);
            this.btnAndra.TabIndex = 2;
            this.btnAndra.Text = "Ändra";
            this.btnAndra.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(477, 304);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Ta bort";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uppdateringsfrekvens:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 249);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 27);
            this.textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(256, 248);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(424, 248);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(138, 28);
            this.comboBox2.TabIndex = 9;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 654);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // lbAvsnitt
            // 
            this.lbAvsnitt.FormattingEnabled = true;
            this.lbAvsnitt.ItemHeight = 20;
            this.lbAvsnitt.Location = new System.Drawing.Point(17, 374);
            this.lbAvsnitt.Name = "lbAvsnitt";
            this.lbAvsnitt.ScrollAlwaysVisible = true;
            this.lbAvsnitt.Size = new System.Drawing.Size(292, 224);
            this.lbAvsnitt.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(327, 409);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(555, 189);
            this.textBox2.TabIndex = 12;
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Location = new System.Drawing.Point(329, 374);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(0, 20);
            this.lblAvsnitt.TabIndex = 13;
            // 
            // lbKategorier
            // 
            this.lbKategorier.FormattingEnabled = true;
            this.lbKategorier.ItemHeight = 20;
            this.lbKategorier.Location = new System.Drawing.Point(623, 16);
            this.lbKategorier.Name = "lbKategorier";
            this.lbKategorier.Size = new System.Drawing.Size(260, 164);
            this.lbKategorier.TabIndex = 14;
            // 
            // btnLaggTill
            // 
            this.btnLaggTill.Location = new System.Drawing.Point(623, 258);
            this.btnLaggTill.Name = "btnLaggTill";
            this.btnLaggTill.Size = new System.Drawing.Size(91, 31);
            this.btnLaggTill.TabIndex = 15;
            this.btnLaggTill.Text = "Lägg till";
            this.btnLaggTill.UseVisualStyleBackColor = true;
            // 
            // btnAndra2
            // 
            this.btnAndra2.Location = new System.Drawing.Point(720, 258);
            this.btnAndra2.Name = "btnAndra2";
            this.btnAndra2.Size = new System.Drawing.Size(79, 31);
            this.btnAndra2.TabIndex = 16;
            this.btnAndra2.Text = "Ändra";
            this.btnAndra2.UseVisualStyleBackColor = true;
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(805, 258);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(77, 31);
            this.btnDelete2.TabIndex = 17;
            this.btnDelete2.Text = "Ta bort";
            this.btnDelete2.UseVisualStyleBackColor = true;
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(623, 221);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(174, 27);
            this.tbKategori.TabIndex = 18;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(623, 198);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(52, 20);
            this.lblKategori.TabIndex = 19;
            this.lblKategori.Text = "Namn:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 654);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnAndra2);
            this.Controls.Add(this.btnLaggTill);
            this.Controls.Add(this.lbKategorier);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbAvsnitt);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAndra);
            this.Controls.Add(this.btnPrenumerera);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataBoxAvsnitt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataBoxNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataBoxFrekvens;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataBoxKategori;
        private System.Windows.Forms.Button btnPrenumerera;
        private System.Windows.Forms.Button btnAndra;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox lbAvsnitt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.ListBox lbKategorier;
        private System.Windows.Forms.Button btnLaggTill;
        private System.Windows.Forms.Button btnAndra2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.Label lblKategori;
    }
}

