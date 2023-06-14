using iRh.Windows.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            CarregarEstado();

        }
        private void CarregarEstado()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();
            var estadosAZ = listaEstados.OrderBy(x => x.Sigla).ToList();

            cmbEstados.Items.Clear();
            cmbEstados.DataSource = listaEstados.OrderBy(x => x.Sigla);
            cmbEstados.DisplayMember = "Sigla";
            cmbEstados.ValueMember = "Id";

            cmbEstados.SelectedValue = 12;

        }


      
    }
}
 