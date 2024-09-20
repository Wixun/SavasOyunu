using SavasOyunu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavasOyunu
{
	public partial class Form1 : Form
	{
		Random rnd = new Random();
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		Buyucu oyuncu1 = new Buyucu();
		int DusmanCani;

		// instance alma islemi	
		private void txtSec_Click(object sender, EventArgs e)
		{
			oyuncu1.OyuncuIsmi = txtOyuncu.Text;
			oyuncu1.Brans = txtBrans.Text;
			oyuncu1.Irk = txtIrk.Text;
			oyuncu1.Silah = txtSilah.Text;

			MessageBox.Show($"[Seçilen Karakter] -> Isim: {oyuncu1.OyuncuIsmi} ~ Irk: {oyuncu1.Brans} ~ Branş: {oyuncu1.Brans} ~ Silah: {oyuncu1.Silah}");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DusmanCani = lblDusmanCani.Width;
		}


		private void txtIrk_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtBrans_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtSaldır_Click(object sender, EventArgs e)
		{
			int deliciVurus = rnd.Next(0, 65);
			oyuncu1.SaldiriGucuHesapla();
			oyuncu1.SaldiriGucu += deliciVurus;
			DusmanCani -= oyuncu1.SaldiriGucu;
			lblDusmanCani.Width = DusmanCani;
			MessageBox.Show($"Düşmana {oyuncu1.SaldiriGucu} kadar vurdunuz.");
			if (DusmanCani <= 0)
			{
				MessageBox.Show("Düşmanı Yendiniz.");
			}
		}
	}
}
