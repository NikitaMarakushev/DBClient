
namespace DBClient
{
    partial class AddClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClients));
            this.contactsNumberInput = new System.Windows.Forms.TextBox();
            this.addRecordHandler = new System.Windows.Forms.Button();
            this.clientTypeSelector = new System.Windows.Forms.ComboBox();
            this.dateOfConclusionInput = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // contactsNumberInput
            // 
            this.contactsNumberInput.Location = new System.Drawing.Point(163, 91);
            this.contactsNumberInput.Name = "contactsNumberInput";
            this.contactsNumberInput.Size = new System.Drawing.Size(398, 22);
            this.contactsNumberInput.TabIndex = 0;
            // 
            // addRecordHandler
            // 
            this.addRecordHandler.Location = new System.Drawing.Point(163, 199);
            this.addRecordHandler.Name = "addRecordHandler";
            this.addRecordHandler.Size = new System.Drawing.Size(398, 58);
            this.addRecordHandler.TabIndex = 1;
            this.addRecordHandler.Text = "Add";
            this.addRecordHandler.UseVisualStyleBackColor = true;
            this.addRecordHandler.Click += new System.EventHandler(this.AddRecordHandler);
            // 
            // clientTypeSelector
            // 
            this.clientTypeSelector.FormattingEnabled = true;
            this.clientTypeSelector.Location = new System.Drawing.Point(163, 149);
            this.clientTypeSelector.Name = "clientTypeSelector";
            this.clientTypeSelector.Size = new System.Drawing.Size(398, 24);
            this.clientTypeSelector.TabIndex = 2;
            // 
            // dateOfConclusionInput
            // 
            this.dateOfConclusionInput.Location = new System.Drawing.Point(163, 40);
            this.dateOfConclusionInput.Name = "dateOfConclusionInput";
            this.dateOfConclusionInput.Size = new System.Drawing.Size(398, 22);
            this.dateOfConclusionInput.TabIndex = 0;
            // 
            // EditClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 362);
            this.Controls.Add(this.dateOfConclusionInput);
            this.Controls.Add(this.clientTypeSelector);
            this.Controls.Add(this.addRecordHandler);
            this.Controls.Add(this.contactsNumberInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditClientsForm";
            this.Text = "EditClientsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox contactsNumberInput;
        private System.Windows.Forms.Button addRecordHandler;
        private System.Windows.Forms.ComboBox clientTypeSelector;
        private System.Windows.Forms.DateTimePicker dateOfConclusionInput;
    }
}