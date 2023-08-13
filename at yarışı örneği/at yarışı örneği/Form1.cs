using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarışı_örneği
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
		int birinciatinsolauzakligi, ikinciatinsolauzakligi, ucuncuatinsolauzakligi;
		Random rastgele = new Random();

		private void Form1_Load(object sender, EventArgs e)
		{
		
			birinciatinsolauzakligi = pictureBox1.Left;
			ikinciatinsolauzakligi = pictureBox2.Left;
			ucuncuatinsolauzakligi = pictureBox3.Left;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			int birinciatingenisligi = pictureBox1.Width;
			int ikinciatingenisligi = pictureBox2.Width;
			int ucuncuatingenisligi = pictureBox3.Width;

			int bitisuzakligi = label5.Left;

			pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 16);
			pictureBox2.Left = pictureBox2.Left + rastgele.Next(5,16);
			pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 16);

			if(pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left> pictureBox3.Left + 5)
			{
				label7.Text = "1.at yarışmayı önde götürüyor";
			}
			if(pictureBox2.Left>pictureBox1.Left +5 && pictureBox2.Left> pictureBox3.Left +5)
			{
				label7.Text = "2.çok güzel bir atakla öne geçmeyi başardı";
			}
			if(pictureBox3.Left>pictureBox1.Left+5 && pictureBox3.Left> pictureBox2.Left+ 5)
			{
				label7.Text = "inanamıyorum sayın seyirciler 3.at mucize bir şekilde öne geciyor.";
			}

			if(birinciatingenisligi+pictureBox1.Left>=bitisuzakligi)
			{
				timer1.Enabled = false;
				label7.Text=("işte bu işte bu sayın seyirciler 1. at yarışmayı kazandı");
			}
			if(ikinciatingenisligi+pictureBox2.Left>=bitisuzakligi)
			{
				timer1.Enabled = false;
				label7.Text=("işte bu işte bu sayın seyirciler 2. at yarışmayı kazandı");
			}
			if(ucuncuatingenisligi+pictureBox3.Left>=bitisuzakligi)
			{
				timer1.Enabled = false;
			    label7.Text=("işte bu işte bu sayın seyirciler 3.at yarışmayı kazandı");
			}



		}
	}
}
