namespace SPAN
{
    partial class IcpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IcpForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splYes = new System.Windows.Forms.RadioButton();
            this.splNo = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hrsNo = new System.Windows.Forms.RadioButton();
            this.hrsYes = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nochYes = new System.Windows.Forms.RadioButton();
            this.nochNo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 191);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "ICP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "CHANGE IN HOURS?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "NO CHANGE?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splYes);
            this.panel1.Controls.Add(this.splNo);
            this.panel1.Location = new System.Drawing.Point(212, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 23);
            this.panel1.TabIndex = 31;
            // 
            // splYes
            // 
            this.splYes.AutoSize = true;
            this.splYes.Checked = true;
            this.splYes.Location = new System.Drawing.Point(3, 3);
            this.splYes.Name = "splYes";
            this.splYes.Size = new System.Drawing.Size(43, 17);
            this.splYes.TabIndex = 8;
            this.splYes.TabStop = true;
            this.splYes.Text = "Yes";
            this.splYes.UseVisualStyleBackColor = true;
            this.splYes.CheckedChanged += new System.EventHandler(this.splYes_CheckedChanged);
            // 
            // splNo
            // 
            this.splNo.AutoSize = true;
            this.splNo.Location = new System.Drawing.Point(52, 3);
            this.splNo.Name = "splNo";
            this.splNo.Size = new System.Drawing.Size(39, 17);
            this.splNo.TabIndex = 14;
            this.splNo.Text = "No";
            this.splNo.UseVisualStyleBackColor = true;
            this.splNo.CheckedChanged += new System.EventHandler(this.splNo_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hrsNo);
            this.panel2.Controls.Add(this.hrsYes);
            this.panel2.Location = new System.Drawing.Point(212, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 23);
            this.panel2.TabIndex = 32;
            // 
            // hrsNo
            // 
            this.hrsNo.AutoSize = true;
            this.hrsNo.Location = new System.Drawing.Point(52, 3);
            this.hrsNo.Name = "hrsNo";
            this.hrsNo.Size = new System.Drawing.Size(39, 17);
            this.hrsNo.TabIndex = 16;
            this.hrsNo.TabStop = true;
            this.hrsNo.Text = "No";
            this.hrsNo.UseVisualStyleBackColor = true;
            this.hrsNo.CheckedChanged += new System.EventHandler(this.hrsNo_CheckedChanged);
            // 
            // hrsYes
            // 
            this.hrsYes.AutoSize = true;
            this.hrsYes.Location = new System.Drawing.Point(3, 3);
            this.hrsYes.Name = "hrsYes";
            this.hrsYes.Size = new System.Drawing.Size(43, 17);
            this.hrsYes.TabIndex = 13;
            this.hrsYes.TabStop = true;
            this.hrsYes.Text = "Yes";
            this.hrsYes.UseVisualStyleBackColor = true;
            this.hrsYes.CheckedChanged += new System.EventHandler(this.hrsYes_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nochYes);
            this.panel3.Controls.Add(this.nochNo);
            this.panel3.Location = new System.Drawing.Point(212, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 25);
            this.panel3.TabIndex = 33;
            // 
            // nochYes
            // 
            this.nochYes.AutoSize = true;
            this.nochYes.Location = new System.Drawing.Point(3, 3);
            this.nochYes.Name = "nochYes";
            this.nochYes.Size = new System.Drawing.Size(43, 17);
            this.nochYes.TabIndex = 11;
            this.nochYes.TabStop = true;
            this.nochYes.Text = "Yes";
            this.nochYes.UseVisualStyleBackColor = true;
            this.nochYes.CheckedChanged += new System.EventHandler(this.nochYes_CheckedChanged);
            // 
            // nochNo
            // 
            this.nochNo.AutoSize = true;
            this.nochNo.Location = new System.Drawing.Point(52, 3);
            this.nochNo.Name = "nochNo";
            this.nochNo.Size = new System.Drawing.Size(39, 17);
            this.nochNo.TabIndex = 15;
            this.nochNo.TabStop = true;
            this.nochNo.Text = "No";
            this.nochNo.UseVisualStyleBackColor = true;
            this.nochNo.CheckedChanged += new System.EventHandler(this.nochNo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "CHANGE IN SPL?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(620, 394);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(168, 44);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Prev";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(86, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IcpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IcpForm";
            this.Text = "Oregon Department of Human Services";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton splYes;
        private System.Windows.Forms.RadioButton splNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton hrsNo;
        private System.Windows.Forms.RadioButton hrsYes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton nochYes;
        private System.Windows.Forms.RadioButton nochNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}