namespace SporSalonuÜcretHesaplayıcı
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            label2=new Label();
            checkBox1=new CheckBox();
            checkBox2=new CheckBox();
            checkBox3=new CheckBox();
            button1=new Button();
            comboBox1=new ComboBox();
            textBox1=new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(176, 16);
            label1.Name="label1";
            label1.Size=new Size(77, 19);
            label1.TabIndex=0;
            label1.Text="Üniversite :";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(176, 76);
            label2.Name="label2";
            label2.Size=new Size(79, 19);
            label2.TabIndex=1;
            label2.Text="Yıllık Aidat :";
            label2.Click+=label2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize=true;
            checkBox1.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location=new Point(12, 12);
            checkBox1.Name="checkBox1";
            checkBox1.Size=new Size(113, 25);
            checkBox1.TabIndex=3;
            checkBox1.Text="Öğrenci (aç)";
            checkBox1.UseVisualStyleBackColor=true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize=true;
            checkBox2.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location=new Point(12, 43);
            checkBox2.Name="checkBox2";
            checkBox2.Size=new Size(129, 25);
            checkBox2.TabIndex=4;
            checkBox2.Text="Öğretim Üyesi";
            checkBox2.UseVisualStyleBackColor=true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize=true;
            checkBox3.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location=new Point(12, 74);
            checkBox3.Name="checkBox3";
            checkBox3.Size=new Size(123, 25);
            checkBox3.TabIndex=5;
            checkBox3.Text="İdari Personel";
            checkBox3.UseVisualStyleBackColor=true;
            // 
            // button1
            // 
            button1.BackColor=SystemColors.ButtonHighlight;
            button1.Font=new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor=SystemColors.ActiveCaptionText;
            button1.Location=new Point(259, 45);
            button1.Name="button1";
            button1.Size=new Size(194, 23);
            button1.TabIndex=6;
            button1.Text="AİDAT HESAPLA";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled=true;
            comboBox1.Items.AddRange(new object[] { "NNY", "AGÜ", "ERÜ", "DİĞER" });
            comboBox1.Location=new Point(259, 16);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(194, 23);
            comboBox1.TabIndex=7;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(259, 76);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(194, 23);
            textBox1.TabIndex=8;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(465, 109);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}