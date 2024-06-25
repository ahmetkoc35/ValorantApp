namespace DataBaseReaderProgram
{
    partial class SearchScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchScreen));
            searchButton=new Button();
            dataGridView1=new DataGridView();
            label1=new Label();
            usernameTextbox=new TextBox();
            backButton=new Button();
            label2=new Label();
            searchCombobox=new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Location=new Point(203, 140);
            searchButton.Name="searchButton";
            searchButton.Size=new Size(207, 63);
            searchButton.TabIndex=0;
            searchButton.Text="Search";
            searchButton.UseVisualStyleBackColor=true;
            searchButton.Click+=searchButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location=new Point(34, 232);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.RowTemplate.Height=29;
            dataGridView1.Size=new Size(675, 246);
            dataGridView1.TabIndex=1;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(203, 30);
            label1.Name="label1";
            label1.Size=new Size(184, 20);
            label1.TabIndex=2;
            label1.Text="Who Are You Looking For?";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location=new Point(203, 84);
            usernameTextbox.Name="usernameTextbox";
            usernameTextbox.Size=new Size(207, 27);
            usernameTextbox.TabIndex=3;
            // 
            // backButton
            // 
            backButton.Location=new Point(440, 140);
            backButton.Name="backButton";
            backButton.Size=new Size(96, 63);
            backButton.TabIndex=4;
            backButton.Text="Back";
            backButton.UseVisualStyleBackColor=true;
            backButton.Click+=backButton_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(440, 30);
            label2.Name="label2";
            label2.Size=new Size(95, 20);
            label2.TabIndex=5;
            label2.Text="Search With?";
            // 
            // searchCombobox
            // 
            searchCombobox.FormattingEnabled=true;
            searchCombobox.Items.AddRange(new object[] { "ID", "Username" });
            searchCombobox.Location=new Point(440, 83);
            searchCombobox.Name="searchCombobox";
            searchCombobox.Size=new Size(96, 28);
            searchCombobox.TabIndex=6;
            searchCombobox.Text="ID";
            // 
            // SearchScreen
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            ClientSize=new Size(752, 502);
            Controls.Add(searchCombobox);
            Controls.Add(label2);
            Controls.Add(backButton);
            Controls.Add(usernameTextbox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(searchButton);
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="SearchScreen";
            StartPosition=FormStartPosition.CenterScreen;
            Text="SearchScreen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox usernameTextbox;
        private Button backButton;
        private Label label2;
        private ComboBox searchCombobox;
    }
}