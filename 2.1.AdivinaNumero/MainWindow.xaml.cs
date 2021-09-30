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

namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int numeroRandom;
        public MainWindow()
        {
            InitializeComponent();
             numeroRandom = random.Next(1, 100);
        }
       
           
        

        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            
           
            if (int.Parse(IntroducirTextBox.Text) == numeroRandom)
            {
                ResultadoTextBlock.Text = "Has Acertadooo !! " ;
            }
            else
            {
                ResultadoTextBlock.Text = "Has fallado !! ";
            }
           
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            numeroRandom = random.Next(1, 100);
        }
    }
}
