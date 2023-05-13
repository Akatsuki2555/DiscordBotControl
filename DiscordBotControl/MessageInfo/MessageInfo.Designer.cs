using System.ComponentModel;

namespace DiscordBotControl {
    partial class MessageInfo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.Label();
            this.creationDate = new System.Windows.Forms.Label();
            this.lastEditDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 168);
            this.textBox1.TabIndex = 0;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(11, 192);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(246, 18);
            this.author.TabIndex = 1;
            this.author.Text = "label1";
            // 
            // creationDate
            // 
            this.creationDate.Location = new System.Drawing.Point(11, 210);
            this.creationDate.Name = "creationDate";
            this.creationDate.Size = new System.Drawing.Size(246, 17);
            this.creationDate.TabIndex = 2;
            this.creationDate.Text = "label1";
            // 
            // lastEditDate
            // 
            this.lastEditDate.Location = new System.Drawing.Point(11, 227);
            this.lastEditDate.Name = "lastEditDate";
            this.lastEditDate.Size = new System.Drawing.Size(246, 18);
            this.lastEditDate.TabIndex = 3;
            this.lastEditDate.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(263, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Embeds";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(263, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 147);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(263, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Attachments";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(263, 210);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(280, 147);
            this.listBox2.TabIndex = 8;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // MessageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 368);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lastEditDate);
            this.Controls.Add(this.creationDate);
            this.Controls.Add(this.author);
            this.Controls.Add(this.textBox1);
            this.Name = "MessageInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageInfo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label creationDate;

        private System.Windows.Forms.Label lastEditDate;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}