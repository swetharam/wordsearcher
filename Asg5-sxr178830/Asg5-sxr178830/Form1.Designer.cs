namespace Asg5_sxr178830
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchbtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.TextBox();
            this.two = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datadisplay = new System.Windows.Forms.ListView();
            this.linenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.line_text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.occurances = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.one);
            this.panel1.Controls.Add(this.two);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.browse);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 287);
            this.panel1.TabIndex = 0;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(815, 132);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(107, 55);
            this.searchbtn.TabIndex = 7;
            this.searchbtn.Text = "SEARCH";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(279, 189);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "CASE SENSITIVE";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "SEARCH TERM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "SEARCH DIRECTORY";
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(279, 64);
            this.one.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(371, 26);
            this.one.TabIndex = 3;
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(279, 127);
            this.two.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(371, 26);
            this.two.TabIndex = 2;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(815, 215);
            this.stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(107, 55);
            this.stop.TabIndex = 1;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(815, 49);
            this.browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(107, 55);
            this.browse.TabIndex = 0;
            this.browse.Text = "BROWSE";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datadisplay);
            this.panel2.Controls.Add(this.occurances);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Location = new System.Drawing.Point(3, 296);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 309);
            this.panel2.TabIndex = 1;
            // 
            // datadisplay
            // 
            this.datadisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.datadisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.linenum,
            this.line_text});
            this.datadisplay.Location = new System.Drawing.Point(0, 1);
            this.datadisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datadisplay.Name = "datadisplay";
            this.datadisplay.Size = new System.Drawing.Size(941, 283);
            this.datadisplay.TabIndex = 2;
            this.datadisplay.UseCompatibleStateImageBehavior = false;
            this.datadisplay.View = System.Windows.Forms.View.Details;
            // 
            // linenum
            // 
            this.linenum.Text = "Line Number";
            this.linenum.Width = 142;
            // 
            // line_text
            // 
            this.line_text.Text = "Text";
            this.line_text.Width = 468;
            // 
            // occurances
            // 
            this.occurances.Location = new System.Drawing.Point(0, 0);
            this.occurances.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.occurances.Name = "occurances";
            this.occurances.Size = new System.Drawing.Size(941, 284);
            this.occurances.TabIndex = 1;
            this.occurances.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 287);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(943, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "SearchItUp";
            this.TransparencyKey = System.Drawing.Color.BlanchedAlmond;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox one;
        private System.Windows.Forms.TextBox two;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.RichTextBox occurances;
        private System.Windows.Forms.ListView datadisplay;
        private System.Windows.Forms.ColumnHeader linenum;
        private System.Windows.Forms.ColumnHeader line_text;
    }
}

