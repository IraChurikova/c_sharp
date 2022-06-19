
namespace Lab5.Main
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmergencyServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTrolleybusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.notificationTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.addDriverToolStripMenuItem,
            this.addEmergencyServiceToolStripMenuItem,
            this.addTrolleybusToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1584, 36);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip2";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.startToolStripMenuItem.Text = "Запуск";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // addDriverToolStripMenuItem
            // 
            this.addDriverToolStripMenuItem.Enabled = false;
            this.addDriverToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addDriverToolStripMenuItem.Name = "addDriverToolStripMenuItem";
            this.addDriverToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.addDriverToolStripMenuItem.Text = "Добавить водителя";
            this.addDriverToolStripMenuItem.Click += new System.EventHandler(this.addDriverToolStripMenuItem_Click);
            // 
            // addEmergencyServiceToolStripMenuItem
            // 
            this.addEmergencyServiceToolStripMenuItem.Enabled = false;
            this.addEmergencyServiceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addEmergencyServiceToolStripMenuItem.Name = "addEmergencyServiceToolStripMenuItem";
            this.addEmergencyServiceToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.addEmergencyServiceToolStripMenuItem.Text = "Добавить аварийную службу";
            this.addEmergencyServiceToolStripMenuItem.Click += new System.EventHandler(this.addEmergencyServiceToolStripMenuItem_Click);
            // 
            // addTrolleybusToolStripMenuItem
            // 
            this.addTrolleybusToolStripMenuItem.Enabled = false;
            this.addTrolleybusToolStripMenuItem.Name = "addTrolleybusToolStripMenuItem";
            this.addTrolleybusToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.addTrolleybusToolStripMenuItem.Text = "Добавить троллейбус";
            this.addTrolleybusToolStripMenuItem.Click += new System.EventHandler(this.addCompatitionToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.notificationTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(1584, 741);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // notificationTextBox
            // 
            this.notificationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.notificationTextBox.Location = new System.Drawing.Point(0, 0);
            this.notificationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.notificationTextBox.Multiline = true;
            this.notificationTextBox.Name = "notificationTextBox";
            this.notificationTextBox.ReadOnly = true;
            this.notificationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notificationTextBox.Size = new System.Drawing.Size(429, 741);
            this.notificationTextBox.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1150, 741);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 777);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "TrolleyBus LIFE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmergencyServiceToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox notificationTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem addTrolleybusToolStripMenuItem;
    }
}

