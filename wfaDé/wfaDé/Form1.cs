using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaDé
{
    public partial class Form1 : Form
    {
        DéOrdinaire déOrdinaire = new DéOrdinaire("Ordinaire", 6);
        DéPipe déPipe = new DéPipe("DéPipe", 6);
        Random random = new Random();
        int totalPoint = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnMelange_Click(object sender, EventArgs e)
        {
            int chancedé = random.Next(1, 101);

            if (chancedé <= 50)
            {            
                déOrdinaire.Melanger();
                lblTypeDé.Text = déOrdinaire.TypeDeDé;
                lblValeurDé.Text = déOrdinaire.NombreObtenue.ToString();
                totalPoint += déOrdinaire.NombreObtenue;
                lblTotalPoint.Text = totalPoint.ToString();
            }
            else
            {
                déPipe.Melanger();
                lblTypeDé.Text = déPipe.TypeDeDé;
                lblValeurDé.Text = déPipe.NombreRésultat.ToString();
                totalPoint += déPipe.NombreRésultat;
                lblTotalPoint.Text = totalPoint.ToString();
            }
        }
    }
}
