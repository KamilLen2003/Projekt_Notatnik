using System;
using System.IO;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Form1 : Form
    {
        private string sciezkaPliku = "notatnik.txt"; // Ścieżka do pliku

        public Form1()
        {
            InitializeComponent();
        }

        // Zapis do pliku tekstu
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                string tekst = "\r\n" + txtWpiszTekst.Text; // Nowa linia
                File.AppendAllText(sciezkaPliku, tekst);
                txtWpiszTekst.Text = " "; // czyszczenie pola po zapisaniu

            }

            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // Wczytuje tekst z pliku i wyświetla
        private void btnWyswietl_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(sciezkaPliku))
                {
                    txtZawartoscNotatnika.Text = File.ReadAllText(sciezkaPliku);
                }
                else
                {
                    txtZawartoscNotatnika.Text = "Brak zapisanych notatek!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd odczytu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
