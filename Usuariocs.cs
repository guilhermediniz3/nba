using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace NBA3
{
    public partial class Usuariocs : Form
    {
        public Usuariocs()
        {
            InitializeComponent();

            populateComboboxes();
        }





        private void Usuariocs_Load(object sender, EventArgs e)
        {

        }

        private void btnbotao_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();


            MySqlConnection conexao = new MySqlConnection(conn);
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand("select * from usuario where nome = 'garrafinha'", conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    string usuario = (string)reader[0];
                    MessageBox.Show((String)reader[0]);
                    MessageBox.Show(usuario + "teste sucesso");

                }


            }



            catch (MySqlException msqle)
            {
                MessageBox.Show("ERRO DE CONEXAO" + msqle.Message, "erro");

            }
            finally
            {
                conexao.Close();


            }
        }

        private void butao_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();


            MySqlConnection conexao = new MySqlConnection(conn);
            try
            {
                conexao.Open();
                String nome = "guilhermo";
                String senha = "9292";
                int nivel = 10;
                String email = "teste";

                String query = $"insert into usuario values ('{nome}', {senha}, {nivel}, '{email}')";
                MessageBox.Show(query);
                MySqlCommand comando = new MySqlCommand(query, conexao);
                MySqlDataReader reader = comando.ExecuteReader();
            }
            catch (MySqlException err)
            {
                MessageBox.Show("ERRO DE CONEXAO" + err.Message, "erro");
            }
        }

        private void btnteste_Click(object sender, EventArgs e)
        {

            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();


            MySqlConnection conexao = new MySqlConnection(conn);
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand("select * from usuario where nome = 'garrafinha'", conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string usuario = (string)reader[0];
                    string senha = (string)reader[1];
                    lblresultado.Text = String.Format(usuario);
                    lblsenha.Text = ((string)senha);
                }


            }



            catch (MySqlException msqle)
            {
                MessageBox.Show("ERRO DE CONEXAO" + msqle.Message, "erro");

            }
            finally
            {
                conexao.Close();


            }





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btntime_Click(object sender, EventArgs e)
        {


        }

        private void populateComboboxes()
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();

            MySqlConnection conexao = new MySqlConnection(conn);
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand("select * from club", conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string nome_club = (string)reader[1];
                    comboBox2.Items.Add(nome_club);
                    comboBox1.Items.Add(nome_club);

                }
            }
            catch (MySqlException msqle)
            {
                MessageBox.Show("ERRO DE CONEXAO" + msqle.Message, "erro");

            }
            finally
            {
                conexao.Close();


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Time2Selecionado = comboBox2.SelectedItem.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Time1Selecionado = comboBox1.SelectedItem.ToString();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();

            MySqlConnection conexao = new MySqlConnection(conn);
            try
            {
                conexao.Open();
                
                String Time1Selecionado = comboBox1.SelectedItem.ToString();

               
                MySqlCommand comando = new MySqlCommand($"select nome_club,sum((pts + ast +stl + blk) - (fg3a + fga) -  (fta - ftm) + (turnover * 2)) as eficiencia from club, jogador, resultado, estadio where estadio.id_estadio = resultado.id_estadio and jogador.id_jogador = resultado.id_jogador and club.id_club = jogador.id_club and resultado.id_resultado = jogador.id_jogador and nome_club = '{Time1Selecionado}'", conexao);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataTable result1 = new DataTable();
                adapter.Fill(result1);
                double eficienciaA = 0;
                if (result1.Rows.Count > 0)
                {
                    lblvalorindiceTimeA.Text = result1.Rows[0][1].ToString();
                    eficienciaA = (double)result1.Rows[0][1];
                }
                String Time2Selecionado = comboBox2.SelectedItem.ToString();
                if (comboBox2.SelectedItem.ToString() == (string.Empty) )

                {
                    Console.WriteLine("Informe o segundo Time para continuar :");
                    
                }

                MySqlCommand comando2 = new MySqlCommand($"select nome_club,sum((pts + ast +stl + blk) - (fg3a + fga) -  (fta - ftm) + (turnover * 2)) as eficiencia from club, jogador, resultado, estadio where estadio.id_estadio = resultado.id_estadio and jogador.id_jogador = resultado.id_jogador and club.id_club = jogador.id_club and resultado.id_resultado = jogador.id_jogador and nome_club = '{Time2Selecionado}'", conexao);
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(comando2);
                DataTable result2 = new DataTable();
                adapter2.Fill(result2);
                double eficienciaB = 0;
                if (result2.Rows.Count > 0)
                {
                    lblvalorindiceTimeB.Text = result2.Rows[0][1].ToString();
                    eficienciaB = (double)result2.Rows[0][1];
                }

                if (Time1Selecionado == Time2Selecionado || Time2Selecionado == Time1Selecionado)

                {
                    Console.WriteLine("Não é possível comparar o mesmo Time :");


                }
               



                double porcentagemA = eficienciaA / (eficienciaA + eficienciaB) * 100;
                double porcentagemB = eficienciaB / (eficienciaA + eficienciaB) * 100;

                lblporcentagemA.Text = porcentagemA.ToString("F1") + "%";
                lblporcentagemB.Text = porcentagemB.ToString("F1") + "%";
                if (porcentagemA > porcentagemB)

                {
                    lblporcentagemA.ForeColor = System.Drawing.Color.Green;
                    lblporcentagemB.ForeColor = System.Drawing.Color.Red;

                }

                else
                {
                    lblporcentagemB.ForeColor = System.Drawing.Color.Green;
                    lblporcentagemA.ForeColor = System.Drawing.Color.Red;


                }
       

               
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    //string nome_club = (string)reader[1];
                    double eficiencia = (double)reader[1];
                    lblindicetimeA.Text = (eficiencia.ToString());

                }
            }
            catch (MySqlException msqle)
            {
                MessageBox.Show("ERRO DE CONEXAO" + msqle.Message, "erro");

            }
            finally
            {
                conexao.Close();


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
