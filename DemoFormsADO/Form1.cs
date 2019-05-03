using DemoFormsADO.SourceADOTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFormsADO
{
    public partial class Form1 : Form
    {
        SourceADO sado = new SourceADO();
        ProductsTableAdapter pta = new ProductsTableAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pta.Fill(sado.Products);
            dgProduits.DataSource = sado.Products;

            // TODO: cette ligne de code charge les données dans la table 'sourceADO.Products'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.productsTableAdapter.Fill(this.sourceADO.Products);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pta.Update(sado.Products);
            MessageBox.Show("Sauvegarde Réussie");
        }
    }
}
