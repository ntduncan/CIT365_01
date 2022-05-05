namespace MegaDesk_Duncan
{
    partial class MainMenu
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
            this.btnSearchQuote = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewAllQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewQuote
            // 
            this.btnAddNewQuote.Location = new System.Drawing.Point(12, 46);
            this.btnAddNewQuote.Name = "btnAddNewQuote";
            this.btnAddNewQuote.Size = new System.Drawing.Size(391, 71);
            this.btnAddNewQuote.TabIndex = 0;
            this.btnAddNewQuote.Text = "Add New Quote";
            this.btnAddNewQuote.UseVisualStyleBackColor = true;
            this.btnAddNewQuote.Click += new System.EventHandler(this.btnAddNewQuote_Click);
            // 
            // btnSearchQuote
            // 
            this.btnSearchQuote.Location = new System.Drawing.Point(12, 242);
            this.btnSearchQuote.Name = "btnSearchQuote";
            this.btnSearchQuote.Size = new System.Drawing.Size(391, 71);
            this.btnSearchQuote.TabIndex = 1;
            this.btnSearchQuote.Text = "Seach Quote";
            this.btnSearchQuote.UseVisualStyleBackColor = true;
            this.btnSearchQuote.Click += new System.EventHandler(this.btnSearchQuotes_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(391, 71);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewAllQuotes
            // 
            this.btnViewAllQuotes.Location = new System.Drawing.Point(12, 144);
            this.btnViewAllQuotes.Name = "btnViewAllQuotes";
            this.btnViewAllQuotes.Size = new System.Drawing.Size(391, 71);
            this.btnViewAllQuotes.TabIndex = 3;
            this.btnViewAllQuotes.Text = "View Quotes";
            this.btnViewAllQuotes.UseVisualStyleBackColor = true;
            this.btnViewAllQuotes.Click += new System.EventHandler(this.btnViewAllQuotes_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewAllQuotes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchQuote);
            this.Controls.Add(this.btnAddNewQuote);
            this.Name = "MainMenu";
            this.Text = "Mega Desk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewQuote;
        private System.Windows.Forms.Button btnSearchQuote;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewAllQuotes;
    }
}

