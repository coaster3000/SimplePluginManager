using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PluginManager
{
    
    public partial class MainWindow : Form
    {
        public const String appName = "Plugin Manager";

        private String[] files = null;

        private String path = null;
        private String lastPath = null;

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                path = System.IO.File.ReadAllText(Environment.CurrentDirectory + "\\currdir.dat");
                btn_rename.Enabled = !listView1.MultiSelect;
            }
            catch (Exception err)
            {
                path = null;
            }

            
        }

        private void windowNameUpdate(String text)
        {
            this.Text = appName + " - " + text;
        }
        private void OnFormClosing(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(Environment.CurrentDirectory + "\\currdir.dat", path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fbd1.RootFolder = Environment.SpecialFolder.Desktop;
            
            fbd1.ShowNewFolderButton = false;
            fbd1.Description = "Select a folder to manager.";

            if (!selectPath())
            {
                this.Close();

                this.Dispose();
                Application.Exit();
            }

            windowNameUpdate(path);
        }

        private void btn_selectFolder_Click(object sender, EventArgs e)
        {
            selectPath();
        }

        private bool selectPath()
        {
            DialogResult r = fbd1.ShowDialog();
            if (r == DialogResult.Cancel && path == null)
                return false;

            lastPath = path;
            path = fbd1.SelectedPath;

            bool update = updateList();
            if (lastPath == path && !update)
                return false;
            else
            {
                windowNameUpdate(path);
                return update;
            }
        }

        private bool updateList()
        {
            try
            {
                String[] data = System.IO.Directory.GetFiles(path);

                listView1.Items.Clear();
                foreach (String i in data)
                {
                    String d = i.Split('\\').Last();
                    if (d.EndsWith(".jar") || d.EndsWith(".disabled") || d.Contains(".jar."))
                    {
                        ListViewItem b = new ListViewItem(d);
                        if (!(d.EndsWith(".jar")))
                            b.BackColor = Color.Cyan;

                        listView1.Items.Add(b);
                    }
                    else
                        continue;
                }
                if (listView1.Items.Count == 0)
                {
                    DialogResult r = MessageBox.Show("There were no files found that matched plugin management.", "Invalid Folder", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                    if (r == DialogResult.Retry)
                        return selectPath();
                    else if (r == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (System.IO.DirectoryNotFoundException err)
            {
                DialogResult r = MessageBox.Show("That directory was not found!", "Sorry!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.Retry)
                    return selectPath();
                else if (r == DialogResult.Cancel)
                {
                    if (path == null || path.Equals(""))
                        return false;
                    else
                        return true;
                }
            }
            return false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = listView1.SelectedItems.Count;
            int i = 0;
            files = new String[size];
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                
                files[i] = path + '\\' +item.Text;
                i++;
            }

            if (!listView1.MultiSelect && size > 0)
                txtBox_rename.Text = files[0].Split('\\').Last();
        }

        private void btn_enable_Click(object sender, EventArgs e)
        {
            foreach (String file in files)
                if (!file.Split('\\').Last().EndsWith(".jar"))
                    try
                    {
                        System.IO.File.Move(file, file.Replace(".disabled", ""));

                        
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Exception Occured: \n" + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            updateList();
        }

        private void btn_disable_Click(object sender, EventArgs e)
        {
            foreach(String file in files)
                if (file.Split('\\').Last().EndsWith(".jar"))
                    try
                    {
                        System.IO.File.Move(file, file + ".disabled");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Exception Occured: \n" + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            updateList();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            updateList();
        }

        private void btn_Toggle_SingleSelect_Click(object sender, EventArgs e)
        {
            bool d = !listView1.MultiSelect;

            listView1.MultiSelect = d;

            if (d)
                btn_Toggle_SingleSelect.Text = "Multi Select";
            else
                btn_Toggle_SingleSelect.Text = "Single Select";

            btn_rename.Enabled = !d;
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            Regex reg = null;

            reg = new Regex(txtbox_nameFormat.Text, RegexOptions.IgnoreCase);

            try
            {
                foreach (String file in files)
                {
                    Match m = reg.Match(file);
                    int i = m.Groups.Count - 1;
                    String ext = null;
                    if (i >= 0)
                        ext = m.Groups[i].ToString();
                    else
                        ext = "";

                    String newfile = reg.Replace(file, ext);
                    try
                    {
                        MessageBox.Show(file + "\n" + newfile + "\n"+ ext);
                        System.IO.File.Move(file, newfile);
                    }
                    catch (Exception er)
                    {

                        MessageBox.Show("Error Occured on file rename: \n " + er.Message + "\n\n Additional Details: \n m=" + m.ToString() + "\n m.groups[" + i + "]=" + m.Groups[i].ToString()
                            + "\n file=" + file + "\n newFile=" + newfile + "\n ext=" + ext
                            , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (NullReferenceException err)
            {
                MessageBox.Show("You must select files to do replacement", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            updateList();
        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            foreach (String file in files)
            {
                String[] d = file.Split('\\');
                String a = "";
                bool first = true;
                for (int i = 0; i < (d.Count() - 1); i++)
                    if (!first)
                        a += "\\" + d[i];
                    else
                    {
                        a += d[i];
                        first = false;

                    }
                a += "\\";
                a += txtBox_rename.Text;
                try
                {

                    System.IO.File.Move(file, a);
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error Occured on file rename: \n " + er.Message + "\n Additional Details: \n a= " + a + "\n file= " + file, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            updateList();
        }

        private void btn_reset_formatter_Click(object sender, EventArgs e)
        {
            txtbox_nameFormat.Text = "(?:\\.)?(?:V)?[-.\\d]+(\\.jar|\\.disabled)";
        }

    }
}
