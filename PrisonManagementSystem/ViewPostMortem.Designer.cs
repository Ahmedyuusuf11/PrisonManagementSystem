namespace JailManagement
{
    partial class ViewPostMortem
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
            PostMortemGridView = new DataGridView();
            label1 = new Label();
            PostMortemSearchBox = new TextBox();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)PostMortemGridView).BeginInit();
            SuspendLayout();
            // 
            // PostMortemGridView
            // 
            PostMortemGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PostMortemGridView.Location = new Point(121, 145);
            PostMortemGridView.Margin = new Padding(4, 3, 4, 3);
            PostMortemGridView.Name = "PostMortemGridView";
            PostMortemGridView.Size = new Size(908, 375);
            PostMortemGridView.TabIndex = 11;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(397, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(359, 45);
            label1.TabIndex = 10;
            label1.Text = "View PostMortem";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PostMortemSearchBox
            // 
            PostMortemSearchBox.Location = new Point(134, 87);
            PostMortemSearchBox.Margin = new Padding(4, 3, 4, 3);
            PostMortemSearchBox.Multiline = true;
            PostMortemSearchBox.Name = "PostMortemSearchBox";
            PostMortemSearchBox.Size = new Size(265, 37);
            PostMortemSearchBox.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 24);
            label2.TabIndex = 43;
            label2.Text = "Search";
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.SeaShell;
            button2.Location = new Point(58, 595);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(168, 53);
            button2.TabIndex = 45;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            // 
            // ViewPostMortem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 662);
            Controls.Add(button2);
            Controls.Add(PostMortemSearchBox);
            Controls.Add(label2);
            Controls.Add(PostMortemGridView);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ViewPostMortem";
            Text = "ViewPostMortem";
            FormClosing += ViewPostMortem_FormClosing;
            Load += ViewPostMortem_Load;
            ((System.ComponentModel.ISupportInitialize)PostMortemGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView PostMortemGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PostMortemSearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}