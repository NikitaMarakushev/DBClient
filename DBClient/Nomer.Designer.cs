namespace DBClient
{
    partial class Nomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nomer));
            this.nomerDataDridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addNumberInput = new System.Windows.Forms.TextBox();
            this.addNomerInputLabel = new System.Windows.Forms.Label();
            this.addNomerHandler = new System.Windows.Forms.Button();
            this.updateNomerHandler = new System.Windows.Forms.Button();
            this.updateNewNomerInputId = new System.Windows.Forms.TextBox();
            this.updateNewNomerInput = new System.Windows.Forms.TextBox();
            this.updateNewNomerInputIdLabel = new System.Windows.Forms.Label();
            this.updateNewNomerInputLabel = new System.Windows.Forms.Label();
            this.deleteNomerInputIdLabel = new System.Windows.Forms.Label();
            this.deleteNomerInputId = new System.Windows.Forms.TextBox();
            this.deleteNomerHandler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nomerDataDridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomerDataDridView
            // 
            this.nomerDataDridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nomerDataDridView.Location = new System.Drawing.Point(12, 12);
            this.nomerDataDridView.Name = "nomerDataDridView";
            this.nomerDataDridView.RowHeadersWidth = 51;
            this.nomerDataDridView.RowTemplate.Height = 24;
            this.nomerDataDridView.Size = new System.Drawing.Size(435, 323);
            this.nomerDataDridView.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(468, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 323);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addNomerHandler);
            this.tabPage1.Controls.Add(this.addNomerInputLabel);
            this.tabPage1.Controls.Add(this.addNumberInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(312, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.updateNewNomerInputLabel);
            this.tabPage2.Controls.Add(this.updateNewNomerInputIdLabel);
            this.tabPage2.Controls.Add(this.updateNewNomerInput);
            this.tabPage2.Controls.Add(this.updateNewNomerInputId);
            this.tabPage2.Controls.Add(this.updateNomerHandler);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(312, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteNomerHandler);
            this.tabPage3.Controls.Add(this.deleteNomerInputId);
            this.tabPage3.Controls.Add(this.deleteNomerInputIdLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(312, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // addNumberInput
            // 
            this.addNumberInput.Location = new System.Drawing.Point(7, 45);
            this.addNumberInput.Name = "addNumberInput";
            this.addNumberInput.Size = new System.Drawing.Size(299, 22);
            this.addNumberInput.TabIndex = 0;
            // 
            // addNomerInputLabel
            // 
            this.addNomerInputLabel.AutoSize = true;
            this.addNomerInputLabel.Location = new System.Drawing.Point(6, 26);
            this.addNomerInputLabel.Name = "addNomerInputLabel";
            this.addNomerInputLabel.Size = new System.Drawing.Size(73, 16);
            this.addNomerInputLabel.TabIndex = 1;
            this.addNomerInputLabel.Text = "Add nomer";
            // 
            // addNomerHandler
            // 
            this.addNomerHandler.Location = new System.Drawing.Point(7, 89);
            this.addNomerHandler.Name = "addNomerHandler";
            this.addNomerHandler.Size = new System.Drawing.Size(299, 199);
            this.addNomerHandler.TabIndex = 2;
            this.addNomerHandler.Text = "Add Nomer";
            this.addNomerHandler.UseVisualStyleBackColor = true;
            this.addNomerHandler.Click += new System.EventHandler(this.addNomerHandler_Click);
            // 
            // updateNomerHandler
            // 
            this.updateNomerHandler.Location = new System.Drawing.Point(7, 159);
            this.updateNomerHandler.Name = "updateNomerHandler";
            this.updateNomerHandler.Size = new System.Drawing.Size(299, 129);
            this.updateNomerHandler.TabIndex = 0;
            this.updateNomerHandler.Text = "Update nomer";
            this.updateNomerHandler.UseVisualStyleBackColor = true;
            this.updateNomerHandler.Click += new System.EventHandler(this.updateNomerHandler_Click);
            // 
            // updateNewNomerInputId
            // 
            this.updateNewNomerInputId.Location = new System.Drawing.Point(7, 51);
            this.updateNewNomerInputId.Name = "updateNewNomerInputId";
            this.updateNewNomerInputId.Size = new System.Drawing.Size(299, 22);
            this.updateNewNomerInputId.TabIndex = 1;
            // 
            // updateNewNomerInput
            // 
            this.updateNewNomerInput.Location = new System.Drawing.Point(7, 114);
            this.updateNewNomerInput.Name = "updateNewNomerInput";
            this.updateNewNomerInput.Size = new System.Drawing.Size(299, 22);
            this.updateNewNomerInput.TabIndex = 2;
            // 
            // updateNewNomerInputIdLabel
            // 
            this.updateNewNomerInputIdLabel.AutoSize = true;
            this.updateNewNomerInputIdLabel.Location = new System.Drawing.Point(6, 32);
            this.updateNewNomerInputIdLabel.Name = "updateNewNomerInputIdLabel";
            this.updateNewNomerInputIdLabel.Size = new System.Drawing.Size(18, 16);
            this.updateNewNomerInputIdLabel.TabIndex = 3;
            this.updateNewNomerInputIdLabel.Text = "Id";
            // 
            // updateNewNomerInputLabel
            // 
            this.updateNewNomerInputLabel.AutoSize = true;
            this.updateNewNomerInputLabel.Location = new System.Drawing.Point(4, 95);
            this.updateNewNomerInputLabel.Name = "updateNewNomerInputLabel";
            this.updateNewNomerInputLabel.Size = new System.Drawing.Size(75, 16);
            this.updateNewNomerInputLabel.TabIndex = 4;
            this.updateNewNomerInputLabel.Text = "New nomer";
            // 
            // deleteNomerInputIdLabel
            // 
            this.deleteNomerInputIdLabel.AutoSize = true;
            this.deleteNomerInputIdLabel.Location = new System.Drawing.Point(16, 15);
            this.deleteNomerInputIdLabel.Name = "deleteNomerInputIdLabel";
            this.deleteNomerInputIdLabel.Size = new System.Drawing.Size(18, 16);
            this.deleteNomerInputIdLabel.TabIndex = 0;
            this.deleteNomerInputIdLabel.Text = "Id";
            // 
            // deleteNomerInputId
            // 
            this.deleteNomerInputId.Location = new System.Drawing.Point(19, 34);
            this.deleteNomerInputId.Name = "deleteNomerInputId";
            this.deleteNomerInputId.Size = new System.Drawing.Size(287, 22);
            this.deleteNomerInputId.TabIndex = 1;
            // 
            // deleteNomerHandler
            // 
            this.deleteNomerHandler.Location = new System.Drawing.Point(19, 76);
            this.deleteNomerHandler.Name = "deleteNomerHandler";
            this.deleteNomerHandler.Size = new System.Drawing.Size(277, 212);
            this.deleteNomerHandler.TabIndex = 2;
            this.deleteNomerHandler.Text = "Delete";
            this.deleteNomerHandler.UseVisualStyleBackColor = true;
            this.deleteNomerHandler.Click += new System.EventHandler(this.deleteNomerHandler_Click);
            // 
            // Nomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 353);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.nomerDataDridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nomer";
            this.Text = "Nomer";
            ((System.ComponentModel.ISupportInitialize)(this.nomerDataDridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView nomerDataDridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox addNumberInput;
        private System.Windows.Forms.Label addNomerInputLabel;
        private System.Windows.Forms.Button addNomerHandler;
        private System.Windows.Forms.Button updateNomerHandler;
        private System.Windows.Forms.TextBox updateNewNomerInputId;
        private System.Windows.Forms.TextBox updateNewNomerInput;
        private System.Windows.Forms.Label updateNewNomerInputLabel;
        private System.Windows.Forms.Label updateNewNomerInputIdLabel;
        private System.Windows.Forms.Button deleteNomerHandler;
        private System.Windows.Forms.TextBox deleteNomerInputId;
        private System.Windows.Forms.Label deleteNomerInputIdLabel;
    }
}