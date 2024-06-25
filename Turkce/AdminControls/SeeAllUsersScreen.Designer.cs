namespace DataBaseReaderProgram
{
    partial class SeeAllUsersScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeAllUsersScreen));
            dataGridView1=new DataGridView();
            label1=new Label();
            backButton=new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location=new Point(54, 90);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.RowTemplate.Height=29;
            dataGridView1.Size=new Size(733, 273);
            dataGridView1.TabIndex=0;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(382, 50);
            label1.Name="label1";
            label1.Size=new Size(80, 20);
            label1.TabIndex=1;
            label1.Text="ALL USERS";
            // 
            // backButton
            // 
            backButton.Location=new Point(372, 382);
            backButton.Name="backButton";
            backButton.Size=new Size(109, 46);
            backButton.TabIndex=2;
            backButton.Text="Back";
            backButton.UseVisualStyleBackColor=true;
            backButton.Click+=backButton_Click;
            // 
            // SeeAllUsersScreen
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            ClientSize=new Size(843, 472);
            Controls.Add(backButton);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="SeeAllUsersScreen";
            StartPosition=FormStartPosition.CenterScreen;
            Text="SeeAllUsersScreen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button backButton;
    }
}