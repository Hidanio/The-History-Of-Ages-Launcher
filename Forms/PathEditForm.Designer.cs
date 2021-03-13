
namespace The_History_Of_Ages_Launcher.Forms
{
    partial class PathEditForm
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
            this.Path_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Path_button
            // 
            this.Path_button.Location = new System.Drawing.Point(109, 47);
            this.Path_button.Name = "Path_button";
            this.Path_button.Size = new System.Drawing.Size(184, 39);
            this.Path_button.TabIndex = 0;
            this.Path_button.Text = "Указать путь";
            this.Path_button.UseVisualStyleBackColor = true;
            this.Path_button.Click += new System.EventHandler(this.Path_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите путь к игре";
            // 
            // PathEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path_button);
            this.Name = "PathEditForm";
            this.Text = "PathEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Path_button;
        private System.Windows.Forms.Label label1;
    }
}