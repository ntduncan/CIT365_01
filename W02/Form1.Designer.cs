namespace W02
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.plusSign = new System.Windows.Forms.Label();
            this.minusSign = new System.Windows.Forms.Label();
            this.plusLeft = new System.Windows.Forms.Label();
            this.plusRight = new System.Windows.Forms.Label();
            this.minusLeft = new System.Windows.Forms.Label();
            this.minusRight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.multLeft = new System.Windows.Forms.Label();
            this.multRight = new System.Windows.Forms.Label();
            this.divLeft = new System.Windows.Forms.Label();
            this.divRight = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.quotiant = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.todaysDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotiant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(153, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // plusSign
            // 
            this.plusSign.AutoSize = true;
            this.plusSign.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusSign.Location = new System.Drawing.Point(118, 56);
            this.plusSign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plusSign.Name = "plusSign";
            this.plusSign.Size = new System.Drawing.Size(26, 28);
            this.plusSign.TabIndex = 2;
            this.plusSign.Text = "+";
            this.plusSign.Click += new System.EventHandler(this.label2_Click);
            // 
            // minusSign
            // 
            this.minusSign.AutoSize = true;
            this.minusSign.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusSign.Location = new System.Drawing.Point(122, 99);
            this.minusSign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minusSign.Name = "minusSign";
            this.minusSign.Size = new System.Drawing.Size(20, 28);
            this.minusSign.TabIndex = 3;
            this.minusSign.Text = "-\r\n";
            // 
            // plusLeft
            // 
            this.plusLeft.AutoSize = true;
            this.plusLeft.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusLeft.Location = new System.Drawing.Point(61, 50);
            this.plusLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plusLeft.Name = "plusLeft";
            this.plusLeft.Size = new System.Drawing.Size(25, 32);
            this.plusLeft.TabIndex = 4;
            this.plusLeft.Text = "?";
            this.plusLeft.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // plusRight
            // 
            this.plusRight.AutoSize = true;
            this.plusRight.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusRight.Location = new System.Drawing.Point(174, 50);
            this.plusRight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plusRight.Name = "plusRight";
            this.plusRight.Size = new System.Drawing.Size(25, 32);
            this.plusRight.TabIndex = 5;
            this.plusRight.Text = "?";
            // 
            // minusLeft
            // 
            this.minusLeft.AutoSize = true;
            this.minusLeft.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusLeft.Location = new System.Drawing.Point(61, 99);
            this.minusLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minusLeft.Name = "minusLeft";
            this.minusLeft.Size = new System.Drawing.Size(25, 32);
            this.minusLeft.TabIndex = 6;
            this.minusLeft.Text = "?";
            // 
            // minusRight
            // 
            this.minusRight.AutoSize = true;
            this.minusRight.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusRight.Location = new System.Drawing.Point(174, 99);
            this.minusRight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minusRight.Name = "minusRight";
            this.minusRight.Size = new System.Drawing.Size(25, 32);
            this.minusRight.TabIndex = 7;
            this.minusRight.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(212, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(212, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(212, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(212, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(121, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "x";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(116, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "÷";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // multLeft
            // 
            this.multLeft.AutoSize = true;
            this.multLeft.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multLeft.Location = new System.Drawing.Point(61, 148);
            this.multLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.multLeft.Name = "multLeft";
            this.multLeft.Size = new System.Drawing.Size(25, 32);
            this.multLeft.TabIndex = 14;
            this.multLeft.Text = "?";
            // 
            // multRight
            // 
            this.multRight.AutoSize = true;
            this.multRight.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multRight.Location = new System.Drawing.Point(174, 149);
            this.multRight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.multRight.Name = "multRight";
            this.multRight.Size = new System.Drawing.Size(25, 32);
            this.multRight.TabIndex = 15;
            this.multRight.Text = "?";
            // 
            // divLeft
            // 
            this.divLeft.AutoSize = true;
            this.divLeft.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divLeft.Location = new System.Drawing.Point(61, 200);
            this.divLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.divLeft.Name = "divLeft";
            this.divLeft.Size = new System.Drawing.Size(25, 32);
            this.divLeft.TabIndex = 16;
            this.divLeft.Text = "?";
            // 
            // divRight
            // 
            this.divRight.AutoSize = true;
            this.divRight.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divRight.Location = new System.Drawing.Point(174, 200);
            this.divRight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.divRight.Name = "divRight";
            this.divRight.Size = new System.Drawing.Size(25, 32);
            this.divRight.TabIndex = 17;
            this.divRight.Text = "?";
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sum.Location = new System.Drawing.Point(257, 50);
            this.sum.Margin = new System.Windows.Forms.Padding(1);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(103, 39);
            this.sum.TabIndex = 1;
            this.sum.ValueChanged += new System.EventHandler(this.checkAnswer_ValueChanged);
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difference.Location = new System.Drawing.Point(257, 104);
            this.difference.Margin = new System.Windows.Forms.Padding(1);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(103, 39);
            this.difference.TabIndex = 2;
            this.difference.ValueChanged += new System.EventHandler(this.checkAnswer_ValueChanged);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.product.Location = new System.Drawing.Point(257, 153);
            this.product.Margin = new System.Windows.Forms.Padding(1);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(103, 39);
            this.product.TabIndex = 3;
            this.product.ValueChanged += new System.EventHandler(this.checkAnswer_ValueChanged);
            // 
            // quotiant
            // 
            this.quotiant.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quotiant.Location = new System.Drawing.Point(257, 200);
            this.quotiant.Margin = new System.Windows.Forms.Padding(1);
            this.quotiant.Name = "quotiant";
            this.quotiant.Size = new System.Drawing.Size(103, 39);
            this.quotiant.TabIndex = 4;
            this.quotiant.ValueChanged += new System.EventHandler(this.checkAnswer_ValueChanged);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(153, 260);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.startButton.Name = "startButton";
            this.startButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startButton.Size = new System.Drawing.Size(113, 35);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(257, 11);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(128, 23);
            this.timeLabel.TabIndex = 18;
            // 
            // todaysDate
            // 
            this.todaysDate.Location = new System.Drawing.Point(4, 5);
            this.todaysDate.Name = "todaysDate";
            this.todaysDate.Size = new System.Drawing.Size(142, 23);
            this.todaysDate.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 305);
            this.Controls.Add(this.todaysDate);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotiant);
            this.Controls.Add(this.product);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.divRight);
            this.Controls.Add(this.divLeft);
            this.Controls.Add(this.multRight);
            this.Controls.Add(this.multLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minusRight);
            this.Controls.Add(this.minusLeft);
            this.Controls.Add(this.plusRight);
            this.Controls.Add(this.plusLeft);
            this.Controls.Add(this.minusSign);
            this.Controls.Add(this.plusSign);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Nate Duncan Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private Label label1;
        private Label plusSign;
        private Label minusSign;
        private Label plusLeft;
        private Label plusRight;
        private Label minusLeft;
        private Label minusRight;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label multLeft;
        private Label multRight;
        private Label divLeft;
        private Label divRight;
        private NumericUpDown sum;
        private NumericUpDown difference;
        private NumericUpDown product;
        private NumericUpDown quotiant;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
        private Label timeLabel;
        private Label todaysDate;
    }
}