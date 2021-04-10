
namespace NFC_Project
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deviceBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.btnWrite1 = new System.Windows.Forms.Button();
            this.btnRead1 = new System.Windows.Forms.Button();
            this.btnGetUID1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblData1 = new System.Windows.Forms.Label();
            this.lblUID1 = new System.Windows.Forms.Label();
            this.deviceBox2 = new System.Windows.Forms.GroupBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnWrite2 = new System.Windows.Forms.Button();
            this.btnRead2 = new System.Windows.Forms.Button();
            this.btnGetUID2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblData2 = new System.Windows.Forms.Label();
            this.lblUID2 = new System.Windows.Forms.Label();
            this.deviceBox1.SuspendLayout();
            this.deviceBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceBox1
            // 
            this.deviceBox1.Controls.Add(this.txtInput1);
            this.deviceBox1.Controls.Add(this.btnWrite1);
            this.deviceBox1.Controls.Add(this.btnRead1);
            this.deviceBox1.Controls.Add(this.btnGetUID1);
            this.deviceBox1.Controls.Add(this.label3);
            this.deviceBox1.Controls.Add(this.lblData1);
            this.deviceBox1.Controls.Add(this.lblUID1);
            this.deviceBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deviceBox1.Location = new System.Drawing.Point(12, 12);
            this.deviceBox1.Name = "deviceBox1";
            this.deviceBox1.Size = new System.Drawing.Size(492, 141);
            this.deviceBox1.TabIndex = 0;
            this.deviceBox1.TabStop = false;
            this.deviceBox1.Text = "Device 1";
            // 
            // txtInput1
            // 
            this.txtInput1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput1.Location = new System.Drawing.Point(128, 102);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(234, 25);
            this.txtInput1.TabIndex = 6;
            // 
            // btnWrite1
            // 
            this.btnWrite1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWrite1.Location = new System.Drawing.Point(368, 102);
            this.btnWrite1.Name = "btnWrite1";
            this.btnWrite1.Size = new System.Drawing.Size(104, 25);
            this.btnWrite1.TabIndex = 5;
            this.btnWrite1.Text = "Write";
            this.btnWrite1.UseVisualStyleBackColor = true;
            this.btnWrite1.Click += new System.EventHandler(this.btnWrite1_Click);
            // 
            // btnRead1
            // 
            this.btnRead1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRead1.Location = new System.Drawing.Point(368, 70);
            this.btnRead1.Name = "btnRead1";
            this.btnRead1.Size = new System.Drawing.Size(104, 25);
            this.btnRead1.TabIndex = 4;
            this.btnRead1.Text = "Read";
            this.btnRead1.UseVisualStyleBackColor = true;
            this.btnRead1.Click += new System.EventHandler(this.btnRead1_Click);
            // 
            // btnGetUID1
            // 
            this.btnGetUID1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetUID1.Location = new System.Drawing.Point(368, 35);
            this.btnGetUID1.Name = "btnGetUID1";
            this.btnGetUID1.Size = new System.Drawing.Size(104, 25);
            this.btnGetUID1.TabIndex = 3;
            this.btnGetUID1.Text = "get UID";
            this.btnGetUID1.UseVisualStyleBackColor = true;
            this.btnGetUID1.Click += new System.EventHandler(this.btnGetUID1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input Data : ";
            // 
            // lblData1
            // 
            this.lblData1.AutoSize = true;
            this.lblData1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData1.Location = new System.Drawing.Point(19, 70);
            this.lblData1.Name = "lblData1";
            this.lblData1.Size = new System.Drawing.Size(59, 21);
            this.lblData1.TabIndex = 1;
            this.lblData1.Text = "Data : ";
            // 
            // lblUID1
            // 
            this.lblUID1.AutoSize = true;
            this.lblUID1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUID1.Location = new System.Drawing.Point(19, 39);
            this.lblUID1.Name = "lblUID1";
            this.lblUID1.Size = new System.Drawing.Size(92, 21);
            this.lblUID1.TabIndex = 0;
            this.lblUID1.Text = "Card UID : ";
            // 
            // deviceBox2
            // 
            this.deviceBox2.Controls.Add(this.txtInput2);
            this.deviceBox2.Controls.Add(this.btnWrite2);
            this.deviceBox2.Controls.Add(this.btnRead2);
            this.deviceBox2.Controls.Add(this.btnGetUID2);
            this.deviceBox2.Controls.Add(this.label1);
            this.deviceBox2.Controls.Add(this.lblData2);
            this.deviceBox2.Controls.Add(this.lblUID2);
            this.deviceBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deviceBox2.Location = new System.Drawing.Point(12, 160);
            this.deviceBox2.Name = "deviceBox2";
            this.deviceBox2.Size = new System.Drawing.Size(492, 141);
            this.deviceBox2.TabIndex = 1;
            this.deviceBox2.TabStop = false;
            this.deviceBox2.Text = "Device 2";
            // 
            // txtInput2
            // 
            this.txtInput2.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput2.Location = new System.Drawing.Point(128, 102);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(234, 25);
            this.txtInput2.TabIndex = 6;
            // 
            // btnWrite2
            // 
            this.btnWrite2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWrite2.Location = new System.Drawing.Point(368, 102);
            this.btnWrite2.Name = "btnWrite2";
            this.btnWrite2.Size = new System.Drawing.Size(104, 25);
            this.btnWrite2.TabIndex = 5;
            this.btnWrite2.Text = "Write";
            this.btnWrite2.UseVisualStyleBackColor = true;
            this.btnWrite2.Click += new System.EventHandler(this.btnWrite2_Click);
            // 
            // btnRead2
            // 
            this.btnRead2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRead2.Location = new System.Drawing.Point(368, 70);
            this.btnRead2.Name = "btnRead2";
            this.btnRead2.Size = new System.Drawing.Size(104, 25);
            this.btnRead2.TabIndex = 4;
            this.btnRead2.Text = "Read";
            this.btnRead2.UseVisualStyleBackColor = true;
            this.btnRead2.Click += new System.EventHandler(this.btnRead2_Click);
            // 
            // btnGetUID2
            // 
            this.btnGetUID2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetUID2.Location = new System.Drawing.Point(368, 35);
            this.btnGetUID2.Name = "btnGetUID2";
            this.btnGetUID2.Size = new System.Drawing.Size(104, 25);
            this.btnGetUID2.TabIndex = 3;
            this.btnGetUID2.Text = "get UID";
            this.btnGetUID2.UseVisualStyleBackColor = true;
            this.btnGetUID2.Click += new System.EventHandler(this.btnGetUID2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Data : ";
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData2.Location = new System.Drawing.Point(19, 70);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(59, 21);
            this.lblData2.TabIndex = 1;
            this.lblData2.Text = "Data : ";
            // 
            // lblUID2
            // 
            this.lblUID2.AutoSize = true;
            this.lblUID2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUID2.Location = new System.Drawing.Point(19, 39);
            this.lblUID2.Name = "lblUID2";
            this.lblUID2.Size = new System.Drawing.Size(92, 21);
            this.lblUID2.TabIndex = 0;
            this.lblUID2.Text = "Card UID : ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 313);
            this.Controls.Add(this.deviceBox2);
            this.Controls.Add(this.deviceBox1);
            this.Name = "mainForm";
            this.Text = "NFC Project (1.0v)";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.deviceBox1.ResumeLayout(false);
            this.deviceBox1.PerformLayout();
            this.deviceBox2.ResumeLayout(false);
            this.deviceBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox deviceBox1;
        private System.Windows.Forms.Button btnWrite1;
        private System.Windows.Forms.Button btnRead1;
        private System.Windows.Forms.Button btnGetUID1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblData1;
        private System.Windows.Forms.Label lblUID1;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.GroupBox deviceBox2;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button btnWrite2;
        private System.Windows.Forms.Button btnRead2;
        private System.Windows.Forms.Button btnGetUID2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblData2;
        private System.Windows.Forms.Label lblUID2;
    }
}

