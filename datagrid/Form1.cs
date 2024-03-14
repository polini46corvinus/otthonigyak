namespace datagrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                GONB b = new GONB();
                b.Top = i*200;
                Controls.Add(b);
            }
        }
    }
}
