
namespace Presentation_Layer
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.btnPrenumerera = new System.Windows.Forms.Button();
            this.btnAndra = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.comboBoxFrekvens = new System.Windows.Forms.ComboBox();
            this.cbKategorier = new System.Windows.Forms.ComboBox();
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
            this.listViewPodd = new System.Windows.Forms.ListView();
            this.listNamn = new System.Windows.Forms.ColumnHeader();
            this.listAvsnitt = new System.Windows.Forms.ColumnHeader();
            this.listFrekvens = new System.Windows.Forms.ColumnHeader();
            this.listKategori = new System.Windows.Forms.ColumnHeader();
            this.lblKatLista = new System.Windows.Forms.Label();
            this.lblAvsLista = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.uppdelare1 = new System.Windows.Forms.Label();
            this.uppdelare2 = new System.Windows.Forms.Label();
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            this.lblNamn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrenumerera
            // 
            this.btnPrenumerera.Location = new System.Drawing.Point(212, 250);
            this.btnPrenumerera.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrenumerera.Name = "btnPrenumerera";
            this.btnPrenumerera.Size = new System.Drawing.Size(92, 23);
            this.btnPrenumerera.TabIndex = 1;
            this.btnPrenumerera.Text = "Prenumerera";
            this.btnPrenumerera.UseVisualStyleBackColor = true;
            this.btnPrenumerera.Click += new System.EventHandler(this.btnPrenumerera_Click);
            // 
            // btnAndra
            // 
            this.btnAndra.Location = new System.Drawing.Point(339, 250);
            this.btnAndra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAndra.Name = "btnAndra";
            this.btnAndra.Size = new System.Drawing.Size(75, 23);
            this.btnAndra.TabIndex = 2;
            this.btnAndra.Text = "Ändra";
            this.btnAndra.UseVisualStyleBackColor = true;
            this.btnAndra.Click += new System.EventHandler(this.btnAndra_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(462, 251);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Ta bort";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uppdateringsfrekvens:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(32, 196);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(104, 23);
            this.textBoxURL.TabIndex = 7;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // comboBoxFrekvens
            // 
            this.comboBoxFrekvens.FormattingEnabled = true;
            this.comboBoxFrekvens.Items.AddRange(new object[] {
            "5 sekunder",
            "30 sekunder",
            "60 sekunder"});
            this.comboBoxFrekvens.Location = new System.Drawing.Point(212, 196);
            this.comboBoxFrekvens.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFrekvens.Name = "comboBoxFrekvens";
            this.comboBoxFrekvens.Size = new System.Drawing.Size(125, 23);
            this.comboBoxFrekvens.TabIndex = 8;
            // 
            // cbKategorier
            // 
            this.cbKategorier.FormattingEnabled = true;
            this.cbKategorier.Location = new System.Drawing.Point(412, 196);
            this.cbKategorier.Margin = new System.Windows.Forms.Padding(2);
            this.cbKategorier.Name = "cbKategorier";
            this.cbKategorier.Size = new System.Drawing.Size(125, 23);
            this.cbKategorier.TabIndex = 9;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 498);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // lbAvsnitt
            // 
            this.lbAvsnitt.FormattingEnabled = true;
            this.lbAvsnitt.ItemHeight = 15;
            this.lbAvsnitt.Location = new System.Drawing.Point(12, 318);
            this.lbAvsnitt.Margin = new System.Windows.Forms.Padding(2);
            this.lbAvsnitt.Name = "lbAvsnitt";
            this.lbAvsnitt.ScrollAlwaysVisible = true;
            this.lbAvsnitt.Size = new System.Drawing.Size(235, 169);
            this.lbAvsnitt.TabIndex = 11;
            this.lbAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lbAvsnitt_SelectedIndexChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(257, 312);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(557, 175);
            this.textBox2.TabIndex = 12;
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Location = new System.Drawing.Point(266, 295);
            this.lblAvsnitt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(0, 15);
            this.lblAvsnitt.TabIndex = 13;
            // 
            // lbKategorier
            // 
            this.lbKategorier.FormattingEnabled = true;
            this.lbKategorier.ItemHeight = 15;
            this.lbKategorier.Location = new System.Drawing.Point(589, 26);
            this.lbKategorier.Margin = new System.Windows.Forms.Padding(2);
            this.lbKategorier.Name = "lbKategorier";
            this.lbKategorier.Size = new System.Drawing.Size(256, 139);
            this.lbKategorier.TabIndex = 14;
            this.lbKategorier.SelectedIndexChanged += new System.EventHandler(this.lbKategorier_SelectedIndexChanged);
            // 
            // btnLaggTill
            // 
            this.btnLaggTill.Location = new System.Drawing.Point(589, 240);
            this.btnLaggTill.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaggTill.Name = "btnLaggTill";
            this.btnLaggTill.Size = new System.Drawing.Size(80, 23);
            this.btnLaggTill.TabIndex = 15;
            this.btnLaggTill.Text = "Lägg till";
            this.btnLaggTill.UseVisualStyleBackColor = true;
            this.btnLaggTill.Click += new System.EventHandler(this.btnLaggTill_Click_1);
            // 
            // btnAndra2
            // 
            this.btnAndra2.Location = new System.Drawing.Point(697, 239);
            this.btnAndra2.Margin = new System.Windows.Forms.Padding(2);
            this.btnAndra2.Name = "btnAndra2";
            this.btnAndra2.Size = new System.Drawing.Size(69, 23);
            this.btnAndra2.TabIndex = 16;
            this.btnAndra2.Text = "Ändra";
            this.btnAndra2.UseVisualStyleBackColor = true;
            this.btnAndra2.Click += new System.EventHandler(this.btnAndra2_Click_1);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(791, 238);
            this.btnDelete2.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(67, 23);
            this.btnDelete2.TabIndex = 17;
            this.btnDelete2.Text = "Ta bort";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click_1);
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(589, 196);
            this.tbKategori.Margin = new System.Windows.Forms.Padding(2);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(153, 23);
            this.tbKategori.TabIndex = 18;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(589, 178);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(43, 15);
            this.lblKategori.TabIndex = 19;
            this.lblKategori.Text = "Namn:";
            // 
            // listViewPodd
            // 
            this.listViewPodd.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewPodd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listNamn,
            this.listAvsnitt,
            this.listFrekvens,
            this.listKategori});
            this.listViewPodd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewPodd.FullRowSelect = true;
            this.listViewPodd.GridLines = true;
            this.listViewPodd.HideSelection = false;
            this.listViewPodd.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewPodd.Location = new System.Drawing.Point(17, 6);
            this.listViewPodd.Margin = new System.Windows.Forms.Padding(2);
            this.listViewPodd.MultiSelect = false;
            this.listViewPodd.Name = "listViewPodd";
            this.listViewPodd.Size = new System.Drawing.Size(534, 159);
            this.listViewPodd.TabIndex = 20;
            this.listViewPodd.UseCompatibleStateImageBehavior = false;
            this.listViewPodd.View = System.Windows.Forms.View.Details;
            this.listViewPodd.SelectedIndexChanged += new System.EventHandler(this.listViewPodd_SelectedIndexChanged);
            // 
            // listNamn
            // 
            this.listNamn.Text = "Namn";
            this.listNamn.Width = 230;
            // 
            // listAvsnitt
            // 
            this.listAvsnitt.Text = "Avsnitt";
            this.listAvsnitt.Width = 80;
            // 
            // listFrekvens
            // 
            this.listFrekvens.Text = "Frekvens";
            this.listFrekvens.Width = 100;
            // 
            // listKategori
            // 
            this.listKategori.Text = "Kategori";
            this.listKategori.Width = 120;
            // 
            // lblKatLista
            // 
            this.lblKatLista.AutoSize = true;
            this.lblKatLista.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKatLista.Location = new System.Drawing.Point(589, 8);
            this.lblKatLista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKatLista.Name = "lblKatLista";
            this.lblKatLista.Size = new System.Drawing.Size(83, 17);
            this.lblKatLista.TabIndex = 21;
            this.lblKatLista.Text = "KATEGORIER";
            // 
            // lblAvsLista
            // 
            this.lblAvsLista.AutoSize = true;
            this.lblAvsLista.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvsLista.Location = new System.Drawing.Point(11, 288);
            this.lblAvsLista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvsLista.Name = "lblAvsLista";
            this.lblAvsLista.Size = new System.Drawing.Size(58, 17);
            this.lblAvsLista.TabIndex = 22;
            this.lblAvsLista.Text = "AVSNITT";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(2, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(6, 498);
            this.splitter2.TabIndex = 23;
            this.splitter2.TabStop = false;
            // 
            // uppdelare1
            // 
            this.uppdelare1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uppdelare1.Location = new System.Drawing.Point(566, 8);
            this.uppdelare1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uppdelare1.Name = "uppdelare1";
            this.uppdelare1.Size = new System.Drawing.Size(1, 280);
            this.uppdelare1.TabIndex = 24;
            // 
            // uppdelare2
            // 
            this.uppdelare2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uppdelare2.Location = new System.Drawing.Point(17, 287);
            this.uppdelare2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uppdelare2.Name = "uppdelare2";
            this.uppdelare2.Size = new System.Drawing.Size(884, 1);
            this.uppdelare2.TabIndex = 25;
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Location = new System.Drawing.Point(33, 251);
            this.textBoxNamn.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(103, 23);
            this.textBoxNamn.TabIndex = 26;
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(33, 233);
            this.lblNamn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(43, 15);
            this.lblNamn.TabIndex = 27;
            this.lblNamn.Text = "Namn:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(908, 498);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.textBoxNamn);
            this.Controls.Add(this.uppdelare2);
            this.Controls.Add(this.uppdelare1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.lblAvsLista);
            this.Controls.Add(this.lblKatLista);
            this.Controls.Add(this.listViewPodd);
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
            this.Controls.Add(this.cbKategorier);
            this.Controls.Add(this.comboBoxFrekvens);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAndra);
            this.Controls.Add(this.btnPrenumerera);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "RSS-läsare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Button btnPrenumerera;
        private System.Windows.Forms.Button btnAndra;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.ComboBox comboBoxFrekvens;
        private System.Windows.Forms.ComboBox cbKategorier;

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
        private System.Windows.Forms.ListView listViewPodd;
        private System.Windows.Forms.ColumnHeader listNamn;
        private System.Windows.Forms.ColumnHeader listAvsnitt;
        private System.Windows.Forms.ColumnHeader listFrekvens;
        private System.Windows.Forms.ColumnHeader listKategori;
        private System.Windows.Forms.Label lblKatLista;
        private System.Windows.Forms.Label lblAvsLista;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label uppdelare1;
        private System.Windows.Forms.Label uppdelare2;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.Label lblNamn;
    }
}

