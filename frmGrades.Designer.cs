namespace Grades
{
    partial class frmGrades
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtBxResults = new System.Windows.Forms.RichTextBox();
            this.txtBxFirst = new System.Windows.Forms.TextBox();
            this.txtBxLast = new System.Windows.Forms.TextBox();
            this.txtBxGrade = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(58, 30);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(29, 13);
            this.lblFirst.TabIndex = 1;
            this.lblFirst.Text = "&First:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(58, 77);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(30, 13);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "&Last:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(54, 115);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(39, 13);
            this.lblGrade.TabIndex = 4;
            this.lblGrade.Text = "&Grade:";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(56, 153);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(45, 13);
            this.lblResults.TabIndex = 6;
            this.lblResults.Text = "Results:";
            // 
            // txtBxResults
            // 
            this.txtBxResults.Location = new System.Drawing.Point(116, 150);
            this.txtBxResults.Name = "txtBxResults";
            this.txtBxResults.ReadOnly = true;
            this.txtBxResults.Size = new System.Drawing.Size(274, 96);
            this.txtBxResults.TabIndex = 7;
            this.txtBxResults.TabStop = false;
            this.txtBxResults.Text = "";
            // 
            // txtBxFirst
            // 
            this.txtBxFirst.Location = new System.Drawing.Point(116, 27);
            this.txtBxFirst.Name = "txtBxFirst";
            this.txtBxFirst.Size = new System.Drawing.Size(100, 20);
            this.txtBxFirst.TabIndex = 0;
            // 
            // txtBxLast
            // 
            this.txtBxLast.Location = new System.Drawing.Point(116, 70);
            this.txtBxLast.Name = "txtBxLast";
            this.txtBxLast.Size = new System.Drawing.Size(100, 20);
            this.txtBxLast.TabIndex = 3;
            // 
            // txtBxGrade
            // 
            this.txtBxGrade.Location = new System.Drawing.Point(116, 112);
            this.txtBxGrade.Name = "txtBxGrade";
            this.txtBxGrade.Size = new System.Drawing.Size(100, 20);
            this.txtBxGrade.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 179);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(26, 208);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 23);
            this.btnSummary.TabIndex = 9;
            this.btnSummary.Text = "&Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(27, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 273);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBxGrade);
            this.Controls.Add(this.txtBxLast);
            this.Controls.Add(this.txtBxFirst);
            this.Controls.Add(this.txtBxResults);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Name = "frmGrades";
            this.Text = "Grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.RichTextBox txtBxResults;
        private System.Windows.Forms.TextBox txtBxFirst;
        private System.Windows.Forms.TextBox txtBxLast;
        private System.Windows.Forms.TextBox txtBxGrade;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnExit;
    }
}

