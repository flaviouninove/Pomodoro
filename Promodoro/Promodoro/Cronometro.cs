using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promodoro
{
    public partial class Cronometro : Form
    {

        int minutos = 25;
        int soma = 0;
        int pausa = 5;


        public Cronometro()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            soma = soma - 1;
            lbtempo.Text = Convert.ToString(soma);
            if (soma == 0)
            {
                timer1.Stop();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (soma == 0)
            {

                soma = soma + (minutos * 60);
                timer1.Interval = 1000;
                timer1.Start();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (soma == 0)
            {
                soma = soma + (pausa * 60);
                timer1.Interval = 1000;
                timer1.Start();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            soma = 0;
            lbtempo.Text = "0";
        }

        private void lbtempo_Click(object sender, EventArgs e)
        {

        }
    }
}
