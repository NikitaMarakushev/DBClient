
namespace DBClient
{
    partial class ClientsTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsTable));
            this.addHandler = new System.Windows.Forms.Button();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchClientsTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchClientHandler = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.filtersPanel = new System.Windows.Forms.Panel();
            this.filterByIdComboBox = new System.Windows.Forms.ComboBox();
            this.filterByNumberComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.filtersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addHandler
            // 
            this.addHandler.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addHandler.Location = new System.Drawing.Point(12, 499);
            this.addHandler.Name = "addHandler";
            this.addHandler.Size = new System.Drawing.Size(178, 77);
            this.addHandler.TabIndex = 0;
            this.addHandler.Text = "add";
            this.addHandler.UseVisualStyleBackColor = true;
            this.addHandler.Click += new System.EventHandler(this.addClientLoad);
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.RowHeadersWidth = 51;
            this.clientsDataGridView.RowTemplate.Height = 24;
            this.clientsDataGridView.Size = new System.Drawing.Size(578, 426);
            this.clientsDataGridView.TabIndex = 1;
            this.clientsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(208, 499);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(178, 77);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateClientLoad);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(412, 499);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(178, 77);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteClientLoad);
            // 
            // searchClientsTextBox
            // 
            this.searchClientsTextBox.Location = new System.Drawing.Point(113, 444);
            this.searchClientsTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.searchClientsTextBox.Multiline = true;
            this.searchClientsTextBox.Name = "searchClientsTextBox";
            this.searchClientsTextBox.Size = new System.Drawing.Size(352, 40);
            this.searchClientsTextBox.TabIndex = 2;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.Location = new System.Drawing.Point(12, 444);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(95, 29);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Search:";
            // 
            // searchClientHandler
            // 
            this.searchClientHandler.Location = new System.Drawing.Point(472, 444);
            this.searchClientHandler.Name = "searchClientHandler";
            this.searchClientHandler.Size = new System.Drawing.Size(118, 40);
            this.searchClientHandler.TabIndex = 4;
            this.searchClientHandler.Text = "Search";
            this.searchClientHandler.UseVisualStyleBackColor = true;
            this.searchClientHandler.Click += new System.EventHandler(this.searchClientHandler_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(606, 24);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(141, 22);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total found: ???";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(610, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 33);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show filters";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // filtersPanel
            // 
            this.filtersPanel.Controls.Add(this.filterByNumberComboBox);
            this.filtersPanel.Controls.Add(this.filterByIdComboBox);
            this.filtersPanel.Location = new System.Drawing.Point(610, 103);
            this.filtersPanel.Name = "filtersPanel";
            this.filtersPanel.Size = new System.Drawing.Size(200, 473);
            this.filtersPanel.TabIndex = 7;
            // 
            // filterByIdComboBox
            // 
            this.filterByIdComboBox.FormattingEnabled = true;
            this.filterByIdComboBox.Location = new System.Drawing.Point(19, 16);
            this.filterByIdComboBox.Name = "filterByIdComboBox";
            this.filterByIdComboBox.Size = new System.Drawing.Size(161, 24);
            this.filterByIdComboBox.TabIndex = 0;
            // 
            // filterByNumberComboBox
            // 
            this.filterByNumberComboBox.FormattingEnabled = true;
            this.filterByNumberComboBox.Location = new System.Drawing.Point(19, 78);
            this.filterByNumberComboBox.Name = "filterByNumberComboBox";
            this.filterByNumberComboBox.Size = new System.Drawing.Size(161, 24);
            this.filterByNumberComboBox.TabIndex = 1;
            // 
            // ClientsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 691);
            this.Controls.Add(this.filtersPanel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.searchClientHandler);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchClientsTextBox);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addHandler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientsTable";
            this.Text = "ClientsTable";
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.filtersPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addHandler;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox searchClientsTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchClientHandler;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel filtersPanel;
        private System.Windows.Forms.ComboBox filterByIdComboBox;
        private System.Windows.Forms.ComboBox filterByNumberComboBox;
    }
}