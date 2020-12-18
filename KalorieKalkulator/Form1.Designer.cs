
namespace KalorieKalkulator
{
    partial class initialize
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tWiek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sexm = new System.Windows.Forms.RadioButton();
            this.sexk = new System.Windows.Forms.RadioButton();
            this.tWzrost = new System.Windows.Forms.TextBox();
            this.tWaga = new System.Windows.Forms.TextBox();
            this.bOblicz = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lWynik = new System.Windows.Forms.Label();
            this.nAktywnosc = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nAktywnosc)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tWiek
            // 
            this.tWiek.Location = new System.Drawing.Point(99, 37);
            this.tWiek.Name = "tWiek";
            this.tWiek.Size = new System.Drawing.Size(100, 23);
            this.tWiek.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Podaj dane:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wiek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Płeć: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wzrost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Waga:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Poziom aktywności fizycznej:";
            // 
            // sexm
            // 
            this.sexm.Checked = true;
            this.sexm.Location = new System.Drawing.Point(99, 68);
            this.sexm.Name = "sexm";
            this.sexm.Size = new System.Drawing.Size(94, 19);
            this.sexm.TabIndex = 8;
            this.sexm.TabStop = true;
            this.sexm.Text = "Mężczyzna";
            this.sexm.UseVisualStyleBackColor = true;
            // 
            // sexk
            // 
            this.sexk.AutoSize = true;
            this.sexk.Location = new System.Drawing.Point(221, 68);
            this.sexk.Name = "sexk";
            this.sexk.Size = new System.Drawing.Size(65, 19);
            this.sexk.TabIndex = 9;
            this.sexk.Text = "Kobieta";
            this.sexk.UseVisualStyleBackColor = true;
            // 
            // tWzrost
            // 
            this.tWzrost.Location = new System.Drawing.Point(99, 93);
            this.tWzrost.Name = "tWzrost";
            this.tWzrost.Size = new System.Drawing.Size(100, 23);
            this.tWzrost.TabIndex = 10;
            // 
            // tWaga
            // 
            this.tWaga.Location = new System.Drawing.Point(99, 122);
            this.tWaga.Name = "tWaga";
            this.tWaga.Size = new System.Drawing.Size(100, 23);
            this.tWaga.TabIndex = 11;
            // 
            // bOblicz
            // 
            this.bOblicz.Location = new System.Drawing.Point(22, 320);
            this.bOblicz.Name = "bOblicz";
            this.bOblicz.Size = new System.Drawing.Size(75, 23);
            this.bOblicz.TabIndex = 14;
            this.bOblicz.Text = "Oblicz";
            this.bOblicz.UseVisualStyleBackColor = true;
            this.bOblicz.Click += new System.EventHandler(this.inputDdata);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Twoje zapotrzebowanie kalorii wynosi: ";
            // 
            // lWynik
            // 
            this.lWynik.AutoSize = true;
            this.lWynik.Location = new System.Drawing.Point(238, 360);
            this.lWynik.Name = "lWynik";
            this.lWynik.Size = new System.Drawing.Size(0, 15);
            this.lWynik.TabIndex = 16;
            // 
            // nAktywnosc
            // 
            this.nAktywnosc.Location = new System.Drawing.Point(202, 155);
            this.nAktywnosc.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nAktywnosc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAktywnosc.Name = "nAktywnosc";
            this.nAktywnosc.Size = new System.Drawing.Size(102, 23);
            this.nAktywnosc.TabIndex = 18;
            this.nAktywnosc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "1- Brak aktywności fizycznej";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "2 - Niska aktywność";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "3 - Średnia aktywność";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "5 - Bardzo wysoka aktywność";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "4 - Wysoka aktywność";
            // 
            // initialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(396, 409);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nAktywnosc);
            this.Controls.Add(this.lWynik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bOblicz);
            this.Controls.Add(this.tWaga);
            this.Controls.Add(this.tWzrost);
            this.Controls.Add(this.sexk);
            this.Controls.Add(this.sexm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tWiek);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "initialize";
            this.Text = "Kalkulator Kalorii";
            ((System.ComponentModel.ISupportInitialize)(this.nAktywnosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tWiek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton sexm;
        private System.Windows.Forms.RadioButton sexk;
        private System.Windows.Forms.TextBox tWzrost;
        private System.Windows.Forms.TextBox tWaga;
        private System.Windows.Forms.Button bOblicz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lWynik;
        private System.Windows.Forms.NumericUpDown nAktywnosc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

