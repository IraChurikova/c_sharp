
namespace лаба2_с_шарп
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
            this.HometextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FlattextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.YeartextBox = new System.Windows.Forms.TextBox();
            this.withDistrictcheckbtn = new System.Windows.Forms.RadioButton();
            this.withoutDistrictcheckbtn = new System.Windows.Forms.RadioButton();
            this.inputButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DistricttextBox = new System.Windows.Forms.TextBox();
            this.SecondClasslistBox = new System.Windows.Forms.ListBox();
            this.FirstClasslistBox = new System.Windows.Forms.ListBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HometextBox
            // 
            this.HometextBox.Location = new System.Drawing.Point(22, 31);
            this.HometextBox.Multiline = true;
            this.HometextBox.Name = "HometextBox";
            this.HometextBox.Size = new System.Drawing.Size(435, 31);
            this.HometextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер дома";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Число квартир";
            // 
            // FlattextBox
            // 
            this.FlattextBox.Location = new System.Drawing.Point(22, 86);
            this.FlattextBox.Multiline = true;
            this.FlattextBox.Name = "FlattextBox";
            this.FlattextBox.Size = new System.Drawing.Size(435, 31);
            this.FlattextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год сооружения";
            // 
            // YeartextBox
            // 
            this.YeartextBox.Location = new System.Drawing.Point(22, 139);
            this.YeartextBox.Multiline = true;
            this.YeartextBox.Name = "YeartextBox";
            this.YeartextBox.Size = new System.Drawing.Size(435, 31);
            this.YeartextBox.TabIndex = 5;
            // 
            // withDistrictcheckbtn
            // 
            this.withDistrictcheckbtn.AutoSize = true;
            this.withDistrictcheckbtn.Location = new System.Drawing.Point(22, 187);
            this.withDistrictcheckbtn.Name = "withDistrictcheckbtn";
            this.withDistrictcheckbtn.Size = new System.Drawing.Size(97, 21);
            this.withDistrictcheckbtn.TabIndex = 6;
            this.withDistrictcheckbtn.TabStop = true;
            this.withDistrictcheckbtn.Text = "с районом";
            this.withDistrictcheckbtn.UseVisualStyleBackColor = true;
            this.withDistrictcheckbtn.CheckedChanged += new System.EventHandler(this.withCountrycheckbtn_CheckedChanged);
            // 
            // withoutDistrictcheckbtn
            // 
            this.withoutDistrictcheckbtn.AutoSize = true;
            this.withoutDistrictcheckbtn.Location = new System.Drawing.Point(247, 187);
            this.withoutDistrictcheckbtn.Name = "withoutDistrictcheckbtn";
            this.withoutDistrictcheckbtn.Size = new System.Drawing.Size(104, 21);
            this.withoutDistrictcheckbtn.TabIndex = 7;
            this.withoutDistrictcheckbtn.TabStop = true;
            this.withoutDistrictcheckbtn.Text = "без района";
            this.withoutDistrictcheckbtn.UseVisualStyleBackColor = true;
            this.withoutDistrictcheckbtn.CheckedChanged += new System.EventHandler(this.withoutCountrycheckbtn_CheckedChanged);
            // 
            // inputButton
            // 
            this.inputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputButton.Location = new System.Drawing.Point(526, 54);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(120, 84);
            this.inputButton.TabIndex = 8;
            this.inputButton.Text = "Ввод";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Район:";
            // 
            // DistricttextBox
            // 
            this.DistricttextBox.Enabled = false;
            this.DistricttextBox.Location = new System.Drawing.Point(190, 221);
            this.DistricttextBox.Multiline = true;
            this.DistricttextBox.Name = "DistricttextBox";
            this.DistricttextBox.Size = new System.Drawing.Size(251, 27);
            this.DistricttextBox.TabIndex = 10;
            // 
            // SecondClasslistBox
            // 
            this.SecondClasslistBox.FormattingEnabled = true;
            this.SecondClasslistBox.HorizontalScrollbar = true;
            this.SecondClasslistBox.ItemHeight = 16;
            this.SecondClasslistBox.Location = new System.Drawing.Point(424, 305);
            this.SecondClasslistBox.Name = "SecondClasslistBox";
            this.SecondClasslistBox.Size = new System.Drawing.Size(374, 276);
            this.SecondClasslistBox.TabIndex = 12;
            // 
            // FirstClasslistBox
            // 
            this.FirstClasslistBox.FormattingEnabled = true;
            this.FirstClasslistBox.HorizontalScrollbar = true;
            this.FirstClasslistBox.ItemHeight = 16;
            this.FirstClasslistBox.Location = new System.Drawing.Point(22, 305);
            this.FirstClasslistBox.Name = "FirstClasslistBox";
            this.FirstClasslistBox.Size = new System.Drawing.Size(374, 276);
            this.FirstClasslistBox.TabIndex = 13;
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(364, 265);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(93, 34);
            this.outputButton.TabIndex = 14;
            this.outputButton.Text = "Вывод";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 593);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.FirstClasslistBox);
            this.Controls.Add(this.SecondClasslistBox);
            this.Controls.Add(this.DistricttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.withoutDistrictcheckbtn);
            this.Controls.Add(this.withDistrictcheckbtn);
            this.Controls.Add(this.YeartextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FlattextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HometextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HometextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FlattextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox YeartextBox;
        private System.Windows.Forms.RadioButton withDistrictcheckbtn;
        private System.Windows.Forms.RadioButton withoutDistrictcheckbtn;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DistricttextBox;
        private System.Windows.Forms.ListBox SecondClasslistBox;
        private System.Windows.Forms.ListBox FirstClasslistBox;
        private System.Windows.Forms.Button outputButton;
    }
}

