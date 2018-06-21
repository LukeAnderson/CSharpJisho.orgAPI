namespace JapaneseApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.japaneseDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nextButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.RichTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelEnglishWordsAndEnhance = new System.Windows.Forms.TableLayoutPanel();
            this.EnhanceTextBox = new System.Windows.Forms.RichTextBox();
            this.EnglishDefinitionTextBox = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PartOfSpeechColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RomajiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KanaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KanjiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.JishoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.zoomedCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanelEnglishWordsAndEnhance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.JishoTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishDefinitionToolStripMenuItem,
            this.japaneseDefinitionToolStripMenuItem,
            this.zoomedCellToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // englishDefinitionToolStripMenuItem
            // 
            this.englishDefinitionToolStripMenuItem.Name = "englishDefinitionToolStripMenuItem";
            this.englishDefinitionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.englishDefinitionToolStripMenuItem.Text = "English";
            this.englishDefinitionToolStripMenuItem.Click += new System.EventHandler(this.englishDefinitionToolStripMenuItem_Click);
            // 
            // japaneseDefinitionToolStripMenuItem
            // 
            this.japaneseDefinitionToolStripMenuItem.Name = "japaneseDefinitionToolStripMenuItem";
            this.japaneseDefinitionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.japaneseDefinitionToolStripMenuItem.Text = "Japanese";
            this.japaneseDefinitionToolStripMenuItem.Click += new System.EventHandler(this.japaneseDefinitionToolStripMenuItem_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.ColumnCount = 3;
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.00888F));
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.66431F));
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.66248F));
            this.searchPanel.Controls.Add(this.searchButton, 0, 0);
            this.searchPanel.Controls.Add(this.searchTextbox, 0, 0);
            this.searchPanel.Controls.Add(this.nextButton, 2, 0);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(0, 475);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.RowCount = 1;
            this.searchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchPanel.Size = new System.Drawing.Size(761, 73);
            this.searchPanel.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(635, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(123, 67);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.searchTextbox.Location = new System.Drawing.Point(3, 3);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(452, 67);
            this.searchTextbox.TabIndex = 3;
            this.searchTextbox.Text = "Search Words";
            this.searchTextbox.GotFocus += new System.EventHandler(this.searchTextbox_GotFocus);
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(461, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(168, 67);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.05618F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(331, 554);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanelEnglishWordsAndEnhance);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 554);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanelEnglishWordsAndEnhance
            // 
            this.tableLayoutPanelEnglishWordsAndEnhance.ColumnCount = 2;
            this.tableLayoutPanelEnglishWordsAndEnhance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEnglishWordsAndEnhance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEnglishWordsAndEnhance.Controls.Add(this.EnglishDefinitionTextBox, 0, 0);
            this.tableLayoutPanelEnglishWordsAndEnhance.Controls.Add(this.EnhanceTextBox, 1, 0);
            this.tableLayoutPanelEnglishWordsAndEnhance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEnglishWordsAndEnhance.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelEnglishWordsAndEnhance.Name = "tableLayoutPanelEnglishWordsAndEnhance";
            this.tableLayoutPanelEnglishWordsAndEnhance.RowCount = 1;
            this.tableLayoutPanelEnglishWordsAndEnhance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEnglishWordsAndEnhance.Size = new System.Drawing.Size(331, 554);
            this.tableLayoutPanelEnglishWordsAndEnhance.TabIndex = 7;
            // 
            // EnhanceTextBox
            // 
            this.EnhanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnhanceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnhanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnhanceTextBox.Location = new System.Drawing.Point(165, 0);
            this.EnhanceTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.EnhanceTextBox.Name = "EnhanceTextBox";
            this.EnhanceTextBox.ReadOnly = true;
            this.EnhanceTextBox.Size = new System.Drawing.Size(166, 554);
            this.EnhanceTextBox.TabIndex = 6;
            this.EnhanceTextBox.Text = "";
            // 
            // EnglishDefinitionTextBox
            // 
            this.EnglishDefinitionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnglishDefinitionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnglishDefinitionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishDefinitionTextBox.Location = new System.Drawing.Point(0, 0);
            this.EnglishDefinitionTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.EnglishDefinitionTextBox.Name = "EnglishDefinitionTextBox";
            this.EnglishDefinitionTextBox.ReadOnly = true;
            this.EnglishDefinitionTextBox.Size = new System.Drawing.Size(165, 554);
            this.EnglishDefinitionTextBox.TabIndex = 5;
            this.EnglishDefinitionTextBox.Text = "English Words:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KanjiColumn,
            this.KanaColumn,
            this.RomajiColumn,
            this.PartOfSpeechColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(755, 469);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PartOfSpeechColumn
            // 
            this.PartOfSpeechColumn.HeaderText = "Part Of Speech";
            this.PartOfSpeechColumn.Name = "PartOfSpeechColumn";
            this.PartOfSpeechColumn.ReadOnly = true;
            // 
            // RomajiColumn
            // 
            this.RomajiColumn.HeaderText = "Romaji";
            this.RomajiColumn.Name = "RomajiColumn";
            this.RomajiColumn.ReadOnly = true;
            // 
            // KanaColumn
            // 
            this.KanaColumn.HeaderText = "Kana";
            this.KanaColumn.Name = "KanaColumn";
            this.KanaColumn.ReadOnly = true;
            // 
            // KanjiColumn
            // 
            this.KanjiColumn.HeaderText = "Kanji";
            this.KanjiColumn.Name = "KanjiColumn";
            this.KanjiColumn.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.14572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.85428F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.JishoTableLayoutPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.32491F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1098, 554);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // JishoTableLayoutPanel
            // 
            this.JishoTableLayoutPanel.ColumnCount = 1;
            this.JishoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.JishoTableLayoutPanel.Controls.Add(this.dataGridView1, 0, 0);
            this.JishoTableLayoutPanel.Controls.Add(this.searchPanel, 0, 1);
            this.JishoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JishoTableLayoutPanel.Location = new System.Drawing.Point(334, 3);
            this.JishoTableLayoutPanel.Name = "JishoTableLayoutPanel";
            this.JishoTableLayoutPanel.RowCount = 2;
            this.JishoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.78815F));
            this.JishoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.21185F));
            this.JishoTableLayoutPanel.Size = new System.Drawing.Size(761, 548);
            this.JishoTableLayoutPanel.TabIndex = 5;
            // 
            // zoomedCellToolStripMenuItem
            // 
            this.zoomedCellToolStripMenuItem.Name = "zoomedCellToolStripMenuItem";
            this.zoomedCellToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomedCellToolStripMenuItem.Text = "Zoomed Cell";
            this.zoomedCellToolStripMenuItem.Click += new System.EventHandler(this.zoomedCellToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1098, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CSharpJisho.orgAPI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanelEnglishWordsAndEnhance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.JishoTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishDefinitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem japaneseDefinitionToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel searchPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RichTextBox searchTextbox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEnglishWordsAndEnhance;
        private System.Windows.Forms.RichTextBox EnglishDefinitionTextBox;
        private System.Windows.Forms.RichTextBox EnhanceTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanjiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RomajiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartOfSpeechColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel JishoTableLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem zoomedCellToolStripMenuItem;
    }
}

