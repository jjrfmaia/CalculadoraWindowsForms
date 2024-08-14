namespace CalculadoraWindowsForms
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
            btnSoma = new Button();
            btnSub = new Button();
            btnDivi = new Button();
            btnMulti = new Button();
            ttb1 = new TextBox();
            ttb2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(235, 117);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(173, 43);
            btnSoma.TabIndex = 0;
            btnSoma.Text = "Soma";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(235, 192);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(173, 43);
            btnSub.TabIndex = 1;
            btnSub.Text = "Subtração";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnDivi
            // 
            btnDivi.Location = new Point(235, 266);
            btnDivi.Name = "btnDivi";
            btnDivi.Size = new Size(173, 43);
            btnDivi.TabIndex = 9;
            btnDivi.Text = "Divisão";
            btnDivi.UseVisualStyleBackColor = true;
            btnDivi.Click += btnDivi_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(235, 340);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(173, 43);
            btnMulti.TabIndex = 10;
            btnMulti.Text = "Multiplicação";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // ttb1
            // 
            ttb1.Location = new Point(33, 117);
            ttb1.Name = "ttb1";
            ttb1.Size = new Size(164, 23);
            ttb1.TabIndex = 11;
            ttb1.TextChanged += textBox1_TextChanged;
            // 
            // ttb2
            // 
            ttb2.Location = new Point(33, 167);
            ttb2.Name = "ttb2";
            ttb2.Size = new Size(164, 23);
            ttb2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 99);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 13;
            label1.Text = "1° Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 149);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 14;
            label2.Text = "2° Número ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(127, 28);
            label3.Name = "label3";
            label3.Size = new Size(205, 47);
            label3.TabIndex = 15;
            label3.Text = "Calculadora";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ttb2);
            Controls.Add(ttb1);
            Controls.Add(btnMulti);
            Controls.Add(btnDivi);
            Controls.Add(btnSub);
            Controls.Add(btnSoma);
            Name = "Form1";
            Text = "Calculadora Simples";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSoma;
        private Button btnSub;
        private Button btnDivi;
        private Button btnMulti;
        private TextBox ttb1;
        private TextBox ttb2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
