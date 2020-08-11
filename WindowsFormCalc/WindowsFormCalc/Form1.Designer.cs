namespace WindowsFormCalc
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblAddRes = new System.Windows.Forms.Label();
            this.lblSubRes = new System.Windows.Forms.Label();
            this.lblMulRes = new System.Windows.Forms.Label();
            this.lblDivRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(334, 51);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(334, 121);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(259, 58);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(38, 13);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "NUM1";
            this.lblNum1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(259, 128);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(38, 13);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "NUM2";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(294, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(452, 205);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "SUBTRACT";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(293, 246);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 23);
            this.btnMul.TabIndex = 6;
            this.btnMul.Text = "MULTIPLY";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(452, 246);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "DIVIDE";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // lblAddRes
            // 
            this.lblAddRes.AutoSize = true;
            this.lblAddRes.Location = new System.Drawing.Point(375, 210);
            this.lblAddRes.Name = "lblAddRes";
            this.lblAddRes.Size = new System.Drawing.Size(0, 13);
            this.lblAddRes.TabIndex = 8;
            // 
            // lblSubRes
            // 
            this.lblSubRes.AutoSize = true;
            this.lblSubRes.Location = new System.Drawing.Point(556, 210);
            this.lblSubRes.Name = "lblSubRes";
            this.lblSubRes.Size = new System.Drawing.Size(0, 13);
            this.lblSubRes.TabIndex = 9;
            // 
            // lblMulRes
            // 
            this.lblMulRes.AutoSize = true;
            this.lblMulRes.Location = new System.Drawing.Point(375, 256);
            this.lblMulRes.Name = "lblMulRes";
            this.lblMulRes.Size = new System.Drawing.Size(0, 13);
            this.lblMulRes.TabIndex = 10;
            // 
            // lblDivRes
            // 
            this.lblDivRes.AutoSize = true;
            this.lblDivRes.Location = new System.Drawing.Point(556, 256);
            this.lblDivRes.Name = "lblDivRes";
            this.lblDivRes.Size = new System.Drawing.Size(0, 13);
            this.lblDivRes.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDivRes);
            this.Controls.Add(this.lblMulRes);
            this.Controls.Add(this.lblSubRes);
            this.Controls.Add(this.lblAddRes);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblAddRes;
        private System.Windows.Forms.Label lblSubRes;
        private System.Windows.Forms.Label lblMulRes;
        private System.Windows.Forms.Label lblDivRes;
    }
}

