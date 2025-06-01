
namespace DBClient
{
    partial class DeleteClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteClients));
            this.updateRecordHandlerDelete = new System.Windows.Forms.Button();
            this.Client_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateRecordHandlerDelete
            // 
            this.updateRecordHandlerDelete.Location = new System.Drawing.Point(12, 50);
            this.updateRecordHandlerDelete.Name = "updateRecordHandlerDelete";
            this.updateRecordHandlerDelete.Size = new System.Drawing.Size(398, 58);
            this.updateRecordHandlerDelete.TabIndex = 10;
            this.updateRecordHandlerDelete.Text = "Delete";
            this.updateRecordHandlerDelete.UseVisualStyleBackColor = true;
            this.updateRecordHandlerDelete.Click += new System.EventHandler(this.updateRecordHandlerDelete_Click);
            // 
            // Client_ID
            // 
            this.Client_ID.Location = new System.Drawing.Point(12, 22);
            this.Client_ID.Name = "Client_ID";
            this.Client_ID.Size = new System.Drawing.Size(398, 22);
            this.Client_ID.TabIndex = 8;
            // 
            // DeleteClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 136);
            this.Controls.Add(this.updateRecordHandlerDelete);
            this.Controls.Add(this.Client_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteClients";
            this.Text = "DeleteClients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updateRecordHandlerDelete;
        private System.Windows.Forms.TextBox Client_ID;
    }
}