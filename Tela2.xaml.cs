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
using System.Windows.Shapes;
using Atividade1e2.Telas;

namespace Atividade1e2
{
    /// <summary>
    /// Lógica interna para Tela2.xaml
    /// </summary>
    public partial class Tela2 : Window
    {
        public Tela2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Tela3 chama = new Tela3();

            chama.ShowDialog();
        }
    }
}
