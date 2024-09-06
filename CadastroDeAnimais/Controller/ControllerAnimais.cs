using CadastroDeAnimais.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAnimais.Controller
{
    internal class ControllerAnimais
    {
        //crud
        //c-create/inserir registros na tabela do banco
        //r-read/ler os registros da tabela do banco
        //u-update/Alterar registros da tabela do banco
        //d-delete/Apagar registros da tabela do banco

        //Método de inserir registros na tabela do banco
       public void EnviarBanco()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PCadastroAnimais",cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", Animais.Nome);
                cmd.Parameters.AddWithValue("@raca", Animais.Raca);
                cmd.Parameters.AddWithValue("@porte", Animais.Porte);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
