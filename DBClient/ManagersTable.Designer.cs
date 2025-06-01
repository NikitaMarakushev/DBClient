namespace DBClient
{
    partial class ManagersTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagersTable));
            this.managersDataGridView = new System.Windows.Forms.DataGridView();
            this.managerTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addManagerStoymostUslugLabel = new System.Windows.Forms.Label();
            this.addManagerPodcluchenieManageraLabel = new System.Windows.Forms.Label();
            this.addManagerDataNachalaUslugLabel = new System.Windows.Forms.Label();
            this.addManagersFIOLabel = new System.Windows.Forms.Label();
            this.addManagerNumberLabel = new System.Windows.Forms.Label();
            this.addManagerHandler = new System.Windows.Forms.Button();
            this.stoymostUslugComboBox = new System.Windows.Forms.ComboBox();
            this.podclucheniyeManageraComboBox = new System.Windows.Forms.ComboBox();
            this.dataNachalaUslug = new System.Windows.Forms.DateTimePicker();
            this.managersFio = new System.Windows.Forms.TextBox();
            this.managersNumber = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateStoymostUslugComboBox = new System.Windows.Forms.ComboBox();
            this.updatePodcluchenieManageraComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateStoymostUslugLabel = new System.Windows.Forms.Label();
            this.updateDataNachalaUslugLabel = new System.Windows.Forms.Label();
            this.managersFioLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ManagersNumberLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.updateManagersDataPodclucheniya = new System.Windows.Forms.DateTimePicker();
            this.updateManagersNumber = new System.Windows.Forms.TextBox();
            this.updateManagersFIO = new System.Windows.Forms.TextBox();
            this.ManagersIdLabel = new System.Windows.Forms.Label();
            this.updateManagersId = new System.Windows.Forms.TextBox();
            this.updateManagerHandler = new System.Windows.Forms.Button();
            this.deleteManager = new System.Windows.Forms.TabPage();
            this.deleteManagerByIdLabel = new System.Windows.Forms.Label();
            this.deleteManagerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteManagerHandler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.managersDataGridView)).BeginInit();
            this.managerTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.deleteManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // managersDataGridView
            // 
            this.managersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.managersDataGridView.Name = "managersDataGridView";
            this.managersDataGridView.RowHeadersWidth = 51;
            this.managersDataGridView.RowTemplate.Height = 24;
            this.managersDataGridView.Size = new System.Drawing.Size(452, 426);
            this.managersDataGridView.TabIndex = 2;
            // 
            // managerTabControl
            // 
            this.managerTabControl.Controls.Add(this.tabPage1);
            this.managerTabControl.Controls.Add(this.tabPage2);
            this.managerTabControl.Controls.Add(this.deleteManager);
            this.managerTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managerTabControl.Location = new System.Drawing.Point(470, 12);
            this.managerTabControl.Name = "managerTabControl";
            this.managerTabControl.SelectedIndex = 0;
            this.managerTabControl.Size = new System.Drawing.Size(328, 426);
            this.managerTabControl.TabIndex = 3;
            this.managerTabControl.Tag = "Add";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addManagerStoymostUslugLabel);
            this.tabPage1.Controls.Add(this.addManagerPodcluchenieManageraLabel);
            this.tabPage1.Controls.Add(this.addManagerDataNachalaUslugLabel);
            this.tabPage1.Controls.Add(this.addManagersFIOLabel);
            this.tabPage1.Controls.Add(this.addManagerNumberLabel);
            this.tabPage1.Controls.Add(this.addManagerHandler);
            this.tabPage1.Controls.Add(this.stoymostUslugComboBox);
            this.tabPage1.Controls.Add(this.podclucheniyeManageraComboBox);
            this.tabPage1.Controls.Add(this.dataNachalaUslug);
            this.tabPage1.Controls.Add(this.managersFio);
            this.tabPage1.Controls.Add(this.managersNumber);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(320, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addManagerStoymostUslugLabel
            // 
            this.addManagerStoymostUslugLabel.AutoSize = true;
            this.addManagerStoymostUslugLabel.Location = new System.Drawing.Point(3, 228);
            this.addManagerStoymostUslugLabel.Name = "addManagerStoymostUslugLabel";
            this.addManagerStoymostUslugLabel.Size = new System.Drawing.Size(139, 16);
            this.addManagerStoymostUslugLabel.TabIndex = 7;
            this.addManagerStoymostUslugLabel.Text = "ID_Stoymost_uslug";
            // 
            // addManagerPodcluchenieManageraLabel
            // 
            this.addManagerPodcluchenieManageraLabel.AutoSize = true;
            this.addManagerPodcluchenieManageraLabel.Location = new System.Drawing.Point(6, 174);
            this.addManagerPodcluchenieManageraLabel.Name = "addManagerPodcluchenieManageraLabel";
            this.addManagerPodcluchenieManageraLabel.Size = new System.Drawing.Size(202, 16);
            this.addManagerPodcluchenieManageraLabel.TabIndex = 7;
            this.addManagerPodcluchenieManageraLabel.Text = "ID_Podcluchenie_managera";
            // 
            // addManagerDataNachalaUslugLabel
            // 
            this.addManagerDataNachalaUslugLabel.AutoSize = true;
            this.addManagerDataNachalaUslugLabel.Location = new System.Drawing.Point(3, 124);
            this.addManagerDataNachalaUslugLabel.Name = "addManagerDataNachalaUslugLabel";
            this.addManagerDataNachalaUslugLabel.Size = new System.Drawing.Size(140, 16);
            this.addManagerDataNachalaUslugLabel.TabIndex = 7;
            this.addManagerDataNachalaUslugLabel.Text = "Data nachala uslug";
            // 
            // addManagersFIOLabel
            // 
            this.addManagersFIOLabel.AutoSize = true;
            this.addManagersFIOLabel.Location = new System.Drawing.Point(3, 68);
            this.addManagersFIOLabel.Name = "addManagersFIOLabel";
            this.addManagersFIOLabel.Size = new System.Drawing.Size(108, 16);
            this.addManagersFIOLabel.TabIndex = 7;
            this.addManagersFIOLabel.Text = "Manager\'s FIO";
            // 
            // addManagerNumberLabel
            // 
            this.addManagerNumberLabel.AutoSize = true;
            this.addManagerNumberLabel.Location = new System.Drawing.Point(6, 16);
            this.addManagerNumberLabel.Name = "addManagerNumberLabel";
            this.addManagerNumberLabel.Size = new System.Drawing.Size(135, 16);
            this.addManagerNumberLabel.TabIndex = 7;
            this.addManagerNumberLabel.Text = "Manager\'s number";
            // 
            // addManagerHandler
            // 
            this.addManagerHandler.BackColor = System.Drawing.Color.LimeGreen;
            this.addManagerHandler.Location = new System.Drawing.Point(6, 277);
            this.addManagerHandler.Name = "addManagerHandler";
            this.addManagerHandler.Size = new System.Drawing.Size(307, 101);
            this.addManagerHandler.TabIndex = 6;
            this.addManagerHandler.Text = "Add manager";
            this.addManagerHandler.UseVisualStyleBackColor = false;
            this.addManagerHandler.Click += new System.EventHandler(this.AddManagerHandler);
            // 
            // stoymostUslugComboBox
            // 
            this.stoymostUslugComboBox.FormattingEnabled = true;
            this.stoymostUslugComboBox.Location = new System.Drawing.Point(7, 247);
            this.stoymostUslugComboBox.Name = "stoymostUslugComboBox";
            this.stoymostUslugComboBox.Size = new System.Drawing.Size(307, 24);
            this.stoymostUslugComboBox.TabIndex = 5;
            // 
            // podclucheniyeManageraComboBox
            // 
            this.podclucheniyeManageraComboBox.FormattingEnabled = true;
            this.podclucheniyeManageraComboBox.Location = new System.Drawing.Point(7, 193);
            this.podclucheniyeManageraComboBox.Name = "podclucheniyeManageraComboBox";
            this.podclucheniyeManageraComboBox.Size = new System.Drawing.Size(307, 24);
            this.podclucheniyeManageraComboBox.TabIndex = 4;
            // 
            // dataNachalaUslug
            // 
            this.dataNachalaUslug.Location = new System.Drawing.Point(6, 143);
            this.dataNachalaUslug.Name = "dataNachalaUslug";
            this.dataNachalaUslug.Size = new System.Drawing.Size(307, 22);
            this.dataNachalaUslug.TabIndex = 3;
            // 
            // managersFio
            // 
            this.managersFio.Location = new System.Drawing.Point(7, 87);
            this.managersFio.Name = "managersFio";
            this.managersFio.Size = new System.Drawing.Size(307, 22);
            this.managersFio.TabIndex = 2;
            // 
            // managersNumber
            // 
            this.managersNumber.Location = new System.Drawing.Point(7, 35);
            this.managersNumber.Name = "managersNumber";
            this.managersNumber.Size = new System.Drawing.Size(307, 22);
            this.managersNumber.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.updateStoymostUslugComboBox);
            this.tabPage2.Controls.Add(this.updatePodcluchenieManageraComboBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.updateStoymostUslugLabel);
            this.tabPage2.Controls.Add(this.updateDataNachalaUslugLabel);
            this.tabPage2.Controls.Add(this.managersFioLabel);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ManagersNumberLabel);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.updateManagersDataPodclucheniya);
            this.tabPage2.Controls.Add(this.updateManagersNumber);
            this.tabPage2.Controls.Add(this.updateManagersFIO);
            this.tabPage2.Controls.Add(this.ManagersIdLabel);
            this.tabPage2.Controls.Add(this.updateManagersId);
            this.tabPage2.Controls.Add(this.updateManagerHandler);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(320, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // updateStoymostUslugComboBox
            // 
            this.updateStoymostUslugComboBox.FormattingEnabled = true;
            this.updateStoymostUslugComboBox.Location = new System.Drawing.Point(7, 306);
            this.updateStoymostUslugComboBox.Name = "updateStoymostUslugComboBox";
            this.updateStoymostUslugComboBox.Size = new System.Drawing.Size(302, 24);
            this.updateStoymostUslugComboBox.TabIndex = 6;
            // 
            // updatePodcluchenieManageraComboBox
            // 
            this.updatePodcluchenieManageraComboBox.FormattingEnabled = true;
            this.updatePodcluchenieManageraComboBox.Location = new System.Drawing.Point(7, 251);
            this.updatePodcluchenieManageraComboBox.Name = "updatePodcluchenieManageraComboBox";
            this.updatePodcluchenieManageraComboBox.Size = new System.Drawing.Size(302, 24);
            this.updatePodcluchenieManageraComboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID_Podcluchenie_managera";
            // 
            // updateStoymostUslugLabel
            // 
            this.updateStoymostUslugLabel.AutoSize = true;
            this.updateStoymostUslugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateStoymostUslugLabel.Location = new System.Drawing.Point(3, 287);
            this.updateStoymostUslugLabel.Name = "updateStoymostUslugLabel";
            this.updateStoymostUslugLabel.Size = new System.Drawing.Size(139, 16);
            this.updateStoymostUslugLabel.TabIndex = 5;
            this.updateStoymostUslugLabel.Text = "ID_Stoymost_uslug";
            // 
            // updateDataNachalaUslugLabel
            // 
            this.updateDataNachalaUslugLabel.AutoSize = true;
            this.updateDataNachalaUslugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateDataNachalaUslugLabel.Location = new System.Drawing.Point(6, 173);
            this.updateDataNachalaUslugLabel.Name = "updateDataNachalaUslugLabel";
            this.updateDataNachalaUslugLabel.Size = new System.Drawing.Size(146, 16);
            this.updateDataNachalaUslugLabel.TabIndex = 5;
            this.updateDataNachalaUslugLabel.Text = "Data Nachala Uslug";
            // 
            // managersFioLabel
            // 
            this.managersFioLabel.AutoSize = true;
            this.managersFioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managersFioLabel.Location = new System.Drawing.Point(6, 121);
            this.managersFioLabel.Name = "managersFioLabel";
            this.managersFioLabel.Size = new System.Drawing.Size(108, 16);
            this.managersFioLabel.TabIndex = 5;
            this.managersFioLabel.Text = "Manager\'s FIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manager\'s Number";
            // 
            // ManagersNumberLabel
            // 
            this.ManagersNumberLabel.AutoSize = true;
            this.ManagersNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManagersNumberLabel.Location = new System.Drawing.Point(9, 71);
            this.ManagersNumberLabel.Name = "ManagersNumberLabel";
            this.ManagersNumberLabel.Size = new System.Drawing.Size(138, 16);
            this.ManagersNumberLabel.TabIndex = 5;
            this.ManagersNumberLabel.Text = "Manager\'s Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 22);
            this.textBox1.TabIndex = 3;
            // 
            // updateManagersDataPodclucheniya
            // 
            this.updateManagersDataPodclucheniya.Location = new System.Drawing.Point(7, 192);
            this.updateManagersDataPodclucheniya.Name = "updateManagersDataPodclucheniya";
            this.updateManagersDataPodclucheniya.Size = new System.Drawing.Size(304, 22);
            this.updateManagersDataPodclucheniya.TabIndex = 4;
            // 
            // updateManagersNumber
            // 
            this.updateManagersNumber.Location = new System.Drawing.Point(7, 90);
            this.updateManagersNumber.Name = "updateManagersNumber";
            this.updateManagersNumber.Size = new System.Drawing.Size(304, 22);
            this.updateManagersNumber.TabIndex = 3;
            // 
            // updateManagersFIO
            // 
            this.updateManagersFIO.Location = new System.Drawing.Point(7, 140);
            this.updateManagersFIO.Name = "updateManagersFIO";
            this.updateManagersFIO.Size = new System.Drawing.Size(305, 22);
            this.updateManagersFIO.TabIndex = 3;
            // 
            // ManagersIdLabel
            // 
            this.ManagersIdLabel.AutoSize = true;
            this.ManagersIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManagersIdLabel.Location = new System.Drawing.Point(6, 23);
            this.ManagersIdLabel.Name = "ManagersIdLabel";
            this.ManagersIdLabel.Size = new System.Drawing.Size(97, 16);
            this.ManagersIdLabel.TabIndex = 2;
            this.ManagersIdLabel.Text = "Manager\'s Id";
            // 
            // updateManagersId
            // 
            this.updateManagersId.Location = new System.Drawing.Point(7, 42);
            this.updateManagersId.Name = "updateManagersId";
            this.updateManagersId.Size = new System.Drawing.Size(307, 22);
            this.updateManagersId.TabIndex = 1;
            // 
            // updateManagerHandler
            // 
            this.updateManagerHandler.BackColor = System.Drawing.Color.OrangeRed;
            this.updateManagerHandler.Location = new System.Drawing.Point(6, 336);
            this.updateManagerHandler.Name = "updateManagerHandler";
            this.updateManagerHandler.Size = new System.Drawing.Size(308, 55);
            this.updateManagerHandler.TabIndex = 0;
            this.updateManagerHandler.Text = "Update manager";
            this.updateManagerHandler.UseVisualStyleBackColor = false;
            this.updateManagerHandler.Click += new System.EventHandler(this.UpdateManagerHandler);
            // 
            // deleteManager
            // 
            this.deleteManager.Controls.Add(this.deleteManagerByIdLabel);
            this.deleteManager.Controls.Add(this.deleteManagerId);
            this.deleteManager.Controls.Add(this.label1);
            this.deleteManager.Controls.Add(this.deleteManagerHandler);
            this.deleteManager.Location = new System.Drawing.Point(4, 25);
            this.deleteManager.Name = "deleteManager";
            this.deleteManager.Padding = new System.Windows.Forms.Padding(3);
            this.deleteManager.Size = new System.Drawing.Size(320, 397);
            this.deleteManager.TabIndex = 2;
            this.deleteManager.Text = "Delete";
            this.deleteManager.UseVisualStyleBackColor = true;
            // 
            // deleteManagerByIdLabel
            // 
            this.deleteManagerByIdLabel.AutoSize = true;
            this.deleteManagerByIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteManagerByIdLabel.Location = new System.Drawing.Point(6, 19);
            this.deleteManagerByIdLabel.Name = "deleteManagerByIdLabel";
            this.deleteManagerByIdLabel.Size = new System.Drawing.Size(193, 16);
            this.deleteManagerByIdLabel.TabIndex = 4;
            this.deleteManagerByIdLabel.Text = "Enter the deleting manager";
            // 
            // deleteManagerId
            // 
            this.deleteManagerId.Location = new System.Drawing.Point(9, 40);
            this.deleteManagerId.Name = "deleteManagerId";
            this.deleteManagerId.Size = new System.Drawing.Size(305, 22);
            this.deleteManagerId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // deleteManagerHandler
            // 
            this.deleteManagerHandler.BackColor = System.Drawing.Color.Crimson;
            this.deleteManagerHandler.Location = new System.Drawing.Point(7, 98);
            this.deleteManagerHandler.Name = "deleteManagerHandler";
            this.deleteManagerHandler.Size = new System.Drawing.Size(307, 271);
            this.deleteManagerHandler.TabIndex = 0;
            this.deleteManagerHandler.Text = "Delete manager";
            this.deleteManagerHandler.UseVisualStyleBackColor = false;
            this.deleteManagerHandler.Click += new System.EventHandler(this.DeleteManagerHandler);
            // 
            // ManagersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.managerTabControl);
            this.Controls.Add(this.managersDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagersTable";
            this.Text = "ManagersTable";
            ((System.ComponentModel.ISupportInitialize)(this.managersDataGridView)).EndInit();
            this.managerTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.deleteManager.ResumeLayout(false);
            this.deleteManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView managersDataGridView;
        private System.Windows.Forms.TabControl managerTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage deleteManager;
        private System.Windows.Forms.Button updateManagerHandler;
        private System.Windows.Forms.Button deleteManagerHandler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox managersNumber;
        private System.Windows.Forms.TextBox managersFio;
        private System.Windows.Forms.DateTimePicker dataNachalaUslug;
        private System.Windows.Forms.ComboBox podclucheniyeManageraComboBox;
        private System.Windows.Forms.ComboBox stoymostUslugComboBox;
        private System.Windows.Forms.Button addManagerHandler;
        private System.Windows.Forms.Label ManagersIdLabel;
        private System.Windows.Forms.TextBox updateManagersId;
        private System.Windows.Forms.DateTimePicker updateManagersDataPodclucheniya;
        private System.Windows.Forms.TextBox updateManagersNumber;
        private System.Windows.Forms.TextBox updateManagersFIO;
        private System.Windows.Forms.Label ManagersNumberLabel;
        private System.Windows.Forms.ComboBox updatePodcluchenieManageraComboBox;
        private System.Windows.Forms.ComboBox updateStoymostUslugComboBox;
        private System.Windows.Forms.Label managersFioLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label updateDataNachalaUslugLabel;
        private System.Windows.Forms.Label updateStoymostUslugLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label deleteManagerByIdLabel;
        private System.Windows.Forms.TextBox deleteManagerId;
        private System.Windows.Forms.Label addManagerNumberLabel;
        private System.Windows.Forms.Label addManagersFIOLabel;
        private System.Windows.Forms.Label addManagerDataNachalaUslugLabel;
        private System.Windows.Forms.Label addManagerPodcluchenieManageraLabel;
        private System.Windows.Forms.Label addManagerStoymostUslugLabel;
    }
}