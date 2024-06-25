namespace DataBaseReaderProgram
{
    partial class LogInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            logInButton=new Button();
            mailTextbox=new TextBox();
            kullanıcıAdıLabel=new Label();
            sifreLabel=new Label();
            passwordTextbox=new TextBox();
            arayuzLabel=new Label();
            signUpButton=new Button();
            exitButton=new Button();
            showHide=new CheckBox();
            forgotPasswordLink=new LinkLabel();
            languageButtonTurkishFlag=new Button();
            languageButtonEnglishFlag=new Button();
            SuspendLayout();
            // 
            // logInButton
            // 
            logInButton.BackColor=Color.Gainsboro;
            logInButton.Cursor=Cursors.Hand;
            logInButton.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            logInButton.Location=new Point(162, 280);
            logInButton.Name="logInButton";
            logInButton.Size=new Size(209, 73);
            logInButton.TabIndex=0;
            logInButton.Text="GIrIs Yap";
            logInButton.UseVisualStyleBackColor=false;
            logInButton.Click+=logInButton_Click;
            // 
            // mailTextbox
            // 
            mailTextbox.Cursor=Cursors.IBeam;
            mailTextbox.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mailTextbox.Location=new Point(162, 159);
            mailTextbox.Name="mailTextbox";
            mailTextbox.Size=new Size(183, 27);
            mailTextbox.TabIndex=1;
            // 
            // kullanıcıAdıLabel
            // 
            kullanıcıAdıLabel.AutoSize=true;
            kullanıcıAdıLabel.BackColor=Color.Transparent;
            kullanıcıAdıLabel.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            kullanıcıAdıLabel.ForeColor=SystemColors.Info;
            kullanıcıAdıLabel.Location=new Point(162, 132);
            kullanıcıAdıLabel.Name="kullanıcıAdıLabel";
            kullanıcıAdıLabel.Size=new Size(116, 24);
            kullanıcıAdıLabel.TabIndex=2;
            kullanıcıAdıLabel.Text="E Posta";
            // 
            // sifreLabel
            // 
            sifreLabel.AutoSize=true;
            sifreLabel.BackColor=Color.Transparent;
            sifreLabel.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sifreLabel.ForeColor=SystemColors.Info;
            sifreLabel.Location=new Point(162, 203);
            sifreLabel.Name="sifreLabel";
            sifreLabel.Size=new Size(78, 24);
            sifreLabel.TabIndex=4;
            sifreLabel.Text="SIfre";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Cursor=Cursors.IBeam;
            passwordTextbox.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextbox.Location=new Point(162, 230);
            passwordTextbox.Name="passwordTextbox";
            passwordTextbox.Size=new Size(183, 27);
            passwordTextbox.TabIndex=3;
            passwordTextbox.UseSystemPasswordChar=true;
            // 
            // arayuzLabel
            // 
            arayuzLabel.AutoSize=true;
            arayuzLabel.BackColor=Color.Transparent;
            arayuzLabel.Font=new Font("VALORANT", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            arayuzLabel.ForeColor=SystemColors.Info;
            arayuzLabel.Location=new Point(17, 25);
            arayuzLabel.Name="arayuzLabel";
            arayuzLabel.Size=new Size(518, 76);
            arayuzLabel.TabIndex=5;
            arayuzLabel.Text="Valorant TurnuvalarI \r\nArayuzu";
            arayuzLabel.UseWaitCursor=true;
            // 
            // signUpButton
            // 
            signUpButton.BackColor=Color.Gainsboro;
            signUpButton.Cursor=Cursors.Hand;
            signUpButton.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            signUpButton.Location=new Point(162, 443);
            signUpButton.Name="signUpButton";
            signUpButton.Size=new Size(209, 60);
            signUpButton.TabIndex=6;
            signUpButton.Text="Hemen Uye Ol!";
            signUpButton.UseVisualStyleBackColor=false;
            signUpButton.Click+=signUpButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor=Color.Gainsboro;
            exitButton.Cursor=Cursors.Hand;
            exitButton.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.Location=new Point(449, 550);
            exitButton.Name="exitButton";
            exitButton.Size=new Size(104, 41);
            exitButton.TabIndex=7;
            exitButton.Text="CIkIs";
            exitButton.UseVisualStyleBackColor=false;
            exitButton.Click+=exitButton_Click;
            // 
            // showHide
            // 
            showHide.AutoSize=true;
            showHide.BackColor=Color.Transparent;
            showHide.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            showHide.ForeColor=SystemColors.Info;
            showHide.Location=new Point(351, 233);
            showHide.Name="showHide";
            showHide.Size=new Size(133, 28);
            showHide.TabIndex=8;
            showHide.Text="Goster";
            showHide.TextImageRelation=TextImageRelation.TextAboveImage;
            showHide.UseVisualStyleBackColor=false;
            showHide.CheckedChanged+=showHide_CheckedChanged;
            // 
            // forgotPasswordLink
            // 
            forgotPasswordLink.ActiveLinkColor=Color.Moccasin;
            forgotPasswordLink.AutoSize=true;
            forgotPasswordLink.BackColor=Color.Transparent;
            forgotPasswordLink.Cursor=Cursors.Help;
            forgotPasswordLink.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            forgotPasswordLink.ForeColor=SystemColors.Info;
            forgotPasswordLink.LinkColor=SystemColors.Info;
            forgotPasswordLink.Location=new Point(162, 370);
            forgotPasswordLink.Name="forgotPasswordLink";
            forgotPasswordLink.Size=new Size(154, 48);
            forgotPasswordLink.TabIndex=9;
            forgotPasswordLink.TabStop=true;
            forgotPasswordLink.Text="SIfrenI mI \r\nUnuttun?";
            forgotPasswordLink.LinkClicked+=forgotPasswordLink_LinkClicked;
            // 
            // languageButtonTurkishFlag
            // 
            languageButtonTurkishFlag.BackColor=Color.Transparent;
            languageButtonTurkishFlag.Cursor=Cursors.Hand;
            languageButtonTurkishFlag.Image=(Image)resources.GetObject("languageButtonTurkishFlag.Image");
            languageButtonTurkishFlag.Location=new Point(28, 556);
            languageButtonTurkishFlag.Name="languageButtonTurkishFlag";
            languageButtonTurkishFlag.Size=new Size(38, 29);
            languageButtonTurkishFlag.TabIndex=10;
            languageButtonTurkishFlag.UseVisualStyleBackColor=false;
            languageButtonTurkishFlag.Click+=languageButtonTurkishFlag_Click;
            // 
            // languageButtonEnglishFlag
            // 
            languageButtonEnglishFlag.BackColor=Color.Transparent;
            languageButtonEnglishFlag.Cursor=Cursors.Hand;
            languageButtonEnglishFlag.Image=(Image)resources.GetObject("languageButtonEnglishFlag.Image");
            languageButtonEnglishFlag.Location=new Point(28, 556);
            languageButtonEnglishFlag.Name="languageButtonEnglishFlag";
            languageButtonEnglishFlag.Size=new Size(38, 29);
            languageButtonEnglishFlag.TabIndex=11;
            languageButtonEnglishFlag.UseVisualStyleBackColor=false;
            languageButtonEnglishFlag.Click+=languageButtonEnglishFlag_Click;
            // 
            // LogInPage
            // 
            AcceptButton=logInButton;
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(576, 603);
            Controls.Add(languageButtonEnglishFlag);
            Controls.Add(languageButtonTurkishFlag);
            Controls.Add(forgotPasswordLink);
            Controls.Add(showHide);
            Controls.Add(exitButton);
            Controls.Add(signUpButton);
            Controls.Add(arayuzLabel);
            Controls.Add(sifreLabel);
            Controls.Add(passwordTextbox);
            Controls.Add(kullanıcıAdıLabel);
            Controls.Add(mailTextbox);
            Controls.Add(logInButton);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="LogInPage";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Play Valorant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logInButton;
        private TextBox mailTextbox;
        private Label kullanıcıAdıLabel;
        private Label sifreLabel;
        private TextBox passwordTextbox;
        private Label arayuzLabel;
        private Button signUpButton;
        private Button exitButton;
        private CheckBox showHide;
        private LinkLabel forgotPasswordLink;
        private Button languageButtonTurkishFlag;
        private Button languageButtonEnglishFlag;
    }
}