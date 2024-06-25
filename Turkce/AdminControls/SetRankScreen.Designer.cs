namespace DataBaseReaderProgram.AdminControls
{
    partial class SetRankScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetRankScreen));
            setRankButton=new Button();
            label1=new Label();
            label2=new Label();
            usernameSetRankTextbox=new TextBox();
            rankSelectionComboBox=new ComboBox();
            dataGridView1=new DataGridView();
            dataGridView2=new DataGridView();
            backButton=new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // setRankButton
            // 
            setRankButton.Location=new Point(680, 346);
            setRankButton.Name="setRankButton";
            setRankButton.Size=new Size(187, 51);
            setRankButton.TabIndex=0;
            setRankButton.Text="Set Rank";
            setRankButton.UseVisualStyleBackColor=true;
            setRankButton.Click+=setRankButton_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(680, 200);
            label1.Name="label1";
            label1.Size=new Size(187, 40);
            label1.TabIndex=1;
            label1.Text="What Is The Rank That You \r\n          Want To set";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(681, 84);
            label2.Name="label2";
            label2.Size=new Size(186, 40);
            label2.TabIndex=2;
            label2.Text="Which User That You Want \r\n        To Set The Rank";
            // 
            // usernameSetRankTextbox
            // 
            usernameSetRankTextbox.Location=new Point(680, 136);
            usernameSetRankTextbox.Name="usernameSetRankTextbox";
            usernameSetRankTextbox.Size=new Size(187, 27);
            usernameSetRankTextbox.TabIndex=3;
            // 
            // rankSelectionComboBox
            // 
            rankSelectionComboBox.FormattingEnabled=true;
            rankSelectionComboBox.Items.AddRange(new object[] { "Administrator", "User" });
            rankSelectionComboBox.Location=new Point(680, 258);
            rankSelectionComboBox.Name="rankSelectionComboBox";
            rankSelectionComboBox.Size=new Size(187, 28);
            rankSelectionComboBox.TabIndex=4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location=new Point(62, 32);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.Size=new Size(569, 221);
            dataGridView1.TabIndex=5;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location=new Point(62, 292);
            dataGridView2.Name="dataGridView2";
            dataGridView2.RowHeadersWidth=51;
            dataGridView2.Size=new Size(569, 240);
            dataGridView2.TabIndex=6;
            // 
            // backButton
            // 
            backButton.Location=new Point(727, 442);
            backButton.Name="backButton";
            backButton.Size=new Size(100, 42);
            backButton.TabIndex=7;
            backButton.Text="Back";
            backButton.UseVisualStyleBackColor=true;
            backButton.Click+=backButton_Click;
            // 
            // SetRankScreen
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            ClientSize=new Size(916, 566);
            Controls.Add(backButton);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(rankSelectionComboBox);
            Controls.Add(usernameSetRankTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(setRankButton);
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="SetRankScreen";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Set Rank";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button setRankButton;
        private Label label1;
        private Label label2;
        private TextBox usernameSetRankTextbox;
        private ComboBox rankSelectionComboBox;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button backButton;
    }
}