
namespace access_array_from_another_form
{
    partial class CustomForm
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
            this.cstmsvbtn = new System.Windows.Forms.Button();
            this.cstmtst1 = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cstmsvbtn
            // 
            this.cstmsvbtn.Location = new System.Drawing.Point(38, 90);
            this.cstmsvbtn.Name = "cstmsvbtn";
            this.cstmsvbtn.Size = new System.Drawing.Size(150, 34);
            this.cstmsvbtn.TabIndex = 0;
            this.cstmsvbtn.Text = "CSTMS";
            this.cstmsvbtn.UseVisualStyleBackColor = true;
            this.cstmsvbtn.Click += new System.EventHandler(this.cstmsvbtn_Click);
            // 
            // cstmtst1
            // 
            this.cstmtst1.Location = new System.Drawing.Point(38, 36);
            this.cstmtst1.Name = "cstmtst1";
            this.cstmtst1.Size = new System.Drawing.Size(150, 31);
            this.cstmtst1.TabIndex = 1;
            this.cstmtst1.Text = "Hello 1";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(320, 175);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(112, 34);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.cstmtst1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.cstmsvbtn);
            this.Name = "CustomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom: Count=0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cstmsvbtn;
        private System.Windows.Forms.TextBox cstmtst1;
        private System.Windows.Forms.Button buttonClose;
    }
}

