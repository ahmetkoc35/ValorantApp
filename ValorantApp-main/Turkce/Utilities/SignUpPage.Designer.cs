namespace DataBaseReaderProgram
{
    partial class SignUpPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpPage));
            password=new Label();
            passwordTextbox=new TextBox();
            passwordCheck=new Label();
            passwordCheckTextbox=new TextBox();
            continueButton=new Button();
            backButton=new Button();
            passwordCheckbox=new CheckBox();
            passwordAgainCheckox=new CheckBox();
            email=new Label();
            mailTextbox=new TextBox();
            emailCombobox=new ComboBox();
            SuspendLayout();
            // 
            // password
            // 
            password.AutoSize=true;
            password.BackColor=Color.Transparent;
            password.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            password.ForeColor=SystemColors.Info;
            password.Location=new Point(115, 180);
            password.Name="password";
            password.Size=new Size(78, 24);
            password.TabIndex=3;
            password.Text="SIfre";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Cursor=Cursors.IBeam;
            passwordTextbox.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextbox.Location=new Point(115, 207);
            passwordTextbox.Name="passwordTextbox";
            passwordTextbox.Size=new Size(222, 27);
            passwordTextbox.TabIndex=2;
            passwordTextbox.UseSystemPasswordChar=true;
            // 
            // passwordCheck
            // 
            passwordCheck.AutoSize=true;
            passwordCheck.BackColor=Color.Transparent;
            passwordCheck.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            passwordCheck.ForeColor=SystemColors.Info;
            passwordCheck.Location=new Point(115, 280);
            passwordCheck.Name="passwordCheck";
            passwordCheck.Size=new Size(182, 24);
            passwordCheck.TabIndex=5;
            passwordCheck.Text="SIfre Tekrar";
            // 
            // passwordCheckTextbox
            // 
            passwordCheckTextbox.Cursor=Cursors.IBeam;
            passwordCheckTextbox.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordCheckTextbox.Location=new Point(115, 307);
            passwordCheckTextbox.Name="passwordCheckTextbox";
            passwordCheckTextbox.Size=new Size(222, 27);
            passwordCheckTextbox.TabIndex=4;
            passwordCheckTextbox.UseSystemPasswordChar=true;
            // 
            // continueButton
            // 
            continueButton.BackColor=Color.Gainsboro;
            continueButton.Cursor=Cursors.Hand;
            continueButton.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            continueButton.Location=new Point(136, 363);
            continueButton.Name="continueButton";
            continueButton.Size=new Size(171, 52);
            continueButton.TabIndex=6;
            continueButton.Text="Kaydol";
            continueButton.UseVisualStyleBackColor=false;
            continueButton.Click+=continueButton_Click;
            // 
            // backButton
            // 
            backButton.Cursor=Cursors.Hand;
            backButton.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Location=new Point(425, 469);
            backButton.Name="backButton";
            backButton.Size=new Size(145, 58);
            backButton.TabIndex=7;
            backButton.Text="GerI Don";
            backButton.UseVisualStyleBackColor=true;
            backButton.Click+=backButton_Click;
            // 
            // passwordCheckbox
            // 
            passwordCheckbox.AutoSize=true;
            passwordCheckbox.BackColor=Color.Transparent;
            passwordCheckbox.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            passwordCheckbox.ForeColor=SystemColors.Info;
            passwordCheckbox.Location=new Point(364, 207);
            passwordCheckbox.Name="passwordCheckbox";
            passwordCheckbox.Size=new Size(133, 28);
            passwordCheckbox.TabIndex=8;
            passwordCheckbox.Text="Goster";
            passwordCheckbox.UseVisualStyleBackColor=false;
            passwordCheckbox.CheckedChanged+=passwordCheckbox_CheckedChanged;
            // 
            // passwordAgainCheckox
            // 
            passwordAgainCheckox.AutoSize=true;
            passwordAgainCheckox.BackColor=Color.Transparent;
            passwordAgainCheckox.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            passwordAgainCheckox.ForeColor=SystemColors.Info;
            passwordAgainCheckox.Location=new Point(364, 312);
            passwordAgainCheckox.Name="passwordAgainCheckox";
            passwordAgainCheckox.Size=new Size(133, 28);
            passwordAgainCheckox.TabIndex=9;
            passwordAgainCheckox.Text="Goster";
            passwordAgainCheckox.UseVisualStyleBackColor=false;
            passwordAgainCheckox.CheckedChanged+=passwordAgainCheckox_CheckedChanged;
            // 
            // email
            // 
            email.AutoSize=true;
            email.BackColor=Color.Transparent;
            email.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            email.ForeColor=SystemColors.Info;
            email.Location=new Point(115, 99);
            email.Name="email";
            email.Size=new Size(121, 24);
            email.TabIndex=11;
            email.Text="E-Posta";
            // 
            // mailTextbox
            // 
            mailTextbox.Cursor=Cursors.IBeam;
            mailTextbox.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mailTextbox.Location=new Point(115, 126);
            mailTextbox.Name="mailTextbox";
            mailTextbox.Size=new Size(222, 27);
            mailTextbox.TabIndex=10;
            // 
            // emailCombobox
            // 
            emailCombobox.FormattingEnabled=true;
            emailCombobox.Items.AddRange(new object[] { "@hotmail.com", "@gmail.com", "@outlook.com" });
            emailCombobox.Location=new Point(343, 126);
            emailCombobox.Name="emailCombobox";
            emailCombobox.Size=new Size(151, 28);
            emailCombobox.TabIndex=12;
            emailCombobox.Text="@hotmail.com";
            // 
            // SignUpPage
            // 
            AcceptButton=continueButton;
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(609, 532);
            Controls.Add(emailCombobox);
            Controls.Add(email);
            Controls.Add(mailTextbox);
            Controls.Add(passwordAgainCheckox);
            Controls.Add(passwordCheckbox);
            Controls.Add(backButton);
            Controls.Add(continueButton);
            Controls.Add(passwordCheck);
            Controls.Add(passwordCheckTextbox);
            Controls.Add(password);
            Controls.Add(passwordTextbox);
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="SignUpPage";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Play Valorant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label password;
        private TextBox passwordTextbox;
        private Label passwordCheck;
        private TextBox passwordCheckTextbox;
        private Button continueButton;
        private Button backButton;
        private CheckBox passwordCheckbox;
        private CheckBox passwordAgainCheckox;
        private Label email;
        private TextBox mailTextbox;
        private ComboBox emailCombobox;
    }
}