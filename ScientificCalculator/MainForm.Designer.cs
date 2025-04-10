namespace ScientificCalculator
{
    partial class MainForm
    {
        public ComboBox comboBoxOperation;
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
            //ComboBox comboBoxOperation;
            textBoxNumber1 = new TextBox();
            textBoxNumber2 = new TextBox();
            buttonCalculateBasic = new Button();
            labelResultBasic = new Label();
            labelBasicSign = new Label();
            label1 = new Label();
            textBoxEquation = new TextBox();
            label2 = new Label();
            labelResultEquation = new Label();
            buttonSolveEquation = new Button();
            label3 = new Label();
            buttonSolveIntegral = new Button();
            labelResultIntegral = new Label();
            label5 = new Label();
            textBoxIntegral = new TextBox();
            label6 = new Label();
            textBoxEdge2 = new TextBox();
            textBoxEdge1 = new TextBox();
            comboBoxOperation = new ComboBox();
            SuspendLayout();
            // 
            // textBoxNumber1
            // 
            textBoxNumber1.Location = new Point(187, 16);
            textBoxNumber1.Name = "textBoxNumber1";
            textBoxNumber1.Size = new Size(47, 23);
            textBoxNumber1.TabIndex = 1;
            // 
            // textBoxNumber2
            // 
            textBoxNumber2.Location = new Point(266, 16);
            textBoxNumber2.Name = "textBoxNumber2";
            textBoxNumber2.Size = new Size(47, 23);
            textBoxNumber2.TabIndex = 1;
            // 
            // buttonCalculateBasic
            // 
            buttonCalculateBasic.Location = new Point(667, 20);
            buttonCalculateBasic.Name = "buttonCalculateBasic";
            buttonCalculateBasic.Size = new Size(99, 24);
            buttonCalculateBasic.TabIndex = 2;
            buttonCalculateBasic.Text = "Вычислить";
            buttonCalculateBasic.UseVisualStyleBackColor = true;
            buttonCalculateBasic.Click += buttonCalculateBasic_Click;
            // 
            // labelResultBasic
            // 
            labelResultBasic.AutoSize = true;
            labelResultBasic.Location = new Point(345, 19);
            labelResultBasic.Name = "labelResultBasic";
            labelResultBasic.Size = new Size(0, 15);
            labelResultBasic.TabIndex = 3;
            // 
            // labelBasicSign
            // 
            labelBasicSign.AutoSize = true;
            labelBasicSign.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelBasicSign.Location = new Point(240, 11);
            labelBasicSign.Name = "labelBasicSign";
            labelBasicSign.Size = new Size(26, 28);
            labelBasicSign.TabIndex = 3;
            labelBasicSign.Text = "+";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 4;
            label1.Text = "Y=";
            // 
            // textBoxEquation
            // 
            textBoxEquation.Location = new Point(48, 69);
            textBoxEquation.Name = "textBoxEquation";
            textBoxEquation.Size = new Size(102, 23);
            textBoxEquation.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(150, 64);
            label2.Name = "label2";
            label2.Size = new Size(37, 28);
            label2.TabIndex = 6;
            label2.Text = "x=";
            // 
            // labelResultEquation
            // 
            labelResultEquation.AutoSize = true;
            labelResultEquation.Font = new Font("Segoe UI", 9F);
            labelResultEquation.Location = new Point(187, 69);
            labelResultEquation.Name = "labelResultEquation";
            labelResultEquation.Size = new Size(0, 15);
            labelResultEquation.TabIndex = 7;
            // 
            // buttonSolveEquation
            // 
            buttonSolveEquation.Location = new Point(667, 70);
            buttonSolveEquation.Name = "buttonSolveEquation";
            buttonSolveEquation.Size = new Size(99, 24);
            buttonSolveEquation.TabIndex = 8;
            buttonSolveEquation.Text = "Вычислить";
            buttonSolveEquation.UseVisualStyleBackColor = true;
            buttonSolveEquation.Click += buttonSolveEquation_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(319, 11);
            label3.Name = "label3";
            label3.Size = new Size(26, 28);
            label3.TabIndex = 9;
            label3.Text = "=";
            // 
            // buttonSolveIntegral
            // 
            buttonSolveIntegral.Location = new Point(667, 133);
            buttonSolveIntegral.Name = "buttonSolveIntegral";
            buttonSolveIntegral.Size = new Size(99, 24);
            buttonSolveIntegral.TabIndex = 14;
            buttonSolveIntegral.Text = "Вычислить";
            buttonSolveIntegral.UseVisualStyleBackColor = true;
            buttonSolveIntegral.Click += buttonSolveIntegral_Click;
            // 
            // labelResultIntegral
            // 
            labelResultIntegral.AutoSize = true;
            labelResultIntegral.Font = new Font("Segoe UI", 9F);
            labelResultIntegral.Location = new Point(168, 141);
            labelResultIntegral.Name = "labelResultIntegral";
            labelResultIntegral.Size = new Size(0, 15);
            labelResultIntegral.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(136, 133);
            label5.Name = "label5";
            label5.Size = new Size(26, 28);
            label5.TabIndex = 12;
            label5.Text = "=";
            // 
            // textBoxIntegral
            // 
            textBoxIntegral.Location = new Point(29, 138);
            textBoxIntegral.Name = "textBoxIntegral";
            textBoxIntegral.Size = new Size(102, 23);
            textBoxIntegral.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.Location = new Point(11, 130);
            label6.Name = "label6";
            label6.Size = new Size(24, 28);
            label6.TabIndex = 10;
            label6.Text = "∫";
            // 
            // textBoxEdge2
            // 
            textBoxEdge2.Location = new Point(13, 109);
            textBoxEdge2.Name = "textBoxEdge2";
            textBoxEdge2.Size = new Size(16, 23);
            textBoxEdge2.TabIndex = 15;
            // 
            // textBoxEdge1
            // 
            textBoxEdge1.Location = new Point(13, 167);
            textBoxEdge1.Name = "textBoxEdge1";
            textBoxEdge1.Size = new Size(16, 23);
            textBoxEdge1.TabIndex = 16;
            // 
            // comboBoxOperation
            // 
            comboBoxOperation.AutoCompleteMode = AutoCompleteMode.Append;
            comboBoxOperation.FormattingEnabled = true;
            comboBoxOperation.Items.AddRange(new object[] { "Сложение", "Вычитание", "Умножение", "Деление" });
            comboBoxOperation.Location = new Point(29, 16);
            comboBoxOperation.Name = "comboBoxOperation";
            comboBoxOperation.Size = new Size(121, 23);
            comboBoxOperation.TabIndex = 0;
            comboBoxOperation.SelectedIndexChanged += comboBoxOperation_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 202);
            Controls.Add(textBoxEdge1);
            Controls.Add(textBoxEdge2);
            Controls.Add(buttonSolveIntegral);
            Controls.Add(labelResultIntegral);
            Controls.Add(label5);
            Controls.Add(textBoxIntegral);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(buttonSolveEquation);
            Controls.Add(labelResultEquation);
            Controls.Add(label2);
            Controls.Add(textBoxEquation);
            Controls.Add(label1);
            Controls.Add(labelBasicSign);
            Controls.Add(labelResultBasic);
            Controls.Add(buttonCalculateBasic);
            Controls.Add(textBoxNumber2);
            Controls.Add(textBoxNumber1);
            Controls.Add(comboBoxOperation);
            Name = "MainForm";
            Text = "Научный калькулятор";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox textBoxNumber1;
        private TextBox textBoxNumber2;
        private Button buttonCalculateBasic;
        private Label labelResultBasic;
        private Label labelBasicSign;
        private Label label1;
        private TextBox textBoxEquation;
        private Label label2;
        private Label labelResultEquation;
        private Button buttonSolveEquation;
        private Label label3;
        private Button buttonSolveIntegral;
        private Label labelResultIntegral;
        private Label label5;
        private TextBox textBoxIntegral;
        private Label label6;
        private TextBox textBoxEdge2;
        private TextBox textBoxEdge1;
    }
}
