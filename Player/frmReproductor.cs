using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class frmReproductor : MaterialForm
    {
        public frmReproductor()
        {
            InitializeComponent();
        }

        private void frmReproductor_Load(object sender, EventArgs e)
        {

        }

        private void AddFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = openFileDialog1.FileName;
                lbxFiles.Items.Add(nombreArchivo);
            }



        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            AddFile();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lbxFiles.SelectedIndex > 0)
            {
                string ruta = lbxFiles.SelectedItem.ToString();

                MediaPlayer.URL = ruta;
                MediaPlayer.Ctlcontrols.play();
            }


        }

        private void pbxRemove_Click(object sender, EventArgs e)
        {
            if(lbxFiles.SelectedIndex > 0)
            {
                string archivo = lbxFiles.SelectedItem.ToString();
                lbxFiles.Items.Remove(archivo);  

            }
        }

        private void pbxNext_Click(object sender, EventArgs e)
        {
            if (lbxFiles.SelectedIndex >= 0)
            {
                int indice = lbxFiles.SelectedIndex;

                if (indice < lbxFiles.Items.Count - 1)
                {
                    lbxFiles.SelectedIndex = indice + 1;

                    string ruta = lbxFiles.SelectedItem.ToString();

                    MediaPlayer.URL = ruta;
                    MediaPlayer.Ctlcontrols.play();

                }

            }

        }

        private void pbxBack_Click(object sender, EventArgs e)
        {

            if (lbxFiles.SelectedIndex >= 0)
            {
                int indice = lbxFiles.SelectedIndex;

                if (indice > 0)
                {
                    lbxFiles.SelectedIndex = indice - 1;

                    string ruta = lbxFiles.SelectedItem.ToString();
                    MediaPlayer.URL = ruta;
                    MediaPlayer.Ctlcontrols.play();

                }

            }

        }
    }
}




/*
 
 
      private void pbxNext_Click(object sender, EventArgs e)
        {
            if (lbxFiles.SelectedIndex >= 0)
            {
                int indice = lbxFiles.SelectedIndex;

                if (indice < lbxFiles.Items.Count - 1)
                {
                    lbxFiles.SelectedIndex = indice + 1;

                    string ruta = lbxFiles.SelectedItem.ToString();

                    MediaPlayer.URL = ruta;
                    MediaPlayer.Ctlcontrols.play(); 

                }



            }
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            if(lbxFiles.SelectedIndex >= 0)
            {
                int indice = lbxFiles.SelectedIndex;

                if (indice > 0)
                {
                    lbxFiles.SelectedIndex = indice - 1;

                    string ruta = lbxFiles.SelectedItem.ToString();
                    MediaPlayer.URL = ruta;
                    MediaPlayer.Ctlcontrols.play();

                }

            }
        }
 
 
 
 */