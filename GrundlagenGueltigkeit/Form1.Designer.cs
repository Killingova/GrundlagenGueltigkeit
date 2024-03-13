namespace GrundlagenGueltigkeit
{
    partial class Form1
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
            CmdAnzeige1 = new Button();
            CmdAnzeige2 = new Button();
            LblAnzeige = new Label();
            CmdAnzeige3 = new Button();
            CmdAnzeige4 = new Button();
            SuspendLayout();
            // 
            // CmdAnzeige1
            // 
            CmdAnzeige1.Location = new Point(329, 55);
            CmdAnzeige1.Name = "CmdAnzeige1";
            CmdAnzeige1.Size = new Size(221, 44);
            CmdAnzeige1.TabIndex = 0;
            CmdAnzeige1.Text = "Anzeige 1";
            CmdAnzeige1.UseVisualStyleBackColor = true;
            CmdAnzeige1.Click += CmdAnzeige1_Click;
            // 
            // CmdAnzeige2
            // 
            CmdAnzeige2.Location = new Point(329, 155);
            CmdAnzeige2.Name = "CmdAnzeige2";
            CmdAnzeige2.Size = new Size(221, 44);
            CmdAnzeige2.TabIndex = 1;
            CmdAnzeige2.Text = "Anzeige 2";
            CmdAnzeige2.UseVisualStyleBackColor = true;
            CmdAnzeige2.Click += CmdAnzeige2_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.BorderStyle = BorderStyle.FixedSingle;
            LblAnzeige.Location = new Point(112, 82);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(2, 22);
            LblAnzeige.TabIndex = 2;
            // 
            // CmdAnzeige3
            // 
            CmdAnzeige3.Location = new Point(329, 255);
            CmdAnzeige3.Name = "CmdAnzeige3";
            CmdAnzeige3.Size = new Size(221, 44);
            CmdAnzeige3.TabIndex = 3;
            CmdAnzeige3.Text = "Anzeige 3";
            CmdAnzeige3.UseVisualStyleBackColor = true;
            CmdAnzeige3.Click += CmdAnzeige3_Click;
            // 
            // CmdAnzeige4
            // 
            CmdAnzeige4.Location = new Point(329, 355);
            CmdAnzeige4.Name = "CmdAnzeige4";
            CmdAnzeige4.Size = new Size(221, 44);
            CmdAnzeige4.TabIndex = 4;
            CmdAnzeige4.Text = "Anzeige 4";
            CmdAnzeige4.UseVisualStyleBackColor = true;
            CmdAnzeige4.Click += CmdAnzeige4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeige4);
            Controls.Add(CmdAnzeige3);
            Controls.Add(LblAnzeige);
            Controls.Add(CmdAnzeige2);
            Controls.Add(CmdAnzeige1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeige1;
        private Button CmdAnzeige2;
        private Label LblAnzeige;
        private Button CmdAnzeige3;
        private Button CmdAnzeige4;
    }
}
