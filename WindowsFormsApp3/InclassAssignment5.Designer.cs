namespace WindowsFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_NumofTerms = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn1_Calculate = new System.Windows.Forms.Button();
            this.label1_Output = new System.Windows.Forms.Label();
            this.label1_answer = new System.Windows.Forms.Label();
            this.label1_userNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_NumofTerms
            // 
            this.label1_NumofTerms.AutoSize = true;
            this.label1_NumofTerms.Location = new System.Drawing.Point(48, 33);
            this.label1_NumofTerms.Name = "label1_NumofTerms";
            this.label1_NumofTerms.Size = new System.Drawing.Size(113, 17);
            this.label1_NumofTerms.TabIndex = 0;
            this.label1_NumofTerms.Text = "Enter # of terms:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btn1_Calculate
            // 
            this.btn1_Calculate.Location = new System.Drawing.Point(51, 112);
            this.btn1_Calculate.Name = "btn1_Calculate";
            this.btn1_Calculate.Size = new System.Drawing.Size(93, 39);
            this.btn1_Calculate.TabIndex = 2;
            this.btn1_Calculate.Text = "Calculate";
            this.btn1_Calculate.UseVisualStyleBackColor = true;
            this.btn1_Calculate.Click += new System.EventHandler(this.btn1_Calculate_Click);
            // 
            // label1_Output
            // 
            this.label1_Output.AutoSize = true;
            this.label1_Output.Location = new System.Drawing.Point(48, 200);
            this.label1_Output.Name = "label1_Output";
            this.label1_Output.Size = new System.Drawing.Size(189, 17);
            this.label1_Output.TabIndex = 3;
            this.label1_Output.Text = "Approximate value of PI after";
            // 
            // label1_answer
            // 
            this.label1_answer.AutoSize = true;
            this.label1_answer.Location = new System.Drawing.Point(48, 231);
            this.label1_answer.Name = "label1_answer";
            this.label1_answer.Size = new System.Drawing.Size(0, 17);
            this.label1_answer.TabIndex = 5;
            // 
            // label1_userNum
            // 
            this.label1_userNum.AutoSize = true;
            this.label1_userNum.Location = new System.Drawing.Point(239, 200);
            this.label1_userNum.Name = "label1_userNum";
            this.label1_userNum.Size = new System.Drawing.Size(0, 17);
            this.label1_userNum.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 527);
            this.Controls.Add(this.label1_answer);
            this.Controls.Add(this.label1_userNum);
            this.Controls.Add(this.label1_Output);
            this.Controls.Add(this.btn1_Calculate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1_NumofTerms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximating PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_NumofTerms;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn1_Calculate;
        private System.Windows.Forms.Label label1_Output;
        private System.Windows.Forms.Label label1_answer;
        private System.Windows.Forms.Label label1_userNum;
    }
}

