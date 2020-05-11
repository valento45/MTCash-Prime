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
        List<ContatoCliente> Contato;
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

            //if (Id_Pessoa > 0)
            //    Contato = ContatoCliente.GetByClient(Id_Pessoa);
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
                SqlCommand cmd = new SqlCommand($"update mtcash.tb_cliente set nome = '{client.Nome}', tipo_documento = '{client.Tipo_Documento}', documento = '{client.Documento}', cpf = '{client.Cpf_Cnpj}', data_nascimento = '{client.Data_Nascimento}', tipo = '{client.Tipo_Pessoa}' where id_cliente = '{client.Id_Pessoa}';");
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

        public static void ExportarXML(Cliente client)
        {
            SaveFileDialog savefile = new SaveFileDialog();
                try
                {
                    XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", null));
                    XElement cabecalho = new XElement("CLIENTE");
                    XElement cliente = new XElement("registro");
                    cliente.Add(new XElement("CODIGO", client.Id_Pessoa));
                    cliente.Add(new XElement("NOME", client.Nome));
                    cliente.Add(new XElement("TIPODOCUMENTO", client.Tipo_Documento));
                    cliente.Add(new XElement("DOCUMENTO", client.Documento));
                    cliente.Add(new XElement("CPFCNJP", client.Cpf_Cnpj));
                    cliente.Add(new XElement("DATANASCIMENTO", client.Data_Nascimento));
                    cliente.Add(new XElement("TIPOPESSOA", client.Tipo_Pessoa));

                    var list_endereco = EnderecoCliente.GetListByIdClient(client.Id_Pessoa);

                    if (list_endereco.Count > 0)
                        foreach (var x in list_endereco.OrderBy(n => n.id_endereco_cliente))
                        {
                            int i = 1;
                            XElement endereco = new XElement("ENDERECO" + i);
                            endereco.Add(new XElement("UF", x.Uf));
                            endereco.Add(new XElement("CIDADE", x.Cidade));
                            endereco.Add(new XElement("ENDERECO", x.Endereco_));
                            endereco.Add(new XElement("NUMERO", x.Numero));
                            endereco.Add(new XElement("COMPLEMENTO", x.Complemento));

                            cliente.Add(endereco);
                            i++;
                        }

                    cabecalho.Add(cliente);
                    xml.Add(cabecalho);

                    savefile.Filter = "Xml (*.xml) | *xml| All files (*.*) |*.*";
                    savefile.FilterIndex = 2;
                    savefile.FileName = "cliente" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss").Replace("/", "-").Replace(":", "");
                    savefile.RestoreDirectory = true;

                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        xml.Save(savefile.FileName + ".xml");
                        MessageBox.Show("Arquivo salvo em: " + savefile.FileName, "log " + DateTime.Now.ToString("dd/MM/yyyy - HH:ss:mm"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    NetworkLog.Insert(ex, savefile.FileName);
                    MessageBox.Show("O arquivo pode não ter sido salvo corretamente! \r\n\r\n\r\n" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
    }


    /*CLASSE ENDERECO CLIENTE*/
    public class EnderecoCliente : Endereco
    {
        public int id_cliente { get; set; }
        public int id_endereco_cliente { get; set; }
        public ContatoCliente Contato { get; set; }

        public Cliente Cliente_ { get; set; }
        public EnderecoCliente() { }
        public EnderecoCliente(DataRow dr)
        {
            id_endereco_cliente = Convert.ToInt32(dr["id_endereco_cliente"]);
            Uf = dr["uf"].ToString();
            Cidade = dr["cidade"].ToString();
            Endereco_ = dr["endereco"].ToString();
            Numero = Convert.ToInt32(dr["numero"]);
            Complemento = dr["complemento"].ToString();
            id_cliente = Convert.ToInt32(dr["id_cliente"]);
        }
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

        public static void DeleteEnderecoClient(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from mtcash.tb_endereco_cliente where id_cliente = " + id);
            Access.ExecuteNonQuery(cmd);
        }

        public static List<EnderecoCliente> GetListByIdClient(int id)
        {
            List<EnderecoCliente> result = new List<EnderecoCliente>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM mtcash.tb_endereco_cliente where id_cliente =" + id);
            foreach (DataRow row in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new EnderecoCliente(row));

            if (result.Count > 0)
                return result;
            else
                return new List<EnderecoCliente>();
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
        public int Id_contato_cliente { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Id_cliente { get; set; }

        public ContatoCliente() { }
        public ContatoCliente(DataRow dr)
        {
            Id_contato_cliente = Convert.ToInt32(dr["id_contato_cliente"]);
            Email = dr["email"].ToString();
            Telefone = dr["telefone"].ToString();
            Id_cliente = Convert.ToInt32(dr["id_cliente"]);
        }

        public static List<ContatoCliente> GetByClient(int id)
        {
            List<ContatoCliente> result = new List<ContatoCliente>();
            SqlCommand cmd = new SqlCommand("select * from mtcash.tb_contato_cliente where id_cliente =" + id);
            foreach (DataRow row in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new ContatoCliente(row));
            return result;
        }
        public static void Insert(ContatoCliente contatocliente, int cliente)
        {
            if (cliente > 0)
                try
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = $"INSERT INTO mtcash.tb_contato_cliente (email, telefone, id_cliente) values ('{contatocliente.Email}', '{contatocliente.Telefone}', '{cliente}');";
                    Access.ExecuteReader(cmd);
                }
                catch (Exception ex)
                {
                    NetworkLog.Insert(ex, null);
                    MessageBox.Show("Não foi possível cadastrar o contato!\r\n\r\n\r\nErro: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        public static void DeleteContatoClient(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from mtcash.tb_contato_cliente where id_cliente = " + id);
            Access.ExecuteNonQuery(cmd);
        }
    }
}
