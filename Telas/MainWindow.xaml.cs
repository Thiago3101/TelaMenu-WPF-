using MenuTela.Telas;
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

namespace MenuTela
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
            Cadastro_Escola cadastro_Escola = new Cadastro_Escola();
            cadastro_Escola.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Cadastro_curso cadastro_Curso = new Cadastro_curso();
            cadastro_Curso.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Cadastro_Turma cadastro_Turma = new Cadastro_Turma();
            cadastro_Turma.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Cadastro_aluno cadastro_aluno = new Cadastro_aluno();
            cadastro_aluno.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Consulta_Escola consulta_escola = new Consulta_Escola();
            consulta_escola.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Consulta_curso consulta_curso = new Consulta_curso();
            consulta_curso.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Consulta_Turma consulta_Turma = new Consulta_Turma();
            consulta_Turma.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Consulta_aluno consulta_Aluno = new Consulta_aluno();
            consulta_Aluno.Show();
            this.Close();
        }
    }
}
