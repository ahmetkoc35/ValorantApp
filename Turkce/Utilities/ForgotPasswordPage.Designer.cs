namespace DataBaseReaderProgram.Utilities
{
    partial class ForgotPasswordPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordPage));
            email=new Label();
            emailTextbox=new TextBox();
            sendButton=new Button();
            backButton=new Button();
            SuspendLayout();
            // 
            // email
            // 
            email.AutoSize=true;
            email.BackColor=Color.Transparent;
            email.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            email.ForeColor=SystemColors.Info;
            email.Location=new Point(107, 110);
            email.Name="email";
            email.Size=new Size(134, 24);
            email.TabIndex=3;
            email.Text="E-Postan";
            // 
            // emailTextbox
            // 
            emailTextbox.Cursor=Cursors.IBeam;
            emailTextbox.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emailTextbox.Location=new Point(107, 133);
            emailTextbox.Name="emailTextbox";
            emailTextbox.Size=new Size(223, 27);
            emailTextbox.TabIndex=2;
            // 
            // sendButton
            // 
            sendButton.BackColor=Color.Gainsboro;
            sendButton.Cursor=Cursors.Hand;
            sendButton.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sendButton.Location=new Point(107, 214);
            sendButton.Name="sendButton";
            sendButton.Size=new Size(223, 44);
            sendButton.TabIndex=4;
            sendButton.Text="GOnder";
            sendButton.UseVisualStyleBackColor=false;
            sendButton.Click+=sendButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor=Color.Gainsboro;
            backButton.Cursor=Cursors.Hand;
            backButton.Font=new Font("VALORANT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Location=new Point(166, 288);
            backButton.Name="backButton";
            backButton.Size=new Size(107, 44);
            backButton.TabIndex=5;
            backButton.Text="CIkIs";
            backButton.UseVisualStyleBackColor=false;
            backButton.Click+=backButton_Click;
            // 
            // ForgotPasswordPage
            // 
            AcceptButton=sendButton;
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(466, 449);
            Controls.Add(backButton);
            Controls.Add(sendButton);
            Controls.Add(email);
            Controls.Add(emailTextbox);
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="ForgotPasswordPage";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Play Valorant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label email;
        private TextBox emailTextbox;
        private Button sendButton;
        private Button backButton;
    }
}