
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnTool = new System.Windows.Forms.RadioButton();
            this.rbtnConsume = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 55);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tool Check In Out Page";
            // 
            // txtToolBarcode
            // 
            this.txtToolBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToolBarcode.Location = new System.Drawing.Point(320, 288);
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
            this.label1.Location = new System.Drawing.Point(120, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tool Barcode:";
            // 
            // btnIN
            // 
            this.btnIN.Location = new System.Drawing.Point(960, 432);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(96, 64);
            this.btnIN.TabIndex = 18;
            this.btnIN.Text = "Check In";
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(1080, 432);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(96, 64);
            this.btnOut.TabIndex = 19;
            this.btnOut.Text = "Check Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblQty.Location = new System.Drawing.Point(128, 352);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(140, 33);
            this.lblQty.TabIndex = 20;
            this.lblQty.Text = "Quantity: ";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(320, 352);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(866, 40);
            this.txtQty.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTool);
            this.groupBox1.Controls.Add(this.rbtnConsume);
            this.groupBox1.Location = new System.Drawing.Point(120, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 120);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check out";
            // 
            // rbtnTool
            // 
            this.rbtnTool.AutoSize = true;
            this.rbtnTool.Checked = true;
            this.rbtnTool.Location = new System.Drawing.Point(16, 32);
            this.rbtnTool.Name = "rbtnTool";
            this.rbtnTool.Size = new System.Drawing.Size(64, 24);
            this.rbtnTool.TabIndex = 24;
            this.rbtnTool.TabStop = true;
            this.rbtnTool.Text = "Tool";
            this.rbtnTool.UseVisualStyleBackColor = true;
            this.rbtnTool.CheckedChanged += new System.EventHandler(this.rbtnTool_CheckedChanged);
            // 
            // rbtnConsume
            // 
            this.rbtnConsume.AutoSize = true;
            this.rbtnConsume.Location = new System.Drawing.Point(16, 72);
            this.rbtnConsume.Name = "rbtnConsume";
            this.rbtnConsume.Size = new System.Drawing.Size(123, 24);
            this.rbtnConsume.TabIndex = 23;
            this.rbtnConsume.Text = "Consumable";
            this.rbtnConsume.UseVisualStyleBackColor = true;
            // 
            // Tool_Check_IN_OUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtToolBarcode);
            this.Controls.Add(this.label1);
            this.Name = "Tool_Check_IN_OUT";
            this.Text = "Tool_Check_IN_OUT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnTool;
        private System.Windows.Forms.RadioButton rbtnConsume;
    }
}