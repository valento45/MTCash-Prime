using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;
using MTBE_u.Gateway;

namespace MTBE_u.Entities
{
    public class Cliente : Pessoa
    {
        public Cliente() { }
        public Cliente(DataRow dr)
        {
            Id_Pessoa = Convert.ToInt32(dr["id_cliente"]);
            Nome = dr["nome"].ToString();
            Tipo_Documento = dr["tipo_documento"].ToString();
            Documento = dr["documento"].ToString();
            Cpf_Cnpj = dr["cpf"].ToString();
            Data_Nascimento = (dr["data_nascimento"] != null ? (DateTime?)dr["data_nascimento"] : (DateTime?)null);
            Tipo_Pessoa = dr["tipo"].ToString();
        }

        public string Tipo_Pessoa { get; set; }

        public static int InsertClient(Cliente cliente)
        {
            int chave = -1;
            if (cliente != null)
            {
                SqlCommand cmd = new SqlCommand($"INSERT INTO mtcash.tb_cliente (nome, tipo_documento, documento, cpf, data_nascimento, tipo) values ('{cliente.Nome}', '{cliente.Tipo_Documento}', '{cliente.Documento}', '{cliente.Cpf_Cnpj}', '{cliente.Data_Nascimento}', '{cliente.Tipo_Pessoa}'); SELECT SCOPE_IDENTITY();");
                chave = Convert.ToInt32(Access.ExecuteScalar(cmd));
            }                
            return chave;
        }
        public static void DeleteClient(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from mtcash.tb_endereco_cliente where id_cliente =" + id);
            Access.ExecuteNonQuery(cmd);

            cmd.CommandText = "delete from mtcash.tb_cliente where id_cliente =" + id;
            Access.ExecuteNonQuery(cmd);
        }

        public static List<Cliente> ListarClients()
        {
            List<Cliente> result = new List<Cliente>();
            SqlCommand cmd = new SqlCommand("select * from mtcash.tb_cliente");
            foreach (DataRow cliente in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Cliente(cliente));

            if (result.Count > 0)
                return result;
            else
                return new List<Cliente>();

        }

        public static void UpdateClient(Cliente client)
        {
            if (client.Id_Pessoa > 0)
            {
                SqlCommand cmd = new SqlCommand($"update mtcash.tb_cliente set nome = '{client.Nome}', '{client.Tipo_Documento}, '{client.Documento}', '{client.Cpf_Cnpj}, '{client.Tipo_Pessoa}' where id_cliente = '{client.Id_Pessoa}';");
                Access.ExecuteNonQuery(cmd);
            }
        }

        public static Cliente GetById(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from mtcash.tb_cliente where id_cliente = " + id);
            DataTable dt = Access.ExecuteReader(cmd).Tables[0];

            if (dt.Rows.Count > 0)
                return new Cliente(dt.Rows[0]);
            else
                return new Cliente();
        }

        public static Cliente GetByDocument(string document)
        {
            SqlCommand cmd = new SqlCommand("select * from mtcash.tb_cliente where documento ='" + document + "';");
            DataTable dt = Access.ExecuteReader(cmd).Tables[0];

            if (dt.Rows.Count > 0)
                return new Cliente(dt.Rows[0]);
            else
                return new Cliente();
        }

        public static bool ExportarXML(Cliente client)
        {
            bool sucesso = false;
            SaveFileDialog savefile = new SaveFileDialog();
            try
            {                
                XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", null));                
                XElement cabecalho = new XElement("CLIENTE");             
                XElement cliente = new XElement("registro");
                cliente.Add(new XElement("NOME", client.Nome));
                cliente.Add(new XElement("TIPODOCUMENTO", client.Tipo_Documento));
                cliente.Add(new XElement("DOCUMENTO", client.Documento));
                cliente.Add(new XElement("CPFCNJP", client.Cpf_Cnpj));
                cliente.Add(new XElement("DATANASCIMENTO", client.Data_Nascimento));
                cliente.Add(new XElement("TIPOPESSOA", client.Tipo_Pessoa));                
                
                cabecalho.Add(cliente);
                xml.Add(cabecalho);
                
                savefile.Filter = "Xml (*.xml) | *xml| All files (*.*) |*.*";
                savefile.FilterIndex = 2;
                savefile.RestoreDirectory = true;

                if(savefile.ShowDialog() == DialogResult.OK)
                {
                    xml.Save(savefile.FileName + "Cliente" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss").Replace("/", "").Replace(":", "") + ".xml");
                    sucesso = true;
                    MessageBox.Show("Arquivo salvo em: " + savefile.FileName, "xml salvo em log " + DateTime.Now.ToString("dd/MM/yyyy - HH:ss:mm"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                NetworkLog.Insert(ex, savefile.FileName);
                sucesso = false;
                MessageBox.Show("O arquivo pode não ter sido salvo corretamente! \r\n\r\n\r\n" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return sucesso;
        }
    }


    /*CLASSE ENDERECO CLIENTE*/
    public class EnderecoCliente : Endereco
    {
        public Cliente Cliente_ { get; set; }

        public static void InsertEnderecoClient(Endereco endereco, int cliente)
        {
            if (cliente > 0)
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"INSERT INTO mtcash.tb_endereco_cliente (uf, cidade, endereco, numero, complemento, id_cliente) values ('{endereco.Uf}', '{endereco.Cidade}', '{endereco.Endereco_}', '{endereco.Numero}', '{endereco.Complemento}', '{cliente}');";
                    Access.ExecuteReader(cmd);
                }
                catch (Exception ex)
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
