using System.Windows.Forms.VisualStyles;

namespace kolkoikrzyz
{

    public partial class Form1 : Form
    {
        int ktoObecnieGra = 0;
        int ileNaPlanszy = 0;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            
            if (ktoObecnieGra == 0)
            {
                przycisk.Image = imageList1.Images[ktoObecnieGra];
                kto1.Text = "K�ko";
                przycisk.Enabled = false;
                przycisk.Text = ",";
                
                ileNaPlanszy++;
                ktoObecnieGra++;
            }
            else if(ktoObecnieGra == 1)
            {
                przycisk.Image = imageList1.Images[ktoObecnieGra];
                
                kto1.Text = "Krzy�yk";
                przycisk.Enabled = false;
                ileNaPlanszy++;
                ktoObecnieGra--;
                przycisk.Text = ".";
            }
            if(ileNaPlanszy == 9)
            {
                remis();
            }
            czyWygrany();
        }
        private void czyWygrany()
        {
            //
            if(button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                koniec();
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                koniec();
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                koniec();
            }
            //
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                koniec();
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                koniec();
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                koniec();
            }
            //
            else if(button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                koniec();

            }
            else if(button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                koniec();

            }
           
            
        }
        private void koniec()
        {
            this.Hide();
            var m = new Form2();
            m.Show();

        }
        private void remis()
        {
            // ten kod ukrywa wszystko
            foreach (Control c in this.Controls)
            {
                c.Visible = false;
            }
            //
            kto1.Text = "Remis";
            kto1.Visible = true;
            button10.Visible = true;


        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}