
namespace Lab5.Main
{
    partial class SelectEmergenceServiceType
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectEmergenceServiceComboBox = new System.Windows.Forms.ComboBox();
            this.agreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете тип аварийной службы";
            // 
            // selectEmergenceServiceComboBox
            // 
            this.selectEmergenceServiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectEmergenceServiceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectEmergenceServiceComboBox.FormattingEnabled = true;
            this.selectEmergenceServiceComboBox.Location = new System.Drawing.Point(21, 41);
            this.selectEmergenceServiceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectEmergenceServiceComboBox.Name = "selectEmergenceServiceComboBox";
            this.selectEmergenceServiceComboBox.Size = new System.Drawing.Size(236, 33);
            this.selectEmergenceServiceComboBox.TabIndex = 1;
            this.selectEmergenceServiceComboBox.SelectedIndexChanged += new System.EventHandler(this.selectEmergenceServiceComboBox_SelectedIndexChanged);
            // 
            // agreeButton
            // 
            this.agreeButton.Enabled = false;
            this.agreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.agreeButton.Location = new System.Drawing.Point(21, 82);
            this.agreeButton.Margin = new System.Windows.Forms.Padding(4);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(161, 41);
            this.agreeButton.TabIndex = 2;
            this.agreeButton.Text = "Выбрать";
            this.agreeButton.UseVisualStyleBackColor = true;
            this.agreeButton.Click += new System.EventHandler(this.agreeButton_Click);
            // 
            // SelectEmergenceServiceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 140);
            this.Controls.Add(this.agreeButton);
            this.Controls.Add(this.selectEmergenceServiceComboBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectEmergenceServiceType";
            this.Text = "Выберете тип аварийной службы";
            this.Load += new System.EventHandler(this.SelectEmergenceServiceType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectEmergenceServiceComboBox;
        private System.Windows.Forms.Button agreeButton;
    }
}