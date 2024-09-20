namespace SavasOyunu
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtOyuncu = new System.Windows.Forms.TextBox();
			this.txtIrk = new System.Windows.Forms.TextBox();
			this.txtBrans = new System.Windows.Forms.TextBox();
			this.txtSilah = new System.Windows.Forms.TextBox();
			this.btnSec = new System.Windows.Forms.Button();
			this.lblDusmanCani = new System.Windows.Forms.Label();
			this.textIrk = new System.Windows.Forms.Label();
			this.txtSaldır = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Oyuncu İsmi:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(165, 75);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(31, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Irk:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(29, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Brans:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(29, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Silah:";
			// 
			// txtOyuncu
			// 
			this.txtOyuncu.Location = new System.Drawing.Point(135, 37);
			this.txtOyuncu.Name = "txtOyuncu";
			this.txtOyuncu.Size = new System.Drawing.Size(153, 20);
			this.txtOyuncu.TabIndex = 1;
			// 
			// txtIrk
			// 
			this.txtIrk.Location = new System.Drawing.Point(135, 77);
			this.txtIrk.Name = "txtIrk";
			this.txtIrk.Size = new System.Drawing.Size(153, 20);
			this.txtIrk.TabIndex = 1;
			this.txtIrk.TextChanged += new System.EventHandler(this.txtIrk_TextChanged);
			// 
			// txtBrans
			// 
			this.txtBrans.Location = new System.Drawing.Point(135, 115);
			this.txtBrans.Name = "txtBrans";
			this.txtBrans.Size = new System.Drawing.Size(153, 20);
			this.txtBrans.TabIndex = 1;
			this.txtBrans.TextChanged += new System.EventHandler(this.txtBrans_TextChanged);
			// 
			// txtSilah
			// 
			this.txtSilah.Location = new System.Drawing.Point(135, 158);
			this.txtSilah.Name = "txtSilah";
			this.txtSilah.Size = new System.Drawing.Size(153, 20);
			this.txtSilah.TabIndex = 1;
			// 
			// btnSec
			// 
			this.btnSec.Location = new System.Drawing.Point(174, 210);
			this.btnSec.Name = "btnSec";
			this.btnSec.Size = new System.Drawing.Size(114, 58);
			this.btnSec.TabIndex = 2;
			this.btnSec.Text = "Seç";
			this.btnSec.UseVisualStyleBackColor = true;
			this.btnSec.Click += new System.EventHandler(this.txtSec_Click);
			// 
			// lblDusmanCani
			// 
			this.lblDusmanCani.BackColor = System.Drawing.Color.DarkRed;
			this.lblDusmanCani.Location = new System.Drawing.Point(471, 35);
			this.lblDusmanCani.Name = "lblDusmanCani";
			this.lblDusmanCani.Size = new System.Drawing.Size(300, 27);
			this.lblDusmanCani.TabIndex = 4;
			// 
			// textIrk
			// 
			this.textIrk.AutoSize = true;
			this.textIrk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textIrk.Location = new System.Drawing.Point(29, 75);
			this.textIrk.Name = "textIrk";
			this.textIrk.Size = new System.Drawing.Size(31, 20);
			this.textIrk.TabIndex = 6;
			this.textIrk.Text = "Irk:";
			// 
			// txtSaldır
			// 
			this.txtSaldır.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.txtSaldır.Location = new System.Drawing.Point(620, 243);
			this.txtSaldır.Name = "txtSaldır";
			this.txtSaldır.Size = new System.Drawing.Size(151, 65);
			this.txtSaldır.TabIndex = 7;
			this.txtSaldır.Text = "Saldır";
			this.txtSaldır.UseVisualStyleBackColor = false;
			this.txtSaldır.Click += new System.EventHandler(this.txtSaldır_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SavasOyunu.Properties.Resources.indir;
			this.pictureBox1.Location = new System.Drawing.Point(474, 77);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(297, 139);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 336);
			this.Controls.Add(this.txtSaldır);
			this.Controls.Add(this.textIrk);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblDusmanCani);
			this.Controls.Add(this.btnSec);
			this.Controls.Add(this.txtSilah);
			this.Controls.Add(this.txtBrans);
			this.Controls.Add(this.txtIrk);
			this.Controls.Add(this.txtOyuncu);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtOyuncu;
		private System.Windows.Forms.TextBox txtIrk;
		private System.Windows.Forms.TextBox txtBrans;
		private System.Windows.Forms.TextBox txtSilah;
		private System.Windows.Forms.Button btnSec;
		private System.Windows.Forms.Label lblDusmanCani;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label textIrk;
		private System.Windows.Forms.Button txtSaldır;
	}
}

