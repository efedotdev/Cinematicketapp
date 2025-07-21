using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Cinematicketapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
        int cashregister = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int pop, ticket, snack, drink, total;
            pop = Convert.ToInt32(txtpop.Text);
            ticket = Convert.ToInt32(txtticket.Text);
            snack = Convert.ToInt32(txtsnacks.Text);
            drink = Convert.ToInt32(txtdrink.Text);
            total = 100 * ticket + 45 * pop + 20 * snack + 20 * drink;
            label12.Text = $"{total} TL";
            cashregister = cashregister + total;
            label13.Text = $"{cashregister} TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label12.Text = "00 TL";
            txtpop.Text = "";
            txtdrink.Text = "";
            txtsnacks.Text = "";
            txtticket.Text = "";
            txtpop.Focus();
        }

        public class Person(string name,string lname)
        {
            public string first { get; } = name;
            public string last { get; } = lname;
            public override string ToString()
            {
                return $"{first} {last}";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string name, seat2, lname,date,seat,clas,movie;

            name = Convert.ToString(txtname.Text);
            lname = Convert.ToString(txtlname.Text);
            clas = Convert.ToString(cmbxseat.Text);
            seat = Convert.ToString(comboBox1.Text);
            date = Convert.ToString(dateTimePicker1.Text);
            movie = Convert.ToString(cmbxmovie.Text);
            seat2 = Convert.ToString(comboBox2.Text);

            var p1 = new Person($"{name}",$"{lname}");
            var p2 = new Person($"{Convert.ToString(textBox6.Text)}",
                $"{Convert.ToString(textBox5.Text)}");
            
            listBox1.Items.Add($"Movie; {movie}");
            listBox1.Items.Add($"{p1} Seatnumber;{clas}{seat}");
            listBox1.Items.Add($"{p2} Seatnumber:{clas}{seat2}");
            listBox1.Items.Add($"Date; {date} Have fun!! ");

            MessageBox.Show($" Tebrikler,{p1} ve {p2}." +
                $"\n Biletleriniz kayýt edildi,\n birbirinizle geçireceðiniz zamanýn kýymetini bilmeyi\n UNUTMAYIIIN <3<3");
        }
    }
}
