namespace TrackerUI
{
	partial class TournamentViewerForm
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
			this.HeaderLabel = new System.Windows.Forms.Label();
			this.TournamentName = new System.Windows.Forms.Label();
			this.roundLabel = new System.Windows.Forms.Label();
			this.roundDropDown = new System.Windows.Forms.ComboBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.MatchupListBox = new System.Windows.Forms.ListBox();
			this.TeamOneScoreText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// HeaderLabel
			// 
			this.HeaderLabel.AutoSize = true;
			this.HeaderLabel.Font = new System.Drawing.Font("Segoe Fluent Icons", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeaderLabel.Location = new System.Drawing.Point(50, 53);
			this.HeaderLabel.Name = "HeaderLabel";
			this.HeaderLabel.Size = new System.Drawing.Size(133, 28);
			this.HeaderLabel.TabIndex = 0;
			this.HeaderLabel.Text = "Tournament:";
			// 
			// TournamentName
			// 
			this.TournamentName.AutoSize = true;
			this.TournamentName.Font = new System.Drawing.Font("Segoe Fluent Icons", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TournamentName.Location = new System.Drawing.Point(245, 166);
			this.TournamentName.Name = "TournamentName";
			this.TournamentName.Size = new System.Drawing.Size(84, 28);
			this.TournamentName.TabIndex = 1;
			this.TournamentName.Text = "<none>";
			this.TournamentName.Click += new System.EventHandler(this.label1_Click);
			// 
			// roundLabel
			// 
			this.roundLabel.AutoSize = true;
			this.roundLabel.Font = new System.Drawing.Font("Segoe Fluent Icons", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roundLabel.Location = new System.Drawing.Point(0, 0);
			this.roundLabel.Name = "roundLabel";
			this.roundLabel.Size = new System.Drawing.Size(76, 32);
			this.roundLabel.TabIndex = 2;
			this.roundLabel.Text = "round";
			this.roundLabel.Click += new System.EventHandler(this.label2_Click);
			// 
			// roundDropDown
			// 
			this.roundDropDown.FormattingEnabled = true;
			this.roundDropDown.Location = new System.Drawing.Point(272, 52);
			this.roundDropDown.Name = "roundDropDown";
			this.roundDropDown.Size = new System.Drawing.Size(121, 24);
			this.roundDropDown.TabIndex = 3;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(281, 105);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(114, 21);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Unplayed Only";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// MatchupListBox
			// 
			this.MatchupListBox.FormattingEnabled = true;
			this.MatchupListBox.ItemHeight = 16;
			this.MatchupListBox.Location = new System.Drawing.Point(487, 97);
			this.MatchupListBox.Name = "MatchupListBox";
			this.MatchupListBox.Size = new System.Drawing.Size(120, 84);
			this.MatchupListBox.TabIndex = 5;
			this.MatchupListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// TeamOneScoreText
			// 
			this.TeamOneScoreText.AutoSize = true;
			this.TeamOneScoreText.Font = new System.Drawing.Font("Segoe Fluent Icons", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TeamOneScoreText.Location = new System.Drawing.Point(245, 166);
			this.TeamOneScoreText.Name = "TeamOneScoreText";
			this.TeamOneScoreText.Size = new System.Drawing.Size(74, 28);
			this.TeamOneScoreText.TabIndex = 6;
			this.TeamOneScoreText.Text = "Score:";
			this.TeamOneScoreText.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// TournamentViewerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 360);
			this.Controls.Add(this.TeamOneScoreText);
			this.Controls.Add(this.MatchupListBox);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.roundDropDown);
			this.Controls.Add(this.roundLabel);
			this.Controls.Add(this.TournamentName);
			this.Controls.Add(this.HeaderLabel);
			this.Font = new System.Drawing.Font("Segoe Fluent Icons", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "TournamentViewerForm";
			this.Text = "Tournament Viewer";
			this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label HeaderLabel;
		private System.Windows.Forms.Label TournamentName;
		private System.Windows.Forms.Label roundLabel;
		private System.Windows.Forms.ComboBox roundDropDown;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ListBox MatchupListBox;
		private System.Windows.Forms.Label TeamOneScoreText;
	}
}

