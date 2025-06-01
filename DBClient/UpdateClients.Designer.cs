
namespace DBClient
{
    partial class UpdateClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateClients));
            this.dateOfConclusionInputUpdate = new System.Windows.Forms.DateTimePicker();
            this.clientTypeSelectorUpdate = new System.Windows.Forms.ComboBox();
            this.updateRecordHandlerUpdate = new System.Windows.Forms.Button();
            this.contactsNumberInputUpdate = new System.Windows.Forms.TextBox();
            this.Client_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateOfConclusionInputUpdate
            // 
            this.dateOfConclusionInputUpdate.Location = new System.Drawing.Point(201, 117);
            this.dateOfConclusionInputUpdate.Name = "dateOfConclusionInputUpdate";
            this.dateOfConclusionInputUpdate.Size = new System.Drawing.Size(398, 22);
            this.dateOfConclusionInputUpdate.TabIndex = 3;
            // 
            // clientTypeSelectorUpdate
            // 
            this.clientTypeSelectorUpdate.FormattingEnabled = true;
            this.clientTypeSelectorUpdate.Location = new System.Drawing.Point(201, 226);
            this.clientTypeSelectorUpdate.Name = "clientTypeSelectorUpdate";
            this.clientTypeSelectorUpdate.Size = new System.Drawing.Size(398, 24);
            this.clientTypeSelectorUpdate.TabIndex = 6;
            // 
            // updateRecordHandlerUpdate
            // 
            this.updateRecordHandlerUpdate.Location = new System.Drawing.Point(201, 276);
            this.updateRecordHandlerUpdate.Name = "updateRecordHandlerUpdate";
            this.updateRecordHandlerUpdate.Size = new System.Drawing.Size(398, 58);
            this.updateRecordHandlerUpdate.TabIndex = 5;
            this.updateRecordHandlerUpdate.Text = "Update";
            this.updateRecordHandlerUpdate.UseVisualStyleBackColor = true;
            this.updateRecordHandlerUpdate.Click += new System.EventHandler(this.updateRecordHandler);
            // 
            // contactsNumberInputUpdate
            // 
            this.contactsNumberInputUpdate.Location = new System.Drawing.Point(201, 168);
            this.contactsNumberInputUpdate.Name = "contactsNumberInputUpdate";
            this.contactsNumberInputUpdate.Size = new System.Drawing.Size(398, 22);
            this.contactsNumberInputUpdate.TabIndex = 4;
            // 
            // Client_ID
            // 
            this.Client_ID.Location = new System.Drawing.Point(201, 80);
            this.Client_ID.Name = "Client_ID";
            this.Client_ID.Size = new System.Drawing.Size(398, 22);
            this.Client_ID.TabIndex = 4;
            // 
            // UpdateClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateOfConclusionInputUpdate);
            this.Controls.Add(this.clientTypeSelectorUpdate);
            this.Controls.Add(this.updateRecordHandlerUpdate);
            this.Controls.Add(this.Client_ID);
            this.Controls.Add(this.contactsNumberInputUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateClients";
            this.Text = "UpdateClients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateOfConclusionInputUpdate;
        private System.Windows.Forms.ComboBox clientTypeSelectorUpdate;
        private System.Windows.Forms.Button updateRecordHandlerUpdate;
        private System.Windows.Forms.TextBox contactsNumberInputUpdate;
        private System.Windows.Forms.TextBox Client_ID;
    }
}