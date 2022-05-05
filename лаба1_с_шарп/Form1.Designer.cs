
namespace лаба1_с_шарп
{
    partial class Form1
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.OutputButton = new System.Windows.Forms.Button();
            this.TrainlenButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.BeginTextBox = new System.Windows.Forms.TextBox();
            this.EndTextBox = new System.Windows.Forms.TextBox();
            this.ResTextBox = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(0, -1);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(824, 324);
            this.listBox.TabIndex = 0;
            // 
            // OutputButton
            // 
            this.OutputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputButton.Location = new System.Drawing.Point(858, 12);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(176, 77);
            this.OutputButton.TabIndex = 1;
            this.OutputButton.Text = "Вывести состав поезда";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // TrainlenButton
            // 
            this.TrainlenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainlenButton.Location = new System.Drawing.Point(516, 329);
            this.TrainlenButton.Name = "TrainlenButton";
            this.TrainlenButton.Size = new System.Drawing.Size(258, 68);
            this.TrainlenButton.TabIndex = 2;
            this.TrainlenButton.Text = "Вывести количество пассажиров и багажа";
            this.TrainlenButton.UseVisualStyleBackColor = true;
            this.TrainlenButton.Click += new System.EventHandler(this.TrainlenButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(12, 440);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(243, 40);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "Найти подходящие поезда";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // BeginTextBox
            // 
            this.BeginTextBox.Location = new System.Drawing.Point(12, 412);
            this.BeginTextBox.Name = "BeginTextBox";
            this.BeginTextBox.Size = new System.Drawing.Size(108, 22);
            this.BeginTextBox.TabIndex = 5;
            // 
            // EndTextBox
            // 
            this.EndTextBox.Location = new System.Drawing.Point(178, 412);
            this.EndTextBox.Name = "EndTextBox";
            this.EndTextBox.Size = new System.Drawing.Size(100, 22);
            this.EndTextBox.TabIndex = 6;
            // 
            // ResTextBox
            // 
            this.ResTextBox.Location = new System.Drawing.Point(12, 496);
            this.ResTextBox.Multiline = true;
            this.ResTextBox.Name = "ResTextBox";
            this.ResTextBox.Size = new System.Drawing.Size(822, 196);
            this.ResTextBox.TabIndex = 7;
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortButton.Location = new System.Drawing.Point(858, 110);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(182, 94);
            this.SortButton.TabIndex = 8;
            this.SortButton.Text = "Отсортировать cостав по классу комфортности";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Начало диапазона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Конец диапазона";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(778, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(865, 210);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 100);
            this.listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 704);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.ResTextBox);
            this.Controls.Add(this.EndTextBox);
            this.Controls.Add(this.BeginTextBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.TrainlenButton);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Button TrainlenButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox BeginTextBox;
        private System.Windows.Forms.TextBox EndTextBox;
        private System.Windows.Forms.TextBox ResTextBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

