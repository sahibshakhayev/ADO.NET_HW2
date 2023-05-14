namespace LoginRegistration
{
    partial class Registration
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
            button2 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(320, 329);
            button2.Name = "button2";
            button2.Size = new Size(109, 29);
            button2.TabIndex = 11;
            button2.Text = "Registration";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 27);
            textBox2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 164);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 8;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 227);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 27);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 119);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 15;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 56);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 14;
            label4.Text = "Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(307, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(240, 53);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(307, 27);
            textBox4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 290);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 17;
            label5.Text = "Re-Password";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(240, 287);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(307, 27);
            textBox5.TabIndex = 16;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 377);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
    }
}