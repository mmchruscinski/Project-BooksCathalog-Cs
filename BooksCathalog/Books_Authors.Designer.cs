namespace BooksCathalog
{
    partial class Books_Authors
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
            this.AddAuthor = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.authorlist = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.auhor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddAuthor
            // 
            this.AddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddAuthor.Location = new System.Drawing.Point(486, 97);
            this.AddAuthor.Name = "AddAuthor";
            this.AddAuthor.Size = new System.Drawing.Size(357, 49);
            this.AddAuthor.TabIndex = 27;
            this.AddAuthor.Text = "Add author";
            this.AddAuthor.UseVisualStyleBackColor = true;
            this.AddAuthor.Click += new System.EventHandler(this.Add);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(486, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(357, 49);
            this.button4.TabIndex = 26;
            this.button4.Text = "Change the author";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(486, 656);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(357, 49);
            this.button2.TabIndex = 24;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(486, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 49);
            this.button1.TabIndex = 23;
            this.button1.Text = "Delete the author";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(41, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 39);
            this.label3.TabIndex = 18;
            this.label3.Text = "Authors";
            // 
            // authorlist
            // 
            this.authorlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorlist.FormattingEnabled = true;
            this.authorlist.ItemHeight = 25;
            this.authorlist.Location = new System.Drawing.Point(30, 61);
            this.authorlist.Name = "authorlist";
            this.authorlist.Size = new System.Drawing.Size(432, 629);
            this.authorlist.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(486, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Authors:";
            // 
            // auhor
            // 
            this.auhor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.auhor.Location = new System.Drawing.Point(486, 61);
            this.auhor.Name = "auhor";
            this.auhor.Size = new System.Drawing.Size(357, 30);
            this.auhor.TabIndex = 28;
            this.auhor.TextChanged += new System.EventHandler(this.button4_Click);
            // 
            // Books_Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 722);
            this.Controls.Add(this.auhor);
            this.Controls.Add(this.AddAuthor);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorlist);
            this.Name = "Books_Authors";
            this.Text = "Authors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAuthor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox authorlist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox auhor;
    }
}