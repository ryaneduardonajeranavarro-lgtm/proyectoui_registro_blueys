using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto2._6_registro_blueys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            double cal1, cal2, cal3, cal4, cal5;
            bool esNum1 = double.TryParse(textBox1.Text, out cal1);
            bool esNum2 = double.TryParse(textBox2.Text, out cal2);
            bool esNum3 = double.TryParse(textBox3.Text, out cal3);
            bool esNum4 = double.TryParse(textBox4.Text, out cal4);
            bool esNum5 = double.TryParse(textBox5.Text, out cal5);
            string nombre = textBox6.Text;
            bool sololetras = nombre.All(char.IsLetter);
            string grupo = textBox7.Text;
            bool sololetra = grupo.All(char.IsLetter);
            if (esNum1 && esNum2 && esNum3 && esNum4 && esNum5 && cal1 <= 10 && cal1 >= 0 && cal2 <= 10
                && cal2 >= 0 && cal3 <= 10 && cal3 >= 0 && cal4 <= 10 && cal4 >= 0 && cal5 <= 10
                && cal5 >= 0)
            {
                label1.Text = "promedio: " + ((cal1 + cal2 + cal3 + cal4 + cal5) / 5).ToString();
                if ((cal1 + cal2 + cal3 + cal4 + cal5) / 5 < 6)
                {
                    label2.Text = "estas reprobado " + nombre;
                    label2.Visible = true;
                    pictureBox1.Visible = true;
                }
                if ((cal1 + cal2 + cal3 + cal4 + cal5) / 5 >= 6 && (cal1 + cal2 + cal3 + cal4 + cal5) / 5 <= 8)
                {
                    label2.Text = "bien pero hay que mejorar " + nombre;
                    label2.Visible = true;
                    pictureBox2.Visible = true;
                }
                if ((cal1 + cal2 + cal3 + cal4 + cal5) / 5 >= 8.1)
                {
                    label2.Text = "Muy bien " + nombre;
                    label2.Visible = true;
                    pictureBox2.Visible = true;
                }
            }
            else
            {
                label1.Text = "error: ingresa numeros validos";
            }
            if (!string.IsNullOrWhiteSpace(nombre) && sololetras)
            {
                label9.Visible = false;
            }
            else
            {
                label9.Visible = true;
                label9.Text = "error: ingresa un nombre valido";
                label1.Text = "Promedio:";
                label2.Visible = false;
                label2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
            if (!string.IsNullOrWhiteSpace(grupo) && sololetra)
            {
                label9.Visible = false;
            }
            else
            {
                label9.Visible = true;
                label9.Text = "error: ingresa un grupo valido";
                label1.Text = "Promedio:";
                label2.Visible = false;
                label2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
        }
    }
}
