using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MT_u.Usuario;
using MTBE_u;
using MTBE_u.Entities.Enums;
using MTBE_u.Exceptions;
using MtCash;
using MtCash.BusinessEntities;
using Aux_Mt;

namespace MT_u
{
    public partial class frmLogin : frmDefault
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    bool sucesso = false;

        //    if (txtUsuario.Text.Length > 0 && txtSenha.Text.Length > 0)
        //        try
        //        {
        //            Usuario usuario = Usuario.Logar(txtUsuario.Text, txtSenha.Text);

        //             //usuario = Usuario.Logar(usuario.Login, usuario.Senha);

        //            if (usuario.Idpessoa > 0)
        //            {
        //                MessageBox.Show($"Olá  {usuario.Login}\nGostamos de ter você aqui!", "Logado com sucesso ! ");
        //                sucesso = true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Erro !\nNão foi possível acessar!", "Line 45, frmLogin.cs");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //}

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                EfetuaLogin();
            }
            catch (UsuarioException ex)
            {                
                MessageBox.Show(ex.Message, "Não foi possível efetuar o login!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                txtUsuario.Select(0, txtUsuario.Text.Length);
            } 
            catch (Exception ex)
            {
                LOG.Insert(ex, null);
                MessageBox.Show(ex.Message, "Ops !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void EfetuaLogin()
        {
            if (txtUsuario.Text.Trim().Length == 0)            
                throw new UsuarioException("Preencha o login corretamente!");
            
            if(txtSenha.Text.Trim().Length == 0)
                throw new UsuarioException("Preencha a senha corretamente!");

            else
            {
                MTBE_u.Usuario usuario = new MTBE_u.Usuario();
                usuario._Usuario = txtUsuario.Text.Trim();
                usuario.Senha = Access.Encrypt(txtUsuario.Text.Trim(), txtSenha.Text.Trim());

                usuario = usuario.Logar(usuario);

                if (usuario.Id_Pessoa <= 0)                
                    throw new UsuarioException("Usuário ou senha inválidos!");

                if(!(bool)usuario.User_atv)
                    throw new UsuarioException("Usuário bloqueado ou inativo!");

                else
                {
                    MessageBox.Show("Seja bem-vindo, " + usuario.Nome + ".\n\n - Hoje é dia: " + DateTime.Now.ToString("dd/MM/yyyy"), "Você está logado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login log = new Login(usuario);
                  //  Login.Modulo._Permissoes = Modulo.GetPermition(usuario).Where(x => x.);
                    this.Hide();
                    using (MDI_MtCash mdi_mtcash = new MDI_MtCash(Login.User))
                    {
                        DialogResult = mdi_mtcash.ShowDialog();
                        if (DialogResult != DialogResult.OK)
                        {
                            //if (MessageBox.Show("Deseja encerrar o programa?", "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                Application.Exit();                            
                        }
                    }
                    this.Visible = true;
                }
            }
        }
        private void LimparCamposLogin()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            Login.User = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (frmConfigurarU frmUsuario = new frmConfigurarU())
            {
                frmUsuario.ShowDialog();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
                btnLogin.PerformClick();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                txtSenha.Focus();
                txtSenha.Select(0, txtSenha.Text.Length);
            }
        }
    }
}
