using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            cboLista.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboLista.SelectedIndex == -1) {
                MessageBox.Show("Nenhum item foi selecionado !!! ", "ComboBox", MessageBoxButtons.OK);
            }
            else 
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            cboLista.Items.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            cboLista.SelectedIndex = -1;
            textBox1.Text = ":";
            textBox1.Text = "";
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void cboLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLista.SelectedIndex != -1)
            { 
            lblPosLista.Text = cboLista.SelectedIndex.ToString();
            lblTextoSel.Text = cboLista.SelectedItem.ToString();
            lblTotal.Text = cboLista.Items.Count.ToString();
            }
        }
    }
}
