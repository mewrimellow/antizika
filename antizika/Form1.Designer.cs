namespace antizika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_CalcularHash_Click = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_CalcularHash_Click
            // 
            btn_CalcularHash_Click.BackColor = Color.SlateGray;
            btn_CalcularHash_Click.Cursor = Cursors.Hand;
            btn_CalcularHash_Click.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CalcularHash_Click.ForeColor = Color.MintCream;
            btn_CalcularHash_Click.Location = new Point(64, 110);
            btn_CalcularHash_Click.Name = "btn_CalcularHash_Click";
            btn_CalcularHash_Click.Size = new Size(175, 142);
            btn_CalcularHash_Click.TabIndex = 0;
            btn_CalcularHash_Click.Text = "Calcular Hash";
            btn_CalcularHash_Click.UseVisualStyleBackColor = false;
            btn_CalcularHash_Click.Click += btn_CalcularHash_Click_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateGray;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.MintCream;
            button2.Location = new Point(559, 110);
            button2.Name = "button2";
            button2.Size = new Size(175, 142);
            button2.TabIndex = 1;
            button2.Text = "Escanear Pasta";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateGray;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.MintCream;
            button3.Location = new Point(310, 92);
            button3.Name = "button3";
            button3.Size = new Size(175, 179);
            button3.TabIndex = 2;
            button3.Text = "Escanear";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 371);
            label1.Name = "label1";
            label1.Size = new Size(332, 36);
            label1.TabIndex = 3;
            label1.Text = "AntiVirus Zika";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_CalcularHash_Click);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Antizika";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_CalcularHash_Click;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}
