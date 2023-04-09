using System.Data;

namespace Gastos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {


            string product = textBox1.Text;
            int cost = Int32.Parse(textBox2.Text);


            string mes = Enum.GetName(typeof(DiasMes), DateTime.Now.Month);

            Directory.CreateDirectory("../../../Gastos/" + mes);

            StreamWriter file = new StreamWriter("../../../Gastos/" + mes + "/" + DateTime.Now.Day + ".csv", true);
            FileInfo info = new FileInfo("../../../Gastos/" + mes + "/" + DateTime.Now.Day + ".csv");
            if (info.Length == 0)
                file.WriteLine("Producto,Costo");


            Operation oper = new Operation(DateTime.Now, product, cost);

            file.WriteLine(oper.ToString());
            file.Close();

            textBox1.Clear();
            textBox2.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            
            DateTime now = dateTimePicker1.Value;
            string mes = Enum.GetName(typeof(DiasMes), now.Month);
            StreamReader reader = new StreamReader("../../../Gastos/" + mes + "/" + now.Day.ToString() + ".csv");
            
            ventana.Show();
            ventana.Show(now, reader);


        }
    }
}