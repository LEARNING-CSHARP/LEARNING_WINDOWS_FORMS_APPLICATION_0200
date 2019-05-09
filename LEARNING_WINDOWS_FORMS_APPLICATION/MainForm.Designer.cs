namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.doSomethingButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// doSomethingButton
			// 
			this.doSomethingButton.BackColor = System.Drawing.Color.Yellow;
			this.doSomethingButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.doSomethingButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.doSomethingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.doSomethingButton.Location = new System.Drawing.Point(12, 12);
			this.doSomethingButton.Name = "doSomethingButton";
			this.doSomethingButton.Size = new System.Drawing.Size(240, 103);
			this.doSomethingButton.TabIndex = 0;
			this.doSomethingButton.Text = "Do Something";
			this.doSomethingButton.UseVisualStyleBackColor = false;
			this.doSomethingButton.Click += new System.EventHandler(this.DoSomethingButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(379, 321);
			this.Controls.Add(this.doSomethingButton);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button doSomethingButton;
	}
}
