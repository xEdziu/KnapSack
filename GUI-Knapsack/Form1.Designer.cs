namespace GUI_Knapsack
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
            runButton = new Button();
            numberTextBox = new TextBox();
            seedTextBox = new TextBox();
            capacityTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            resultListBox = new ListBox();
            label4 = new Label();
            itemsListBox = new ListBox();
            label5 = new Label();
            clearButton = new Button();
            SuspendLayout();
            // 
            // runButton
            // 
            runButton.Location = new Point(72, 233);
            runButton.Name = "runButton";
            runButton.Size = new Size(125, 29);
            runButton.TabIndex = 0;
            runButton.Text = "Uruchom";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(72, 61);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(125, 27);
            numberTextBox.TabIndex = 1;
            // 
            // seedTextBox
            // 
            seedTextBox.Location = new Point(72, 123);
            seedTextBox.Name = "seedTextBox";
            seedTextBox.Size = new Size(125, 27);
            seedTextBox.TabIndex = 2;
            // 
            // capacityTextBox
            // 
            capacityTextBox.Location = new Point(72, 185);
            capacityTextBox.Name = "capacityTextBox";
            capacityTextBox.Size = new Size(125, 27);
            capacityTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 38);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 4;
            label1.Text = "Ilość przedmiotów";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 100);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 5;
            label2.Text = "Ziarno";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 162);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 6;
            label3.Text = "Pojemność";
            // 
            // resultListBox
            // 
            resultListBox.FormattingEnabled = true;
            resultListBox.Location = new Point(72, 335);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new Size(235, 244);
            resultListBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 312);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Wynik";
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.Location = new Point(329, 55);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(278, 524);
            itemsListBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 32);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 10;
            label5.Text = "Przedmioty";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(72, 268);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(125, 29);
            clearButton.TabIndex = 11;
            clearButton.Text = "Wyczyść";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 607);
            Controls.Add(clearButton);
            Controls.Add(label5);
            Controls.Add(itemsListBox);
            Controls.Add(label4);
            Controls.Add(resultListBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(capacityTextBox);
            Controls.Add(seedTextBox);
            Controls.Add(numberTextBox);
            Controls.Add(runButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button runButton;
        private TextBox numberTextBox;
        private TextBox seedTextBox;
        private TextBox capacityTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox resultListBox;
        private Label label4;
        private ListBox itemsListBox;
        private Label label5;
        private Button clearButton;
    }
}
