
namespace лаба3_с_шарп
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.showGuitarFrequencyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.valumeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pullStringButton = new System.Windows.Forms.ToolStripMenuItem();
            this.makeLouderButton = new System.Windows.Forms.ToolStripMenuItem();
            this.breakStringButton = new System.Windows.Forms.ToolStripMenuItem();
            this.playBassButton = new System.Windows.Forms.ToolStripMenuItem();
            this.playButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(336, 356);
            this.listBox1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.AddButton,
            this.DeleteButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(363, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valumeButton,
            this.showGuitarFrequencyButton,
            this.makeLouderButton,
            this.pullStringButton,
            this.breakStringButton,
            this.playBassButton,
            this.playButton});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(179, 28);
            this.toolStripSplitButton1.Text = "Работа с устройством";
           
            // 
            // showGuitarFrequencyButton
            // 
            this.showGuitarFrequencyButton.Name = "showGuitarFrequencyButton";
            this.showGuitarFrequencyButton.Size = new System.Drawing.Size(248, 26);
            this.showGuitarFrequencyButton.Text = "Узнать частоту гитары";
            this.showGuitarFrequencyButton.Click += new System.EventHandler(this.showGuitarFrequencyButton_Click);
            // 
            // valumeButton
            // 
            this.valumeButton.Name = "valumeButton";
            this.valumeButton.Size = new System.Drawing.Size(248, 26);
            this.valumeButton.Text = "Включить гитару";
            this.valumeButton.Click += new System.EventHandler(this.valueButton_Click);
            // 
            // pullStringButton
            // 
            this.pullStringButton.Name = "pullStringButton";
            this.pullStringButton.Size = new System.Drawing.Size(248, 26);
            this.pullStringButton.Text = "Натянуть струну";
            this.pullStringButton.Click += new System.EventHandler(this.pullStringButton_Click);
            // 
            // makeLouderButton
            // 
            this.makeLouderButton.Name = "makeLouderButton";
            this.makeLouderButton.Size = new System.Drawing.Size(248, 26);
            this.makeLouderButton.Text = "Сделать громче";
            this.makeLouderButton.Click += new System.EventHandler(this.makeLouderButton_Click);
            // 
            // breakStringButton
            // 
            this.breakStringButton.Name = "breakStringButton";
            this.breakStringButton.Size = new System.Drawing.Size(248, 26);
            this.breakStringButton.Text = "Порвать струну";
            this.breakStringButton.Click += new System.EventHandler(this.breakStringButton_Click);
            // 
            // playBassButton
            // 
            this.playBassButton.Name = "playBassButton";
            this.playBassButton.Size = new System.Drawing.Size(248, 26);
            this.playBassButton.Text = "Сыграть 1-ю мелодию";
            this.playBassButton.Click += new System.EventHandler(this.playBasButton_Click);
            // 
            // playButton
            // 
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(248, 26);
            this.playButton.Text = "Сыграть 2-ю мелодию";
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 28);
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(69, 28);
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 417);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem valumeButton;
        private System.Windows.Forms.ToolStripMenuItem pullStringButton;
        private System.Windows.Forms.ToolStripMenuItem breakStringButton;
        private System.Windows.Forms.ToolStripMenuItem playBassButton;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripMenuItem makeLouderButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showGuitarFrequencyButton;
        private System.Windows.Forms.ToolStripMenuItem playButton;
    }
}

