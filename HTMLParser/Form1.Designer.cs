namespace HTMLParser
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
            this.listTitles = new System.Windows.Forms.ListBox();
            this.StartPoint = new System.Windows.Forms.Label();
            this.numericStart = new System.Windows.Forms.NumericUpDown();
            this.EndPoint = new System.Windows.Forms.Label();
            this.numericEnd = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // listTitles
            // 
            this.listTitles.FormattingEnabled = true;
            this.listTitles.ItemHeight = 16;
            this.listTitles.Location = new System.Drawing.Point(12, 12);
            this.listTitles.Name = "listTitles";
            this.listTitles.Size = new System.Drawing.Size(613, 340);
            this.listTitles.TabIndex = 0;
            // 
            // StartPoint
            // 
            this.StartPoint.AutoSize = true;
            this.StartPoint.Location = new System.Drawing.Point(682, 37);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Size = new System.Drawing.Size(70, 17);
            this.StartPoint.TabIndex = 1;
            this.StartPoint.Text = "StartPoint";
            // 
            // numericStart
            // 
            this.numericStart.Location = new System.Drawing.Point(760, 35);
            this.numericStart.Name = "numericStart";
            this.numericStart.Size = new System.Drawing.Size(120, 22);
            this.numericStart.TabIndex = 2;
            // 
            // EndPoint
            // 
            this.EndPoint.AutoSize = true;
            this.EndPoint.Location = new System.Drawing.Point(682, 95);
            this.EndPoint.Name = "EndPoint";
            this.EndPoint.Size = new System.Drawing.Size(65, 17);
            this.EndPoint.TabIndex = 3;
            this.EndPoint.Text = "EndPoint";
            // 
            // numericEnd
            // 
            this.numericEnd.Location = new System.Drawing.Point(760, 95);
            this.numericEnd.Name = "numericEnd";
            this.numericEnd.Size = new System.Drawing.Size(120, 22);
            this.numericEnd.TabIndex = 4;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(685, 162);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(195, 37);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(685, 225);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(195, 37);
            this.buttonEnd.TabIndex = 6;
            this.buttonEnd.Text = "Stop";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(685, 294);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(195, 41);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 402);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericEnd);
            this.Controls.Add(this.EndPoint);
            this.Controls.Add(this.numericStart);
            this.Controls.Add(this.StartPoint);
            this.Controls.Add(this.listTitles);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listTitles;
        private System.Windows.Forms.Label StartPoint;
        private System.Windows.Forms.NumericUpDown numericStart;
        private System.Windows.Forms.Label EndPoint;
        private System.Windows.Forms.NumericUpDown numericEnd;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button Exit;
    }
}

