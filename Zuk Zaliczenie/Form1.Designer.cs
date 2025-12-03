namespace Zuk_Zaliczenie
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtImie = new System.Windows.Forms.TextBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.lblPrezent = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.txtPrezent = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnWyswietl = new System.Windows.Forms.Button();
            this.listBoxPrezenty = new System.Windows.Forms.ListBox();
            this.lblPodsumowanie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(12, 49);
            this.txtImie.Multiline = true;
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(152, 68);
            this.txtImie.TabIndex = 0;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(12, 19);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(37, 17);
            this.lblImie.TabIndex = 1;
            this.lblImie.Text = "Imię:";
            // 
            // lblPrezent
            // 
            this.lblPrezent.AutoSize = true;
            this.lblPrezent.Location = new System.Drawing.Point(270, 19);
            this.lblPrezent.Name = "lblPrezent";
            this.lblPrezent.Size = new System.Drawing.Size(61, 17);
            this.lblPrezent.TabIndex = 2;
            this.lblPrezent.Text = "Prezent:";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(483, 19);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(45, 17);
            this.lblCena.TabIndex = 3;
            this.lblCena.Text = "Cena:";
            // 
            // txtPrezent
            // 
            this.txtPrezent.Location = new System.Drawing.Point(273, 49);
            this.txtPrezent.Multiline = true;
            this.txtPrezent.Name = "txtPrezent";
            this.txtPrezent.Size = new System.Drawing.Size(152, 68);
            this.txtPrezent.TabIndex = 4;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(486, 49);
            this.txtCena.Multiline = true;
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(152, 68);
            this.txtCena.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 178);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(116, 90);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnWyswietl
            // 
            this.btnWyswietl.Location = new System.Drawing.Point(188, 178);
            this.btnWyswietl.Name = "btnWyswietl";
            this.btnWyswietl.Size = new System.Drawing.Size(116, 90);
            this.btnWyswietl.TabIndex = 7;
            this.btnWyswietl.Text = "Wyświetl";
            this.btnWyswietl.UseVisualStyleBackColor = true;
            // 
            // listBoxPrezenty
            // 
            this.listBoxPrezenty.FormattingEnabled = true;
            this.listBoxPrezenty.ItemHeight = 16;
            this.listBoxPrezenty.Location = new System.Drawing.Point(454, 226);
            this.listBoxPrezenty.Name = "listBoxPrezenty";
            this.listBoxPrezenty.Size = new System.Drawing.Size(213, 180);
            this.listBoxPrezenty.TabIndex = 8;
            // 
            // lblPodsumowanie
            // 
            this.lblPodsumowanie.AutoSize = true;
            this.lblPodsumowanie.Location = new System.Drawing.Point(451, 190);
            this.lblPodsumowanie.Name = "lblPodsumowanie";
            this.lblPodsumowanie.Size = new System.Drawing.Size(0, 17);
            this.lblPodsumowanie.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPodsumowanie);
            this.Controls.Add(this.listBoxPrezenty);
            this.Controls.Add(this.btnWyswietl);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtPrezent);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblPrezent);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.txtImie);
            this.Name = "Form1";
            this.Text = "Lista Prezentów";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblPrezent;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.TextBox txtPrezent;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnWyswietl;
        private System.Windows.Forms.ListBox listBoxPrezenty;
        private System.Windows.Forms.Label lblPodsumowanie;
    }
}