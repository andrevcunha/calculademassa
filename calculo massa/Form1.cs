using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace Calculo_Massa
{

    public partial class Form1 : Form
    {
        double Espessura;
        double Largura;
        double Comprimento;
        double Massa;
         
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Aço");
            comboBox1.Items.Add("Alumínio");
            comboBox1.Items.Add("Cobre");
            comboBox1.Items.Add("Galvalume");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Aço")
            {
                comboBox2.Items.Clear();
                comboBox2.ResetText();
                comboBox3.Items.Clear();
                comboBox3.ResetText();
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox2.Items.Add("Chapa");
                comboBox2.Items.Add("Chapa Inox");
                comboBox2.Items.Add("Chapa Zincada");
            }
            if (comboBox1.Text == "Alumínio")
            {
                comboBox2.Items.Clear();
                comboBox2.ResetText();
                comboBox3.Items.Clear();
                comboBox3.ResetText();
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox2.Items.Add("Chapa");
            }
            if (comboBox1.Text == "Cobre")
            {
                comboBox2.Items.Clear();
                comboBox2.ResetText();
                comboBox3.Items.Clear();
                comboBox3.ResetText();
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox2.Items.Add("Barra");
                comboBox2.Items.Add("Chapa");
            }
            if (comboBox1.Text == "Galvalume")
            {
                comboBox2.Items.Clear();
                comboBox2.ResetText();
                comboBox3.Items.Clear();
                comboBox3.ResetText();
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox2.Items.Add("Chapa");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa")
            {
                comboBox3.Items.Clear();
                comboBox3.ResetText();
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox3.Items.Add("0,91");
                comboBox3.Items.Add("1,21");
                comboBox3.Items.Add("1,52");
                comboBox3.Items.Add("1,90");
                comboBox3.Items.Add("2,60");
                comboBox3.Items.Add("3,04");
                comboBox3.Items.Add("3,50");
            }
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa Inox")
            {
                comboBox3.Items.Clear();
                comboBox3.ResetText();
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox3.Items.Add("1,00");
                comboBox3.Items.Add("1,50");
                comboBox3.Items.Add("1,98");
                comboBox3.Items.Add("2,60");
                comboBox3.Items.Add("3,00");
            }
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa Zincada")
            {
                comboBox3.Items.Clear();
                comboBox3.ResetText();
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox3.Items.Add("0,91");
                comboBox3.Items.Add("1,52");
                comboBox3.Items.Add("1,90");
                comboBox3.Items.Add("2,65");
                comboBox3.Items.Add("3,04");
            }
            if (comboBox1.Text == "Alumínio" && comboBox2.Text == "Chapa")
            {
                comboBox3.Items.Clear();
                comboBox3.ResetText();
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox3.Items.Add("1,50");
                comboBox3.Items.Add("2,00");
                comboBox3.Items.Add("3,00");
                comboBox3.Items.Add("4,00");
            }
            if (comboBox1.Text == "Cobre" && comboBox2.Text == "Barra")
            {
                comboBox3.Items.Clear();
                comboBox3.ResetText();
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox3.Items.Add("2,00");
                comboBox3.Items.Add("3,00");
                comboBox3.Items.Add("3,20");
                comboBox3.Items.Add("3,50");
                comboBox3.Items.Add("5,00");
                comboBox3.Items.Add("10,00");
            }
            if (comboBox1.Text == "Cobre" && comboBox2.Text == "Chapa")
            {
                comboBox3.Items.Clear();
                comboBox3.ResetText();
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox3.Items.Add("2,00");
                comboBox3.Items.Add("3,20");
            }
            if (comboBox1.Text == "Galvalume" && comboBox2.Text == "Chapa")
            {
                comboBox3.Items.Clear();
                comboBox3.ResetText();
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox3.Items.Add("0,95");
                comboBox3.Items.Add("1,55");
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa" && comboBox3.Text == "0,91")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
            }
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa" && comboBox3.Text == "1,21")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
            }
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa" && comboBox3.Text == "1,52")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
                comboBox4.Items.Add("1200 x 2500");
            }
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa" && comboBox3.Text == "1,90")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
                comboBox4.Items.Add("1200 x 2500");
            }
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa" && comboBox3.Text == "2,60")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
                comboBox4.Items.Add("1200 x 2500");
            }
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa" && comboBox3.Text == "3,04")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
                comboBox4.Items.Add("1200 x 2500");
                comboBox4.Items.Add("1200 x 3000");
            }
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa Zincada" && comboBox3.Text == "0,91")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
            }
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa Zincada" && comboBox3.Text == "1,52")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
            }
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa Zincada" && comboBox3.Text == "1,90")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
            }
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa Zincada" && comboBox3.Text == "2,65")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
            }
            if (comboBox1.Text == "Aço" && comboBox2.Text == "Chapa Zincada" && comboBox3.Text == "3,04")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2500");
            }
            if (comboBox1.Text == "Alumínio" && comboBox2.Text == "Chapa" && comboBox3.Text == "1,50")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
            }
            if (comboBox1.Text == "Alumínio" && comboBox2.Text == "Chapa" && comboBox3.Text == "2,00")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
            }
            if (comboBox1.Text == "Alumínio" && comboBox2.Text == "Chapa" && comboBox3.Text == "3,00")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
            }
            if (comboBox1.Text == "Alumínio" && comboBox2.Text == "Chapa" && comboBox3.Text == "4,00")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
            }
            if (comboBox1.Text == "Cobre" && comboBox2.Text == "Barra" && comboBox3.Text == "2,00")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("12");
            }
            if (comboBox1.Text == "Cobre" && comboBox2.Text == "Barra" && comboBox3.Text == "3,00")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("15");
                comboBox4.Items.Add("30");
            }
            if (comboBox1.Text == "Cobre" && comboBox2.Text == "Barra" && comboBox3.Text == "3,20")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("20");
            }
            if (comboBox1.Text == "Cobre" && comboBox2.Text == "Barra" && comboBox3.Text == "5,00")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("25");
                comboBox4.Items.Add("40");
            }
            if (comboBox1.Text == "Cobre" && comboBox2.Text == "Barra" && comboBox3.Text == "10,00")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("25");
                comboBox4.Items.Add("30");
                comboBox4.Items.Add("40");
                comboBox4.Items.Add("50");
                comboBox4.Items.Add("60");
                comboBox4.Items.Add("100");
            }
            if (comboBox1.Text == "Cobre" && comboBox2.Text == "Chapa" && comboBox3.Text == "2,00")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("600 x 1200");
            }
            if (comboBox1.Text == "Cobre" && comboBox2.Text == "Chapa" && comboBox3.Text == "3,20")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("600 x 1200");
            }
            if (comboBox1.Text == "Galvalume" && comboBox2.Text == "Chapa" && comboBox3.Text == "0,95")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
            }
            if (comboBox1.Text == "Galvalume" && comboBox2.Text == "Chapa" && comboBox3.Text == "1,55")
            {
                comboBox4.Items.Clear();
                comboBox4.ResetText();
                comboBox4.Items.Add("1200 x 2000");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            if (comboBox3.Text != "" && textBox1.Text != "" && textBox2.Text != "")
            {
                Espessura = double.Parse(comboBox3.Text);
                Largura = double.Parse(textBox1.Text);
                Comprimento = double.Parse(textBox2.Text);
            }
            if (comboBox1.Text == "Aço")
            {
                Massa = (Constante.constantes.densaco * (Espessura / 1000) * (Largura / 1000) * (Comprimento / 1000));
            }
            if (comboBox1.Text == "Alumínio")
            {
                Massa = (Constante.constantes.densalu * (Espessura / 1000) * (Largura / 1000) * (Comprimento / 1000));
            }
            if (comboBox1.Text == "Cobre" && comboBox2.Text=="Chapa")
            {
                Massa = (Constante.constantes.denscob * (Espessura / 1000) * (Largura / 1000) * (Comprimento / 1000));
            }
            if (comboBox1.Text == "Cobre" && comboBox2.Text == "Barra")
            {
                textBox1.Text = comboBox4.Text;
                Massa = (Constante.constantes.denscob * (Espessura / 1000) * (Largura / 1000) * (Comprimento / 1000));
                textBox1.ReadOnly = true;
            }
            if (comboBox1.Text == "Galvalume" && comboBox2.Text == "Chapa")
            {
                Massa = (Constante.constantes.densaco * (Espessura / 1000) * (Largura / 1000) * (Comprimento / 1000));
            }
            textBox3.Text = Massa.ToString("0.000");
        }

    }
}

