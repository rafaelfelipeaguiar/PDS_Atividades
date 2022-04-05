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
    /// Lógica interna para tela4.xaml
    /// </summary>
    public partial class tela4 : Window
    {
        public tela4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            telaEscolha cha= new telaEscolha();
            cha.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            telaEscolha cha = new telaEscolha();
            cha.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            telaEscolha cha = new telaEscolha();
            cha.ShowDialog();
        }
    }
}
