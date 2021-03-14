
namespace The_History_Of_Ages_Launcher.Forms
{
    partial class GameSettingsForm
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
            this.ChangeReg_Button = new System.Windows.Forms.Button();
            this.ResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.ApplyGameSettingButton = new System.Windows.Forms.Button();
            this.GraphicComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeReg_Button
            // 
            this.ChangeReg_Button.Location = new System.Drawing.Point(79, 34);
            this.ChangeReg_Button.Name = "ChangeReg_Button";
            this.ChangeReg_Button.Size = new System.Drawing.Size(141, 28);
            this.ChangeReg_Button.TabIndex = 0;
            this.ChangeReg_Button.Text = "Изменить путь к игре";
            this.ChangeReg_Button.UseVisualStyleBackColor = true;
            this.ChangeReg_Button.Click += new System.EventHandler(this.ChangeReg_Button_Click);
            // 
            // ResolutionComboBox
            // 
            this.ResolutionComboBox.FormattingEnabled = true;
            this.ResolutionComboBox.Items.AddRange(new object[] {
            "1920 1080",
            "1280 1080",
            "1366 768"});
            this.ResolutionComboBox.Location = new System.Drawing.Point(79, 116);
            this.ResolutionComboBox.Name = "ResolutionComboBox";
            this.ResolutionComboBox.Size = new System.Drawing.Size(141, 21);
            this.ResolutionComboBox.TabIndex = 1;
            this.ResolutionComboBox.Text = "1920 1080";
            // 
            // ApplyGameSettingButton
            // 
            this.ApplyGameSettingButton.Location = new System.Drawing.Point(107, 262);
            this.ApplyGameSettingButton.Name = "ApplyGameSettingButton";
            this.ApplyGameSettingButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyGameSettingButton.TabIndex = 2;
            this.ApplyGameSettingButton.Text = "Применить";
            this.ApplyGameSettingButton.UseVisualStyleBackColor = true;
            this.ApplyGameSettingButton.Click += new System.EventHandler(this.ApplyGameSettingButton_Click);
            // 
            // GraphicComboBox
            // 
            this.GraphicComboBox.FormattingEnabled = true;
            this.GraphicComboBox.Items.AddRange(new object[] {
            "UltraHigh",
            "Medium",
            "VeryLow"});
            this.GraphicComboBox.Location = new System.Drawing.Point(79, 179);
            this.GraphicComboBox.Name = "GraphicComboBox";
            this.GraphicComboBox.Size = new System.Drawing.Size(141, 21);
            this.GraphicComboBox.TabIndex = 3;
            this.GraphicComboBox.Text = "UltraHigh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Разрешение экрана";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Параметры графики";
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(298, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GraphicComboBox);
            this.Controls.Add(this.ApplyGameSettingButton);
            this.Controls.Add(this.ResolutionComboBox);
            this.Controls.Add(this.ChangeReg_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GameSettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeReg_Button;
        private System.Windows.Forms.ComboBox ResolutionComboBox;
        private System.Windows.Forms.Button ApplyGameSettingButton;
        private System.Windows.Forms.ComboBox GraphicComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}