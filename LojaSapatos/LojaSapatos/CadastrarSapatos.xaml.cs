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

namespace LojaSapatos
{
    /// <summary>
    /// Lógica interna para CadastrarSapatos.xaml
    /// </summary>
    public partial class CadastrarSapatos : Window
    {
        public CadastrarSapatos()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sapatos sapatos = new Sapatos();

            sapatos.nome = nm_sapato.Text;
            if(cadarco_y.IsChecked == true)
            {
                sapatos.cadarco = true;
            }
            sapatos.material = nm_material.Text;
            sapatos.cor = nm_cor.Text;
            sapatos.preco = double.Parse(nm_preco.Text);

            sapatos.lista_sapatos.Add(sapatos);
        }
    }
}
