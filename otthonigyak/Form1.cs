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
                    SajátGomb sajátGomb = new SajátGomb();
                    sajátGomb.Left = i * 30;
                    sajátGomb.Top = j * 30;
                    Controls.Add(sajátGomb);
                }
            }
        }

    }
}
