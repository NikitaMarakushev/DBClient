
namespace DBClient
{
    partial class Rupor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rupor));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Clinets = new System.Windows.Forms.TabPage();
            this.ManagersTab = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.getClients = new System.Windows.Forms.Button();
            this.getManagers = new System.Windows.Forms.Button();
            this.loadNomer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.getNomerSobesednika = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Clinets);
            this.tabControl1.Controls.Add(this.ManagersTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(708, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // Clinets
            // 
            this.Clinets.Location = new System.Drawing.Point(4, 25);
            this.Clinets.Name = "Clinets";
            this.Clinets.Size = new System.Drawing.Size(700, 460);
            this.Clinets.TabIndex = 0;
            // 
            // ManagersTab
            // 
            this.ManagersTab.Location = new System.Drawing.Point(4, 25);
            this.ManagersTab.Name = "ManagersTab";
            this.ManagersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ManagersTab.Size = new System.Drawing.Size(700, 460);
            this.ManagersTab.TabIndex = 1;
            this.ManagersTab.Text = "Managers";
            this.ManagersTab.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(700, 460);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(700, 460);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // getClients
            // 
            this.getClients.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.getClients.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getClients.Location = new System.Drawing.Point(12, 12);
            this.getClients.Name = "getClients";
            this.getClients.Size = new System.Drawing.Size(190, 65);
            this.getClients.TabIndex = 0;
            this.getClients.Text = "Clients";
            this.getClients.UseVisualStyleBackColor = false;
            this.getClients.Click += new System.EventHandler(this.getClientsMainForm);
            // 
            // getManagers
            // 
            this.getManagers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.getManagers.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getManagers.Location = new System.Drawing.Point(208, 12);
            this.getManagers.Name = "getManagers";
            this.getManagers.Size = new System.Drawing.Size(218, 65);
            this.getManagers.TabIndex = 0;
            this.getManagers.Text = "Managers";
            this.getManagers.UseVisualStyleBackColor = false;
            this.getManagers.Click += new System.EventHandler(this.getMangersMainForm);
            // 
            // loadNomer
            // 
            this.loadNomer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loadNomer.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadNomer.Location = new System.Drawing.Point(432, 12);
            this.loadNomer.Name = "loadNomer";
            this.loadNomer.Size = new System.Drawing.Size(221, 65);
            this.loadNomer.TabIndex = 0;
            this.loadNomer.Text = "Numbers";
            this.loadNomer.UseVisualStyleBackColor = false;
            this.loadNomer.Click += new System.EventHandler(this.getNomerData);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(435, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Numbers";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.getNomerData);
            // 
            // getNomerSobesednika
            // 
            this.getNomerSobesednika.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.getNomerSobesednika.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getNomerSobesednika.Location = new System.Drawing.Point(12, 83);
            this.getNomerSobesednika.Name = "getNomerSobesednika";
            this.getNomerSobesednika.Size = new System.Drawing.Size(221, 207);
            this.getNomerSobesednika.TabIndex = 0;
            this.getNomerSobesednika.Text = "Companion\'s number";
            this.getNomerSobesednika.UseVisualStyleBackColor = false;
            this.getNomerSobesednika.Click += new System.EventHandler(this.getNomerData);
            // 
            // Rupor
            // 
            this.ClientSize = new System.Drawing.Size(804, 331);
            this.Controls.Add(this.getNomerSobesednika);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadNomer);
            this.Controls.Add(this.getManagers);
            this.Controls.Add(this.getClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rupor";
            this.Text = "Rupor ";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Clinets;
        private System.Windows.Forms.TabPage ManagersTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button getClients;
        private System.Windows.Forms.Button getManagers;
        private System.Windows.Forms.Button loadNomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button getNomerSobesednika;
    }
}

