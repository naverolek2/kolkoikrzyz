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
                kto1.Text = "Kó³ko";
                przycisk.Enabled = false;
                przycisk.Text = ",";
                
                ileNaPlanszy++;
                ktoObecnieGra++;
            }
            else if(ktoObecnieGra == 1)
            {
                przycisk.Image = imageList1.Images[ktoObecnieGra];
                
                kto1.Text = "Krzy¿yk";
                przycisk.Enabled = false;
                ileNaPlanszy++;
                ktoObecnieGra--;
                przycisk.Text = ".";
            }
            if(ileNaPlanszy == 9)
            {
                // koniec (wyskakuj¹ce okno)
            }
            czyWygrany();
        }
        private void czyWygrany()
        {
            //
            if(button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                label2.Text = "essa";
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                label2.Text = "essa";
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                label2.Text = "essa";
            }
            //
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                label2.Text = "essa";
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                label2.Text = "essa";
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                label2.Text = "essa";
            }
            //
            else if(button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                label2.Text = "essa";
                
            }
            else if(button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                label2.Text = "essa";
                
            }
            if(label2.Text == "essa")
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

    }
}