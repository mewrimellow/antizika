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
            btn_CalcularHash = new Button();
            btn_EscanearPasta = new Button();
            btn_Escanear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_CalcularHash
            // 
            btn_CalcularHash.BackColor = Color.SlateGray;
            btn_CalcularHash.Cursor = Cursors.Hand;
            btn_CalcularHash.Font = new Font("OCR-A BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CalcularHash.ForeColor = Color.MintCream;
            btn_CalcularHash.Location = new Point(64, 110);
            btn_CalcularHash.Name = "btn_CalcularHash";
            btn_CalcularHash.Size = new Size(175, 142);
            btn_CalcularHash.TabIndex = 0;
            btn_CalcularHash.Text = "Calcular Hash";
            btn_CalcularHash.UseVisualStyleBackColor = false;
            btn_CalcularHash.Click += btn_CalcularHash_Click;
            // 
            // btn_EscanearPasta
            // 
            btn_EscanearPasta.BackColor = Color.SlateGray;
            btn_EscanearPasta.Cursor = Cursors.Hand;
            btn_EscanearPasta.Font = new Font("OCR-A BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EscanearPasta.ForeColor = Color.MintCream;
            btn_EscanearPasta.Location = new Point(559, 110);
            btn_EscanearPasta.Name = "btn_EscanearPasta";
            btn_EscanearPasta.Size = new Size(175, 142);
            btn_EscanearPasta.TabIndex = 1;
            btn_EscanearPasta.Text = "Escanear Pasta";
            btn_EscanearPasta.UseVisualStyleBackColor = false;
            // 
            // btn_Escanear
            // 
            btn_Escanear.BackColor = Color.SlateGray;
            btn_Escanear.Cursor = Cursors.Hand;
            btn_Escanear.Font = new Font("OCR-A BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Escanear.ForeColor = Color.MintCream;
            btn_Escanear.Location = new Point(310, 92);
            btn_Escanear.Name = "btn_Escanear";
            btn_Escanear.Size = new Size(175, 179);
            btn_Escanear.TabIndex = 2;
            btn_Escanear.Text = "Escanear";
            btn_Escanear.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("OCR-A BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            Controls.Add(btn_Escanear);
            Controls.Add(btn_EscanearPasta);
            Controls.Add(btn_CalcularHash);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Antizika";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_CalcularHash;
        private Button btn_EscanearPasta;
        private Button btn_Escanear;
        private Label label1;
    }
}
