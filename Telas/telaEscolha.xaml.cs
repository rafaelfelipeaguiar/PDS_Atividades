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

namespace Atividade1e2.Telas
{
    /// <summary>
    /// Lógica interna para telaEscolha.xaml
    /// </summary>
    public partial class telaEscolha : Window
    {
        public telaEscolha()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random numAleatorio = new Random();
            int escolha = numAleatorio.Next(1, 7);

            if (escolha == 1)
            {
                telaFinal1 cha1 = new telaFinal1();
                cha1.ShowDialog();
            }
            if (escolha == 2)
            {
                telaFinal2 cha2 = new telaFinal2();
                cha2.ShowDialog();
            }
            if (escolha == 3)
            {
                telaFinal3 cha3 = new telaFinal3();
                cha3.ShowDialog();
            }
            if (escolha == 4)
            {
                telaFinal4 cha4 = new telaFinal4();
                cha4.ShowDialog();
            }
            if (escolha == 5)
            {
                telaFinal5 cha5 = new telaFinal5();
                cha5.ShowDialog();
            }
            if (escolha == 6)
            {
                telaFinal6 cha6 = new telaFinal6();
                cha6.ShowDialog();
            }
            if (escolha == 7)
            {
                telaFinal6 cha6 = new telaFinal6();
                cha6.ShowDialog();
            }
        }
    }
}
