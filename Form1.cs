namespace SporSalonuÜcretHesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double aidat = 6000;
            double nny = aidat *0.7;
            double ogrenciagu = nny;
            double aPersonelAgu = aidat*075;
            double İpersonelagu = aidat*0.8;
            double ogrenciERU = aidat*0.75;
            double apersonelERU = aidat*0.8;
            double ipersonelERU= aidat*0.85;
            double diger = aidat*0.9;





            if (comboBox1.SelectedIndex == 0)     //combo boxda 1.sırada hangisi seçili ise onu atar
            {
                if (checkBox1.Checked)
                {
                    textBox1.Text= Convert.ToString(nny);
                }
                if (checkBox2.Checked)
                {
                    textBox1.Text= Convert.ToString(nny);
                }
                if (checkBox3.Checked)
                {
                    textBox1.Text= Convert.ToString(nny);
                }




            }
; if (comboBox1.SelectedIndex==1)
            {
                if (checkBox1.Checked)
                {
                    textBox1.Text= Convert.ToString(nny);
                }


                if (checkBox2.Checked)
                {
                    textBox1.Text= Convert.ToString(aPersonelAgu);
                }
                if (checkBox3.Checked)
                {
                    textBox1.Text= Convert.ToString(İpersonelagu);
                }

            }



            if (comboBox1.SelectedIndex==2)
            {

                if (checkBox1.Checked)
                {
                    textBox1.Text= Convert.ToString(ogrenciERU);
                }
                if (checkBox2.Checked)
                {
                    textBox1.Text= Convert.ToString(apersonelERU);
                }
                if (checkBox3.Checked)
                {
                    textBox1.Text= Convert.ToString(ipersonelERU);
                }



            }

            if (comboBox1.SelectedIndex==3)
            {
                if (checkBox1.Checked)
                {
                    textBox1.Text= Convert.ToString(diger);
                }
                if (checkBox2.Checked)
                {
                    textBox1.Text= Convert.ToString(diger);
                }
                if (checkBox3.Checked)
                {
                    textBox1.Text= Convert.ToString(diger);
                }

            }


        }
    }
}