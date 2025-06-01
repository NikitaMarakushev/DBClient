using System.Windows.Forms;

namespace DBClient
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.registrationLogin = new System.Windows.Forms.TextBox();
            this.registrationPassword = new System.Windows.Forms.TextBox();
            this.registationHandler = new System.Windows.Forms.Button();
            this.registrationLoginLabel = new System.Windows.Forms.Label();
            this.registrationPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrationLogin
            // 
            this.registrationLogin.Location = new System.Drawing.Point(13, 32);
            this.registrationLogin.Name = "registrationLogin";
            this.registrationLogin.Size = new System.Drawing.Size(268, 22);
            this.registrationLogin.TabIndex = 0;
            // 
            // registrationPassword
            // 
            this.registrationPassword.Location = new System.Drawing.Point(13, 82);
            this.registrationPassword.Name = "registrationPassword";
            this.registrationPassword.Size = new System.Drawing.Size(268, 22);
            this.registrationPassword.TabIndex = 0;
            // 
            // registationHandler
            // 
            this.registationHandler.BackColor = System.Drawing.Color.Blue;
            this.registationHandler.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registationHandler.Location = new System.Drawing.Point(12, 110);
            this.registationHandler.Name = "registationHandler";
            this.registationHandler.Size = new System.Drawing.Size(268, 47);
            this.registationHandler.TabIndex = 1;
            this.registationHandler.Text = "Register";
            this.registationHandler.UseVisualStyleBackColor = false;
            this.registationHandler.Click += new System.EventHandler(this.RegistationHandler);
            // 
            // registrationLoginLabel
            // 
            this.registrationLoginLabel.AutoSize = true;
            this.registrationLoginLabel.Location = new System.Drawing.Point(13, 10);
            this.registrationLoginLabel.Name = "registrationLoginLabel";
            this.registrationLoginLabel.Size = new System.Drawing.Size(94, 16);
            this.registrationLoginLabel.TabIndex = 2;
            this.registrationLoginLabel.Text = "Your new login";
            // 
            // registrationPasswordLabel
            // 
            this.registrationPasswordLabel.AutoSize = true;
            this.registrationPasswordLabel.Location = new System.Drawing.Point(12, 63);
            this.registrationPasswordLabel.Name = "registrationPasswordLabel";
            this.registrationPasswordLabel.Size = new System.Drawing.Size(124, 16);
            this.registrationPasswordLabel.TabIndex = 2;
            this.registrationPasswordLabel.Text = "Your new password";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 167);
            this.Controls.Add(this.registrationPasswordLabel);
            this.Controls.Add(this.registrationLoginLabel);
            this.Controls.Add(this.registationHandler);
            this.Controls.Add(this.registrationPassword);
            this.Controls.Add(this.registrationLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.KeyDown += new KeyEventHandler(RegistrationKeyDownHandler);
        }

        #endregion

        private System.Windows.Forms.TextBox registrationLogin;
        private System.Windows.Forms.TextBox registrationPassword;
        private System.Windows.Forms.Button registationHandler;
        private System.Windows.Forms.Label registrationLoginLabel;
        private System.Windows.Forms.Label registrationPasswordLabel;
    }
}