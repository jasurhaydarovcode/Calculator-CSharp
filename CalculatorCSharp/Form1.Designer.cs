
namespace CalculatorCSharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.8F);
            this.textBox_Result.Location = new System.Drawing.Point(19, 80);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(439, 69);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.operator_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(126, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(240, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 64);
            this.button3.TabIndex = 1;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(354, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 64);
            this.button4.TabIndex = 1;
            this.button4.Text = "=";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button5.Location = new System.Drawing.Point(12, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 64);
            this.button5.TabIndex = 1;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button6.Location = new System.Drawing.Point(126, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 64);
            this.button6.TabIndex = 1;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button7.Location = new System.Drawing.Point(240, 242);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 64);
            this.button7.TabIndex = 1;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.OrangeRed;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button8.ForeColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(354, 242);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 64);
            this.button8.TabIndex = 1;
            this.button8.Text = "/";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.operator_click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button9.Location = new System.Drawing.Point(12, 312);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 64);
            this.button9.TabIndex = 1;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button10.Location = new System.Drawing.Point(126, 312);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(108, 64);
            this.button10.TabIndex = 1;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button11.Location = new System.Drawing.Point(240, 312);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(108, 64);
            this.button11.TabIndex = 1;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.OrangeRed;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button12.ForeColor = System.Drawing.Color.Transparent;
            this.button12.Location = new System.Drawing.Point(354, 312);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(108, 64);
            this.button12.TabIndex = 1;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.operator_click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button13.Location = new System.Drawing.Point(12, 382);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(108, 64);
            this.button13.TabIndex = 1;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button14.Location = new System.Drawing.Point(126, 382);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(108, 64);
            this.button14.TabIndex = 1;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button15.Location = new System.Drawing.Point(240, 382);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(108, 64);
            this.button15.TabIndex = 1;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button_click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.OrangeRed;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button16.ForeColor = System.Drawing.Color.Transparent;
            this.button16.Location = new System.Drawing.Point(354, 452);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(108, 64);
            this.button16.TabIndex = 1;
            this.button16.Text = "+";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.operator_click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button18.Location = new System.Drawing.Point(12, 452);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(222, 64);
            this.button18.TabIndex = 1;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button_click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button19.Location = new System.Drawing.Point(240, 452);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(108, 64);
            this.button19.TabIndex = 1;
            this.button19.Text = ".";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button_click);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.labelCurrentOperation.Location = new System.Drawing.Point(12, 19);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 38);
            this.labelCurrentOperation.TabIndex = 2;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.OrangeRed;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.button17.ForeColor = System.Drawing.Color.Transparent;
            this.button17.Location = new System.Drawing.Point(354, 382);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(108, 64);
            this.button17.TabIndex = 1;
            this.button17.Text = "-";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.operator_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 529);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Result);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.Button button17;
    }
}

