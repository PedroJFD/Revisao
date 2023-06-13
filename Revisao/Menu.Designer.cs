namespace Revisao
{
    partial class Menu
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
            button1 = new Button();
            rbt_a = new RadioButton();
            rbt_b = new RadioButton();
            button2 = new Button();
            lb_sexo = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(379, 162);
            button1.Name = "button1";
            button1.Size = new Size(75, 56);
            button1.TabIndex = 0;
            button1.Text = "Divisão";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rbt_a
            // 
            rbt_a.AutoSize = true;
            rbt_a.Location = new Point(111, 118);
            rbt_a.Name = "rbt_a";
            rbt_a.Size = new Size(33, 19);
            rbt_a.TabIndex = 1;
            rbt_a.TabStop = true;
            rbt_a.Text = "A";
            rbt_a.UseVisualStyleBackColor = true;
            // 
            // rbt_b
            // 
            rbt_b.AutoSize = true;
            rbt_b.Location = new Point(111, 143);
            rbt_b.Name = "rbt_b";
            rbt_b.Size = new Size(32, 19);
            rbt_b.TabIndex = 2;
            rbt_b.TabStop = true;
            rbt_b.Text = "B";
            rbt_b.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(111, 168);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Qual";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lb_sexo
            // 
            lb_sexo.AutoSize = true;
            lb_sexo.Location = new Point(105, 203);
            lb_sexo.Name = "lb_sexo";
            lb_sexo.Size = new Size(38, 15);
            lb_sexo.TabIndex = 4;
            lb_sexo.Text = "label1";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_sexo);
            Controls.Add(button2);
            Controls.Add(rbt_b);
            Controls.Add(rbt_a);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RadioButton rbt_a;
        private RadioButton rbt_b;
        private Button button2;
        private Label lb_sexo;
    }
}