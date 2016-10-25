namespace math
{
    partial class frmarithmetic
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
            this.lblfristnum = new System.Windows.Forms.Label();
            this.lblsecondnum = new System.Windows.Forms.Label();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtsecondnum = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.btnhello = new System.Windows.Forms.Button();
            this.lbldisplay2 = new System.Windows.Forms.Label();
            this.btnans = new System.Windows.Forms.Button();
            this.txtUserCost = new System.Windows.Forms.TextBox();
            this.txtUserTaxes = new System.Windows.Forms.TextBox();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.btnBYE = new System.Windows.Forms.Button();
            this.lblDisplay3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfristnum
            // 
            this.lblfristnum.AutoSize = true;
            this.lblfristnum.Location = new System.Drawing.Point(37, 27);
            this.lblfristnum.Name = "lblfristnum";
            this.lblfristnum.Size = new System.Drawing.Size(120, 13);
            this.lblfristnum.TabIndex = 0;
            this.lblfristnum.Text = "Please Enter A Number:";
            // 
            // lblsecondnum
            // 
            this.lblsecondnum.AutoSize = true;
            this.lblsecondnum.Location = new System.Drawing.Point(37, 57);
            this.lblsecondnum.Name = "lblsecondnum";
            this.lblsecondnum.Size = new System.Drawing.Size(120, 13);
            this.lblsecondnum.TabIndex = 1;
            this.lblsecondnum.Text = "Please Enter A Number:";
            this.lblsecondnum.Click += new System.EventHandler(this.lblsecondnum_Click);
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(163, 24);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNum.TabIndex = 2;
            // 
            // txtsecondnum
            // 
            this.txtsecondnum.Location = new System.Drawing.Point(163, 54);
            this.txtsecondnum.Name = "txtsecondnum";
            this.txtsecondnum.Size = new System.Drawing.Size(100, 20);
            this.txtsecondnum.TabIndex = 3;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(91, 91);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(135, 23);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "LET\'S DO SOME MATH!";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lbldisplay
            // 
            this.lbldisplay.Location = new System.Drawing.Point(58, 142);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(268, 178);
            this.lbldisplay.TabIndex = 5;
            this.lbldisplay.Click += new System.EventHandler(this.lbldisplay_Click);
            // 
            // btnhello
            // 
            this.btnhello.Location = new System.Drawing.Point(326, 57);
            this.btnhello.Name = "btnhello";
            this.btnhello.Size = new System.Drawing.Size(75, 23);
            this.btnhello.TabIndex = 6;
            this.btnhello.Text = "HELLO ";
            this.btnhello.UseVisualStyleBackColor = true;
            this.btnhello.Click += new System.EventHandler(this.btnhello_Click);
            // 
            // lbldisplay2
            // 
            this.lbldisplay2.AutoSize = true;
            this.lbldisplay2.Location = new System.Drawing.Point(326, 31);
            this.lbldisplay2.Name = "lbldisplay2";
            this.lbldisplay2.Size = new System.Drawing.Size(0, 13);
            this.lbldisplay2.TabIndex = 7;
            // 
            // btnans
            // 
            this.btnans.Location = new System.Drawing.Point(608, 109);
            this.btnans.Name = "btnans";
            this.btnans.Size = new System.Drawing.Size(75, 23);
            this.btnans.TabIndex = 8;
            this.btnans.Text = "done ";
            this.btnans.UseVisualStyleBackColor = true;
            this.btnans.Click += new System.EventHandler(this.btnans_Click);
            // 
            // txtUserCost
            // 
            this.txtUserCost.Location = new System.Drawing.Point(617, 13);
            this.txtUserCost.Name = "txtUserCost";
            this.txtUserCost.Size = new System.Drawing.Size(100, 20);
            this.txtUserCost.TabIndex = 9;
            // 
            // txtUserTaxes
            // 
            this.txtUserTaxes.Location = new System.Drawing.Point(617, 40);
            this.txtUserTaxes.Name = "txtUserTaxes";
            this.txtUserTaxes.Size = new System.Drawing.Size(100, 20);
            this.txtUserTaxes.TabIndex = 10;
            // 
            // lblResult2
            // 
            this.lblResult2.Location = new System.Drawing.Point(534, 135);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(358, 185);
            this.lblResult2.TabIndex = 11;
            this.lblResult2.Click += new System.EventHandler(this.lblresult2_Click);
            // 
            // btnBYE
            // 
            this.btnBYE.Location = new System.Drawing.Point(407, 57);
            this.btnBYE.Name = "btnBYE";
            this.btnBYE.Size = new System.Drawing.Size(75, 23);
            this.btnBYE.TabIndex = 12;
            this.btnBYE.Text = "BYE";
            this.btnBYE.UseVisualStyleBackColor = true;
            this.btnBYE.Click += new System.EventHandler(this.btnBYE_Click);
            // 
            // lblDisplay3
            // 
            this.lblDisplay3.AutoSize = true;
            this.lblDisplay3.Location = new System.Drawing.Point(404, 31);
            this.lblDisplay3.Name = "lblDisplay3";
            this.lblDisplay3.Size = new System.Drawing.Size(0, 13);
            this.lblDisplay3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Taxes";
            // 
            // frmarithmetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 630);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDisplay3);
            this.Controls.Add(this.btnBYE);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.txtUserTaxes);
            this.Controls.Add(this.txtUserCost);
            this.Controls.Add(this.btnans);
            this.Controls.Add(this.lbldisplay2);
            this.Controls.Add(this.btnhello);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtsecondnum);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.lblsecondnum);
            this.Controls.Add(this.lblfristnum);
            this.Name = "frmarithmetic";
            this.Text = "arithmetic and math";
            this.Load += new System.EventHandler(this.frmarithmetic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfristnum;
        private System.Windows.Forms.Label lblsecondnum;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.TextBox txtsecondnum;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Button btnhello;
        private System.Windows.Forms.Label lbldisplay2;
        private System.Windows.Forms.Button btnans;
        private System.Windows.Forms.TextBox txtUserCost;
        private System.Windows.Forms.TextBox txtUserTaxes;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Button btnBYE;
        private System.Windows.Forms.Label lblDisplay3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

