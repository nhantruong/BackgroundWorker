namespace BackgroundWorker
{
    partial class BackgroundWorker
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
            this.resultLable1 = new System.Windows.Forms.Label();
            this.startAsyncButton1 = new System.Windows.Forms.Button();
            this.cancelAsyncButton = new System.Windows.Forms.Button();
            this.bgw_delay5 = new System.ComponentModel.BackgroundWorker();
            this.resultLable2 = new System.Windows.Forms.Label();
            this.startAsyncButton2 = new System.Windows.Forms.Button();
            this.bgw_delay10 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // resultLable1
            // 
            this.resultLable1.AutoSize = true;
            this.resultLable1.Location = new System.Drawing.Point(16, 27);
            this.resultLable1.Name = "resultLable1";
            this.resultLable1.Size = new System.Drawing.Size(64, 13);
            this.resultLable1.TabIndex = 0;
            this.resultLable1.Text = "resultLable1";
            // 
            // startAsyncButton1
            // 
            this.startAsyncButton1.Location = new System.Drawing.Point(16, 54);
            this.startAsyncButton1.Name = "startAsyncButton1";
            this.startAsyncButton1.Size = new System.Drawing.Size(75, 23);
            this.startAsyncButton1.TabIndex = 1;
            this.startAsyncButton1.Text = "Start 1";
            this.startAsyncButton1.UseVisualStyleBackColor = true;
            this.startAsyncButton1.Click += new System.EventHandler(this.startAsyncButton_Click);
            // 
            // cancelAsyncButton
            // 
            this.cancelAsyncButton.Location = new System.Drawing.Point(262, 54);
            this.cancelAsyncButton.Name = "cancelAsyncButton";
            this.cancelAsyncButton.Size = new System.Drawing.Size(75, 23);
            this.cancelAsyncButton.TabIndex = 2;
            this.cancelAsyncButton.Text = "Cancel";
            this.cancelAsyncButton.UseVisualStyleBackColor = true;
            this.cancelAsyncButton.Click += new System.EventHandler(this.cancelAsyncButton_Click);
            // 
            // bgw_delay5
            // 
            this.bgw_delay5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.bgw_delay5.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.bgw_delay5.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // resultLable2
            // 
            this.resultLable2.AutoSize = true;
            this.resultLable2.Location = new System.Drawing.Point(155, 27);
            this.resultLable2.Name = "resultLable2";
            this.resultLable2.Size = new System.Drawing.Size(64, 13);
            this.resultLable2.TabIndex = 0;
            this.resultLable2.Text = "resultLable2";
            // 
            // startAsyncButton2
            // 
            this.startAsyncButton2.Location = new System.Drawing.Point(150, 54);
            this.startAsyncButton2.Name = "startAsyncButton2";
            this.startAsyncButton2.Size = new System.Drawing.Size(75, 23);
            this.startAsyncButton2.TabIndex = 1;
            this.startAsyncButton2.Text = "Start 2";
            this.startAsyncButton2.UseVisualStyleBackColor = true;
            this.startAsyncButton2.Click += new System.EventHandler(this.startAsyncButton2_Click);
            // 
            // bgw_delay10
            // 
            this.bgw_delay10.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_delay10_DoWork);
            this.bgw_delay10.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_delay10_ProgressChanged);
            this.bgw_delay10.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_delay10_RunWorkerCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 194);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BackgroundWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 280);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelAsyncButton);
            this.Controls.Add(this.startAsyncButton2);
            this.Controls.Add(this.startAsyncButton1);
            this.Controls.Add(this.resultLable2);
            this.Controls.Add(this.resultLable1);
            this.Name = "BackgroundWorker";
            this.Text = "BackgroundWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLable1;
        private System.Windows.Forms.Button startAsyncButton1;
        private System.Windows.Forms.Button cancelAsyncButton;
        private System.ComponentModel.BackgroundWorker bgw_delay5;
        private System.Windows.Forms.Label resultLable2;
        private System.Windows.Forms.Button startAsyncButton2;
        private System.ComponentModel.BackgroundWorker bgw_delay10;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

