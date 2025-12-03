using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Zuk_Zaliczenie
{
    public partial class Form1 : Form
    {
        private List<Prezent> listaPrezentow = new List<Prezent>();

        public Form1()
        {
            InitializeComponent();

            // Podłączenie przycisków do właściwych metod
            btnDodaj.Click += btnDodaj_Click;
            btnWyswietl.Click += btnWyswietl_Click;
        }

        // Dodawanie prezentu
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string imie = txtImie.Text.Trim();
            string nazwa = txtPrezent.Text.Trim();
            double cena;

            if (string.IsNullOrEmpty(imie) || string.IsNullOrEmpty(nazwa))
            {
                MessageBox.Show("Uzupełnij imię i nazwę prezentu!");
                return;
            }

            if (!double.TryParse(txtCena.Text, out cena) || cena <= 0)
            {
                MessageBox.Show("Podaj poprawną cenę!");
                return;
            }

            listaPrezentow.Add(new Prezent(imie, nazwa, cena));
            MessageBox.Show("Prezent dodany!");

            // Czyszczenie pól
            txtImie.Text = "";
            txtPrezent.Text = "";
            txtCena.Text = "";

            // Od razu aktualizujemy ListBox
            AktualizujListBox();
        }

        // Wyświetlanie prezentów (opcjonalne)
        private void btnWyswietl_Click(object sender, EventArgs e)
        {
            AktualizujListBox();
        }

        // Metoda do aktualizacji ListBox i podsumowania
        private void AktualizujListBox()
        {
            listBoxPrezenty.Items.Clear();
            double suma = 0;

            foreach (var p in listaPrezentow)
            {
                listBoxPrezenty.Items.Add($"{p.Imie} - {p.Nazwa} - {p.Cena} zł");
                suma += p.Cena;
            }

            lblPodsumowanie.Text = $"Liczba prezentów: {listaPrezentow.Count}   Łączny koszt: {suma} zł";
        }
    }

    // Klasa prezentu
    public class Prezent
    {
        public string Imie { get; set; }
        public string Nazwa { get; set; }
        public double Cena { get; set; }

        public Prezent(string imie, string nazwa, double cena)
        {
            Imie = imie;
            Nazwa = nazwa;
            Cena = cena;
        }
    }
}
