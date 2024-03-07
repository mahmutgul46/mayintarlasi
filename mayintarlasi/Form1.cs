using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayintarlasi
{
    public partial class Form1 : Form
    {
        byte[,] dizi = new byte[4, 4];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random(); 
            int satirRastgele = rastgele.Next(4);
            int sutunRastgele = rastgele.Next(4);
            dizi[satirRastgele, sutunRastgele] = 1;

            for (byte satir = 0; satir < 4; satir++)
            {
                for (byte sutun = 0; sutun < 4; sutun++)
                {
                    PictureBox kutu = this.Controls.Find("p" + satir + sutun, true)[0] as PictureBox;
                    kutu.BackColor = SystemColors.Control;
                }
            }

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            byte satir = byte.Parse(txtSatir.Text);
            byte sutun = byte.Parse(txtSutun.Text);
            PictureBox kutu = this.Controls.Find("p"+satir + sutun, true)[0] as PictureBox;

            byte durum = dizi[satir, sutun];
            if (durum == 0)
            { kutu.BackColor = Color.Green; }
            else
            { kutu.BackColor = Color.Red; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int satirRastgele = rastgele.Next(4);
            int sutunRastgele = rastgele.Next(4);
            dizi[satirRastgele, sutunRastgele] = 1;

        }
    }
}
