
namespace Barcode_Scanner
{
    partial class Tool_Check_IN_OUT
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtToolBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIN = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 55);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tool Check In Out Page";
            // 
            // txtToolBarcode
            // 
            this.txtToolBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToolBarcode.Location = new System.Drawing.Point(248, 184);
            this.txtToolBarcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToolBarcode.Name = "txtToolBarcode";
            this.txtToolBarcode.ReadOnly = true;
            this.txtToolBarcode.Size = new System.Drawing.Size(866, 40);
            this.txtToolBarcode.TabIndex = 16;
            this.txtToolBarcode.TextChanged += new System.EventHandler(this.txtToolBarcode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tool Barcode:";
            // 
            // btnIN
            // 
            this.btnIN.Location = new System.Drawing.Point(888, 328);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(96, 64);
            this.btnIN.TabIndex = 18;
            this.btnIN.Text = "Check In";
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(1008, 328);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(96, 64);
            this.btnOut.TabIndex = 19;
            this.btnOut.Text = "Check Out";
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblQty.Location = new System.Drawing.Point(56, 248);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(140, 33);
            this.lblQty.TabIndex = 20;
            this.lblQty.Text = "Quantity: ";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(248, 248);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(866, 40);
            this.txtQty.TabIndex = 21;
            // 
            // Tool_Check_IN_OUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 509);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtToolBarcode);
            this.Controls.Add(this.label1);
            this.Name = "Tool_Check_IN_OUT";
            this.Text = "Tool_Check_IN_OUT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToolBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
    }
}