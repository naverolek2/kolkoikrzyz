namespace kolkoikrzyz
{

    public partial class Form1 : Form
    {
        int ktoObecnieGra = 0;
        int ileNaPlanszy = 0;
        int[,] plansz = new int[3, 3] {
            {0, 0, 0} ,   
            {0, 0, 0} ,   
            {0, 0, 0}  
        };
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
            }
            if(ileNaPlanszy == 9)
            {
                // koniec (wyskakuj¹ce okno)
            }
        }

        
    }
}