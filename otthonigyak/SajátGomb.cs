using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otthonigyak
{
    public class SajátGomb : Button
    {
        int Méret = 30;
        public static List<string> lista = new List<string>() { "teszt szöveg 1", "teszt szöveg 2" };
        public SajátGomb()
        {
            Text = ":)";
            Height = Méret;
            Width = Méret;
            MouseEnter += SajátGomb_MouseEnter;
            MouseLeave += SajátGomb_MouseLeave;
            MouseClick += SajátGomb_MouseClick;
        }

        private void SajátGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            MessageBox.Show(lista[0] +"\n"+ lista[1]);
        }

        private void SajátGomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void SajátGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
