using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTBE_u.Entities
{
    public class Cliente : Pessoa
    {
        public string Tipo_Pessoa { get; set; }

        public static int InsertCliente(Cliente cliente)
        {
            int chave = 0;
            try
            {
                SqlCommand cmd = new SqlCommand($"INSERT INTO mtcash.tb_cliente (nome, tipo_documento, documento, cpf, data_nascimento, tipo) values ('{cliente.Nome}', '{cliente.Tipo_Documento}', '{cliente.Documento}', '{cliente.Cpf_Cnpj}', '{cliente.Data_Nascimento}', '{cliente.Tipo_Pessoa}'); SELECT SCOPE_IDENTITY();");
                chave = Convert.ToInt32(Access.ExecuteScalar(cmd));
            }
            catch(Exception ex)
            {
                chave = -1;
                MessageBox.Show("Ocorreu um erro ao inserir o cliente!\r\n\r\n\r\n" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return chave;
        }

    }

    public class EnderecoCliente : Endereco
    {        
        public Cliente Cliente_ { get; set; }

        public static void InsertEnderecoCliente(Endereco endereco, int cliente)
        {
            if(cliente > 0)
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"INSERT INTO mtcash.tb_endereco_cliente (uf, cidade, endereco, numero, complemento, id_cliente) values ('{endereco.Uf}', '{endereco.Cidade}', '{endereco.Endereco_}', '{endereco.Numero}', '{endereco.Complemento}', '{cliente}');";
                    Access.ExecuteReader(cmd);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Não foi possível cadastrar o endereço!\r\n\r\n\r\nErro: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }            
        }

        //public static List<Endereco> ListarEnderecosCliente(int id)
        //{
        //    List<Endereco> result = new List<Endereco>();
        //    SqlCommand cmd = new SqlCommand("SELECT * FROM mtcash.tb_endereco_cliente where id_cliente =" + id);
        //    foreach(var end in Access.ExecuteReader())
        //}
    }

    public class ContatoCliente
    {

    }
}
