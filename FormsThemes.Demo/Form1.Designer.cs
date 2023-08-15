using FormsThemes.Controls;

namespace FormsThemes.Demo
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
            groupBox1=new GroupBox();
            checkBox1=new ThemedCheckBox();
            radioButton1=new ThemedRadioButton();
            radioButton2=new ThemedRadioButton();
            listBox1=new ThemedListBox();
            checkBox2=new ThemedCheckBox();
            comboBox2=new ThemedComboBox();
            textBox1=new ThemedTextBox();
            textBox2=new ThemedTextBox();
            textBox3=new ThemedTextBox();
            themedButton1=new ThemedButton();
            themedButton2=new ThemedButton();
            themedButton3=new ThemedButton();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location=new Point(588, 19);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(200, 100);
            groupBox1.TabIndex=2;
            groupBox1.TabStop=false;
            groupBox1.Text="groupBox1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize=true;
            checkBox1.Checked=true;
            checkBox1.CheckState=CheckState.Checked;
            checkBox1.Location=new Point(12, 12);
            checkBox1.Name="checkBox1";
            checkBox1.Size=new Size(83, 19);
            checkBox1.TabIndex=3;
            checkBox1.Text="checkBox1";
            checkBox1.UseVisualStyleBackColor=true;
            checkBox1.CheckedChanged+=checkBox1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize=true;
            radioButton1.Location=new Point(588, 154);
            radioButton1.Name="radioButton1";
            radioButton1.Size=new Size(94, 19);
            radioButton1.TabIndex=4;
            radioButton1.TabStop=true;
            radioButton1.Text="radioButton1";
            radioButton1.UseVisualStyleBackColor=true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize=true;
            radioButton2.Location=new Point(588, 179);
            radioButton2.Name="radioButton2";
            radioButton2.Size=new Size(94, 19);
            radioButton2.TabIndex=5;
            radioButton2.TabStop=true;
            radioButton2.Text="radioButton2";
            radioButton2.UseVisualStyleBackColor=true;
            // 
            // listBox1
            // 
            listBox1.DrawMode=DrawMode.OwnerDrawFixed;
            listBox1.FormattingEnabled=true;
            listBox1.ItemHeight=15;
            listBox1.Location=new Point(366, 19);
            listBox1.Name="listBox1";
            listBox1.Size=new Size(198, 199);
            listBox1.TabIndex=7;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize=true;
            checkBox2.Location=new Point(588, 244);
            checkBox2.Name="checkBox2";
            checkBox2.Size=new Size(83, 19);
            checkBox2.TabIndex=8;
            checkBox2.Text="checkBox2";
            checkBox2.UseVisualStyleBackColor=true;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled=true;
            comboBox2.Items.AddRange(new object[] { "item A", "item B", "item C" });
            comboBox2.Location=new Point(588, 281);
            comboBox2.Name="comboBox2";
            comboBox2.Size=new Size(121, 24);
            comboBox2.TabIndex=9;
            // 
            // textBox1
            // 
            textBox1.BackColor=Color.Transparent;
            textBox1.Location=new Point(366, 240);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(100, 23);
            textBox1.TabIndex=10;
            // 
            // textBox2
            // 
            textBox2.BackColor=Color.Transparent;
            textBox2.Location=new Point(366, 281);
            textBox2.Multiline=true;
            textBox2.Name="textBox2";
            textBox2.Size=new Size(205, 41);
            textBox2.TabIndex=11;
            // 
            // textBox3
            // 
            textBox3.BackColor=Color.Transparent;
            textBox3.Location=new Point(366, 338);
            textBox3.Name="textBox3";
            textBox3.ReadOnly=true;
            textBox3.Size=new Size(205, 23);
            textBox3.TabIndex=12;
            textBox3.Text="abcasdased";
            // 
            // themedButton1
            // 
            themedButton1.Location=new Point(97, 113);
            themedButton1.Name="themedButton1";
            themedButton1.Size=new Size(149, 23);
            themedButton1.TabIndex=13;
            themedButton1.Text="Windows 7";
            themedButton1.UseVisualStyleBackColor=true;
            themedButton1.Click+=themedButton1_Click;
            // 
            // themedButton2
            // 
            themedButton2.Location=new Point(97, 142);
            themedButton2.Name="themedButton2";
            themedButton2.Size=new Size(149, 23);
            themedButton2.TabIndex=14;
            themedButton2.Text="Windows 10";
            themedButton2.UseVisualStyleBackColor=true;
            themedButton2.Click+=themedButton2_Click;
            // 
            // themedButton3
            // 
            themedButton3.Location=new Point(97, 171);
            themedButton3.Name="themedButton3";
            themedButton3.Size=new Size(149, 23);
            themedButton3.TabIndex=15;
            themedButton3.Text="Windows 11";
            themedButton3.UseVisualStyleBackColor=true;
            themedButton3.Click+=themedButton3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(themedButton3);
            Controls.Add(themedButton2);
            Controls.Add(themedButton1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(checkBox2);
            Controls.Add(listBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private ThemedCheckBox checkBox1;
        private ThemedRadioButton radioButton1;
        private ThemedRadioButton radioButton2;
        private ThemedListBox listBox1;
        private ThemedCheckBox checkBox2;
        private ThemedComboBox comboBox2;
        private ThemedTextBox textBox1;
        private ThemedTextBox textBox2;
        private ThemedTextBox textBox3;
        private ThemedButton themedButton1;
        private ThemedButton themedButton2;
        private ThemedButton themedButton3;
    }
}