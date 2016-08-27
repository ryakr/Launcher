namespace WindowsFormsApplication1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.First = new System.Windows.Forms.Button();
            this.Second = new System.Windows.Forms.Button();
            this.Third = new System.Windows.Forms.Button();
            this.Sixth = new System.Windows.Forms.Button();
            this.Fith = new System.Windows.Forms.Button();
            this.Fourth = new System.Windows.Forms.Button();
            this.Seventh = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(173, 462);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // First
            // 
            this.First.BackColor = System.Drawing.Color.Transparent;
            this.First.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.First.Location = new System.Drawing.Point(23, 21);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(143, 31);
            this.First.TabIndex = 1;
            this.First.Text = "button1";
            this.First.UseVisualStyleBackColor = false;
            this.First.Click += new System.EventHandler(this.First_Click);
            // 
            // Second
            // 
            this.Second.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Second.Location = new System.Drawing.Point(23, 71);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(143, 31);
            this.Second.TabIndex = 2;
            this.Second.Text = "button2";
            this.Second.UseVisualStyleBackColor = true;
            // 
            // Third
            // 
            this.Third.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Third.Location = new System.Drawing.Point(23, 122);
            this.Third.Name = "Third";
            this.Third.Size = new System.Drawing.Size(143, 31);
            this.Third.TabIndex = 3;
            this.Third.Text = "button3";
            this.Third.UseVisualStyleBackColor = true;
            // 
            // Sixth
            // 
            this.Sixth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sixth.Location = new System.Drawing.Point(23, 272);
            this.Sixth.Name = "Sixth";
            this.Sixth.Size = new System.Drawing.Size(143, 31);
            this.Sixth.TabIndex = 6;
            this.Sixth.Text = "button4";
            this.Sixth.UseVisualStyleBackColor = true;
            // 
            // Fith
            // 
            this.Fith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fith.Location = new System.Drawing.Point(23, 221);
            this.Fith.Name = "Fith";
            this.Fith.Size = new System.Drawing.Size(143, 31);
            this.Fith.TabIndex = 5;
            this.Fith.Text = "button5";
            this.Fith.UseVisualStyleBackColor = true;
            // 
            // Fourth
            // 
            this.Fourth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fourth.Location = new System.Drawing.Point(23, 171);
            this.Fourth.Name = "Fourth";
            this.Fourth.Size = new System.Drawing.Size(143, 31);
            this.Fourth.TabIndex = 4;
            this.Fourth.Text = "button6";
            this.Fourth.UseVisualStyleBackColor = true;
            // 
            // Seventh
            // 
            this.Seventh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seventh.Location = new System.Drawing.Point(23, 323);
            this.Seventh.Name = "Seventh";
            this.Seventh.Size = new System.Drawing.Size(143, 31);
            this.Seventh.TabIndex = 9;
            this.Seventh.Text = "button7";
            this.Seventh.UseVisualStyleBackColor = true;
            // 
            // Eight
            // 
            this.Eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight.Location = new System.Drawing.Point(23, 372);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(143, 31);
            this.Eight.TabIndex = 8;
            this.Eight.Text = "button8";
            this.Eight.UseVisualStyleBackColor = true;
            // 
            // Nine
            // 
            this.Nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nine.Location = new System.Drawing.Point(23, 421);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(143, 31);
            this.Nine.TabIndex = 7;
            this.Nine.Text = "button9";
            this.Nine.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(191, 450);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(427, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(192, 21);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(426, 423);
            this.webBrowser1.TabIndex = 11;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 486);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Seventh);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Sixth);
            this.Controls.Add(this.Fith);
            this.Controls.Add(this.Fourth);
            this.Controls.Add(this.Third);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.First);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button First;
        private System.Windows.Forms.Button Second;
        private System.Windows.Forms.Button Third;
        private System.Windows.Forms.Button Sixth;
        private System.Windows.Forms.Button Fith;
        private System.Windows.Forms.Button Fourth;
        private System.Windows.Forms.Button Seventh;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
    
}

