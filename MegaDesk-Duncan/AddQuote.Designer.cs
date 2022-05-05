namespace MegaDesk_Duncan
{
    partial class AddQuote
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
            this.btnAddNewQuote = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.inputWidth = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.selectorSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.comboBoxRushOrder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.deskSizeGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.deskSizeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewQuote
            // 
            this.btnAddNewQuote.Location = new System.Drawing.Point(176, 367);
            this.btnAddNewQuote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNewQuote.Name = "btnAddNewQuote";
            this.btnAddNewQuote.Size = new System.Drawing.Size(236, 60);
            this.btnAddNewQuote.TabIndex = 0;
            this.btnAddNewQuote.Text = "Add Quote";
            this.btnAddNewQuote.UseVisualStyleBackColor = true;
            this.btnAddNewQuote.Click += new System.EventHandler(this.btnAddNewQuote_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(428, 367);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(236, 60);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // inputWidth
            // 
            this.inputWidth.Location = new System.Drawing.Point(154, 48);
            this.inputWidth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.inputWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.inputWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.inputWidth.Name = "inputWidth";
            this.inputWidth.Size = new System.Drawing.Size(156, 31);
            this.inputWidth.TabIndex = 2;
            this.inputWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(18, 54);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(104, 25);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "Width (in)";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(18, 106);
            this.labelDepth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(106, 25);
            this.labelDepth.TabIndex = 5;
            this.labelDepth.Text = "Depth (in)";
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.Location = new System.Drawing.Point(154, 102);
            this.numericUpDownDepth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDownDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDownDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownDepth.Name = "numericUpDownDepth";
            this.numericUpDownDepth.Size = new System.Drawing.Size(156, 31);
            this.numericUpDownDepth.TabIndex = 4;
            this.numericUpDownDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownDepth_KeyPress);
            // 
            // selectorSurfaceMaterial
            // 
            this.selectorSurfaceMaterial.FormattingEnabled = true;
            this.selectorSurfaceMaterial.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.selectorSurfaceMaterial.Location = new System.Drawing.Point(603, 171);
            this.selectorSurfaceMaterial.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.selectorSurfaceMaterial.Name = "selectorSurfaceMaterial";
            this.selectorSurfaceMaterial.Size = new System.Drawing.Size(156, 33);
            this.selectorSurfaceMaterial.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Surface Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer Full Name";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(284, 31);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(446, 31);
            this.textBoxCustomerName.TabIndex = 9;
            // 
            // comboBoxRushOrder
            // 
            this.comboBoxRushOrder.FormattingEnabled = true;
            this.comboBoxRushOrder.Items.AddRange(new object[] {
            "Standard (14 Day)",
            "3 Day",
            "5 Day",
            "7 Day"});
            this.comboBoxRushOrder.Location = new System.Drawing.Point(163, 271);
            this.comboBoxRushOrder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxRushOrder.Name = "comboBoxRushOrder";
            this.comboBoxRushOrder.Size = new System.Drawing.Size(238, 33);
            this.comboBoxRushOrder.TabIndex = 10;
            this.comboBoxRushOrder.Text = "Standard (14 Day)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Delivary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "# of Drawers";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(603, 113);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(156, 31);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // deskSizeGroup
            // 
            this.deskSizeGroup.Controls.Add(this.labelWidth);
            this.deskSizeGroup.Controls.Add(this.inputWidth);
            this.deskSizeGroup.Controls.Add(this.labelDepth);
            this.deskSizeGroup.Controls.Add(this.numericUpDownDepth);
            this.deskSizeGroup.Location = new System.Drawing.Point(48, 88);
            this.deskSizeGroup.Name = "deskSizeGroup";
            this.deskSizeGroup.Size = new System.Drawing.Size(336, 154);
            this.deskSizeGroup.TabIndex = 14;
            this.deskSizeGroup.TabStop = false;
            this.deskSizeGroup.Text = "Desk Dimensions";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 456);
            this.Controls.Add(this.deskSizeGroup);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRushOrder);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectorSurfaceMaterial);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddNewQuote);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.deskSizeGroup.ResumeLayout(false);
            this.deskSizeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewQuote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown inputWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.ComboBox selectorSurfaceMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.ComboBox comboBoxRushOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox deskSizeGroup;
    }
}