namespace DataBaseReaderProgram
{
    partial class AddNewUserScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUserScreen));
            dataGridView2=new DataGridView();
            dataGridView1=new DataGridView();
            addUserButton=new Button();
            enterUsernameLabel=new Label();
            enterPasswordLabel=new Label();
            enterUsernameTextbox=new TextBox();
            enterPasswordTextbox=new TextBox();
            exitButton=new Button();
            mailTextbox=new TextBox();
            label1=new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location=new Point(324, 291);
            dataGridView2.Name="dataGridView2";
            dataGridView2.RowHeadersWidth=51;
            dataGridView2.Size=new Size(675, 248);
            dataGridView2.TabIndex=4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location=new Point(324, 34);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.Size=new Size(675, 225);
            dataGridView1.TabIndex=3;
            // 
            // addUserButton
            // 
            addUserButton.Location=new Point(58, 378);
            addUserButton.Name="addUserButton";
            addUserButton.Size=new Size(167, 44);
            addUserButton.TabIndex=5;
            addUserButton.Text="Add User";
            addUserButton.UseVisualStyleBackColor=true;
            addUserButton.Click+=addUserButton_Click;
            // 
            // enterUsernameLabel
            // 
            enterUsernameLabel.AutoSize=true;
            enterUsernameLabel.Location=new Point(82, 74);
            enterUsernameLabel.Name="enterUsernameLabel";
            enterUsernameLabel.Size=new Size(113, 20);
            enterUsernameLabel.TabIndex=6;
            enterUsernameLabel.Text="Enter Username";
            // 
            // enterPasswordLabel
            // 
            enterPasswordLabel.AutoSize=true;
            enterPasswordLabel.Location=new Point(82, 278);
            enterPasswordLabel.Name="enterPasswordLabel";
            enterPasswordLabel.Size=new Size(108, 20);
            enterPasswordLabel.TabIndex=7;
            enterPasswordLabel.Text="Enter Password";
            // 
            // enterUsernameTextbox
            // 
            enterUsernameTextbox.Location=new Point(58, 113);
            enterUsernameTextbox.Name="enterUsernameTextbox";
            enterUsernameTextbox.Size=new Size(167, 27);
            enterUsernameTextbox.TabIndex=8;
            // 
            // enterPasswordTextbox
            // 
            enterPasswordTextbox.Location=new Point(58, 316);
            enterPasswordTextbox.Name="enterPasswordTextbox";
            enterPasswordTextbox.Size=new Size(167, 27);
            enterPasswordTextbox.TabIndex=9;
            // 
            // exitButton
            // 
            exitButton.Location=new Point(82, 468);
            exitButton.Name="exitButton";
            exitButton.Size=new Size(108, 48);
            exitButton.TabIndex=10;
            exitButton.Text="Back";
            exitButton.UseVisualStyleBackColor=true;
            exitButton.Click+=exitButton_Click;
            // 
            // mailTextbox
            // 
            mailTextbox.Location=new Point(58, 212);
            mailTextbox.Name="mailTextbox";
            mailTextbox.Size=new Size(167, 27);
            mailTextbox.TabIndex=12;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(82, 170);
            label1.Name="label1";
            label1.Size=new Size(90, 20);
            label1.TabIndex=11;
            label1.Text="Enter E-Mail";
            // 
            // AddNewUserScreen
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            ClientSize=new Size(1061, 603);
            Controls.Add(mailTextbox);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(enterPasswordTextbox);
            Controls.Add(enterUsernameTextbox);
            Controls.Add(enterPasswordLabel);
            Controls.Add(enterUsernameLabel);
            Controls.Add(addUserButton);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="AddNewUserScreen";
            StartPosition=FormStartPosition.CenterScreen;
            Text="AddNewUserScreen";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Button addUserButton;
        private Label enterUsernameLabel;
        private Label enterPasswordLabel;
        private TextBox enterUsernameTextbox;
        private TextBox enterPasswordTextbox;
        private Button exitButton;
        private TextBox mailTextbox;
        private Label label1;
    }
}