using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ShowReport : Form
    {
        public ShowReport(double[] summs, int years,double profit)
        {
            InitializeComponent();
            this.FormClosed += ShowReport_FormClosed;
            PrintOnForm(summs,years,profit);
        }

        private void ShowReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();            
        }

        private void PrintOnForm(double[] summs, int years, double profit)
        {
            labResult.Text = "Для получения максимальной прибыли между предприятиями необходимо распределить ресурсы следующим образом:\n";

            for (int i = 0; i < summs.Length; i++)
            {
                labResult.Text += "\n* Предприятию №"+(i+1)+" необходимо выделить +"+summs[i]+" у.е";
            }

            labResult.Text += "\n\nТакое распределение ресурсов позволит получить прибыль в размере "+profit+" у.е за промежуток времени "+years+" лет(года)";
        }
    }
}
