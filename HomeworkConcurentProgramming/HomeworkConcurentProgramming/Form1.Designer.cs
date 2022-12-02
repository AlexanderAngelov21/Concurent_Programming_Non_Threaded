namespace HomeworkConcurentProgramming
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
            this.countWordsBtn = new System.Windows.Forms.Button();
            this.textBoxWords = new System.Windows.Forms.TextBox();
            this.textBoxShortestWord = new System.Windows.Forms.TextBox();
            this.shortestWordBtn = new System.Windows.Forms.Button();
            this.longestWordBtn = new System.Windows.Forms.Button();
            this.textBoxLongestWord = new System.Windows.Forms.TextBox();
            this.textBoxAverageCount = new System.Windows.Forms.TextBox();
            this.averageCountBtn = new System.Windows.Forms.Button();
            this.fiveMostCommonBtn = new System.Windows.Forms.Button();
            this.textBox5MostCommon = new System.Windows.Forms.TextBox();
            this.fiveLeastCommonBtn = new System.Windows.Forms.Button();
            this.textBox5LeastCommon = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // countWordsBtn
            // 
            this.countWordsBtn.AutoSize = true;
            this.countWordsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.countWordsBtn.Location = new System.Drawing.Point(2, 2);
            this.countWordsBtn.Name = "countWordsBtn";
            this.countWordsBtn.Size = new System.Drawing.Size(197, 30);
            this.countWordsBtn.TabIndex = 0;
            this.countWordsBtn.Text = "Show me number of words";
            this.countWordsBtn.UseVisualStyleBackColor = true;
            this.countWordsBtn.Click += new System.EventHandler(this.countWordsBtn_Click);
            // 
            // textBoxWords
            // 
            this.textBoxWords.Location = new System.Drawing.Point(2, 38);
            this.textBoxWords.Multiline = true;
            this.textBoxWords.Name = "textBoxWords";
            this.textBoxWords.Size = new System.Drawing.Size(197, 133);
            this.textBoxWords.TabIndex = 1;
            // 
            // textBoxShortestWord
            // 
            this.textBoxShortestWord.Location = new System.Drawing.Point(205, 38);
            this.textBoxShortestWord.Multiline = true;
            this.textBoxShortestWord.Name = "textBoxShortestWord";
            this.textBoxShortestWord.Size = new System.Drawing.Size(197, 133);
            this.textBoxShortestWord.TabIndex = 2;
            // 
            // shortestWordBtn
            // 
            this.shortestWordBtn.Location = new System.Drawing.Point(205, 3);
            this.shortestWordBtn.Name = "shortestWordBtn";
            this.shortestWordBtn.Size = new System.Drawing.Size(197, 29);
            this.shortestWordBtn.TabIndex = 3;
            this.shortestWordBtn.Text = "Show me shortest word";
            this.shortestWordBtn.UseVisualStyleBackColor = true;
            this.shortestWordBtn.Click += new System.EventHandler(this.shortestWordBtn_Click);
            // 
            // longestWordBtn
            // 
            this.longestWordBtn.Location = new System.Drawing.Point(408, 3);
            this.longestWordBtn.Name = "longestWordBtn";
            this.longestWordBtn.Size = new System.Drawing.Size(197, 29);
            this.longestWordBtn.TabIndex = 4;
            this.longestWordBtn.Text = "Show me longest word";
            this.longestWordBtn.UseVisualStyleBackColor = true;
            this.longestWordBtn.Click += new System.EventHandler(this.longestWordBtn_Click);
            // 
            // textBoxLongestWord
            // 
            this.textBoxLongestWord.Location = new System.Drawing.Point(408, 39);
            this.textBoxLongestWord.Multiline = true;
            this.textBoxLongestWord.Name = "textBoxLongestWord";
            this.textBoxLongestWord.Size = new System.Drawing.Size(197, 133);
            this.textBoxLongestWord.TabIndex = 5;
            // 
            // textBoxAverageCount
            // 
            this.textBoxAverageCount.Location = new System.Drawing.Point(611, 39);
            this.textBoxAverageCount.Multiline = true;
            this.textBoxAverageCount.Name = "textBoxAverageCount";
            this.textBoxAverageCount.Size = new System.Drawing.Size(197, 132);
            this.textBoxAverageCount.TabIndex = 6;
            // 
            // averageCountBtn
            // 
            this.averageCountBtn.Location = new System.Drawing.Point(611, 3);
            this.averageCountBtn.Name = "averageCountBtn";
            this.averageCountBtn.Size = new System.Drawing.Size(197, 29);
            this.averageCountBtn.TabIndex = 7;
            this.averageCountBtn.Text = "Average Letter Count";
            this.averageCountBtn.UseVisualStyleBackColor = true;
            this.averageCountBtn.Click += new System.EventHandler(this.averageCountBtn_Click);
            // 
            // fiveMostCommonBtn
            // 
            this.fiveMostCommonBtn.Location = new System.Drawing.Point(2, 177);
            this.fiveMostCommonBtn.Name = "fiveMostCommonBtn";
            this.fiveMostCommonBtn.Size = new System.Drawing.Size(197, 29);
            this.fiveMostCommonBtn.TabIndex = 8;
            this.fiveMostCommonBtn.Text = "5 Most common words";
            this.fiveMostCommonBtn.UseVisualStyleBackColor = true;
            this.fiveMostCommonBtn.Click += new System.EventHandler(this.fiveMostCommonBtn_Click);
            // 
            // textBox5MostCommon
            // 
            this.textBox5MostCommon.Location = new System.Drawing.Point(2, 212);
            this.textBox5MostCommon.Multiline = true;
            this.textBox5MostCommon.Name = "textBox5MostCommon";
            this.textBox5MostCommon.Size = new System.Drawing.Size(197, 221);
            this.textBox5MostCommon.TabIndex = 9;
            // 
            // fiveLeastCommonBtn
            // 
            this.fiveLeastCommonBtn.Location = new System.Drawing.Point(205, 177);
            this.fiveLeastCommonBtn.Name = "fiveLeastCommonBtn";
            this.fiveLeastCommonBtn.Size = new System.Drawing.Size(218, 29);
            this.fiveLeastCommonBtn.TabIndex = 10;
            this.fiveLeastCommonBtn.Text = "5 Least common words";
            this.fiveLeastCommonBtn.UseVisualStyleBackColor = true;
            this.fiveLeastCommonBtn.Click += new System.EventHandler(this.fiveLeastCommonBtn_Click);
            // 
            // textBox5LeastCommon
            // 
            this.textBox5LeastCommon.Location = new System.Drawing.Point(205, 212);
            this.textBox5LeastCommon.Multiline = true;
            this.textBox5LeastCommon.Name = "textBox5LeastCommon";
            this.textBox5LeastCommon.Size = new System.Drawing.Size(218, 221);
            this.textBox5LeastCommon.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 457);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(125, 29);
            this.progressBar1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 518);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox5LeastCommon);
            this.Controls.Add(this.fiveLeastCommonBtn);
            this.Controls.Add(this.textBox5MostCommon);
            this.Controls.Add(this.fiveMostCommonBtn);
            this.Controls.Add(this.averageCountBtn);
            this.Controls.Add(this.textBoxAverageCount);
            this.Controls.Add(this.textBoxLongestWord);
            this.Controls.Add(this.longestWordBtn);
            this.Controls.Add(this.shortestWordBtn);
            this.Controls.Add(this.textBoxShortestWord);
            this.Controls.Add(this.textBoxWords);
            this.Controls.Add(this.countWordsBtn);
            this.Name = "Form1";
            this.Text = "Homework App (Non threaded version)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button countWordsBtn;
        private TextBox textBoxWords;
        private TextBox textBoxShortestWord;
        private Button shortestWordBtn;
        private Button longestWordBtn;
        private TextBox textBoxLongestWord;
        private TextBox textBoxAverageCount;
        private Button averageCountBtn;
        private Button fiveMostCommonBtn;
        private TextBox textBox5MostCommon;
        private Button fiveLeastCommonBtn;
        private TextBox textBox5LeastCommon;
        private ProgressBar progressBar1;
    }
}