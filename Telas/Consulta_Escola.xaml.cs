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

namespace MenuTela.Telas
{
    /// <summary>
    /// Lógica interna para Consulta_Escola.xaml
    /// </summary>
    public partial class Consulta_Escola : Window
    {
        public Consulta_Escola()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           MainWindow mainWindow = new MainWindow();
           mainWindow.Show();
           this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Consulta_Turma consulta_Turma = new Consulta_Turma();
            consulta_Turma.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Consulta_curso consulta_Curso = new Consulta_curso();
            consulta_Curso.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Consulta_aluno consulta_Aluno = new Consulta_aluno();
            consulta_Aluno.Show();
            this.Close();
        }
    }
}
