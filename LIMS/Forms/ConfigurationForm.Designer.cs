
namespace LIMS
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.browse_button = new System.Windows.Forms.Button();
            this.networkFolderPath_TextBox = new System.Windows.Forms.TextBox();
            this.NetworkPath_Label = new System.Windows.Forms.Label();
            this.DataPath_Label = new System.Windows.Forms.Label();
            this.dataFolderPath_TextBox = new System.Windows.Forms.TextBox();
            this.outputFolderPath_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Configure_Button = new System.Windows.Forms.Button();
            this.Output_Textbox = new System.Windows.Forms.TextBox();
            this.colorBrowser = new System.Windows.Forms.ColorDialog();
            this.BackgroundColour_Button = new System.Windows.Forms.Button();
            this.ButtonColour_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderBrowser
            // 
            this.folderBrowser.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(387, 185);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(94, 36);
            this.browse_button.TabIndex = 0;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // networkFolderPath_TextBox
            // 
            this.networkFolderPath_TextBox.Location = new System.Drawing.Point(9, 190);
            this.networkFolderPath_TextBox.Name = "networkFolderPath_TextBox";
            this.networkFolderPath_TextBox.Size = new System.Drawing.Size(372, 26);
            this.networkFolderPath_TextBox.TabIndex = 1;
            this.networkFolderPath_TextBox.TextChanged += new System.EventHandler(this.networkFolderPath_TextBox_TextChanged);
            // 
            // NetworkPath_Label
            // 
            this.NetworkPath_Label.AutoSize = true;
            this.NetworkPath_Label.Location = new System.Drawing.Point(8, 167);
            this.NetworkPath_Label.Name = "NetworkPath_Label";
            this.NetworkPath_Label.Size = new System.Drawing.Size(168, 20);
            this.NetworkPath_Label.TabIndex = 2;
            this.NetworkPath_Label.Text = "Path to network folder:";
            // 
            // DataPath_Label
            // 
            this.DataPath_Label.AutoSize = true;
            this.DataPath_Label.Location = new System.Drawing.Point(12, 240);
            this.DataPath_Label.Name = "DataPath_Label";
            this.DataPath_Label.Size = new System.Drawing.Size(144, 20);
            this.DataPath_Label.TabIndex = 3;
            this.DataPath_Label.Text = "Path to data folder:";
            // 
            // dataFolderPath_TextBox
            // 
            this.dataFolderPath_TextBox.Enabled = false;
            this.dataFolderPath_TextBox.Location = new System.Drawing.Point(9, 263);
            this.dataFolderPath_TextBox.Name = "dataFolderPath_TextBox";
            this.dataFolderPath_TextBox.Size = new System.Drawing.Size(372, 26);
            this.dataFolderPath_TextBox.TabIndex = 4;
            this.dataFolderPath_TextBox.TextChanged += new System.EventHandler(this.dataFolderPath_TextBox_TextChanged);
            // 
            // outputFolderPath_TextBox
            // 
            this.outputFolderPath_TextBox.Enabled = false;
            this.outputFolderPath_TextBox.Location = new System.Drawing.Point(9, 338);
            this.outputFolderPath_TextBox.Name = "outputFolderPath_TextBox";
            this.outputFolderPath_TextBox.Size = new System.Drawing.Size(372, 26);
            this.outputFolderPath_TextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path to output folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.MaximumSize = new System.Drawing.Size(400, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 120);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Configure_Button
            // 
            this.Configure_Button.Location = new System.Drawing.Point(564, 357);
            this.Configure_Button.Name = "Configure_Button";
            this.Configure_Button.Size = new System.Drawing.Size(162, 63);
            this.Configure_Button.TabIndex = 8;
            this.Configure_Button.Text = "Configure";
            this.Configure_Button.UseVisualStyleBackColor = true;
            this.Configure_Button.Click += new System.EventHandler(this.Configure_Button_Click);
            // 
            // Output_Textbox
            // 
            this.Output_Textbox.Enabled = false;
            this.Output_Textbox.Location = new System.Drawing.Point(535, 231);
            this.Output_Textbox.Multiline = true;
            this.Output_Textbox.Name = "Output_Textbox";
            this.Output_Textbox.Size = new System.Drawing.Size(219, 104);
            this.Output_Textbox.TabIndex = 9;
            this.Output_Textbox.TextChanged += new System.EventHandler(this.Output_Textbox_TextChanged);
            // 
            // BackgroundColour_Button
            // 
            this.BackgroundColour_Button.Location = new System.Drawing.Point(535, 19);
            this.BackgroundColour_Button.Name = "BackgroundColour_Button";
            this.BackgroundColour_Button.Size = new System.Drawing.Size(219, 53);
            this.BackgroundColour_Button.TabIndex = 10;
            this.BackgroundColour_Button.Text = "Set Background Colour";
            this.BackgroundColour_Button.UseVisualStyleBackColor = true;
            this.BackgroundColour_Button.Click += new System.EventHandler(this.BackgroundColour_Button_Click);
            // 
            // ButtonColour_Button
            // 
            this.ButtonColour_Button.Location = new System.Drawing.Point(535, 86);
            this.ButtonColour_Button.Name = "ButtonColour_Button";
            this.ButtonColour_Button.Size = new System.Drawing.Size(219, 53);
            this.ButtonColour_Button.TabIndex = 11;
            this.ButtonColour_Button.Text = "Set Button Colour";
            this.ButtonColour_Button.UseVisualStyleBackColor = true;
            this.ButtonColour_Button.Click += new System.EventHandler(this.ButtonColour_Button_Click);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonColour_Button);
            this.Controls.Add(this.BackgroundColour_Button);
            this.Controls.Add(this.Output_Textbox);
            this.Controls.Add(this.Configure_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputFolderPath_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataFolderPath_TextBox);
            this.Controls.Add(this.DataPath_Label);
            this.Controls.Add(this.NetworkPath_Label);
            this.Controls.Add(this.networkFolderPath_TextBox);
            this.Controls.Add(this.browse_button);
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.TextBox networkFolderPath_TextBox;
        private System.Windows.Forms.Label NetworkPath_Label;
        private System.Windows.Forms.Label DataPath_Label;
        private System.Windows.Forms.TextBox dataFolderPath_TextBox;
        private System.Windows.Forms.TextBox outputFolderPath_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Configure_Button;
        private System.Windows.Forms.TextBox Output_Textbox;
        private System.Windows.Forms.ColorDialog colorBrowser;
        private System.Windows.Forms.Button BackgroundColour_Button;
        private System.Windows.Forms.Button ButtonColour_Button;
    }
}