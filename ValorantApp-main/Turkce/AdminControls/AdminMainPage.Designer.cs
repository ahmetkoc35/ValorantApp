namespace DataBaseReaderProgram
{
    partial class AdminMainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainPage));
            searchButton=new Button();
            addNewUserButton=new Button();
            deleteUserButton=new Button();
            exitButton=new Button();
            label1=new Label();
            button1=new Button();
            button2=new Button();
            setUserRank=new Button();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Location=new Point(40, 88);
            searchButton.Name="searchButton";
            searchButton.Size=new Size(165, 49);
            searchButton.TabIndex=0;
            searchButton.Text="Search A User";
            searchButton.UseVisualStyleBackColor=true;
            searchButton.Click+=searchButton_Click;
            // 
            // addNewUserButton
            // 
            addNewUserButton.Location=new Point(40, 173);
            addNewUserButton.Name="addNewUserButton";
            addNewUserButton.Size=new Size(165, 51);
            addNewUserButton.TabIndex=2;
            addNewUserButton.Text="Add New User";
            addNewUserButton.UseVisualStyleBackColor=true;
            addNewUserButton.Click+=addNewUserButton_Click;
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location=new Point(335, 88);
            deleteUserButton.Name="deleteUserButton";
            deleteUserButton.Size=new Size(165, 51);
            deleteUserButton.TabIndex=3;
            deleteUserButton.Text="Delete User";
            deleteUserButton.UseVisualStyleBackColor=true;
            deleteUserButton.Click+=deleteUserButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location=new Point(225, 361);
            exitButton.Name="exitButton";
            exitButton.Size=new Size(96, 51);
            exitButton.TabIndex=4;
            exitButton.Text="Exit";
            exitButton.UseVisualStyleBackColor=true;
            exitButton.Click+=exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(125, 30);
            label1.Name="label1";
            label1.Size=new Size(277, 20);
            label1.TabIndex=5;
            label1.Text="Welcome To Valorant App Admin Pannel";
            // 
            // button1
            // 
            button1.Location=new Point(40, 260);
            button1.Name="button1";
            button1.Size=new Size(165, 51);
            button1.TabIndex=6;
            button1.Text="See All Users";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Location=new Point(335, 172);
            button2.Name="button2";
            button2.Size=new Size(165, 52);
            button2.TabIndex=7;
            button2.Text="Set Password";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=setPasswordButton_Click;
            // 
            // setUserRank
            // 
            setUserRank.Location=new Point(335, 260);
            setUserRank.Name="setUserRank";
            setUserRank.Size=new Size(165, 51);
            setUserRank.TabIndex=8;
            setUserRank.Text="Set User Rank";
            setUserRank.UseVisualStyleBackColor=true;
            setUserRank.Click+=setUserRank_Click;
            // 
            // AdminMainPage
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(531, 441);
            Controls.Add(setUserRank);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(deleteUserButton);
            Controls.Add(addNewUserButton);
            Controls.Add(searchButton);
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="AdminMainPage";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Admin Main Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private Button addNewUserButton;
        private Button deleteUserButton;
        private Button exitButton;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button setUserRank;
    }
}