
namespace access_array_from_another_form
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowCustom = new System.Windows.Forms.Button();
            this.buttonShowPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowCustom
            // 
            this.buttonShowCustom.Location = new System.Drawing.Point(31, 38);
            this.buttonShowCustom.Name = "buttonShowCustom";
            this.buttonShowCustom.Size = new System.Drawing.Size(181, 34);
            this.buttonShowCustom.TabIndex = 0;
            this.buttonShowCustom.Text = "Show Custom";
            this.buttonShowCustom.UseVisualStyleBackColor = true;
            this.buttonShowCustom.Click += new System.EventHandler(this.buttonShowCustom_Click);
            // 
            // buttonShowPrint
            // 
            this.buttonShowPrint.Location = new System.Drawing.Point(31, 111);
            this.buttonShowPrint.Name = "buttonShowPrint";
            this.buttonShowPrint.Size = new System.Drawing.Size(181, 34);
            this.buttonShowPrint.TabIndex = 1;
            this.buttonShowPrint.Text = "Show Print";
            this.buttonShowPrint.UseVisualStyleBackColor = true;
            this.buttonShowPrint.Click += new System.EventHandler(this.buttonShowPrint_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.buttonShowPrint);
            this.Controls.Add(this.buttonShowCustom);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowCustom;
        private System.Windows.Forms.Button buttonShowPrint;
    }
}