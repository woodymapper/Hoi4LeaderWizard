namespace Hoi4Charmaker
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
            label1 = new Label();
            Name_TXT = new TextBox();
            GFX_TXT = new TextBox();
            Ideology_TXT = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Tag = new TextBox();
            label6 = new Label();
            bake = new Button();
            Exit_btn = new Button();
            label7 = new Label();
            Error_ctrl = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            expireDate = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 38F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(472, 59);
            label1.TabIndex = 0;
            label1.Text = "Hoi4 Leader Wizard";
            // 
            // Name_TXT
            // 
            Name_TXT.Location = new Point(173, 140);
            Name_TXT.Name = "Name_TXT";
            Name_TXT.Size = new Size(113, 23);
            Name_TXT.TabIndex = 1;
            Name_TXT.TextChanged += Name_TXT_TextChanged;
            // 
            // GFX_TXT
            // 
            GFX_TXT.Location = new Point(173, 169);
            GFX_TXT.Name = "GFX_TXT";
            GFX_TXT.Size = new Size(113, 23);
            GFX_TXT.TabIndex = 2;
            GFX_TXT.TextChanged += GFX_TXT_TextChanged;
            // 
            // Ideology_TXT
            // 
            Ideology_TXT.Location = new Point(173, 198);
            Ideology_TXT.Name = "Ideology_TXT";
            Ideology_TXT.Size = new Size(113, 23);
            Ideology_TXT.TabIndex = 3;
            Ideology_TXT.TextChanged += Ideology_TXT_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 143);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 172);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Portrait:  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 201);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Ideology: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 122);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 7;
            label5.Text = "General Settings";
            // 
            // Tag
            // 
            Tag.Location = new Point(173, 227);
            Tag.Name = "Tag";
            Tag.Size = new Size(113, 23);
            Tag.TabIndex = 8;
            Tag.TextChanged += Tag_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(111, 230);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 9;
            label6.Text = "Tag: ";
            // 
            // bake
            // 
            bake.Location = new Point(183, 317);
            bake.Name = "bake";
            bake.Size = new Size(75, 23);
            bake.TabIndex = 10;
            bake.Text = "Bake!";
            bake.UseVisualStyleBackColor = true;
            bake.Click += bake_Click;
            // 
            // Exit_btn
            // 
            Exit_btn.Location = new Point(183, 346);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(75, 23);
            Exit_btn.TabIndex = 11;
            Exit_btn.Text = "Exit";
            Exit_btn.UseVisualStyleBackColor = true;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(111, 259);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 13;
            label7.Text = "Expire: ";
            // 
            // Error_ctrl
            // 
            Error_ctrl.AutoSize = true;
            Error_ctrl.Location = new Point(12, 408);
            Error_ctrl.Name = "Error_ctrl";
            Error_ctrl.Size = new Size(0, 15);
            Error_ctrl.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 285);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(111, 288);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 16;
            label8.Text = "Filename: ";
            // 
            // expireDate
            // 
            expireDate.Location = new Point(173, 256);
            expireDate.Name = "expireDate";
            expireDate.Size = new Size(113, 23);
            expireDate.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 562);
            Controls.Add(expireDate);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(Error_ctrl);
            Controls.Add(label7);
            Controls.Add(Exit_btn);
            Controls.Add(bake);
            Controls.Add(label6);
            Controls.Add(Tag);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Ideology_TXT);
            Controls.Add(GFX_TXT);
            Controls.Add(Name_TXT);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Name_TXT;
        private TextBox GFX_TXT;
        private TextBox Ideology_TXT;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Tag;
        private Label label6;
        private Button bake;
        private Button Exit_btn;
        private Label label7;
        private Label Error_ctrl;
        private TextBox textBox1;
        private Label label8;
        private TextBox expireDate;
    }
}