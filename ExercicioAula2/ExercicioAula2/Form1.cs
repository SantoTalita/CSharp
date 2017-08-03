using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioAula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeTalita = 28;
            int idadeCiro = 31;
            int idadeAmelie = 0;

            double media = (idadeTalita + idadeCiro + idadeAmelie) / 3;
            MessageBox.Show("A média das idades é :" + media); 
        }
    }
}
