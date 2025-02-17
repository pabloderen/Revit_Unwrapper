﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revit_Unwrapper
{
    public partial class Unwrap : Form
    {
        private string revitFileTemplate;
        private string RevitUnwrappedFolder;

        public Unwrap()
        {
            InitializeComponent();
        }

        public static string revitFile { get; private set; }
        public string destination { get; private set; }

        private void selectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Revit files (*.rvt)|*.rvt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((revitFile = openFileDialog1.FileName) != null)
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void okUnwrap_click(object sender, EventArgs e)
        {
            _7zip.ExtractFile(revitFile, destination);
            this.DialogResult = DialogResult.OK;
            

        }

        private void destinationFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    destination = fbd.SelectedPath;

                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void selectOrigin_Click(object sender, EventArgs e)
        {using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    RevitUnwrappedFolder = fbd.SelectedPath;

                }
            }
           

        }

        private void selectDestinationWrap_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "Revit files (*.rvt)|*.rvt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((revitFileTemplate = saveFileDialog.FileName) != null)
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void okWrap_Click(object sender, EventArgs e)
        {
            Wrapper.wrapper( RevitUnwrappedFolder, revitFileTemplate);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}