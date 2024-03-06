namespace OTS2023_ConventorApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnConvert = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbConverterType = new System.Windows.Forms.GroupBox();
            this.rbtnMass = new System.Windows.Forms.RadioButton();
            this.rbtnLenth = new System.Windows.Forms.RadioButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.gbConverterType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(384, 294);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gbConverterType
            // 
            this.gbConverterType.Controls.Add(this.rbtnLenth);
            this.gbConverterType.Controls.Add(this.rbtnMass);
            this.gbConverterType.Location = new System.Drawing.Point(12, 12);
            this.gbConverterType.Name = "gbConverterType";
            this.gbConverterType.Size = new System.Drawing.Size(204, 100);
            this.gbConverterType.TabIndex = 2;
            this.gbConverterType.TabStop = false;
            this.gbConverterType.Text = "Converter type";
            // 
            // rbtnMass
            // 
            this.rbtnMass.AutoSize = true;
            this.rbtnMass.Location = new System.Drawing.Point(6, 32);
            this.rbtnMass.Name = "rbtnMass";
            this.rbtnMass.Size = new System.Drawing.Size(50, 17);
            this.rbtnMass.TabIndex = 3;
            this.rbtnMass.Text = "Mass";
            this.rbtnMass.UseVisualStyleBackColor = true;
            this.rbtnMass.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnLenth
            // 
            this.rbtnLenth.AutoSize = true;
            this.rbtnLenth.Location = new System.Drawing.Point(6, 55);
            this.rbtnLenth.Name = "rbtnLenth";
            this.rbtnLenth.Size = new System.Drawing.Size(58, 17);
            this.rbtnLenth.TabIndex = 3;
            this.rbtnLenth.Text = "Length";
            this.rbtnLenth.UseVisualStyleBackColor = true;
            this.rbtnLenth.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(253, 200);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "label1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(253, 240);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "label2";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(359, 197);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 5;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(359, 237);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.gbConverterType);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConverterType.ResumeLayout(false);
            this.gbConverterType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gbConverterType;
        private System.Windows.Forms.RadioButton rbtnMass;
        private System.Windows.Forms.RadioButton rbtnLenth;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
    }
}

