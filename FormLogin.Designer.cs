namespace StudentManagementSQLite
{
    partial class FormLogin
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
            buttonLogin = new Button();
            buttonExit = new Button();
            labelLoginId = new Label();
            textBoxLoginId = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(100, 145);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(112, 42);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(218, 145);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(112, 42);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelLoginId
            // 
            labelLoginId.AutoSize = true;
            labelLoginId.Location = new Point(52, 44);
            labelLoginId.Name = "labelLoginId";
            labelLoginId.Size = new Size(77, 25);
            labelLoginId.TabIndex = 2;
            labelLoginId.Text = "Login Id";
            // 
            // textBoxLoginId
            // 
            textBoxLoginId.Location = new Point(150, 44);
            textBoxLoginId.Name = "textBoxLoginId";
            textBoxLoginId.Size = new Size(228, 31);
            textBoxLoginId.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(150, 91);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(228, 31);
            textBoxPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 91);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(431, 231);
            Controls.Add(textBoxPassword);
            Controls.Add(label1);
            Controls.Add(textBoxLoginId);
            Controls.Add(labelLoginId);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Button buttonExit;
        private Label labelLoginId;
        private TextBox textBoxLoginId;
        private TextBox textBoxPassword;
        private Label label1;
    }
}
