namespace prof_elec_1_Calculator
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btnSub = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMulti = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDiv = new Button();
            btnResult = new Button();
            btnDot = new Button();
            btn0 = new Button();
            button17 = new Button();
            btnClear = new Button();
            btnReset = new Button();
            btnCopy = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(264, 99);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Location = new Point(14, 204);
            btn7.Name = "btn7";
            btn7.Size = new Size(61, 67);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(81, 204);
            btn8.Name = "btn8";
            btn8.Size = new Size(61, 67);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNum_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(148, 204);
            btn9.Name = "btn9";
            btn9.Size = new Size(61, 67);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNum_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(215, 204);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(61, 67);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(215, 277);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(61, 67);
            btnSub.TabIndex = 8;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(148, 277);
            btn6.Name = "btn6";
            btn6.Size = new Size(61, 67);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(81, 277);
            btn5.Name = "btn5";
            btn5.Size = new Size(61, 67);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNum_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(14, 277);
            btn4.Name = "btn4";
            btn4.Size = new Size(61, 67);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNum_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(215, 350);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(61, 67);
            btnMulti.TabIndex = 12;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(148, 350);
            btn3.Name = "btn3";
            btn3.Size = new Size(61, 67);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(81, 350);
            btn2.Name = "btn2";
            btn2.Size = new Size(61, 67);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNum_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(14, 350);
            btn1.Name = "btn1";
            btn1.Size = new Size(61, 67);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNum_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(215, 423);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(61, 67);
            btnDiv.TabIndex = 16;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(148, 423);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(61, 67);
            btnResult.TabIndex = 15;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click_1;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(81, 423);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(61, 67);
            btnDot.TabIndex = 14;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(14, 423);
            btn0.Name = "btn0";
            btn0.Size = new Size(61, 67);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNum_Click;
            // 
            // button17
            // 
            button17.Location = new Point(215, 131);
            button17.Name = "button17";
            button17.Size = new Size(61, 67);
            button17.TabIndex = 20;
            button17.Text = "⌫";
            button17.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(148, 131);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 67);
            btnClear.TabIndex = 19;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(81, 131);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(61, 67);
            btnReset.TabIndex = 18;
            btnReset.Text = "CE";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(14, 131);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(61, 67);
            btnCopy.TabIndex = 17;
            btnCopy.Text = ":)";
            btnCopy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 503);
            Controls.Add(button17);
            Controls.Add(btnClear);
            Controls.Add(btnReset);
            Controls.Add(btnCopy);
            Controls.Add(btnDiv);
            Controls.Add(btnResult);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnMulti);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnSub);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btnSub;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnMulti;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDiv;
        private Button btnResult;
        private Button btnDot;
        private Button btn0;
        private Button button17;
        private Button btnClear;
        private Button btnReset;
        private Button btnCopy;
    }
}
