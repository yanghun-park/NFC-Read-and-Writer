
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
            this.cmbNFCType1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBlock1 = new System.Windows.Forms.TextBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.btnWrite1 = new System.Windows.Forms.Button();
            this.btnRead1 = new System.Windows.Forms.Button();
            this.btnGetUID1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblData1 = new System.Windows.Forms.Label();
            this.lblUID1 = new System.Windows.Forms.Label();
            this.deviceBox2 = new System.Windows.Forms.GroupBox();
            this.cmbNFCType2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBlock2 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnWrite2 = new System.Windows.Forms.Button();
            this.btnRead2 = new System.Windows.Forms.Button();
            this.btnGetUID2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblData2 = new System.Windows.Forms.Label();
            this.lblUID2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deviceBox1.SuspendLayout();
            this.deviceBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceBox1
            // 
            this.deviceBox1.Controls.Add(this.cmbNFCType1);
            this.deviceBox1.Controls.Add(this.label2);
            this.deviceBox1.Controls.Add(this.txtBlock1);
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
            this.deviceBox1.Size = new System.Drawing.Size(560, 180);
            this.deviceBox1.TabIndex = 0;
            this.deviceBox1.TabStop = false;
            this.deviceBox1.Text = "Device 1";
            // 
            // cmbNFCType1
            // 
            this.cmbNFCType1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbNFCType1.FormattingEnabled = true;
            this.cmbNFCType1.Location = new System.Drawing.Point(149, 32);
            this.cmbNFCType1.Name = "cmbNFCType1";
            this.cmbNFCType1.Size = new System.Drawing.Size(395, 25);
            this.cmbNFCType1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "NFC Tag Type : ";
            // 
            // txtBlock1
            // 
            this.txtBlock1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtBlock1.ForeColor = System.Drawing.Color.LightGray;
            this.txtBlock1.Location = new System.Drawing.Point(331, 103);
            this.txtBlock1.Name = "txtBlock1";
            this.txtBlock1.Size = new System.Drawing.Size(103, 57);
            this.txtBlock1.TabIndex = 7;
            this.txtBlock1.Text = "Block";
            this.txtBlock1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBlock1.Click += new System.EventHandler(this.txtBlock1_Click);
            // 
            // txtInput1
            // 
            this.txtInput1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput1.Location = new System.Drawing.Point(128, 135);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(197, 25);
            this.txtInput1.TabIndex = 6;
            // 
            // btnWrite1
            // 
            this.btnWrite1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWrite1.Location = new System.Drawing.Point(440, 135);
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
            this.btnRead1.Location = new System.Drawing.Point(440, 103);
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
            this.btnGetUID1.Location = new System.Drawing.Point(440, 68);
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
            this.label3.Location = new System.Drawing.Point(19, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input Data : ";
            // 
            // lblData1
            // 
            this.lblData1.AutoSize = true;
            this.lblData1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData1.Location = new System.Drawing.Point(19, 103);
            this.lblData1.Name = "lblData1";
            this.lblData1.Size = new System.Drawing.Size(59, 21);
            this.lblData1.TabIndex = 1;
            this.lblData1.Text = "Data : ";
            // 
            // lblUID1
            // 
            this.lblUID1.AutoSize = true;
            this.lblUID1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUID1.Location = new System.Drawing.Point(19, 72);
            this.lblUID1.Name = "lblUID1";
            this.lblUID1.Size = new System.Drawing.Size(92, 21);
            this.lblUID1.TabIndex = 0;
            this.lblUID1.Text = "Card UID : ";
            // 
            // deviceBox2
            // 
            this.deviceBox2.Controls.Add(this.cmbNFCType2);
            this.deviceBox2.Controls.Add(this.label4);
            this.deviceBox2.Controls.Add(this.txtBlock2);
            this.deviceBox2.Controls.Add(this.txtInput2);
            this.deviceBox2.Controls.Add(this.btnWrite2);
            this.deviceBox2.Controls.Add(this.btnRead2);
            this.deviceBox2.Controls.Add(this.btnGetUID2);
            this.deviceBox2.Controls.Add(this.label1);
            this.deviceBox2.Controls.Add(this.lblData2);
            this.deviceBox2.Controls.Add(this.lblUID2);
            this.deviceBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deviceBox2.Location = new System.Drawing.Point(12, 201);
            this.deviceBox2.Name = "deviceBox2";
            this.deviceBox2.Size = new System.Drawing.Size(560, 180);
            this.deviceBox2.TabIndex = 1;
            this.deviceBox2.TabStop = false;
            this.deviceBox2.Text = "Device 2";
            // 
            // cmbNFCType2
            // 
            this.cmbNFCType2.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbNFCType2.FormattingEnabled = true;
            this.cmbNFCType2.Location = new System.Drawing.Point(149, 36);
            this.cmbNFCType2.Name = "cmbNFCType2";
            this.cmbNFCType2.Size = new System.Drawing.Size(395, 25);
            this.cmbNFCType2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "NFC Tag Type : ";
            // 
            // txtBlock2
            // 
            this.txtBlock2.Font = new System.Drawing.Font("맑은 고딕 Semilight", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtBlock2.ForeColor = System.Drawing.Color.LightGray;
            this.txtBlock2.Location = new System.Drawing.Point(331, 108);
            this.txtBlock2.Name = "txtBlock2";
            this.txtBlock2.Size = new System.Drawing.Size(103, 57);
            this.txtBlock2.TabIndex = 8;
            this.txtBlock2.Text = "Block";
            this.txtBlock2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBlock2.Click += new System.EventHandler(this.txtBlock2_Click);
            // 
            // txtInput2
            // 
            this.txtInput2.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput2.Location = new System.Drawing.Point(128, 140);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(197, 25);
            this.txtInput2.TabIndex = 6;
            // 
            // btnWrite2
            // 
            this.btnWrite2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWrite2.Location = new System.Drawing.Point(440, 139);
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
            this.btnRead2.Location = new System.Drawing.Point(440, 107);
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
            this.btnGetUID2.Location = new System.Drawing.Point(440, 72);
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
            this.label1.Location = new System.Drawing.Point(19, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Data : ";
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData2.Location = new System.Drawing.Point(19, 108);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(59, 21);
            this.lblData2.TabIndex = 1;
            this.lblData2.Text = "Data : ";
            // 
            // lblUID2
            // 
            this.lblUID2.AutoSize = true;
            this.lblUID2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUID2.Location = new System.Drawing.Point(19, 77);
            this.lblUID2.Name = "lblUID2";
            this.lblUID2.Size = new System.Drawing.Size(92, 21);
            this.lblUID2.TabIndex = 0;
            this.lblUID2.Text = "Card UID : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(404, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Program Version : 1.10v";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 415);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deviceBox2);
            this.Controls.Add(this.deviceBox1);
            this.Name = "mainForm";
            this.Text = "NFC Project (1.1v)";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.deviceBox1.ResumeLayout(false);
            this.deviceBox1.PerformLayout();
            this.deviceBox2.ResumeLayout(false);
            this.deviceBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtBlock1;
        private System.Windows.Forms.TextBox txtBlock2;
        private System.Windows.Forms.ComboBox cmbNFCType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNFCType2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lec;
        private System.Windows.Forms.ComboBox cmbNFCType1;
        private System.Windows.Forms.Label label5;
    }
}

