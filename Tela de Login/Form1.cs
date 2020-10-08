using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tela_de_Login
{
    public partial class Form1 : Form

    {
        Thread nt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Francisco" && textBox2.Text == "35540033")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
                //MessageBox.Show("Bem vindo ao Sistema!");
            }
            else
            {

                MessageBox.Show("Login ou Senha Incorreto!");
            }

        }

        private void novoForm()
        {
            Application.Run(new Form2());


            // esse codigo foi gerado quando eu criei o método "novoFor "throw new NotImplementedException();
        }
    }
}
