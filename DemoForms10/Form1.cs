using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForms10
{
    public partial class Form1 : Form
    {
        BackgroundWorker bgw = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
            //Methode appelee lors de lancement du bgw par sa methode
            bgw.DoWork += bgwTraitementDoWork ;

            //Methode appelee suite à l'achevement du traitement asynchrone
            bgw.RunWorkerCompleted += Bgw_TraitementRunWorkerCompleted;

            //conf du bgw pour quil accepte de remonter la progression
            bgw.WorkerReportsProgress = true;
            //et annuler eventuellement le traitement async en cours
            bgw.WorkerSupportsCancellation = true;

            //gestion de la progression
            bgw.ProgressChanged += Bgw_TraitementProgressChanged;
        }

        private void Bgw_TraitementProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Text = "Achèvement: " + e.ProgressPercentage+"%";
        }

        private void Bgw_TraitementRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Votre Dossier est annulé");
            }
            else
            {
                MessageBox.Show("Votre Dossier est prêt");
            }
            
        }

        private void bgwTraitementDoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                bgw.ReportProgress((i+1)*10);
                if (bgw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgw.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bgw.CancelAsync();
        }
    }
}
