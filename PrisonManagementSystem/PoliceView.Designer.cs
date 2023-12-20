namespace JailManagement
{
    partial class PoliceView
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
            label1 = new Label();
            PoliceComplaiButton = new Button();
            PoliceCriminalButton = new Button();
            PoliceWantedButton = new Button();
            Police_Log_Out = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(695, 70);
            label1.TabIndex = 0;
            label1.Text = "Police View";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PoliceComplaiButton
            // 
            PoliceComplaiButton.BackColor = SystemColors.MenuHighlight;
            PoliceComplaiButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PoliceComplaiButton.Location = new Point(138, 256);
            PoliceComplaiButton.Margin = new Padding(4, 3, 4, 3);
            PoliceComplaiButton.Name = "PoliceComplaiButton";
            PoliceComplaiButton.Size = new Size(206, 61);
            PoliceComplaiButton.TabIndex = 7;
            PoliceComplaiButton.Text = "Complain";
            PoliceComplaiButton.UseVisualStyleBackColor = false;
            PoliceComplaiButton.Click += PoliceComplaiButton_Click;
            // 
            // PoliceCriminalButton
            // 
            PoliceCriminalButton.BackColor = SystemColors.MenuHighlight;
            PoliceCriminalButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PoliceCriminalButton.Location = new Point(436, 256);
            PoliceCriminalButton.Margin = new Padding(4, 3, 4, 3);
            PoliceCriminalButton.Name = "PoliceCriminalButton";
            PoliceCriminalButton.Size = new Size(200, 61);
            PoliceCriminalButton.TabIndex = 7;
            PoliceCriminalButton.Text = "Criminal";
            PoliceCriminalButton.UseVisualStyleBackColor = false;
            PoliceCriminalButton.Click += PoliceCriminalButton_Click;
            // 
            // PoliceWantedButton
            // 
            PoliceWantedButton.BackColor = SystemColors.MenuHighlight;
            PoliceWantedButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PoliceWantedButton.Location = new Point(720, 256);
            PoliceWantedButton.Margin = new Padding(4, 3, 4, 3);
            PoliceWantedButton.Name = "PoliceWantedButton";
            PoliceWantedButton.Size = new Size(201, 61);
            PoliceWantedButton.TabIndex = 7;
            PoliceWantedButton.Text = "Wanted Criminal";
            PoliceWantedButton.UseVisualStyleBackColor = false;
            PoliceWantedButton.Click += PoliceWantedButton_Click;
            // 
            // Police_Log_Out
            // 
            Police_Log_Out.BackColor = Color.FromArgb(0, 192, 192);
            Police_Log_Out.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Police_Log_Out.ForeColor = Color.SeaShell;
            Police_Log_Out.Location = new Point(946, 14);
            Police_Log_Out.Margin = new Padding(4, 3, 4, 3);
            Police_Log_Out.Name = "Police_Log_Out";
            Police_Log_Out.Size = new Size(111, 44);
            Police_Log_Out.TabIndex = 8;
            Police_Log_Out.Text = "Log Out";
            Police_Log_Out.UseVisualStyleBackColor = false;
            Police_Log_Out.Click += Police_Log_Out_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.SeaShell;
            button2.Location = new Point(55, 584);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(168, 53);
            button2.TabIndex = 11;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // PoliceView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1125, 662);
            Controls.Add(button2);
            Controls.Add(Police_Log_Out);
            Controls.Add(PoliceWantedButton);
            Controls.Add(PoliceCriminalButton);
            Controls.Add(PoliceComplaiButton);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PoliceView";
            Text = "PoliceView";
            FormClosing += PoliceView_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PoliceComplaiButton;
        private System.Windows.Forms.Button PoliceCriminalButton;
        private System.Windows.Forms.Button PoliceWantedButton;
        private System.Windows.Forms.Button Police_Log_Out;
        private System.Windows.Forms.Button button2;
    }
}