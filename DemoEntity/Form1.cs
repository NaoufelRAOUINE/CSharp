using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEntity
{
    public partial class Form1 : Form
    {
        NorthwindEntities nwContexte = new NorthwindEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgProduits.DataSource = nwContexte.Products.ToList();

        }

        private void Gestion_selection(object sender, EventArgs e)
        {
            if (dgProduits.SelectedRows.Count>0)
            {
                int id = int.Parse(dgProduits.SelectedRows[0].Cells[0].Value.ToString());
                Products pSelection = nwContexte.Products.Where(p=>p.ProductID==id).First();
                this.Text = string.Format("Le produit {0} est present dans {1} Commandes",
                    pSelection.ProductName, pSelection.Order_Details.Count);
            }
            
        }
    }
}
