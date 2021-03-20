
namespace The_History_Of_Ages_Launcher
{
    partial class GameInterfaceSettingsForm
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
            this.ApplyGameInterfaceButton = new System.Windows.Forms.Button();
            this.PalantirComboBox = new System.Windows.Forms.ComboBox();
            this.InterfaceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApplyGameInterfaceButton
            // 
            this.ApplyGameInterfaceButton.Location = new System.Drawing.Point(206, 134);
            this.ApplyGameInterfaceButton.Name = "ApplyGameInterfaceButton";
            this.ApplyGameInterfaceButton.Size = new System.Drawing.Size(121, 20);
            this.ApplyGameInterfaceButton.TabIndex = 0;
            this.ApplyGameInterfaceButton.Text = "Применить";
            this.ApplyGameInterfaceButton.UseVisualStyleBackColor = true;
            this.ApplyGameInterfaceButton.Click += new System.EventHandler(this.ApplyGameInterfaceButton_Click);
            // 
            // PalantirComboBox
            // 
            this.PalantirComboBox.FormattingEnabled = true;
            this.PalantirComboBox.Items.AddRange(new object[] {
            "Default Palantir",
            "THOA Palantir",
            "THOA Winter",
            "THOA History"});
            this.PalantirComboBox.Location = new System.Drawing.Point(30, 93);
            this.PalantirComboBox.Name = "PalantirComboBox";
            this.PalantirComboBox.Size = new System.Drawing.Size(121, 21);
            this.PalantirComboBox.TabIndex = 1;
            this.PalantirComboBox.Text = "Default Palantir";
            // 
            // InterfaceComboBox
            // 
            this.InterfaceComboBox.FormattingEnabled = true;
            this.InterfaceComboBox.Items.AddRange(new object[] {
            "Angmar",
            "Rohan",
            "Elf",
            "Dwarf",
            "BFME",
            "BFME 2",
            "ROTWK",
            "THOA"});
            this.InterfaceComboBox.Location = new System.Drawing.Point(30, 159);
            this.InterfaceComboBox.Name = "InterfaceComboBox";
            this.InterfaceComboBox.Size = new System.Drawing.Size(121, 21);
            this.InterfaceComboBox.TabIndex = 2;
            this.InterfaceComboBox.Text = "Angmar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Палантир";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Игровой интерфейс";
            // 
            // GameInterfaceSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(390, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InterfaceComboBox);
            this.Controls.Add(this.PalantirComboBox);
            this.Controls.Add(this.ApplyGameInterfaceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GameInterfaceSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GameInterfaceSettings";
            this.Load += new System.EventHandler(this.GameInterfaceSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyGameInterfaceButton;
        private System.Windows.Forms.ComboBox PalantirComboBox;
        private System.Windows.Forms.ComboBox InterfaceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}