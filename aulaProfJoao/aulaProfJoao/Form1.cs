using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaProfJoao
{
    public partial class Form1 : Form
    {
        List<Usuario> listaUsuario = new List<Usuario>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            tx_nome.Text = "";      
            tx_email.Text = "";
            tx_estado.Text = "";
            tx_endereco.Text = "";
            tx_cidade.Text = "";
            tx_salario.Text = "";
            cb_funcao.Text = "";
            cb_momento.Text = "";
            dt_nascimento.Text = DateTime.Now.ToString();
            mtx_RG.Text = "";
            mtx_telefone.Text = "";
            mtx_CPF.Text = "";
          
        }

        private void bt_concluir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.SetCpf(mtx_CPF.Text);
            usuario.SetNome(tx_nome.Text);
            usuario.SetSalario(Convert.ToDouble( tx_salario.Text));
            listaUsuario.Add(usuario);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
