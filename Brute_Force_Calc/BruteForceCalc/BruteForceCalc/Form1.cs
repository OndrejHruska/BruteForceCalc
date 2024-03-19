using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruteForceCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void buttonVypocti_Click(object sender, EventArgs e)
        {
            int pocezZnaku = 0;
            double pocetKombinaci;
            if (checkBoxMalaPismena.Checked)
            {
                pocezZnaku += 26;
            }
            if (checkBoxVelkaPismena.Checked)
            {
                pocezZnaku += 26;
            }
            if (checkBoxCisla.Checked)
            {
                pocezZnaku += 10;
            }
            if (checkBoxSpecialniZnaky.Checked)
            {
                pocezZnaku += 33;
            }
            int pocetMistHesla = Convert.ToInt32(textBoxDelkaHesla.Text);
            int pocetPokusuZaS = Convert.ToInt32(textBoxPocetPokusuZaS.Text);

            MessageBox.Show("Pocet znaku ze kterých se hledá: " + pocezZnaku);

            pocetKombinaci = Math.Pow(pocezZnaku, pocetMistHesla);
               
            MessageBox.Show("pocet kombinaci" + pocetKombinaci);

            //int casvSek = pomoc.Vypocet_CasVSek(pocetKombinaci, pocetPokusuZaS);
            double casVSekundach = pocetKombinaci / pocetPokusuZaS;

            double roky = casVSekundach / (60 * 60 * 24 * 365);
            if (roky > 100)
            {
                label1.Text = "Heslo by trvalo prolomit vice ne 100 let!" + "\nPocet Kombinaci: " + pocetKombinaci;
            }
            else
            {
                 
                double dny = (roky - Math.Floor(roky)) * 365;
                double hodiny = (dny - Math.Floor(dny)) * 24;
                double minuty = (hodiny - Math.Floor(hodiny)) * 60;
                double sekundy = (minuty - Math.Floor(minuty)) * 60;

                label1.Text = $"Heslo by trvalo prolomit: {roky:N0}  roků, {dny:N0}  dnů, {hodiny:N0} hodin, {minuty:N0} mínuty, {sekundy:N0} sekund" + "\nPocet Kombinaci: " + pocetKombinaci;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBoxMalaPismena.Checked = false;
            checkBoxVelkaPismena.Checked = false;
            checkBoxCisla.Checked = false;
            checkBoxSpecialniZnaky.Checked = false;

            textBoxDelkaHesla.Text = string.Empty;
            textBoxPocetPokusuZaS.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

   

}
