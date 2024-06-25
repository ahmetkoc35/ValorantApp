namespace DataBaseReaderProgram
{
    partial class DeleteUserScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUserScreen));
            deleteUserButton=new Button();
            dataGridView1=new DataGridView();
            dataGridView2=new DataGridView();
            label1=new Label();
            deleteUserTextbox=new TextBox();
            backButton=new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location=new Point(889, 236);
            deleteUserButton.Name="deleteUserButton";
            deleteUserButton.Size=new Size(123, 61);
            deleteUserButton.TabIndex=0;
            deleteUserButton.Text="Delete User";
            deleteUserButton.UseVisualStyleBackColor=true;
            deleteUserButton.Click+=deleteUserButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location=new Point(37, 25);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.Size=new Size(675, 226);
            dataGridView1.TabIndex=1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location=new Point(37, 280);
            dataGridView2.Name="dataGridView2";
            dataGridView2.RowHeadersWidth=51;
            dataGridView2.Size=new Size(675, 223);
            dataGridView2.TabIndex=2;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(838, 112);
            label1.Name="label1";
            label1.Size=new Size(221, 40);
            label1.TabIndex=3;
            label1.Text="Please Type The Username That \r\n        You Want To Delete";
            // 
            // deleteUserTextbox
            // 
            deleteUserTextbox.Location=new Point(838, 169);
            deleteUserTextbox.Name="deleteUserTextbox";
            deleteUserTextbox.Size=new Size(221, 27);
            deleteUserTextbox.TabIndex=4;
            // 
            // backButton
            // 
            backButton.Location=new Point(917, 346);
            backButton.Name="backButton";
            backButton.Size=new Size(72, 52);
            backButton.TabIndex=5;
            backButton.Text="Back";
            backButton.UseVisualStyleBackColor=true;
            backButton.Click+=backButton_Click;
            // 
            // DeleteUserScreen
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            ClientSize=new Size(1139, 532);
            Controls.Add(backButton);
            Controls.Add(deleteUserTextbox);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(deleteUserButton);
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="DeleteUserScreen";
            StartPosition=FormStartPosition.CenterScreen;
            Text="DeleteUserScreen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteUserButton;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private TextBox deleteUserTextbox;
        private Button backButton;
    }
}