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

namespace Atividade1e2.Telas
{
    /// <summary>
    /// Lógica interna para Tela3.xaml
    /// </summary>
    public partial class Tela3 : Window
    {
        public Tela3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tela4 chama = new tela4();
            chama.ShowDialog();
        }

        private void btSunga_Click(object sender, RoutedEventArgs e)
        {
            tela4 chama = new tela4();
            chama.ShowDialog();
        }

        private void btv_Click(object sender, RoutedEventArgs e)
        {
            tela4 chama = new tela4();
            chama.ShowDialog();
        }

        private void btJin_Click(object sender, RoutedEventArgs e)
        {
            tela4 chama = new tela4();
            chama.ShowDialog();
        }
    }
}
