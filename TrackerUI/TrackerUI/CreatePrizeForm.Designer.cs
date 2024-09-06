namespace TrackerUI
{
	partial class CreatePrizeForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.PlaceNumberValue = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.PlaceNameValue = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Create Prize";
			// 
			// PlaceNumberValue
			// 
			this.PlaceNumberValue.AutoSize = true;
			this.PlaceNumberValue.Location = new System.Drawing.Point(42, 129);
			this.PlaceNumberValue.Name = "PlaceNumberValue";
			this.PlaceNumberValue.Size = new System.Drawing.Size(108, 20);
			this.PlaceNumberValue.TabIndex = 1;
			this.PlaceNumberValue.Text = "Place Number";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(186, 129);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(159, 26);
			this.textBox1.TabIndex = 2;
			// 
			// PlaceNameValue
			// 
			this.PlaceNameValue.AutoSize = true;
			this.PlaceNameValue.Location = new System.Drawing.Point(42, 186);
			this.PlaceNameValue.Name = "PlaceNameValue";
			this.PlaceNameValue.Size = new System.Drawing.Size(94, 20);
			this.PlaceNameValue.TabIndex = 3;
			this.PlaceNameValue.Text = "Place Name";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(186, 183);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(159, 26);
			this.textBox2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 237);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Prize Amount";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(186, 231);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(159, 26);
			this.textBox3.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(148, 283);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "-Or-";
			
			// 
			// CreatePrizeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.PlaceNameValue);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.PlaceNumberValue);
			this.Controls.Add(this.label1);
			this.Name = "CreatePrizeForm";
			this.Text = "Create Prize";
			this.UseWaitCursor = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label PlaceNumberValue;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label PlaceNameValue;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
	}
}