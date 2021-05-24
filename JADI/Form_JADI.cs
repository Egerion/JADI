using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JADI
{

    public partial class Form_JADI : Form
    {
        public Form_JADI()
        {
            InitializeComponent();
            FindProcess();
        }

        private void FindProcess()
        {
            System.Diagnostics.Process[] ProcessCollection = System.Diagnostics.Process.GetProcesses();
            for (int i = 0; i < ProcessCollection.Length; i++)
            {
                try
                {
                    ComboBox_Process.Items.Add(ProcessCollection[i].ProcessName);
                    //Icon ico = Icon.ExtractAssociatedIcon(ProcessCollection[i].MainModule.FileName);
                }
                catch
                {

                }
                  
            }
        }

        private void Button_ProcRefresh_Click(object sender, EventArgs e)
        {
            ComboBox_Process.SelectedIndex = -1;
            ComboBox_Process.Items.Clear();
            ComboBox_Process.ResetText();
            ComboBox_Process.Text = "List Refreshed";
            FindProcess();
        }

        private void ComboBox_Process_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_Inject_Click(object sender, EventArgs e)
        {
            if(ListBox_Dll.SelectedIndex > -1 && ComboBox_Process.SelectedIndex > -1)
            {
                Injector.DllInject(ComboBox_Process.SelectedItem.ToString(), ListBox_Dll.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Select Process and Dll to do injection.", "Error");
            }
        }

        private void TextBox_FindProcString_TextChanged(object sender, EventArgs e)
        {
            int Index = ComboBox_Process.FindString(TextBox_FindProcString.Text);
            if (Index != -1)
            {
                ComboBox_Process.SelectedIndex = Index;
            }
        }

        private void Button_AddDLL_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Dll File |*.dll";
            openFileDialog.FilterIndex = 2;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ListBox_Dll.Items.Add(openFileDialog.FileName);
                ListBox_Dll.SelectedIndex = 0;
            }
        }

        private void Button_RemoveDll_Click(object sender, EventArgs e)
        {
            if(ListBox_Dll.SelectedIndex != -1)
                ListBox_Dll.Items.RemoveAt(ListBox_Dll.SelectedIndex);
        }

        private void ListBox_Dll_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button_CreateProcWithDll_Click(object sender, EventArgs e)
        {
            if (ListBox_Dll.SelectedIndex != -1)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "Application File |*.exe";
                openFileDialog.FilterIndex = 2;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string directoryPath = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                    Injector.CreateProcessWithDll(openFileDialog.FileName, directoryPath,
                                                  ListBox_Dll.SelectedItem.ToString(), false);
                }
            }
            else
            {
                MessageBox.Show("Select Dll before doing application Selection.", "Warning.");
            }
        }

        private void Button_DllEject_Click(object sender, EventArgs e)
        {
            if(ListBox_Dll.SelectedIndex != -1 && ComboBox_Process.SelectedIndex != -1)
            {
                Injector.DllEject(ComboBox_Process.SelectedItem.ToString(), ListBox_Dll.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Select Process and Dll to do ejection.", "Error");
            }
        }
    }
}
