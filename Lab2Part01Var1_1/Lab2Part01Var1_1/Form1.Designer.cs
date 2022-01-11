
namespace Lab2Part01Var1_1
{
    partial class Lab1_Var1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1_Var1));
            this.textRadiusofCircle = new System.Windows.Forms.TextBox();
            this.textSideofSquare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picSquare = new System.Windows.Forms.PictureBox();
            this.picCircle = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).BeginInit();
            this.SuspendLayout();
            // 
            // textRadiusofCircle
            // 
            this.textRadiusofCircle.Location = new System.Drawing.Point(22, 52);
            this.textRadiusofCircle.Name = "textRadiusofCircle";
            this.textRadiusofCircle.Size = new System.Drawing.Size(86, 20);
            this.textRadiusofCircle.TabIndex = 0;
            // 
            // textSideofSquare
            // 
            this.textSideofSquare.Location = new System.Drawing.Point(218, 52);
            this.textSideofSquare.Name = "textSideofSquare";
            this.textSideofSquare.Size = new System.Drawing.Size(86, 20);
            this.textSideofSquare.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Радиус круга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сторона квадрата";
            // 
            // picSquare
            // 
            this.picSquare.Image = global::Lab2Part01Var1_1.Properties.Resources.ploshad_kvadrata_2;
            this.picSquare.Location = new System.Drawing.Point(322, 26);
            this.picSquare.Name = "picSquare";
            this.picSquare.Size = new System.Drawing.Size(60, 60);
            this.picSquare.TabIndex = 4;
            this.picSquare.TabStop = false;
            // 
            // picCircle
            // 
            this.picCircle.Image = global::Lab2Part01Var1_1.Properties.Resources.radius_kruga_2;
            this.picCircle.Location = new System.Drawing.Point(129, 26);
            this.picCircle.Name = "picCircle";
            this.picCircle.Size = new System.Drawing.Size(60, 60);
            this.picCircle.TabIndex = 5;
            this.picCircle.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(140, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "СРАВНИТЬ ПЛОЩАДИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // help
            // 
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help.Location = new System.Drawing.Point(22, 98);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(76, 25);
            this.help.TabIndex = 7;
            this.help.Text = "Задание";
            this.help.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Lab1_Var1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 135);
            this.Controls.Add(this.help);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picCircle);
            this.Controls.Add(this.picSquare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSideofSquare);
            this.Controls.Add(this.textRadiusofCircle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab1_Var1";
            this.Text = "СРАВНИВАТЕЛЬ ПЛОЩАДЕЙ ДВУХ ФИГУР";
            ((System.ComponentModel.ISupportInitialize)(this.picSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRadiusofCircle;
        private System.Windows.Forms.TextBox textSideofSquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picSquare;
        private System.Windows.Forms.PictureBox picCircle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button help;
    }
}
