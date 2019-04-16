using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using c=System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Label = System.Windows.Controls.Label;

namespace DemoWPF06
{
    /// <summary>
    /// Logique d'interaction pour FileExplorer.xaml
    /// </summary>
    public partial class FileExplorer : Window
    {
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void btnParcourir_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fdbChemin = new FolderBrowserDialog();
            if (fdbChemin.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                txtChemin.Text = fdbChemin.SelectedPath;
                DirectoryInfo dirDossier = new DirectoryInfo(fdbChemin.SelectedPath);

                foreach (FileInfo item in dirDossier.GetFiles())
                {
                    c.Label lbItem = 
                        new c.Label() { Content =item.Name,Width=120};
                    lbItem.MouseDoubleClick += LbItem_MouseDoubleClick;
                    stkFichier.Children.Add(lbItem);


                }
            }
        }

        private void LbItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string strFichier = ((c.Label)sender).Content.ToString();
            string strChemin = txtChemin.Text + "\\" + strFichier;
            FileInfo fichier = new FileInfo(strChemin);
            txtInfos.Text = fichier.Name.ToString();
        }
    }
}
