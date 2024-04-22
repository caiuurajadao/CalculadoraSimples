namespace CalculadoraSimples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonMultiplica = new System.Windows.Forms.Button();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonSubitrai = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonApague = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonVirg = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttoncopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(28, 12);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.Size = new System.Drawing.Size(318, 98);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(271, 362);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 150);
            this.buttonEnter.TabIndex = 1;
            this.buttonEnter.Text = "=";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonMultiplica
            // 
            this.buttonMultiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplica.Location = new System.Drawing.Point(271, 206);
            this.buttonMultiplica.Name = "buttonMultiplica";
            this.buttonMultiplica.Size = new System.Drawing.Size(75, 72);
            this.buttonMultiplica.TabIndex = 2;
            this.buttonMultiplica.Text = "x";
            this.buttonMultiplica.UseVisualStyleBackColor = true;
            this.buttonMultiplica.Click += new System.EventHandler(this.buttonMultiplica_Click);
            // 
            // buttonSoma
            // 
            this.buttonSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoma.Location = new System.Drawing.Point(190, 128);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(75, 72);
            this.buttonSoma.TabIndex = 3;
            this.buttonSoma.Text = "+";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonSubitrai
            // 
            this.buttonSubitrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubitrai.Location = new System.Drawing.Point(109, 128);
            this.buttonSubitrai.Name = "buttonSubitrai";
            this.buttonSubitrai.Size = new System.Drawing.Size(75, 72);
            this.buttonSubitrai.TabIndex = 4;
            this.buttonSubitrai.Text = "-";
            this.buttonSubitrai.UseVisualStyleBackColor = true;
            this.buttonSubitrai.Click += new System.EventHandler(this.buttonSubitrai_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(271, 128);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(75, 72);
            this.buttonDivide.TabIndex = 5;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonApague
            // 
            this.buttonApague.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApague.Location = new System.Drawing.Point(28, 128);
            this.buttonApague.Name = "buttonApague";
            this.buttonApague.Size = new System.Drawing.Size(75, 72);
            this.buttonApague.TabIndex = 6;
            this.buttonApague.Text = "CE";
            this.buttonApague.UseVisualStyleBackColor = true;
            this.buttonApague.Click += new System.EventHandler(this.buttonApague_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 7;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(109, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 72);
            this.button2.TabIndex = 8;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(190, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 72);
            this.button3.TabIndex = 9;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(28, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 72);
            this.button4.TabIndex = 10;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(109, 284);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 72);
            this.button5.TabIndex = 11;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(190, 284);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 72);
            this.button6.TabIndex = 12;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(28, 206);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 72);
            this.button7.TabIndex = 13;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(109, 206);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 72);
            this.button8.TabIndex = 14;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(190, 206);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 72);
            this.button9.TabIndex = 15;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonVirg
            // 
            this.buttonVirg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVirg.Location = new System.Drawing.Point(190, 440);
            this.buttonVirg.Name = "buttonVirg";
            this.buttonVirg.Size = new System.Drawing.Size(75, 72);
            this.buttonVirg.TabIndex = 16;
            this.buttonVirg.Text = ",";
            this.buttonVirg.UseVisualStyleBackColor = true;
            this.buttonVirg.Click += new System.EventHandler(this.buttonVirg_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(109, 440);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 72);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(28, 440);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 72);
            this.buttonDel.TabIndex = 18;
            this.buttonDel.Text = "Del";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttoncopy
            // 
            this.buttoncopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncopy.Location = new System.Drawing.Point(271, 284);
            this.buttoncopy.Name = "buttoncopy";
            this.buttoncopy.Size = new System.Drawing.Size(75, 72);
            this.buttoncopy.TabIndex = 19;
            this.buttoncopy.Text = "copy";
            this.buttoncopy.UseVisualStyleBackColor = true;
            this.buttoncopy.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 562);
            this.Controls.Add(this.buttoncopy);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonVirg);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonApague);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonSubitrai);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.buttonMultiplica);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxDisplay);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonMultiplica;
        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonSubitrai;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonApague;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonVirg;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttoncopy;
    }
}

