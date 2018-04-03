namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.zadanie1 = new System.Windows.Forms.CheckBox();
            this.zadanie2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.zadanie2);
            this.groupBox1.Controls.Add(this.zadanie1);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Do zrobienia codziennie";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 25);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(306, 361);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // zadanie1
            // 
            this.zadanie1.AutoSize = true;
            this.zadanie1.Location = new System.Drawing.Point(6, 45);
            this.zadanie1.Name = "zadanie1";
            this.zadanie1.Size = new System.Drawing.Size(106, 24);
            this.zadanie1.TabIndex = 1;
            this.zadanie1.Text = "Zadanie 1";
            this.zadanie1.UseVisualStyleBackColor = true;
            this.zadanie1.CheckedChanged += new System.EventHandler(this.coding_CheckedChanged);
            // 
            // zadanie2
            // 
            this.zadanie2.AutoSize = true;
            this.zadanie2.Location = new System.Drawing.Point(6, 98);
            this.zadanie2.Name = "zadanie2";
            this.zadanie2.Size = new System.Drawing.Size(106, 24);
            this.zadanie2.TabIndex = 2;
            this.zadanie2.Text = "Zadanie 2";
            this.zadanie2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sprawdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 512);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox zadanie2;
        private System.Windows.Forms.CheckBox zadanie1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

