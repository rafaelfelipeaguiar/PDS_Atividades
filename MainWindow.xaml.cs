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

namespace Atividade1e2
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nome=txtNome.Text;
            string senha=psdSenha.Password.ToString();

            Tela2 tela2 = new Tela2();

            if(nome=="ADM" && senha=="hehe")
            {
                tela2.ShowDialog();
            }

        }

        private void txtNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
