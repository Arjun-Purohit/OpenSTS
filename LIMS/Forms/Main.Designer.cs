
namespace LIMS
{
    partial class MainMenuForm
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
            this.NewPlate_Button = new System.Windows.Forms.Button();
            this.ViewPlates_Button = new System.Windows.Forms.Button();
            this.Config_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewPlate_Button
            // 
            this.NewPlate_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NewPlate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NewPlate_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewPlate_Button.Location = new System.Drawing.Point(57, 139);
            this.NewPlate_Button.Margin = new System.Windows.Forms.Padding(2);
            this.NewPlate_Button.Name = "NewPlate_Button";
            this.NewPlate_Button.Size = new System.Drawing.Size(215, 329);
            this.NewPlate_Button.TabIndex = 0;
            this.NewPlate_Button.Text = "Start New Plate";
            this.NewPlate_Button.UseVisualStyleBackColor = false;
            this.NewPlate_Button.Click += new System.EventHandler(this.NewPlate_Button_Click);
            // 
            // ViewPlates_Button
            // 
            this.ViewPlates_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ViewPlates_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ViewPlates_Button.Location = new System.Drawing.Point(314, 139);
            this.ViewPlates_Button.Margin = new System.Windows.Forms.Padding(2);
            this.ViewPlates_Button.Name = "ViewPlates_Button";
            this.ViewPlates_Button.Size = new System.Drawing.Size(215, 329);
            this.ViewPlates_Button.TabIndex = 1;
            this.ViewPlates_Button.Text = "View Plates";
            this.ViewPlates_Button.UseVisualStyleBackColor = false;
            this.ViewPlates_Button.Click += new System.EventHandler(this.ViewPlates_Button_Click);
            // 
            // Config_Button
            // 
            this.Config_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Config_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Config_Button.Location = new System.Drawing.Point(575, 139);
            this.Config_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Config_Button.Name = "Config_Button";
            this.Config_Button.Size = new System.Drawing.Size(215, 329);
            this.Config_Button.TabIndex = 3;
            this.Config_Button.Text = "Configuration";
            this.Config_Button.UseVisualStyleBackColor = false;
            this.Config_Button.Click += new System.EventHandler(this.Config_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label1.Location = new System.Drawing.Point(158, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sample Tracking Software";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(850, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Config_Button);
            this.Controls.Add(this.ViewPlates_Button);
            this.Controls.Add(this.NewPlate_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenuForm";
            this.Text = "LIMS";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.Shown += new System.EventHandler(this.MainMenuForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewPlate_Button;
        private System.Windows.Forms.Button ViewPlates_Button;
        private System.Windows.Forms.Button Config_Button;
        private System.Windows.Forms.Label label1;
    }
}

