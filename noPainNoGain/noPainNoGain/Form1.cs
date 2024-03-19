using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noPainNoGain
{
    public partial class noPainNoGain : Form
    {
        public noPainNoGain()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        void yorumlaBmh()
        {
            richTextBox1.AppendText("\n Bazal metabolizma hızınız " + bmh + " kalori. Bu miktar,vücudunuzun işlevini yerine getirmek için harcadığı kaloridir.Diyetleriniz " + bmh + " kaloriden az olmamalıdır!!");

        }
        void yorumlaVyo()
        {
            if (radioButton1.Checked)
            {
                if (vyo < 10)
                    richTextBox1.AppendText("\n Yağ Oranınız çok düşük! Vücutta işlev bozuklukları görülebilir!");
                else if (vyo > 10 && vyo < 13)
                    richTextBox1.AppendText("\n Yağ oranınız sınırda.Yağ oranınızı düşürmemeye dikkat edin!");
                else if(vyo<20 && vyo>13)
                    richTextBox1.AppendText("\n Yağ oranınız bir sporcu seviyesinde!");
                else if(vyo<24&& vyo>20)
                    richTextBox1.AppendText("\n Yağ oranınız ideal.Vücudunuz formda!");
                else if (vyo<31 && vyo>24)
                    richTextBox1.AppendText("\n Yağ oranınız kabul edilebilir aralıkta. Beslenmenize dikkat etmelisiniz!");
                else
                    richTextBox1.AppendText("\n Yağ oranınız yüksek.Obezite seviyesindesiniz!!");
            }
            else
            {
                if (vyo < 2)
                    richTextBox1.AppendText("\n Yağ oranınız çok düşük! Vücutta işlev bozuklukları görülebilir!");
                else if (vyo < 5 && vyo > 2)
                    richTextBox1.AppendText("\n Yağ oranınız sınırda.Yağ oranınızı düşürmemeye dikkat edin!");
                else if(vyo<13&&vyo>5)
                    richTextBox1.AppendText("\n Yağ oranınız bir sporcu seviyesinde!");
                else if(vyo<17&&vyo>13)
                    richTextBox1.AppendText("\n Yağ oranınız ideal.Vücudunuz formda!");
                else if(vyo<25&&vyo>17)
                    richTextBox1.AppendText("\n Yağ oranınız kabul edilebilir aralıkta. Beslenmenize dikkat etmelisiniz!");
                else
                    richTextBox1.AppendText("\n Yağ oranınız yüksek.Obezite seviyesindesiniz!!");
            }
        }
        void yorumlaVki()
        {
            if(vki<18.5f)
                richTextBox1.AppendText("\n Vücut Kitle Endeksiniz düşük,zayıfsınız.");
            else if(vki<24.9 && vki > 18.5)
                richTextBox1.AppendText("\n Vücut Kitle Endeksiniz ideal aralıkta.Normal Kilodasınız");
            else if(vki<29.9 && vki>25)
                richTextBox1.AppendText("\n Vücut Kitle Endeksiniz idealin üstünde.Fazla Kilolusunuz.Yediklerinize dikkat etmelisiniz!");
            else
                richTextBox1.AppendText("\n Vücut Kitle Endeksiniz yüksek!.Obezite değerlerindesiniz.");
        }
        void yorumlaBelKalca()
        {
            if (radioButton1.Checked)
            {
                if(belkalcaoran<0.80)
                    richTextBox1.AppendText("\n Bel kalca oranınız iyi! Kalp-damar hastalıkları, diyabet, kanser, hipertansiyon, Alzheimer v.b. kronik hastalıklara yakalanma riskiniz düşük!");
                else if(belkalcaoran<0.84)
                    richTextBox1.AppendText("\n Bel kalca oranınız kabul edilebir. Kalp-damar hastalıkları, diyabet, kanser, hipertansiyon, Alzheimer v.b. kronik hastalıklara yakalanma riskiniz orta seviyede.Bel kalca oranınızı korumaya özen gösterin!");
                else
                    richTextBox1.AppendText("\n Bel kalca oranınız Yüksek! Kalp-damar hastalıkları, diyabet, kanser, hipertansiyon, Alzheimer v.b. kronik hastalıklara yakalanma riskiniz yüksek!Bel kalca oranınızı düşürmeye özen gösterin!");
            }
            else
            {
                if(belkalcaoran<0.95)
                    richTextBox1.AppendText("\n Bel kalca oranınız iyi! Kalp-damar hastalıkları, diyabet, kanser, hipertansiyon, Alzheimer v.b. kronik hastalıklara yakalanma riskiniz düşük!");
                else if(belkalcaoran<1)
                    richTextBox1.AppendText("\n Bel kalca oranınız kabul edilebilir! Kalp-damar hastalıkları, diyabet, kanser, hipertansiyon, Alzheimer v.b. kronik hastalıklara yakalanma riskiniz orta seviyede.Bel kalca oranınızı korumaya özen gösterin!");
                else
                    richTextBox1.AppendText("\n Bel kalca oranınız Yüksek! Kalp-damar hastalıkları, diyabet, kanser, hipertansiyon, Alzheimer v.b. kronik hastalıklara yakalanma riskiniz yüksek!Bel kalca oranınızı düşürmeye özen gösterin!");

            }
        }
        void yorumlaAktivite()
        {
            if(comboBox1.SelectedIndex == 0)
               richTextBox1.AppendText("\n Hayatınıza sporu dahil etmeniz tavsiye olunur");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        float boy, kilo, yas, bel, boyun, kalca;

        private void noPainNoGain_Load(object sender, EventArgs e)
        {

        }

        private void noPainNoGain_Leave(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapan : Berat Bircan Karakavuz \n E-Posta : beratbircanpy@gmail.com \nTavsiyeleriniz veya yakaladığınız hatalar-açıklar-fikirler varsa iletmenizi önemle rica ederim.");

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        float bmh,vyo,vki,idealKilo,belkalcaoran,vym,gki,si,pi,ki,yi; 
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show("Aktivite seviyenizi seçiniz!!");
            else if(radioButton1.Checked == false && radioButton2.Checked == false)
                MessageBox.Show("Cinsiyetinizi seçiniz!!");
            else
            {

            
            try { 
            boy = float.Parse(textBox1.Text);            
            yas = float.Parse(textBox2.Text);
            kilo = float.Parse(textBox3.Text);
            bel = float.Parse(textBox4.Text);
            boyun = float.Parse(textBox5.Text);
            kalca =float.Parse(textBox6.Text);
             
            if (radioButton1.Checked)
            {
                //Bazal Metabolizma Hızı
                bmh = 447.593f + (9.247f * kilo) + (3.098f * boy) - (4.330f * yas);
                label16.Text = bmh.ToString("00.00")+" Kalori/Günde";
                //Vücut Yağ Oranı
                vyo = 495 / (1.29579f - 0.35004f * (float)Math.Log10(bel+kalca - boyun) + 0.22100f * (float)Math.Log10(boy)) - 450;
                label17.Text = "% "+vyo.ToString("00.00");
                //Vücut Kitle İndeksi
                vki = kilo / ((float)Math.Pow(boy / 100, 2));
                label18.Text = vki.ToString("00.00");
                //İdeal Kilo
                idealKilo = 45.5f + 2.3f * ((boy / 2.54f) - 60);
                label19.Text = idealKilo.ToString("00.00") +" KG";
                //Bel-Kalça Oranı
                belkalcaoran = bel / kalca;
                label20.Text = belkalcaoran.ToString("00.00");
                //Vücut Yağ Miktarı
                vym = kilo * vyo / 100;
                label22.Text = vym.ToString("00.00") +" KG";
            }
            else {
                //Bazal Metabolizma Hızı
                bmh = 88.362f + (13.397f * kilo) + (4.799f * boy) - (5.677f * yas);
                label16.Text = bmh.ToString("00.00") + " Kalori/Günde";
                //Vücut Yağ Oranı
                vyo = 495 / (1.0324f - 0.19077f * (float)Math.Log10(bel - boyun) + 0.15456f * (float)Math.Log10(boy)) - 450;
                label17.Text ="% "+ vyo.ToString("00.00");
                //Vücut Kitle İndeksi
                vki = kilo / ((float)Math.Pow((boy/100), 2));
                label18.Text = vki.ToString("00.00");
                //İdeal Kilo
                idealKilo = 50 + 2.3f * ((boy / 2.54f) - 60);
                label19.Text = idealKilo.ToString("00.00")+"KG";
                //Bel-Kalça Oranı
                belkalcaoran = bel / kalca;
                label20.Text = belkalcaoran.ToString("00.00");
                //Vücut Yağ Miktarı
                vym = kilo * vyo / 100;
                label22.Text = vym.ToString("00.00")+ "KG";


            }
            //Günlük Kalori İhtiyacı
            if (comboBox1.SelectedIndex == 0)
            {
                gki = 1.2f * bmh;
            }
            else if (comboBox1.SelectedIndex == 1)
                gki = 1.375f * bmh;
            else if (comboBox1.SelectedIndex == 2)
                gki = 1.55f * bmh;
            else if (comboBox1.SelectedIndex == 3)
                gki = 1.725f * bmh;
            else if (comboBox1.SelectedIndex == 4)
                gki = 1.9f * bmh;
            label25.Text = gki.ToString()+" Kalori";
            //Makro Besin İhtiyacı
            si = ((kilo * 0.3f)*100)/1000;
            label30.Text = si.ToString("0.0")+" Litre/Günde";
            pi = (gki * 0.30f) / 4;
            label31.Text = pi.ToString("000") + " Gram/Günde";
            ki = (gki * 0.5f) / 4;
            label32.Text = ki.ToString("000") +" Gram/Günde";
            yi = (gki * 0.2f) / 9;
            label33.Text = yi.ToString("00") + " Gram/Günde";
            if (checkBox1.Checked)
            {
                richTextBox1.Text = " ";
                richTextBox1.AppendText("ANALİZ SONUÇLARININ YORUMLARI");
                yorumlaBmh();
                yorumlaVyo();
                yorumlaVki();
                yorumlaBelKalca();
                yorumlaAktivite();
             
            }
            }
            catch (FormatException) {
                MessageBox.Show("Boş değer bıraktınız veya yanlış sayısal değer girdiniz!\nEğer küsüratlı sayı girmek isterseniz(Örneğin 32.4)küsüratı virgülle belirtiniz!(Örneğin 32,4)\nKutucuklara sadece sayısal değer girin ve boş bırakmayın!");

            }
            }

        }
    }
}
