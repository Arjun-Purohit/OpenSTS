
namespace LIMS
{
    partial class AddSampleBox
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
            this.AddSample_Button = new System.Windows.Forms.Button();
            this.Title_Label = new System.Windows.Forms.Label();
            this.SupplierSampleID_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SupplierPlateID_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Operator_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InternalSampleID_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SupplierWellID_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InternalPlateID_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InternalWellID_TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.isPosControl_Checkbox = new System.Windows.Forms.CheckBox();
            this.isNegControl_Checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddSample_Button
            // 
            this.AddSample_Button.Location = new System.Drawing.Point(347, 460);
            this.AddSample_Button.Name = "AddSample_Button";
            this.AddSample_Button.Size = new System.Drawing.Size(180, 81);
            this.AddSample_Button.TabIndex = 0;
            this.AddSample_Button.Text = "Add Sample";
            this.AddSample_Button.UseVisualStyleBackColor = true;
            this.AddSample_Button.Click += new System.EventHandler(this.AddSample_Button_Click);
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Location = new System.Drawing.Point(12, 42);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(198, 20);
            this.Title_Label.TabIndex = 1;
            this.Title_Label.Text = "Adding Sample to Well: D1";
            this.Title_Label.Click += new System.EventHandler(this.Title_Label_Click);
            // 
            // SupplierSampleID_TextBox
            // 
            this.SupplierSampleID_TextBox.Location = new System.Drawing.Point(32, 299);
            this.SupplierSampleID_TextBox.Name = "SupplierSampleID_TextBox";
            this.SupplierSampleID_TextBox.Size = new System.Drawing.Size(189, 26);
            this.SupplierSampleID_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Supplier Sample ID:";
            // 
            // SupplierPlateID_TextBox
            // 
            this.SupplierPlateID_TextBox.Location = new System.Drawing.Point(32, 124);
            this.SupplierPlateID_TextBox.Name = "SupplierPlateID_TextBox";
            this.SupplierPlateID_TextBox.Size = new System.Drawing.Size(189, 26);
            this.SupplierPlateID_TextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Supplier Plate ID:";
            // 
            // Operator_TextBox
            // 
            this.Operator_TextBox.Location = new System.Drawing.Point(347, 401);
            this.Operator_TextBox.Name = "Operator_TextBox";
            this.Operator_TextBox.Size = new System.Drawing.Size(189, 26);
            this.Operator_TextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Operator:";
            // 
            // InternalSampleID_TextBox
            // 
            this.InternalSampleID_TextBox.Enabled = false;
            this.InternalSampleID_TextBox.Location = new System.Drawing.Point(347, 307);
            this.InternalSampleID_TextBox.Name = "InternalSampleID_TextBox";
            this.InternalSampleID_TextBox.Size = new System.Drawing.Size(189, 26);
            this.InternalSampleID_TextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Internal Sample ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Supplier Well ID:";
            // 
            // SupplierWellID_TextBox
            // 
            this.SupplierWellID_TextBox.Location = new System.Drawing.Point(32, 208);
            this.SupplierWellID_TextBox.Name = "SupplierWellID_TextBox";
            this.SupplierWellID_TextBox.Size = new System.Drawing.Size(189, 26);
            this.SupplierWellID_TextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Internal Plate ID:";
            // 
            // InternalPlateID_TextBox
            // 
            this.InternalPlateID_TextBox.Enabled = false;
            this.InternalPlateID_TextBox.Location = new System.Drawing.Point(347, 124);
            this.InternalPlateID_TextBox.Name = "InternalPlateID_TextBox";
            this.InternalPlateID_TextBox.Size = new System.Drawing.Size(189, 26);
            this.InternalPlateID_TextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Internal Well ID:";
            // 
            // InternalWellID_TextBox
            // 
            this.InternalWellID_TextBox.Enabled = false;
            this.InternalWellID_TextBox.Location = new System.Drawing.Point(347, 218);
            this.InternalWellID_TextBox.Name = "InternalWellID_TextBox";
            this.InternalWellID_TextBox.Size = new System.Drawing.Size(189, 26);
            this.InternalWellID_TextBox.TabIndex = 14;
            this.InternalWellID_TextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 81);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isPosControl_Checkbox
            // 
            this.isPosControl_Checkbox.AutoSize = true;
            this.isPosControl_Checkbox.Location = new System.Drawing.Point(32, 359);
            this.isPosControl_Checkbox.Name = "isPosControl_Checkbox";
            this.isPosControl_Checkbox.Size = new System.Drawing.Size(263, 24);
            this.isPosControl_Checkbox.TabIndex = 19;
            this.isPosControl_Checkbox.Text = "Is this sample a positive control?";
            this.isPosControl_Checkbox.UseVisualStyleBackColor = true;
            this.isPosControl_Checkbox.CheckedChanged += new System.EventHandler(this.isPosControl_Checkbox_CheckedChanged);
            // 
            // isNegControl_Checkbox
            // 
            this.isNegControl_Checkbox.AutoSize = true;
            this.isNegControl_Checkbox.Location = new System.Drawing.Point(32, 403);
            this.isNegControl_Checkbox.Name = "isNegControl_Checkbox";
            this.isNegControl_Checkbox.Size = new System.Drawing.Size(270, 24);
            this.isNegControl_Checkbox.TabIndex = 20;
            this.isNegControl_Checkbox.Text = "Is this sample a negative control?";
            this.isNegControl_Checkbox.UseVisualStyleBackColor = true;
            this.isNegControl_Checkbox.CheckedChanged += new System.EventHandler(this.isNegControl_Checkbox_CheckedChanged);
            // 
            // AddSampleBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 574);
            this.Controls.Add(this.isNegControl_Checkbox);
            this.Controls.Add(this.isPosControl_Checkbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InternalPlateID_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InternalWellID_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SupplierWellID_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InternalSampleID_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Operator_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SupplierPlateID_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SupplierSampleID_TextBox);
            this.Controls.Add(this.Title_Label);
            this.Controls.Add(this.AddSample_Button);
            this.Name = "AddSampleBox";
            this.Text = "AddSampleBox";
            this.Load += new System.EventHandler(this.AddSampleBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSample_Button;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.TextBox SupplierSampleID_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SupplierPlateID_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Operator_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InternalSampleID_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SupplierWellID_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InternalPlateID_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InternalWellID_TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox isPosControl_Checkbox;
        private System.Windows.Forms.CheckBox isNegControl_Checkbox;
    }
}