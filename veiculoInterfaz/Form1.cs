using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace veiculoInterfaz
{
    public partial class Form1 : Form
    {
        Camara camara;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            camara = new Camara(100,pictureBox1,comboBox1);
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            camara.EncenderCamara(Convert.ToInt16(comboBox1.SelectedIndex.ToString().Substring(0,1)));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            camara.Listar();
            try
            {
                comboBox1.SelectedIndex = 0;
            }
            catch { }
        }
    }
}
