using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace JapaneseApp
{
    public partial class Form1 : Form
    {
        static JsonController jsonController = new JsonController();
        RootObject jsonObject;

        List<RichTextBox> richTextBoxes;

        public Form1()
        {
            InitializeComponent();

            //put all of the RichTextboxes into a list too clear them all 
            richTextBoxes = new List<RichTextBox>();
            foreach (Control control in Controls)
            {
                if(control.GetType() == typeof(RichTextBox))
                    richTextBoxes.Add((RichTextBox)control);
            }

        }

        #region Button Clicks

        public void Search(string searchText)
        {
            jsonObject = jsonController.setJson(searchText);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search(searchTextbox.Text);

            if (jsonObject == null)//the search yeilded 0 results -> can't update text
            {
                EnglishDefinitionTextBox.Text = "No results for search";
                return;
            }
            else
            {
                UpdateText();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (jsonObject == null)//the search yeilded 0 results -> can't call Next();
            {
                EnglishDefinitionTextBox.Text = "No results for search";
                return;
            }
            else
            {
                jsonController.nextResult();
                UpdateText();
            }
        }

        #endregion

        #region StripMenuItems

        private void englishDefinitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            EnglishDefinitionTextBox.Font = fd.Font;
        }

        private void japaneseDefinitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            dataGridView1.Font = fd.Font;
        }

        private void zoomedCellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            EnhanceTextBox.Font = fd.Font;
        }
        #endregion


        #region Text Changes

        public void searchTextbox_GotFocus(Object sender, EventArgs e)
        {
            searchTextbox.Text = "";
            searchTextbox.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        public void ClearText()
        {
            foreach (RichTextBox richTextBox in richTextBoxes)
            {
                richTextBox.Clear();
            }
        }

        public void UpdateText()
        {
            dataGridView1.Rows.Clear();

            List<string[]> rows = jsonController.getRows();
            foreach (string[] row in rows)
                dataGridView1.Rows.Add(row);


           for(int colIndex = 0; dataGridView1.CurrentCell.Value == null; colIndex++)
            { 
                if (colIndex == 4)
                    throw new InvalidDataException();
                dataGridView1.CurrentCell = dataGridView1[++colIndex, 0];
            }
            EnhanceTextBox.Text = dataGridView1.CurrentCell.Value.ToString();

            EnglishDefinitionTextBox.Text = printEnglishDefinitions();

        }

        public string printEnglishDefinitions()
        {
            return printList("English Words:\n", jsonController.getEnglishDefinitions());
        }

        public string printList(string baseSting, List<string> list)
        {
            foreach (string str in list)
                baseSting += str + "\n";
            return baseSting;
        }

        #endregion

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                EnhanceTextBox.Text = dataGridView1.CurrentCell.Value.ToString();
        }

   
    }
}