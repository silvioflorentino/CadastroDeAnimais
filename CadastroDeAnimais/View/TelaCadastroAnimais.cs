using CadastroDeAnimais.Controller;
using CadastroDeAnimais.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeAnimais.View
{
    public partial class TelaCadastroAnimais : Form
    {
        public TelaCadastroAnimais()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Animais.Nome = tbx_name.Text;
            Animais.Raca = tbx_Raca.Text;
            Animais.Porte = cbx_Porte.Text;

            ControllerAnimais controllerAnimais = new ControllerAnimais();
            controllerAnimais.EnviarBanco();

        }
    }
}
