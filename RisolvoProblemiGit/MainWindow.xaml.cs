using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VerificaTPS
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biblioteca x;
        public MainWindow()
        {
            InitializeComponent();
            x = new Biblioteca();
        }

        private void AggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            Libro y = new Libro(TxtNome.Text, TXTtitolo.Text, TxtData.Text, TxtEditor.Text, int.Parse(TXTnumeroPagine.Text));
            x.AggiungiLibro(y);
            ListaBox.ItemsSource = "";
            ListaBox.ItemsSource = x._listaLibri;
            Totale_Libri_Presenti.Content = x.NumeroLibriPresenti();
        }

        private void RicercaPerTitolo_Click(object sender, RoutedEventArgs e)
        {
            List<Libro> ListaPerTitolo = x.RicercaLibroPerTitolo(TXTtitolo.Text);
            ListaBox.ItemsSource = "";
            ListaBox.ItemsSource = ListaPerTitolo;
            Totale_Libri_Presenti.Content = x.NumeroLibriPresenti();
        }

        private void RicercaPerAutore_Click(object sender, RoutedEventArgs e)
        {
            List<Libro> ListaPerAutore = x.RIcercaPerAutore(TxtNome.Text);
            ListaBox.ItemsSource = "";
            ListaBox.ItemsSource = ListaPerAutore;
            Totale_Libri_Presenti.Content = x.NumeroLibriPresenti();
        }

        private void ListaBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Libro Prova = (Libro)ListaBox.SelectedItem;
            if(ListaBox.SelectedIndex!=-1)
            {
                MessageBox.Show("Per leggerlo servono " + Prova.CalcolaTempoLettura());
            }
        }
    }
}
