
namespace The_History_Of_Ages_Launcher
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.Launch_button = new System.Windows.Forms.Button();
            this.WorldBuilderButton = new System.Windows.Forms.Button();
            this.languageBox = new System.Windows.Forms.CheckBox();
            this.GameInterface_button = new System.Windows.Forms.Button();
            this.Vk_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.Fb_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.GameSetting_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Launch_button
            // 
            resources.ApplyResources(this.Launch_button, "Launch_button");
            this.Launch_button.Name = "Launch_button";
            this.Launch_button.UseVisualStyleBackColor = true;
            this.Launch_button.Click += new System.EventHandler(this.Launch_button_Click);
            // 
            // WorldBuilderButton
            // 
            resources.ApplyResources(this.WorldBuilderButton, "WorldBuilderButton");
            this.WorldBuilderButton.Name = "WorldBuilderButton";
            this.WorldBuilderButton.UseVisualStyleBackColor = true;
            this.WorldBuilderButton.Click += new System.EventHandler(this.WorldBuilderButton_Click);
            // 
            // languageBox
            // 
            resources.ApplyResources(this.languageBox, "languageBox");
            this.languageBox.Checked = true;
            this.languageBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.languageBox.Name = "languageBox";
            this.languageBox.UseVisualStyleBackColor = true;
            // 
            // GameInterface_button
            // 
            resources.ApplyResources(this.GameInterface_button, "GameInterface_button");
            this.GameInterface_button.Name = "GameInterface_button";
            this.GameInterface_button.UseVisualStyleBackColor = true;
            this.GameInterface_button.Click += new System.EventHandler(this.GameInterface_button_Click);
            // 
            // Vk_LinkLabel
            // 
            resources.ApplyResources(this.Vk_LinkLabel, "Vk_LinkLabel");
            this.Vk_LinkLabel.Name = "Vk_LinkLabel";
            this.Vk_LinkLabel.TabStop = true;
            this.Vk_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Vk_LinkLabel_LinkClicked);
            // 
            // Fb_LinkLabel
            // 
            resources.ApplyResources(this.Fb_LinkLabel, "Fb_LinkLabel");
            this.Fb_LinkLabel.Name = "Fb_LinkLabel";
            this.Fb_LinkLabel.TabStop = true;
            this.Fb_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Fb_LinkLabel_LinkClicked);
            // 
            // GameSetting_button
            // 
            resources.ApplyResources(this.GameSetting_button, "GameSetting_button");
            this.GameSetting_button.Name = "GameSetting_button";
            this.GameSetting_button.UseVisualStyleBackColor = true;
            this.GameSetting_button.Click += new System.EventHandler(this.GameSetting_button_Click);
            // 
            // MainMenuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GameSetting_button);
            this.Controls.Add(this.Fb_LinkLabel);
            this.Controls.Add(this.Vk_LinkLabel);
            this.Controls.Add(this.GameInterface_button);
            this.Controls.Add(this.languageBox);
            this.Controls.Add(this.WorldBuilderButton);
            this.Controls.Add(this.Launch_button);
            this.Name = "MainMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Launch_button;
        private System.Windows.Forms.Button WorldBuilderButton;
        private System.Windows.Forms.CheckBox languageBox;
        private System.Windows.Forms.Button GameInterface_button;
        private System.Windows.Forms.LinkLabel Vk_LinkLabel;
        private System.Windows.Forms.LinkLabel Fb_LinkLabel;
        private System.Windows.Forms.Button GameSetting_button;
    }
}

