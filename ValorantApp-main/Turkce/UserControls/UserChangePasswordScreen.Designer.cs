namespace DataBaseReaderProgram.UserControls
{
    partial class UserChangePasswordScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserChangePasswordScreen));
            oldPasswordTextbox=new TextBox();
            oldPassword=new Label();
            newPassword=new Label();
            newPasswordTextbox=new TextBox();
            checkPasswordTextbox=new TextBox();
            changeButton=new Button();
            backButton=new Button();
            newPasswordAgain=new Label();
            SuspendLayout();
            // 
            // oldPasswordTextbox
            // 
            oldPasswordTextbox.Cursor=Cursors.IBeam;
            oldPasswordTextbox.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            oldPasswordTextbox.Location=new Point(109, 59);
            oldPasswordTextbox.Multiline=true;
            oldPasswordTextbox.Name="oldPasswordTextbox";
            oldPasswordTextbox.Size=new Size(277, 40);
            oldPasswordTextbox.TabIndex=0;
            // 
            // oldPassword
            // 
            oldPassword.AutoSize=true;
            oldPassword.BackColor=Color.Transparent;
            oldPassword.Font=new Font("VALORANT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            oldPassword.ForeColor=SystemColors.Info;
            oldPassword.Location=new Point(109, 32);
            oldPassword.Name="oldPassword";
            oldPassword.Size=new Size(154, 24);
            oldPassword.TabIndex=1;
            oldPassword.Text="ESKI SIFREN";
            // 
            // newPassword
            // 
            newPassword.AutoSize=true;
            newPassword.BackColor=Color.Transparent;
            newPassword.Font=new Font("VALORANT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            newPassword.ForeColor=SystemColors.ControlLightLight;
            newPassword.Location=new Point(109, 118);
            newPassword.Name="newPassword";
            newPassword.Size=new Size(168, 26);
            newPassword.TabIndex=3;
            newPassword.Text="YENI SIFREN";
            // 
            // newPasswordTextbox
            // 
            newPasswordTextbox.Cursor=Cursors.IBeam;
            newPasswordTextbox.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            newPasswordTextbox.Location=new Point(108, 147);
            newPasswordTextbox.Multiline=true;
            newPasswordTextbox.Name="newPasswordTextbox";
            newPasswordTextbox.Size=new Size(277, 40);
            newPasswordTextbox.TabIndex=2;
            // 
            // checkPasswordTextbox
            // 
            checkPasswordTextbox.Cursor=Cursors.IBeam;
            checkPasswordTextbox.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkPasswordTextbox.Location=new Point(108, 239);
            checkPasswordTextbox.Multiline=true;
            checkPasswordTextbox.Name="checkPasswordTextbox";
            checkPasswordTextbox.Size=new Size(277, 40);
            checkPasswordTextbox.TabIndex=4;
            // 
            // changeButton
            // 
            changeButton.BackColor=Color.Gainsboro;
            changeButton.Cursor=Cursors.Hand;
            changeButton.Font=new Font("VALORANT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            changeButton.Location=new Point(109, 299);
            changeButton.Name="changeButton";
            changeButton.Size=new Size(277, 69);
            changeButton.TabIndex=6;
            changeButton.Text="DEGISTIR";
            changeButton.UseVisualStyleBackColor=false;
            changeButton.Click+=changeButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor=Color.Gainsboro;
            backButton.Cursor=Cursors.Hand;
            backButton.Font=new Font("VALORANT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.ForeColor=SystemColors.ActiveCaptionText;
            backButton.Location=new Point(164, 384);
            backButton.Name="backButton";
            backButton.Size=new Size(158, 63);
            backButton.TabIndex=7;
            backButton.Text="GERI DON";
            backButton.UseVisualStyleBackColor=false;
            backButton.Click+=backButton_Click;
            // 
            // newPasswordAgain
            // 
            newPasswordAgain.AutoSize=true;
            newPasswordAgain.BackColor=Color.Transparent;
            newPasswordAgain.Font=new Font("VALORANT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            newPasswordAgain.ForeColor=SystemColors.Info;
            newPasswordAgain.Location=new Point(109, 212);
            newPasswordAgain.Name="newPasswordAgain";
            newPasswordAgain.Size=new Size(260, 24);
            newPasswordAgain.TabIndex=8;
            newPasswordAgain.Text="yenI sIfren tekrar";
            // 
            // UserChangePasswordScreen
            // 
            AcceptButton=changeButton;
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            BackColor=Color.White;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(472, 490);
            Controls.Add(newPasswordAgain);
            Controls.Add(backButton);
            Controls.Add(changeButton);
            Controls.Add(checkPasswordTextbox);
            Controls.Add(newPassword);
            Controls.Add(newPasswordTextbox);
            Controls.Add(oldPassword);
            Controls.Add(oldPasswordTextbox);
            ForeColor=SystemColors.ControlText;
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="UserChangePasswordScreen";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Play Valorant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox oldPasswordTextbox;
        private Label oldPassword;
        private Label newPassword;
        private TextBox newPasswordTextbox;
        private TextBox checkPasswordTextbox;
        private Button changeButton;
        private Button backButton;
        private Label newPasswordAgain;
    }
}