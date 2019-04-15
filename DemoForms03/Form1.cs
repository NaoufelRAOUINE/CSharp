using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForms03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fermeture(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Au revoir");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        

        private void OkValidation(object sender, EventArgs e)
        {
            if (txtNom.Text.Length>0)
            {
                MessageBox.Show("Bienvenue "+txtNom.Text);
            }
            
        }

        private void aa(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
            //Autre Methode
            //txtNom.CharacterCasing = CharacterCasing.Upper;
        }

        
    }
}
