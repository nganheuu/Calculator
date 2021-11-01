
namespace Calculator
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
            this.lbTT = new System.Windows.Forms.Label();
            this.lbSoa = new System.Windows.Forms.Label();
            this.btnCong = new System.Windows.Forms.Button();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.lbSob = new System.Windows.Forms.Label();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.lbKQ = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.BackColor = System.Drawing.Color.Salmon;
            this.lbTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTT.ForeColor = System.Drawing.Color.White;
            this.lbTT.Location = new System.Drawing.Point(203, 22);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(234, 58);
            this.lbTT.TabIndex = 0;
            this.lbTT.Text = "Tính toán";
            // 
            // lbSoa
            // 
            this.lbSoa.AutoSize = true;
            this.lbSoa.BackColor = System.Drawing.Color.Salmon;
            this.lbSoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoa.ForeColor = System.Drawing.Color.White;
            this.lbSoa.Location = new System.Drawing.Point(24, 126);
            this.lbSoa.Name = "lbSoa";
            this.lbSoa.Size = new System.Drawing.Size(72, 29);
            this.lbSoa.TabIndex = 0;
            this.lbSoa.Text = "Số a:";
            // 
            // btnCong
            // 
            this.btnCong.BackColor = System.Drawing.Color.Salmon;
            this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.ForeColor = System.Drawing.Color.White;
            this.btnCong.Location = new System.Drawing.Point(371, 317);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(111, 89);
            this.btnCong.TabIndex = 1;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = false;
            // 
            // txtSoa
            // 
            this.txtSoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoa.Location = new System.Drawing.Point(154, 127);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(346, 30);
            this.txtSoa.TabIndex = 2;
            // 
            // lbSob
            // 
            this.lbSob.AutoSize = true;
            this.lbSob.BackColor = System.Drawing.Color.Salmon;
            this.lbSob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSob.ForeColor = System.Drawing.Color.White;
            this.lbSob.Location = new System.Drawing.Point(24, 188);
            this.lbSob.Name = "lbSob";
            this.lbSob.Size = new System.Drawing.Size(72, 29);
            this.lbSob.TabIndex = 0;
            this.lbSob.Text = "Số b:";
            // 
            // txtSob
            // 
            this.txtSob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSob.Location = new System.Drawing.Point(154, 189);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(346, 30);
            this.txtSob.TabIndex = 2;
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.BackColor = System.Drawing.Color.Salmon;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.ForeColor = System.Drawing.Color.White;
            this.lbKQ.Location = new System.Drawing.Point(24, 256);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(107, 29);
            this.lbKQ.TabIndex = 0;
            this.lbKQ.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(154, 257);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(346, 30);
            this.txtKetQua.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbSob);
            this.Controls.Add(this.lbSoa);
            this.Controls.Add(this.lbTT);
            this.Name = "Form1";
            this.Text = "Tính toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.Label lbSoa;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.Label lbSob;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

