using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gastos
{
    public partial class Form2 : Form
    {
        StreamReader reader;
        public Form2()
        {
            InitializeComponent();
        }

        public void Show(DateTime now, StreamReader file)
        {
            reader = file;
            int sum = 0;
            string line = file.ReadLine();
            while ((line = file.ReadLine()) != null)
            {

                string[] values = line.Split(',');
                sum += Int32.Parse(values[1]);
                textBox1.AppendText("Producto: " + values[0] + " Costo: " + values[1] + Environment.NewLine);
            }
            MessageBox.Show("El total gastado hoy es: " + sum.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sum = 0;
            string[] values;
            string line = reader.ReadLine();
            while ((line = reader.ReadLine()) != null)
            {
                values = line.Split(',');
                sum += Int32.Parse(values[1]);
            }
            MessageBox.Show("El total gastado hoy es: " + sum.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
