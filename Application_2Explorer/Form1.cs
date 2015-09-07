using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Application_2Explorer
{
    public partial class Akhilesh_Explorer : Form
    {
        public Akhilesh_Explorer()
        {
            InitializeComponent();
        }

        public void GetDrives()
        {
            String[] drives = Directory.GetLogicalDrives();
            for (int i = 0; i < drives.Length; i++)
            {
                lstDrives.Items.Add(drives[i]);

            }

        }

        public void GetDirs()
        {
            lstDirectories.Items.Clear();
            String[] dirs = Directory.GetDirectories(lstDrives.SelectedItem.ToString());
            for (int i = 0; i < dirs.Length; i++)
            {
                lstDirectories.Items.Add(dirs[i]);
            }

        }

        public void GetFiles()
        {
            try
            {
                lstFiles.Items.Clear();
                string[] files = Directory.GetFiles(lstDirectories.SelectedItem.ToString());

                for (int i = 0; i < files.Length; i++)
                {
                    lstFiles.Items.Add(files[i]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }






        private void Akhilesh_Explorer_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(10);
            notifyIcon1.ContextMenuStrip = contextMenuStrip2;
            GetDrives();
            lstDirectories.ContextMenuStrip = contextMenuStrip1;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDirs();


        }

        private void lstDirectories_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFiles();

        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileType = Path.GetExtension(lstFiles.SelectedItem.ToString());
            if (fileType != ".jpg" && fileType != ".png" && fileType != ".gif")
            {
                MessageBox.Show("Cnnot View the files");
            }
            else
            {
                x.Image = Image.FromFile(lstFiles.SelectedItem.ToString());
            }

        }

        private void x_Click(object sender, EventArgs e)
        {
        }

        private void NewFolder_Click(object sender, EventArgs e)
        {
            string folderNAme = txtFolder.Text;
            string path = lstDrives.SelectedItem.ToString();
            if (Directory.Exists(path + folderNAme))
            {

                MessageBox.Show("Folder Exists");
            }
            else
            {
                Directory.CreateDirectory(path + folderNAme);

                txtFolder.Text = "";
                GetDirs();

            }
        }

        private void deleteDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure Wanted to Delete ", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Directory.Delete(lstDirectories.SelectedItem.ToString());
                GetDirs();
            }
            else
            {
                GetDirs();

            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDirs();

        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
