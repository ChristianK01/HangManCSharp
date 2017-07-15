namespace HangManGame
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
            this.Hang_Man = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Unknown_Word = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit_Answers = new System.Windows.Forms.GroupBox();
            this.Submit_letter_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Hang_Man.SuspendLayout();
            this.Unknown_Word.SuspendLayout();
            this.Submit_Answers.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hang_Man
            // 
            this.Hang_Man.Controls.Add(this.panel1);
            this.Hang_Man.Location = new System.Drawing.Point(12, 12);
            this.Hang_Man.Name = "Hang_Man";
            this.Hang_Man.Size = new System.Drawing.Size(203, 258);
            this.Hang_Man.TabIndex = 0;
            this.Hang_Man.TabStop = false;
            this.Hang_Man.Text = "Hang Man";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 239);
            this.panel1.TabIndex = 0;
            // 
            // Unknown_Word
            // 
            this.Unknown_Word.Controls.Add(this.label2);
            this.Unknown_Word.Controls.Add(this.label1);
            this.Unknown_Word.Location = new System.Drawing.Point(235, 28);
            this.Unknown_Word.Name = "Unknown_Word";
            this.Unknown_Word.Size = new System.Drawing.Size(284, 133);
            this.Unknown_Word.TabIndex = 1;
            this.Unknown_Word.TabStop = false;
            this.Unknown_Word.Text = "Unknown Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wrong Letters:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word Length:";
            // 
            // Submit_Answers
            // 
            this.Submit_Answers.Controls.Add(this.Submit_letter_box);
            this.Submit_Answers.Controls.Add(this.button1);
            this.Submit_Answers.Location = new System.Drawing.Point(235, 176);
            this.Submit_Answers.Name = "Submit_Answers";
            this.Submit_Answers.Size = new System.Drawing.Size(284, 94);
            this.Submit_Answers.TabIndex = 2;
            this.Submit_Answers.TabStop = false;
            this.Submit_Answers.Text = "Submit Letter";
            // 
            // Submit_letter_box
            // 
            this.Submit_letter_box.Location = new System.Drawing.Point(126, 65);
            this.Submit_letter_box.MaxLength = 1;
            this.Submit_letter_box.Name = "Submit_letter_box";
            this.Submit_letter_box.Size = new System.Drawing.Size(44, 20);
            this.Submit_letter_box.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit Letter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 287);
            this.Controls.Add(this.Submit_Answers);
            this.Controls.Add(this.Unknown_Word);
            this.Controls.Add(this.Hang_Man);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HangMan";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Hang_Man.ResumeLayout(false);
            this.Unknown_Word.ResumeLayout(false);
            this.Unknown_Word.PerformLayout();
            this.Submit_Answers.ResumeLayout(false);
            this.Submit_Answers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Hang_Man;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Unknown_Word;
        private System.Windows.Forms.GroupBox Submit_Answers;
        private System.Windows.Forms.TextBox Submit_letter_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

