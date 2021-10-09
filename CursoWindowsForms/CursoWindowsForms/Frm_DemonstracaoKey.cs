using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void Txt_Entrada_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Informacoes.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n");
            Txt_Informacoes.AppendText("\t" + "Código da tecla: " + ((int)e.KeyCode) + "\r\n");
            Txt_Informacoes.AppendText("\t" + "Nome da tecla: " + e.KeyData + "\r\n");

            Lbl_ResultadoMinuscula.Text = e.KeyCode.ToString().ToLower();
            Lbl_ResultadoMaiuscula.Text = e.KeyCode.ToString().ToUpper();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Informacoes.Text = "";
            Txt_Entrada.Text = "";

            Lbl_ResultadoMinuscula.Text = "";
            Lbl_ResultadoMaiuscula.Text = "";
        }
    }
}
