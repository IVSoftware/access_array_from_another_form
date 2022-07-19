
namespace access_array_from_another_form
{
    partial class PrintForm
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
            this.buttonShowArray = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowArray
            // 
            this.buttonShowArray.Location = new System.Drawing.Point(51, 91);
            this.buttonShowArray.Name = "buttonShowArray";
            this.buttonShowArray.Size = new System.Drawing.Size(144, 34);
            this.buttonShowArray.TabIndex = 0;
            this.buttonShowArray.Text = "Show Array";
            this.buttonShowArray.UseVisualStyleBackColor = true;
            this.buttonShowArray.Click += new System.EventHandler(this.buttonShowArray_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(320, 175);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(112, 34);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonShowArray);
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowArray;
        private System.Windows.Forms.Button buttonClose;
    }
}