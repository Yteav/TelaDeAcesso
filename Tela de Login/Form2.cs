using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_de_Login
{
    public partial class Form2 : Form
    {  
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.Red;
          
            label1.Text = "Sistema Ativado!";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Sistema Desativado!";        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
