using System.Windows.Forms;

namespace DBClient
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.authorizeLoginInput = new System.Windows.Forms.TextBox();
            this.authorizePasswordInput = new System.Windows.Forms.TextBox();
            this.authorizationHandler = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.openRegistrationForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorizeLoginInput
            // 
            this.authorizeLoginInput.Location = new System.Drawing.Point(12, 28);
            this.authorizeLoginInput.Name = "authorizeLoginInput";
            this.authorizeLoginInput.Size = new System.Drawing.Size(298, 22);
            this.authorizeLoginInput.TabIndex = 0;
            // 
            // authorizePasswordInput
            // 
            this.authorizePasswordInput.Location = new System.Drawing.Point(12, 72);
            this.authorizePasswordInput.Name = "authorizePasswordInput";
            this.authorizePasswordInput.Size = new System.Drawing.Size(298, 22);
            this.authorizePasswordInput.TabIndex = 0;
            // 
            // authorizationHandler
            // 
            this.authorizationHandler.Location = new System.Drawing.Point(12, 100);
            this.authorizationHandler.Name = "authorizationHandler";
            this.authorizationHandler.Size = new System.Drawing.Size(297, 43);
            this.authorizationHandler.TabIndex = 1;
            this.authorizationHandler.Text = "Authorize";
            this.authorizationHandler.UseVisualStyleBackColor = true;
            this.authorizationHandler.Click += new System.EventHandler(this.AuthorizationHandler);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(12, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(75, 16);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Your loging";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 53);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(97, 16);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Your password";
            // 
            // openRegistrationForm
            // 
            this.openRegistrationForm.Location = new System.Drawing.Point(15, 150);
            this.openRegistrationForm.Name = "openRegistrationForm";
            this.openRegistrationForm.Size = new System.Drawing.Size(294, 23);
            this.openRegistrationForm.TabIndex = 3;
            this.openRegistrationForm.Text = "Don\'t have an account? Register";
            this.openRegistrationForm.UseVisualStyleBackColor = true;
            this.openRegistrationForm.Click += new System.EventHandler(this.OpenRegistrationForm);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 184);
            this.Controls.Add(this.openRegistrationForm);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.authorizationHandler);
            this.Controls.Add(this.authorizePasswordInput);
            this.Controls.Add(this.authorizeLoginInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AuthorizationKeyDownHandler);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox authorizeLoginInput;
        private System.Windows.Forms.TextBox authorizePasswordInput;
        private System.Windows.Forms.Button authorizationHandler;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button openRegistrationForm;
    }
}