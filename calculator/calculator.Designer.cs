
namespace WinFormsApp1
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.ClearAndResetButton = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.PlusButtom = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.LabelCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // n7
            // 
            this.n7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n7.Location = new System.Drawing.Point(12, 139);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(50, 57);
            this.n7.TabIndex = 0;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // n8
            // 
            this.n8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n8.Location = new System.Drawing.Point(68, 139);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(50, 57);
            this.n8.TabIndex = 0;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // n9
            // 
            this.n9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n9.Location = new System.Drawing.Point(124, 139);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(50, 57);
            this.n9.TabIndex = 0;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DivisionButton.Location = new System.Drawing.Point(180, 139);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(50, 57);
            this.DivisionButton.TabIndex = 0;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // ClearAndResetButton
            // 
            this.ClearAndResetButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearAndResetButton.Location = new System.Drawing.Point(236, 139);
            this.ClearAndResetButton.Name = "ClearAndResetButton";
            this.ClearAndResetButton.Size = new System.Drawing.Size(50, 57);
            this.ClearAndResetButton.TabIndex = 0;
            this.ClearAndResetButton.Text = "C/E";
            this.ClearAndResetButton.UseVisualStyleBackColor = true;
            this.ClearAndResetButton.Click += new System.EventHandler(this.ClearAndResetButton_Click);
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n4.Location = new System.Drawing.Point(12, 203);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(50, 57);
            this.n4.TabIndex = 0;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n5.Location = new System.Drawing.Point(68, 203);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(50, 57);
            this.n5.TabIndex = 0;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n6.Location = new System.Drawing.Point(124, 203);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(50, 57);
            this.n6.TabIndex = 0;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MultiplicationButton.Location = new System.Drawing.Point(180, 203);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(50, 57);
            this.MultiplicationButton.TabIndex = 0;
            this.MultiplicationButton.Text = "×";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackspaceButton.Location = new System.Drawing.Point(236, 203);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(50, 57);
            this.BackspaceButton.TabIndex = 0;
            this.BackspaceButton.Text = "⌫";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            this.BackspaceButton.Click += new System.EventHandler(this.BackspaceButtonClick);
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n1.Location = new System.Drawing.Point(12, 266);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(50, 57);
            this.n1.TabIndex = 0;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n2.Location = new System.Drawing.Point(68, 266);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(50, 57);
            this.n2.TabIndex = 0;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n3.Location = new System.Drawing.Point(124, 266);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(50, 57);
            this.n3.TabIndex = 0;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // MinusButton
            // 
            this.MinusButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinusButton.Location = new System.Drawing.Point(180, 266);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(50, 57);
            this.MinusButton.TabIndex = 0;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // n0
            // 
            this.n0.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n0.Location = new System.Drawing.Point(12, 330);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(106, 57);
            this.n0.TabIndex = 0;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.ButtonClick);
            // 
            // DotButton
            // 
            this.DotButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DotButton.Location = new System.Drawing.Point(124, 330);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(50, 57);
            this.DotButton.TabIndex = 0;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // PlusButtom
            // 
            this.PlusButtom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlusButtom.Location = new System.Drawing.Point(180, 330);
            this.PlusButtom.Name = "PlusButtom";
            this.PlusButtom.Size = new System.Drawing.Size(50, 57);
            this.PlusButtom.TabIndex = 0;
            this.PlusButtom.Text = "+";
            this.PlusButtom.UseVisualStyleBackColor = true;
            this.PlusButtom.Click += new System.EventHandler(this.OperatorClick);
            // 
            // EqualButton
            // 
            this.EqualButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EqualButton.Location = new System.Drawing.Point(236, 266);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(50, 120);
            this.EqualButton.TabIndex = 0;
            this.EqualButton.Text = " =";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButtonClick);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResultTextBox.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultTextBox.Location = new System.Drawing.Point(13, 77);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(274, 56);
            this.ResultTextBox.TabIndex = 1;
            this.ResultTextBox.Text = "0";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelCurrentOperation
            // 
            this.LabelCurrentOperation.AutoSize = true;
            this.LabelCurrentOperation.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelCurrentOperation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LabelCurrentOperation.Location = new System.Drawing.Point(13, 28);
            this.LabelCurrentOperation.Name = "LabelCurrentOperation";
            this.LabelCurrentOperation.Size = new System.Drawing.Size(0, 46);
            this.LabelCurrentOperation.TabIndex = 2;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 392);
            this.Controls.Add(this.LabelCurrentOperation);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.BackspaceButton);
            this.Controls.Add(this.ClearAndResetButton);
            this.Controls.Add(this.PlusButtom);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button ClearAndResetButton;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button PlusButtom;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label LabelCurrentOperation;
    }
}

