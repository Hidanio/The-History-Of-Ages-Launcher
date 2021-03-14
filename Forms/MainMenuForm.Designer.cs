
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
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.GameInterface_button = new System.Windows.Forms.Button();
            this.Vk_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.Fb_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.GameSetting_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Launch_button
            // 
            resources.ApplyResources(this.Launch_button, "Launch_button");
            this.Launch_button.Name = "Launch_button";
            this.Launch_button.UseVisualStyleBackColor = true;
            this.Launch_button.Click += new System.EventHandler(this.Launch_button_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Launch_button);
            this.Name = "MainMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Launch_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button GameInterface_button;
        private System.Windows.Forms.LinkLabel Vk_LinkLabel;
        private System.Windows.Forms.LinkLabel Fb_LinkLabel;
        private System.Windows.Forms.Button GameSetting_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

