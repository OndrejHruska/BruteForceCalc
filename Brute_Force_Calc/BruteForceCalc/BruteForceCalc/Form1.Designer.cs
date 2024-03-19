namespace BruteForceCalc
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBoxMalaPismena = new System.Windows.Forms.CheckBox();
            this.checkBoxVelkaPismena = new System.Windows.Forms.CheckBox();
            this.checkBoxCisla = new System.Windows.Forms.CheckBox();
            this.checkBoxSpecialniZnaky = new System.Windows.Forms.CheckBox();
            this.buttonVypocti = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxDelkaHesla = new System.Windows.Forms.TextBox();
            this.textBoxPocetPokusuZaS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxMalaPismena
            // 
            this.checkBoxMalaPismena.AutoSize = true;
            this.checkBoxMalaPismena.Location = new System.Drawing.Point(109, 65);
            this.checkBoxMalaPismena.Name = "checkBoxMalaPismena";
            this.checkBoxMalaPismena.Size = new System.Drawing.Size(169, 24);
            this.checkBoxMalaPismena.TabIndex = 0;
            this.checkBoxMalaPismena.Text = "Mala pismena (a-z)";
            this.checkBoxMalaPismena.UseVisualStyleBackColor = true;
            // 
            // checkBoxVelkaPismena
            // 
            this.checkBoxVelkaPismena.AutoSize = true;
            this.checkBoxVelkaPismena.Location = new System.Drawing.Point(109, 95);
            this.checkBoxVelkaPismena.Name = "checkBoxVelkaPismena";
            this.checkBoxVelkaPismena.Size = new System.Drawing.Size(179, 24);
            this.checkBoxVelkaPismena.TabIndex = 1;
            this.checkBoxVelkaPismena.Text = "Velka pismena (A-Z)";
            this.checkBoxVelkaPismena.UseVisualStyleBackColor = true;
            // 
            // checkBoxCisla
            // 
            this.checkBoxCisla.AutoSize = true;
            this.checkBoxCisla.Location = new System.Drawing.Point(109, 125);
            this.checkBoxCisla.Name = "checkBoxCisla";
            this.checkBoxCisla.Size = new System.Drawing.Size(106, 24);
            this.checkBoxCisla.TabIndex = 2;
            this.checkBoxCisla.Text = "Čísla (0-9)";
            this.checkBoxCisla.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpecialniZnaky
            // 
            this.checkBoxSpecialniZnaky.AutoSize = true;
            this.checkBoxSpecialniZnaky.Location = new System.Drawing.Point(109, 155);
            this.checkBoxSpecialniZnaky.Name = "checkBoxSpecialniZnaky";
            this.checkBoxSpecialniZnaky.Size = new System.Drawing.Size(203, 24);
            this.checkBoxSpecialniZnaky.TabIndex = 3;
            this.checkBoxSpecialniZnaky.Text = "Speciální znaky (*,! atd.)";
            this.checkBoxSpecialniZnaky.UseVisualStyleBackColor = true;
            // 
            // buttonVypocti
            // 
            this.buttonVypocti.Location = new System.Drawing.Point(109, 258);
            this.buttonVypocti.Name = "buttonVypocti";
            this.buttonVypocti.Size = new System.Drawing.Size(100, 38);
            this.buttonVypocti.TabIndex = 4;
            this.buttonVypocti.Text = "Vypočitej!";
            this.buttonVypocti.UseVisualStyleBackColor = true;
            this.buttonVypocti.Click += new System.EventHandler(this.buttonVypocti_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxDelkaHesla
            // 
            this.textBoxDelkaHesla.Location = new System.Drawing.Point(109, 194);
            this.textBoxDelkaHesla.Name = "textBoxDelkaHesla";
            this.textBoxDelkaHesla.Size = new System.Drawing.Size(100, 26);
            this.textBoxDelkaHesla.TabIndex = 6;
            // 
            // textBoxPocetPokusuZaS
            // 
            this.textBoxPocetPokusuZaS.Location = new System.Drawing.Point(109, 226);
            this.textBoxPocetPokusuZaS.Name = "textBoxPocetPokusuZaS";
            this.textBoxPocetPokusuZaS.Size = new System.Drawing.Size(100, 26);
            this.textBoxPocetPokusuZaS.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(113, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(673, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "pocet znaku hesla (pokud zadate pocet znaku hesla na >20 nastaví se do programu 2" +
    "0 znaku)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Počet pokusů za sekundu (max 2.8 mld)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPocetPokusuZaS);
            this.Controls.Add(this.textBoxDelkaHesla);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonVypocti);
            this.Controls.Add(this.checkBoxSpecialniZnaky);
            this.Controls.Add(this.checkBoxCisla);
            this.Controls.Add(this.checkBoxVelkaPismena);
            this.Controls.Add(this.checkBoxMalaPismena);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "No brute force Calcurator?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxMalaPismena;
        private System.Windows.Forms.CheckBox checkBoxVelkaPismena;
        private System.Windows.Forms.CheckBox checkBoxCisla;
        private System.Windows.Forms.CheckBox checkBoxSpecialniZnaky;
        private System.Windows.Forms.Button buttonVypocti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDelkaHesla;
        private System.Windows.Forms.TextBox textBoxPocetPokusuZaS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

