namespace Notatnik
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWprowadzTekst;
        private System.Windows.Forms.Label lblZawartoscNotatnika;
        private System.Windows.Forms.TextBox txtWpiszTekst;
        private System.Windows.Forms.TextBox txtZawartoscNotatnika;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnWyswietl;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWprowadzTekst = new System.Windows.Forms.Label();
            this.lblZawartoscNotatnika = new System.Windows.Forms.Label();
            this.txtWpiszTekst = new System.Windows.Forms.TextBox();
            this.txtZawartoscNotatnika = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnWyswietl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWprowadzTekst
            // 
            this.lblWprowadzTekst.AutoSize = true;
            this.lblWprowadzTekst.Location = new System.Drawing.Point(340, 45);
            this.lblWprowadzTekst.Name = "lblWprowadzTekst";
            this.lblWprowadzTekst.Size = new System.Drawing.Size(87, 13);
            this.lblWprowadzTekst.TabIndex = 0;
            this.lblWprowadzTekst.Text = "Wprowadź tekst:";
            // 
            // lblZawartoscNotatnika
            // 
            this.lblZawartoscNotatnika.AutoSize = true;
            this.lblZawartoscNotatnika.Location = new System.Drawing.Point(337, 211);
            this.lblZawartoscNotatnika.Name = "lblZawartoscNotatnika";
            this.lblZawartoscNotatnika.Size = new System.Drawing.Size(107, 13);
            this.lblZawartoscNotatnika.TabIndex = 1;
            this.lblZawartoscNotatnika.Text = "Zawartość notatnika:";
            // 
            // txtWpiszTekst
            // 
            this.txtWpiszTekst.Location = new System.Drawing.Point(340, 65);
            this.txtWpiszTekst.Multiline = true;
            this.txtWpiszTekst.Name = "txtWpiszTekst";
            this.txtWpiszTekst.Size = new System.Drawing.Size(400, 60);
            this.txtWpiszTekst.TabIndex = 0;
            // 
            // txtZawartoscNotatnika
            // 
            this.txtZawartoscNotatnika.BackColor = System.Drawing.Color.White;
            this.txtZawartoscNotatnika.Location = new System.Drawing.Point(340, 227);
            this.txtZawartoscNotatnika.Multiline = true;
            this.txtZawartoscNotatnika.Name = "txtZawartoscNotatnika";
            this.txtZawartoscNotatnika.ReadOnly = true;
            this.txtZawartoscNotatnika.Size = new System.Drawing.Size(413, 236);
            this.txtZawartoscNotatnika.TabIndex = 1;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(340, 160);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(80, 30);
            this.btnZapisz.TabIndex = 2;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnWyswietl
            // 
            this.btnWyswietl.Location = new System.Drawing.Point(660, 160);
            this.btnWyswietl.Name = "btnWyswietl";
            this.btnWyswietl.Size = new System.Drawing.Size(80, 30);
            this.btnWyswietl.TabIndex = 3;
            this.btnWyswietl.Text = "Wyświetl";
            this.btnWyswietl.Click += new System.EventHandler(this.btnWyswietl_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1074, 505);
            this.Controls.Add(this.lblWprowadzTekst);
            this.Controls.Add(this.lblZawartoscNotatnika);
            this.Controls.Add(this.txtWpiszTekst);
            this.Controls.Add(this.txtZawartoscNotatnika);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnWyswietl);
            this.Name = "Form1";
            this.Text = "Notatnik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
