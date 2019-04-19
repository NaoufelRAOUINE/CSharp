using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForms12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Assembly assCompilation;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //Acces a la boite de dialogue d'ouverture de fichier
            OpenFileDialog ofdSelection = new OpenFileDialog();
            ofdSelection.DefaultExt = "dll";

            if (ofdSelection.ShowDialog()==DialogResult.OK)
            {
                txtFichier.Text = ofdSelection.FileName;
                assCompilation=Assembly.LoadFrom(ofdSelection.FileName);
                lstClasses.Items.Clear();
                foreach (TypeInfo item in assCompilation.DefinedTypes)
                {
                    lstClasses.Items.Add(item.Name);
                }

                

            }
        }

        private void lstClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (assCompilation!=null)
            {
                string strChoix = lstClasses.SelectedItem.ToString();

                TypeInfo typeChoixClasse =
                    assCompilation.DefinedTypes.Where(d => d.Name == strChoix).First();
                lstProprietes.Items.Clear();
                foreach (var item in typeChoixClasse.DeclaredProperties)
                {
                    lstProprietes.Items.Add(item.Name);
                }
            }
        }
    }
}
