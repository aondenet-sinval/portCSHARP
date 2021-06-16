using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DTO;
using System.Data.SqlClient;

namespace Loja.DAL
{
    public class UsuarioDAL
    {
        /*Metodo cargaUsuario, retorna uma Lista de objetos usuario DTO
         * (composto por vários atributos), vai até o BD e busca todos os usuários.
         * Usamos o try e Catch caso dê algum erro, retorna para a camada view
         * Executar o método cargaUsuario (será criado na DAL)
         * */
        public IList<Usuario_DTO> cargaUsuario()
        {
            try
            {
                /*Conexão com BD
                 * Seleciona todos os dados da tb_usuarios*/
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT*FROM tb_usuarios";
                CM.Connection = CON;
                SqlDataReader ER;
                IList<Usuario_DTO> listUsuarioDTO = new List<Usuario_DTO>();
                CON.Open();
                ER = CM.ExecuteReader();
                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        Usuario_DTO usu = new Usuario_DTO();
                        /*nome dos objetos criados na DTO
                         * Cada objeto criado é enviado para a lista, possibilitando
                         * que no final vc tenha uma lista com vários usuários */
                        usu.Cod_usuario = Convert.ToInt32(ER["Cod_usuario"]);
                        usu.Perfil = Convert.ToInt32(ER["Perfil"]);
                        usu.Cadastro = Convert.ToDateTime(ER["Cadastro"]);
                        usu.Nome = Convert.ToString(ER["Nome"]);
                        usu.Email = Convert.ToString(ER["Email"]);
                        usu.Login = Convert.ToString(ER["Cadastro"]);
                        usu.Senha = Convert.ToString(ER["Senha"]);
                        usu.Situacao = Convert.ToString(ER["Situacao"]);
                        listUsuarioDTO.Add(usu);
                    }
                }
                return listUsuarioDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insereUsuario(Usuario_DTO USU)
        {
            try
            {
                /*Conexão com BD
                * Inserindo dados na tb_usuarios*/
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO tb_usuarios (Nome, Login, Email, Senha, Cadastro, Situacao, Perfil)" + "VALUES (@Nome, @Login, @Email, @Senha, @Cadastro, @Situacao, @Perfil)";
                /*Parameters irá substituir os valores dentro do campo */
                CM.Parameters.Add("Nome", System.Data.SqlDbType.VarChar).Value = USU.Nome;
                CM.Parameters.Add("Login", System.Data.SqlDbType.VarChar).Value = USU.Login;
                CM.Parameters.Add("Email", System.Data.SqlDbType.VarChar).Value = USU.Email;
                CM.Parameters.Add("Senha", System.Data.SqlDbType.VarChar).Value = USU.Senha;
                CM.Parameters.Add("Cadastro", System.Data.SqlDbType.DateTime).Value = USU.Cadastro;
                CM.Parameters.Add("Situacao", System.Data.SqlDbType.NVarChar).Value = USU.Situacao;
                CM.Parameters.Add("Perfil", System.Data.SqlDbType.Int).Value = USU.Perfil;
                CM.Connection = CON;
                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int editaUsuario(Usuario_DTO USU)
        {
            try
            {
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                /*Atenção ao nome dos campos que deve ser igual ao Banco de Dados*/
                CM.CommandText = "UPDATE tb_usuarios SET Perfil=@Perfil," +
                "Nome=@Nome," + "Login=@Login," + "Email=@Email," + "Senha=@Senha," +
                "Cadastro=@Cadastro," + "Situacao=@Situacao" + "WHERE Cod_usuario=@Cod_usuario";
                /*Parameters irá substituir os valores dentro do campo*/
                CM.Parameters.Add("Perfil", System.Data.SqlDbType.Int).Value = USU.Perfil;
                CM.Parameters.Add("Nome", System.Data.SqlDbType.VarChar).Value = USU.Nome;
                CM.Parameters.Add("Login", System.Data.SqlDbType.VarChar).Value = USU.Login;
                CM.Parameters.Add("Email", System.Data.SqlDbType.VarChar).Value = USU.Email;
                CM.Parameters.Add("Senha", System.Data.SqlDbType.VarChar).Value = USU.Senha;
                CM.Parameters.Add("Cadastro", System.Data.SqlDbType.DateTime).Value = USU.Cadastro;
                CM.Parameters.Add("Situacao", System.Data.SqlDbType.VarChar).Value = USU.Situacao;
                CM.Parameters.Add("Cod_usuario", System.Data.SqlDbType.VarChar).Value = USU.Situacao;
                CM.Connection = CON;
                /*Abre conexão*/
                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int deletaUsuario(Usuario_DTO USU)
        {
            try
            {
                /*Excluindo dados na tb_usuarios*/
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "DELETE tb_usuarios WHERE Cod_usuario = @Cod_usuario";
                /*Têm um único parâmetro que será o código do usuário, só existe um*/
                CM.Parameters.Add("Cod_usuario", System.Data.SqlDbType.Int).Value = USU.Cod_usuario;
                CM.Connection = CON;
                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                /*Retorna registros afetados*/
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
