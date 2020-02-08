namespace WindowsFormsAppVCL
{
    partial class Calculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnVirgule = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.gbButtons.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btnEqual);
            this.gbButtons.Controls.Add(this.btnVirgule);
            this.gbButtons.Controls.Add(this.btnAdd);
            this.gbButtons.Controls.Add(this.btn3);
            this.gbButtons.Controls.Add(this.btnSubstract);
            this.gbButtons.Controls.Add(this.btn6);
            this.gbButtons.Controls.Add(this.btnMultiply);
            this.gbButtons.Controls.Add(this.btn9);
            this.gbButtons.Controls.Add(this.btn0);
            this.gbButtons.Controls.Add(this.btn2);
            this.gbButtons.Controls.Add(this.btn5);
            this.gbButtons.Controls.Add(this.btn8);
            this.gbButtons.Controls.Add(this.btnInvert);
            this.gbButtons.Controls.Add(this.btn1);
            this.gbButtons.Controls.Add(this.btn4);
            this.gbButtons.Controls.Add(this.btn7);
            this.gbButtons.Controls.Add(this.btnDivide);
            this.gbButtons.Controls.Add(this.btnBack);
            this.gbButtons.Controls.Add(this.btnC);
            this.gbButtons.Controls.Add(this.btnCE);
            this.gbButtons.Location = new System.Drawing.Point(12, 104);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(298, 368);
            this.gbButtons.TabIndex = 2;
            this.gbButtons.TabStop = false;
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(225, 296);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(67, 65);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.buttonOperatorClick);
            // 
            // btnVirgule
            // 
            this.btnVirgule.Location = new System.Drawing.Point(152, 296);
            this.btnVirgule.Name = "btnVirgule";
            this.btnVirgule.Size = new System.Drawing.Size(67, 65);
            this.btnVirgule.TabIndex = 18;
            this.btnVirgule.Text = ",";
            this.btnVirgule.UseVisualStyleBackColor = true;
            this.btnVirgule.Click += new System.EventHandler(this.btnVirgule_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(225, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 65);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.buttonOperatorClick);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(152, 225);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 65);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(225, 154);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(67, 65);
            this.btnSubstract.TabIndex = 15;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.buttonOperatorClick);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(152, 154);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 65);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(225, 83);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(67, 65);
            this.btnMultiply.TabIndex = 13;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.buttonOperatorClick);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(152, 83);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 65);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(79, 296);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(67, 65);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(79, 225);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(67, 65);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(79, 154);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(67, 65);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(79, 83);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(67, 65);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(6, 296);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(67, 65);
            this.btnInvert.TabIndex = 7;
            this.btnInvert.Text = "+/-";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 225);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(67, 65);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 154);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(67, 65);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 83);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(67, 65);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(225, 12);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(67, 65);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.buttonOperatorClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(152, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 65);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(79, 12);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(67, 65);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(6, 12);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(67, 65);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.labelResult);
            this.gbResult.Controls.Add(this.labelCurrentOperation);
            this.gbResult.Location = new System.Drawing.Point(12, 5);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(298, 93);
            this.gbResult.TabIndex = 2;
            this.gbResult.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(268, 66);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(13, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "0";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Location = new System.Drawing.Point(6, 16);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 13);
            this.labelCurrentOperation.TabIndex = 2;
            this.labelCurrentOperation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 485);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbButtons);
            this.Name = "Form1";
            this.Text = "Calculatrice";
            this.gbButtons.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnVirgule;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.Label labelResult;
    }
}

