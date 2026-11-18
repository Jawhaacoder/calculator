namespace TooniiMashin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblFirst = new Label();
            txtFirst = new TextBox();
            lblSecond = new Label();
            txtSecond = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            lblResult = new Label();

            SuspendLayout();

            // lblFirst
            lblFirst.AutoSize = true;
            lblFirst.Location = new Point(33, 33);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(95, 25);
            lblFirst.TabIndex = 0;
            lblFirst.Text = "Эхний тоо";

            // txtFirst
            txtFirst.Location = new Point(272, 33);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(150, 31);
            txtFirst.TabIndex = 1;

            // lblSecond
            lblSecond.AutoSize = true;
            lblSecond.Location = new Point(33, 75);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(129, 25);
            lblSecond.TabIndex = 2;
            lblSecond.Text = "Хоёр дахь тоо";

            // txtSecond
            txtSecond.Location = new Point(272, 75);
            txtSecond.Name = "txtSecond";
            txtSecond.Size = new Size(150, 31);
            txtSecond.TabIndex = 3;

            // btnAdd
            btnAdd.Location = new Point(33, 118);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 45);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;

            // btnSubtract
            btnSubtract.Location = new Point(137, 118);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(80, 45);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "−";
            btnSubtract.UseVisualStyleBackColor = true;

            // btnMultiply
            btnMultiply.Location = new Point(242, 118);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(80, 45);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;

            // btnDivide
            btnDivide.Location = new Point(352, 118);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(80, 45);
            btnDivide.TabIndex = 7;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;

            // lblResult
            lblResult.AutoSize = true;
            lblResult.Location = new Point(33, 190);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(66, 25);
            lblResult.TabIndex = 8;
            lblResult.Text = "Хариу:";

            // Form1
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 344);

            Controls.Add(lblResult);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtSecond);
            Controls.Add(lblSecond);
            Controls.Add(txtFirst);
            Controls.Add(lblFirst);

            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тооны машин";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirst;
        private TextBox txtFirst;
        private Label lblSecond;
        private TextBox txtSecond;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Label lblResult;
    }
}