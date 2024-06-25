namespace DataBaseReaderProgram
{
    partial class SetPasswordScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetPasswordScreen));
            label2=new Label();
            newPasswordText=new TextBox();
            label3=new Label();
            newPasswordCheckText=new TextBox();
            changePasswordButton=new Button();
            dataGridView1=new DataGridView();
            dataGridView2=new DataGridView();
            label4=new Label();
            userPasswordText=new TextBox();
            backButton=new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(600, 251);
            label2.Name="label2";
            label2.Size=new Size(185, 20);
            label2.TabIndex=2;
            label2.Text="What Is The New Password";
            // 
            // newPasswordText
            // 
            newPasswordText.Location=new Point(600, 285);
            newPasswordText.Name="newPasswordText";
            newPasswordText.Size=new Size(245, 27);
            newPasswordText.TabIndex=3;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(600, 338);
            label3.Name="label3";
            label3.Size=new Size(231, 20);
            label3.TabIndex=4;
            label3.Text="Please Enter New Password Again";
            // 
            // newPasswordCheckText
            // 
            newPasswordCheckText.Location=new Point(600, 376);
            newPasswordCheckText.Name="newPasswordCheckText";
            newPasswordCheckText.Size=new Size(245, 27);
            newPasswordCheckText.TabIndex=5;
            // 
            // changePasswordButton
            // 
            changePasswordButton.Location=new Point(650, 429);
            changePasswordButton.Name="changePasswordButton";
            changePasswordButton.Size=new Size(154, 51);
            changePasswordButton.TabIndex=6;
            changePasswordButton.Text="Change Password";
            changePasswordButton.UseVisualStyleBackColor=true;
            changePasswordButton.Click+=changePasswordButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location=new Point(34, 46);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.RowTemplate.Height=29;
            dataGridView1.Size=new Size(524, 226);
            dataGridView1.TabIndex=7;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location=new Point(34, 311);
            dataGridView2.Name="dataGridView2";
            dataGridView2.RowHeadersWidth=51;
            dataGridView2.RowTemplate.Height=29;
            dataGridView2.Size=new Size(524, 257);
            dataGridView2.TabIndex=8;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(600, 127);
            label4.Name="label4";
            label4.Size=new Size(245, 40);
            label4.TabIndex=9;
            label4.Text="Which Username's Password Would \r\n            You Want To Change ";
            // 
            // userPasswordText
            // 
            userPasswordText.Location=new Point(600, 188);
            userPasswordText.Name="userPasswordText";
            userPasswordText.Size=new Size(245, 27);
            userPasswordText.TabIndex=10;
            // 
            // backButton
            // 
            backButton.Location=new Point(686, 527);
            backButton.Name="backButton";
            backButton.Size=new Size(84, 41);
            backButton.TabIndex=11;
            backButton.Text="Back";
            backButton.UseVisualStyleBackColor=true;
            backButton.Click+=backButton_Click;
            // 
            // SetPasswordScreen
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            ClientSize=new Size(916, 603);
            Controls.Add(backButton);
            Controls.Add(userPasswordText);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(changePasswordButton);
            Controls.Add(newPasswordCheckText);
            Controls.Add(label3);
            Controls.Add(newPasswordText);
            Controls.Add(label2);
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="SetPasswordScreen";
            StartPosition=FormStartPosition.CenterScreen;
            Text="SetPasswordScreen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox newPasswordText;
        private Label label3;
        private TextBox newPasswordCheckText;
        private Button changePasswordButton;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label4;
        private TextBox userPasswordText;
        private Button backButton;
    }
}