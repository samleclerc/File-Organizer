using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Organizer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dlgAddFolder.ShowDialog();

            if (dlgAddFolder.SelectedPath != "")
            {
                lstFolders.Items.Add(dlgAddFolder.SelectedPath);
            }
        }

        private void btnGetItems_Click(object sender, EventArgs e)
        {
            datItems.Rows.Clear();

            foreach (var item in lstFolders.Items)
            {
                if (Directory.Exists(item.ToString()))
                {
                    // This path is a directory
                    ProcessDir(item.ToString());
                }
                else
                {
                    Console.WriteLine("{0} is not a valid directory.", item.ToString());
                }
            }
        }

        private void ProcessDir(string dir)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(dir);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDir(subdirectory);
        }

        private void ProcessFile(string path)
        {
            FileInfo file = new FileInfo(path);

            datItems.Rows.Add(false, file.Name, file.Extension, file.Length.ToString(), file.CreationTime, file.LastWriteTime, file.DirectoryName);
        }
    }
}
