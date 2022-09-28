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

namespace Adivina_Numero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numero;
        public MainWindow()
        {
            InitializeComponent();
            numero = this.GenerarNumero(100);
        }
        public int GenerarNumero(int maximo) => new Random().Next(maximo + 1);

        private void ComprobarButtom_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(this.NombreTextBox.Text) < this.numero)
            {
                this.AcertadoTextBlock.Text = "Te quedas corto";
            }
            else if (int.Parse(this.NombreTextBox.Text) > this.numero)
            {
                this.AcertadoTextBlock.Text = "Te has pasado";
            }
            else
            {
                this.AcertadoTextBlock.Text = "Acertaste !!!";
            }
        }

        private void ReiniciarButtom_Click(object sender, RoutedEventArgs e)
        {
            this.numero = this.GenerarNumero(100);
            this.NombreTextBox.Text = "";
            this.AcertadoTextBlock.Text = "";
        }
    }
}
