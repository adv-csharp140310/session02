namespace session02
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
            buttonMiladiToJalali = new Button();
            buttonJalaliMonth = new Button();
            buttonJalaliSeason = new Button();
            buttonJalaliToMiladi = new Button();
            SuspendLayout();
            // 
            // buttonMiladiToJalali
            // 
            buttonMiladiToJalali.Location = new Point(12, 12);
            buttonMiladiToJalali.Name = "buttonMiladiToJalali";
            buttonMiladiToJalali.Size = new Size(179, 23);
            buttonMiladiToJalali.TabIndex = 0;
            buttonMiladiToJalali.Text = "Miladi to jalali";
            buttonMiladiToJalali.UseVisualStyleBackColor = true;
            buttonMiladiToJalali.Click += buttonMiladiToJalali_Click;
            // 
            // buttonJalaliMonth
            // 
            buttonJalaliMonth.Location = new Point(12, 41);
            buttonJalaliMonth.Name = "buttonJalaliMonth";
            buttonJalaliMonth.Size = new Size(179, 23);
            buttonJalaliMonth.TabIndex = 1;
            buttonJalaliMonth.Text = " jalali month name";
            buttonJalaliMonth.UseVisualStyleBackColor = true;
            buttonJalaliMonth.Click += buttonJalaliMonth_Click;
            // 
            // buttonJalaliSeason
            // 
            buttonJalaliSeason.Location = new Point(12, 70);
            buttonJalaliSeason.Name = "buttonJalaliSeason";
            buttonJalaliSeason.Size = new Size(179, 23);
            buttonJalaliSeason.TabIndex = 2;
            buttonJalaliSeason.Text = " jalali season name";
            buttonJalaliSeason.UseVisualStyleBackColor = true;
            buttonJalaliSeason.Click += buttonJalaliSeason_Click;
            // 
            // buttonJalaliToMiladi
            // 
            buttonJalaliToMiladi.Location = new Point(12, 99);
            buttonJalaliToMiladi.Name = "buttonJalaliToMiladi";
            buttonJalaliToMiladi.Size = new Size(179, 23);
            buttonJalaliToMiladi.TabIndex = 3;
            buttonJalaliToMiladi.Text = "Jalali to Miladi";
            buttonJalaliToMiladi.UseVisualStyleBackColor = true;
            buttonJalaliToMiladi.Click += buttonJalaliToMiladi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonJalaliToMiladi);
            Controls.Add(buttonJalaliSeason);
            Controls.Add(buttonJalaliMonth);
            Controls.Add(buttonMiladiToJalali);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonMiladiToJalali;
        private Button buttonJalaliMonth;
        private Button buttonJalaliSeason;
        private Button buttonJalaliToMiladi;
    }
}
