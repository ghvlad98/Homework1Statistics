namespace HandlersCS
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CEButton = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.ButtonSIx = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonX = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(12, 12);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(544, 23);
            this.UserInputText.TabIndex = 0;
            this.UserInputText.MouseEnter += new System.EventHandler(this.UserInputText_MouseEnter);
            this.UserInputText.MouseLeave += new System.EventHandler(this.UserInputText_MouseLeave);
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationResultText.Location = new System.Drawing.Point(12, 38);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(544, 16);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "Please enter an equation and press enter or =";
            this.CalculationResultText.Click += new System.EventHandler(this.CalculationResultText_Click);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 4);
            this.ButtonsPanel.Controls.Add(this.ButtonEquals, 3, 4);
            this.ButtonsPanel.Controls.Add(this.ButtonPoint, 2, 4);
            this.ButtonsPanel.Controls.Add(this.ButtonZero, 1, 4);
            this.ButtonsPanel.Controls.Add(this.ButtonPlus, 3, 3);
            this.ButtonsPanel.Controls.Add(this.ButtonThree, 2, 3);
            this.ButtonsPanel.Controls.Add(this.ButtonTwo, 1, 3);
            this.ButtonsPanel.Controls.Add(this.ButtonOne, 0, 3);
            this.ButtonsPanel.Controls.Add(this.buttonMinus, 3, 2);
            this.ButtonsPanel.Controls.Add(this.ButtonSIx, 2, 2);
            this.ButtonsPanel.Controls.Add(this.ButtonFive, 1, 2);
            this.ButtonsPanel.Controls.Add(this.ButtonFour, 0, 2);
            this.ButtonsPanel.Controls.Add(this.ButtonX, 3, 1);
            this.ButtonsPanel.Controls.Add(this.DelButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.ButtonSeven, 0, 1);
            this.ButtonsPanel.Controls.Add(this.ButtonEight, 1, 1);
            this.ButtonsPanel.Controls.Add(this.ButtonNine, 2, 1);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 54);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(544, 463);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // CEButton
            // 
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 371);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(130, 89);
            this.CEButton.TabIndex = 20;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEquals.Location = new System.Drawing.Point(411, 371);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(130, 89);
            this.ButtonEquals.TabIndex = 19;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // ButtonPoint
            // 
            this.ButtonPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPoint.Location = new System.Drawing.Point(275, 371);
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.Size = new System.Drawing.Size(130, 89);
            this.ButtonPoint.TabIndex = 18;
            this.ButtonPoint.Text = ".";
            this.ButtonPoint.UseVisualStyleBackColor = true;
            this.ButtonPoint.Click += new System.EventHandler(this.ButtonPoint_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonZero.Location = new System.Drawing.Point(139, 371);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(130, 89);
            this.ButtonZero.TabIndex = 17;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = true;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPlus.Location = new System.Drawing.Point(411, 279);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(130, 86);
            this.ButtonPlus.TabIndex = 15;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonThree.Location = new System.Drawing.Point(275, 279);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(130, 86);
            this.ButtonThree.TabIndex = 14;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = true;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTwo.Location = new System.Drawing.Point(139, 279);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(130, 86);
            this.ButtonTwo.TabIndex = 13;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = true;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonOne.Location = new System.Drawing.Point(3, 279);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(130, 86);
            this.ButtonOne.TabIndex = 12;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = true;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMinus.Location = new System.Drawing.Point(411, 187);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(130, 86);
            this.buttonMinus.TabIndex = 11;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // ButtonSIx
            // 
            this.ButtonSIx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSIx.Location = new System.Drawing.Point(275, 187);
            this.ButtonSIx.Name = "ButtonSIx";
            this.ButtonSIx.Size = new System.Drawing.Size(130, 86);
            this.ButtonSIx.TabIndex = 10;
            this.ButtonSIx.Text = "6";
            this.ButtonSIx.UseVisualStyleBackColor = true;
            this.ButtonSIx.Click += new System.EventHandler(this.ButtonSIx_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonFive.Location = new System.Drawing.Point(139, 187);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(130, 86);
            this.ButtonFive.TabIndex = 9;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = true;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonFour.Location = new System.Drawing.Point(3, 187);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(130, 86);
            this.ButtonFour.TabIndex = 8;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = true;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonX
            // 
            this.ButtonX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonX.Location = new System.Drawing.Point(411, 95);
            this.ButtonX.Name = "ButtonX";
            this.ButtonX.Size = new System.Drawing.Size(130, 86);
            this.ButtonX.TabIndex = 7;
            this.ButtonX.Text = "X";
            this.ButtonX.UseVisualStyleBackColor = true;
            this.ButtonX.Click += new System.EventHandler(this.ButtonX_Click);
            // 
            // DelButton
            // 
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Location = new System.Drawing.Point(275, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(130, 86);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.Location = new System.Drawing.Point(411, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(130, 86);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSeven.Location = new System.Drawing.Point(3, 95);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(130, 86);
            this.ButtonSeven.TabIndex = 4;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = true;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEight.Location = new System.Drawing.Point(139, 95);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(130, 86);
            this.ButtonEight.TabIndex = 5;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = true;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNine.Location = new System.Drawing.Point(275, 95);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(130, 86);
            this.ButtonNine.TabIndex = 6;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = true;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.ButtonEquals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(568, 529);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserInputText);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UserInputText;
        private Label CalculationResultText;
        private TableLayoutPanel ButtonsPanel;
        private Button ButtonEquals;
        private Button ButtonPoint;
        private Button ButtonZero;
        private Button ButtonPlus;
        private Button ButtonThree;
        private Button ButtonTwo;
        private Button ButtonOne;
        private Button buttonMinus;
        private Button ButtonSIx;
        private Button ButtonFive;
        private Button ButtonFour;
        private Button ButtonX;
        private Button DelButton;
        private Button DivideButton;
        private Button ButtonSeven;
        private Button ButtonEight;
        private Button ButtonNine;
        private Button CEButton;
    }
}