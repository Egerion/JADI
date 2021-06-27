using System.IO;
using System.Windows.Forms;

namespace JADI
{
    public partial class Form_JADI : Form
    {
        string SettingsFile = Directory.GetCurrentDirectory() + "\\Settings.ini";
        //string SettingsFile = "C:\\Users\\Ege\\Documents\\GitHub\\JADI\\JADI\\Settings.ini";

        void LoadUserSettings()
        {
            try
            {
                System.IO.StreamReader StreamReader = new System.IO.StreamReader(SettingsFile);
                for (string line = StreamReader.ReadLine(); line != null; line = StreamReader.ReadLine())
                {
                    if(!string.IsNullOrWhiteSpace(line))
                        ListBox_Dll.Items.Add(line);
                }
                StreamReader.Close();
            }
            catch
            {
                MessageBox.Show("Application cannot find or read Settings.ini file.", "Warning.");
            }
        }

        void SaveUserSettings()
        {
            try
            {
                string[] lines = File.ReadAllLines(SettingsFile);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i < ListBox_Dll.Items.Count)
                    {
                        lines[i] = ListBox_Dll.Items[i].ToString();
                    }
                    else
                    {
                        lines[i] = null;
                    }
                }
                File.WriteAllLines(SettingsFile, lines);
            }
            catch
            {
                MessageBox.Show("Application cannot find or write Settings.ini file.", "Warning.");
            }
        }
    }
}