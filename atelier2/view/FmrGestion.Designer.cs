
namespace atelier2.view
{
    partial class FmrGestion
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
            this.gbxPros = new System.Windows.Forms.GroupBox();
            this.btnProModifier = new System.Windows.Forms.Button();
            this.btnProSuprimer = new System.Windows.Forms.Button();
            this.btnProAjouter = new System.Windows.Forms.Button();
            this.dataGridPerso = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxProSelect = new System.Windows.Forms.GroupBox();
            this.btnProAnnuler = new System.Windows.Forms.Button();
            this.btnProEnregistrer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bntafficher = new System.Windows.Forms.Button();
            this.gbxAbsences = new System.Windows.Forms.GroupBox();
            this.btnAbsSuprimer = new System.Windows.Forms.Button();
            this.btnAbsModifier = new System.Windows.Forms.Button();
            this.btnAbsAjouter = new System.Windows.Forms.Button();
            this.dataGridAbs = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAbsAnnuler = new System.Windows.Forms.Button();
            this.btnAbsEnregistrer = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.gbxPros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerso)).BeginInit();
            this.gbxProSelect.SuspendLayout();
            this.gbxAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAbs)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPros
            // 
            this.gbxPros.Controls.Add(this.btnProModifier);
            this.gbxPros.Controls.Add(this.btnProSuprimer);
            this.gbxPros.Controls.Add(this.btnProAjouter);
            this.gbxPros.Controls.Add(this.dataGridPerso);
            this.gbxPros.Location = new System.Drawing.Point(29, 21);
            this.gbxPros.Name = "gbxPros";
            this.gbxPros.Size = new System.Drawing.Size(536, 357);
            this.gbxPros.TabIndex = 0;
            this.gbxPros.TabStop = false;
            this.gbxPros.Text = "le personnel";
            // 
            // btnProModifier
            // 
            this.btnProModifier.Location = new System.Drawing.Point(225, 307);
            this.btnProModifier.Name = "btnProModifier";
            this.btnProModifier.Size = new System.Drawing.Size(75, 23);
            this.btnProModifier.TabIndex = 3;
            this.btnProModifier.Text = "modifier";
            this.btnProModifier.UseVisualStyleBackColor = true;
            this.btnProModifier.Click += new System.EventHandler(this.btnProModifier_Click);
            // 
            // btnProSuprimer
            // 
            this.btnProSuprimer.Location = new System.Drawing.Point(455, 307);
            this.btnProSuprimer.Name = "btnProSuprimer";
            this.btnProSuprimer.Size = new System.Drawing.Size(75, 23);
            this.btnProSuprimer.TabIndex = 2;
            this.btnProSuprimer.Text = "suprimer";
            this.btnProSuprimer.UseVisualStyleBackColor = true;
            // 
            // btnProAjouter
            // 
            this.btnProAjouter.Location = new System.Drawing.Point(6, 307);
            this.btnProAjouter.Name = "btnProAjouter";
            this.btnProAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnProAjouter.TabIndex = 1;
            this.btnProAjouter.Text = "ajouter";
            this.btnProAjouter.UseVisualStyleBackColor = true;
            // 
            // dataGridPerso
            // 
            this.dataGridPerso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPerso.Location = new System.Drawing.Point(6, 19);
            this.dataGridPerso.Name = "dataGridPerso";
            this.dataGridPerso.Size = new System.Drawing.Size(524, 257);
            this.dataGridPerso.TabIndex = 0;
            // 
            // gbxProSelect
            // 
            this.gbxProSelect.Controls.Add(this.btnProAnnuler);
            this.gbxProSelect.Controls.Add(this.btnProEnregistrer);
            this.gbxProSelect.Controls.Add(this.label5);
            this.gbxProSelect.Controls.Add(this.label4);
            this.gbxProSelect.Controls.Add(this.label3);
            this.gbxProSelect.Controls.Add(this.label2);
            this.gbxProSelect.Controls.Add(this.label1);
            this.gbxProSelect.Controls.Add(this.comboBox1);
            this.gbxProSelect.Controls.Add(this.textBox4);
            this.gbxProSelect.Controls.Add(this.textBox3);
            this.gbxProSelect.Controls.Add(this.textBox2);
            this.gbxProSelect.Controls.Add(this.textBox1);
            this.gbxProSelect.Location = new System.Drawing.Point(29, 419);
            this.gbxProSelect.Name = "gbxProSelect";
            this.gbxProSelect.Size = new System.Drawing.Size(601, 219);
            this.gbxProSelect.TabIndex = 1;
            this.gbxProSelect.TabStop = false;
            this.gbxProSelect.Text = "personnel selectionné";
            // 
            // btnProAnnuler
            // 
            this.btnProAnnuler.Location = new System.Drawing.Point(128, 172);
            this.btnProAnnuler.Name = "btnProAnnuler";
            this.btnProAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnProAnnuler.TabIndex = 11;
            this.btnProAnnuler.Text = "annuler";
            this.btnProAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnProEnregistrer
            // 
            this.btnProEnregistrer.Location = new System.Drawing.Point(21, 172);
            this.btnProEnregistrer.Name = "btnProEnregistrer";
            this.btnProEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnProEnregistrer.TabIndex = 10;
            this.btnProEnregistrer.Text = "enregistrer";
            this.btnProEnregistrer.UseVisualStyleBackColor = true;
            this.btnProEnregistrer.Click += new System.EventHandler(this.btnProEnregistrer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "nom";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(397, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(397, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(397, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 0;
            // 
            // bntafficher
            // 
            this.bntafficher.Location = new System.Drawing.Point(600, 102);
            this.bntafficher.Name = "bntafficher";
            this.bntafficher.Size = new System.Drawing.Size(75, 110);
            this.bntafficher.TabIndex = 3;
            this.bntafficher.Text = "afficher absence(s)";
            this.bntafficher.UseVisualStyleBackColor = true;
            // 
            // gbxAbsences
            // 
            this.gbxAbsences.Controls.Add(this.btnAbsSuprimer);
            this.gbxAbsences.Controls.Add(this.btnAbsModifier);
            this.gbxAbsences.Controls.Add(this.btnAbsAjouter);
            this.gbxAbsences.Controls.Add(this.dataGridAbs);
            this.gbxAbsences.Location = new System.Drawing.Point(714, 21);
            this.gbxAbsences.Name = "gbxAbsences";
            this.gbxAbsences.Size = new System.Drawing.Size(412, 357);
            this.gbxAbsences.TabIndex = 5;
            this.gbxAbsences.TabStop = false;
            this.gbxAbsences.Text = "absences";
            // 
            // btnAbsSuprimer
            // 
            this.btnAbsSuprimer.Location = new System.Drawing.Point(331, 307);
            this.btnAbsSuprimer.Name = "btnAbsSuprimer";
            this.btnAbsSuprimer.Size = new System.Drawing.Size(75, 23);
            this.btnAbsSuprimer.TabIndex = 3;
            this.btnAbsSuprimer.Text = "suprimer";
            this.btnAbsSuprimer.UseVisualStyleBackColor = true;
            // 
            // btnAbsModifier
            // 
            this.btnAbsModifier.Location = new System.Drawing.Point(168, 307);
            this.btnAbsModifier.Name = "btnAbsModifier";
            this.btnAbsModifier.Size = new System.Drawing.Size(75, 23);
            this.btnAbsModifier.TabIndex = 2;
            this.btnAbsModifier.Text = "modifier";
            this.btnAbsModifier.UseVisualStyleBackColor = true;
            // 
            // btnAbsAjouter
            // 
            this.btnAbsAjouter.Location = new System.Drawing.Point(6, 307);
            this.btnAbsAjouter.Name = "btnAbsAjouter";
            this.btnAbsAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAbsAjouter.TabIndex = 1;
            this.btnAbsAjouter.Text = "ajouter";
            this.btnAbsAjouter.UseVisualStyleBackColor = true;
            // 
            // dataGridAbs
            // 
            this.dataGridAbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAbs.Location = new System.Drawing.Point(6, 19);
            this.dataGridAbs.Name = "dataGridAbs";
            this.dataGridAbs.Size = new System.Drawing.Size(400, 248);
            this.dataGridAbs.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAbsAnnuler);
            this.groupBox2.Controls.Add(this.btnAbsEnregistrer);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbxMotif);
            this.groupBox2.Location = new System.Drawing.Point(714, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 219);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "absence selectionné";
            // 
            // btnAbsAnnuler
            // 
            this.btnAbsAnnuler.Location = new System.Drawing.Point(168, 172);
            this.btnAbsAnnuler.Name = "btnAbsAnnuler";
            this.btnAbsAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAbsAnnuler.TabIndex = 10;
            this.btnAbsAnnuler.Text = "annuler";
            this.btnAbsAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAbsEnregistrer
            // 
            this.btnAbsEnregistrer.Location = new System.Drawing.Point(49, 172);
            this.btnAbsEnregistrer.Name = "btnAbsEnregistrer";
            this.btnAbsEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnAbsEnregistrer.TabIndex = 9;
            this.btnAbsEnregistrer.Text = "enregistrer";
            this.btnAbsEnregistrer.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(145, 82);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "motif";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "date de fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "date de debut";
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(144, 124);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(200, 21);
            this.cbxMotif.TabIndex = 2;
            // 
            // FmrGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1176, 686);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxAbsences);
            this.Controls.Add(this.bntafficher);
            this.Controls.Add(this.gbxProSelect);
            this.Controls.Add(this.gbxPros);
            this.Name = "FmrGestion";
            this.Text = "Gestionnaire personnel et absence";
            this.gbxPros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerso)).EndInit();
            this.gbxProSelect.ResumeLayout(false);
            this.gbxProSelect.PerformLayout();
            this.gbxAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAbs)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPros;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnProModifier;
        private System.Windows.Forms.Button btnProSuprimer;
        private System.Windows.Forms.Button btnProAjouter;
        private System.Windows.Forms.DataGridView dataGridPerso;
        private System.Windows.Forms.GroupBox gbxProSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bntafficher;
        private System.Windows.Forms.GroupBox gbxAbsences;
        private System.Windows.Forms.Button btnAbsSuprimer;
        private System.Windows.Forms.Button btnAbsModifier;
        private System.Windows.Forms.Button btnAbsAjouter;
        private System.Windows.Forms.DataGridView dataGridAbs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnProAnnuler;
        private System.Windows.Forms.Button btnProEnregistrer;
        private System.Windows.Forms.Button btnAbsAnnuler;
        private System.Windows.Forms.Button btnAbsEnregistrer;
    }
}