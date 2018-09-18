using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexTest
{
    public partial class Form1 : Form
    {
        string path = Application.StartupPath + @"\patterns.txt";
        public Form1()
        {
            InitializeComponent();
            tbPattern.TextChanged += tb_TextChanged;
            tbText.TextChanged += tb_TextChanged;
            tbPattern.TextChanged += saveTextboxesChanged;
            tbPatternName.TextChanged += saveTextboxesChanged;
            readAllPatternsFromFile();
        }

        //If textbox pattern and save pattern name is not empty, then the save button is active
        private void saveTextboxesChanged(object sender, EventArgs e)
        {
            if (tbPatternName.TextLength > 0 && tbPattern.TextLength > 0)
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        //Read all data from the saved pattern file and add it to the listview
        private void readAllPatternsFromFile()
        {
            if (File.Exists(path))
            {
                listView1.Items.Clear();
                foreach (var item in File.ReadAllText(path).Split('\n'))
                {
                    if (item.Length > 3)
                    {
                        ListViewItem lvi = new ListViewItem(item.Split(':')[0]);
                        lvi.SubItems.Add(item.Split(':')[1]);
                        listView1.Items.Add(lvi);
                    }
                }
            }
        }

        //If text to test and pattner (textboxes)  is not empty do regex using both values from the textboxs
        private void tb_TextChanged(object sender, EventArgs e)
        {
            if(tbText.TextLength != 0 && tbPattern.TextLength != 0)
            {
                try
                {
                    Regex rx = new Regex(tbPattern.Text);
                    MatchCollection matches = rx.Matches(tbText.Text);
                    rbMatchedText.Clear();
                    foreach (var item in matches)
                    {
                        rbMatchedText.AppendText(item + Environment.NewLine);
                    }
                    lblMatchedCount.Text = "Count: " + matches.Count;
                }
                catch
                {
                    rbMatchedText.Text = "";
                    lblMatchedCount.Text = "Count: 0";
                }
            }
        }

        //Saves the current pattern with its name to the patterns.txt file
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbPattern.TextLength > 0 && tbPatternName.TextLength > 0)
            {
                File.AppendAllText(path, tbPatternName.Text.Replace("\r","") + ":" + tbPattern.Text.Replace("\r", "") + Environment.NewLine);
                MessageBox.Show("The current pattern was saved with the name: " + tbPatternName.Text, "Saved");
                tbPatternName.Clear();
                readAllPatternsFromFile();
            }
        }

        //Sets the current pattern that is selected in the listview to the current pattern to test
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string pattern = listView1.SelectedItems[0].SubItems[1].Text;
            MessageBox.Show(pattern);
        }

        //Serachfunction, first reset the listview, then check if any of the patterns/pattername is matching the current search field
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            readAllPatternsFromFile();

            List<ListViewItem> lvis = new List<ListViewItem>();
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text.Contains(textBox1.Text) || item.SubItems[1].Text.Contains(textBox1.Text))
                    lvis.Add(item);
            }
            listView1.Items.Clear();
            foreach (var item in lvis)
            {
                listView1.Items.Add(item);
            }
        }

        //Remove the selected item from the listview and the patterns.txt file
        //Dialog result to see if the user is sure HE wants to remove the current pattern
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure you want to remove \"" + listView1.SelectedItems[0].SubItems[0].Text + "\". From the current pattern list?",
                    "Remove file", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    string newContent = "";
                    foreach (var item in File.ReadAllText(path).Split('\n'))
                    {
                        if (item.Replace("\r", "") != listView1.SelectedItems[0].SubItems[0].Text.Replace("\r", "") + ":" + listView1.SelectedItems[0].SubItems[1].Text.Replace("\r", ""))
                            newContent += item.Replace("\r", "") + Environment.NewLine;
                    }
                    File.WriteAllText(path, newContent.Replace("\r", ""));
                    readAllPatternsFromFile();
                }
            }
        }

        //if no item is selected in the listview, set the buttrons to enable = false
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                btnLoad.Enabled = false;
                button1.Enabled = false;
                btnUnselect.Enabled = false;
            }
            else
            {
                btnLoad.Enabled = true;
                button1.Enabled = true;
                btnUnselect.Enabled = true;
            }
        }

        //To unselect a item in the textview
        private void btnUnselect_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
        }
    }
}
