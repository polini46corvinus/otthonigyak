namespace otthonigyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Saj�tGomb saj�tGomb = new Saj�tGomb();
                    saj�tGomb.Left = i * 30;
                    saj�tGomb.Top = j * 30;
                    Controls.Add(saj�tGomb);
                }
            }
        }

    }
}
