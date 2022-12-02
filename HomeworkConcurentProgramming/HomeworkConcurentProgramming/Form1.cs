using System.Text.RegularExpressions;
using System.IO;
using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace HomeworkConcurentProgramming
{
    public partial class Form1 : Form
    {
        static string filePath = "C:\\Users\\Asi\\Desktop\\book.txt";//paste your text file path here
        static FileStream fs = new FileStream(filePath, FileMode.Open);
        static StreamReader sr = new StreamReader(fs);
        public Form1()
        {
            InitializeComponent();
        }
      
        private void countWordsBtn_Click(object sender, EventArgs e)
        {
           
            string content = sr.ReadToEnd();
            content = content.Replace("\r\n", "\r");
            int charCount = content.Length;
            int lineCount = content.Split('\r').Length;
            content = content.Replace('\r', ' ');
            List<string> words = content.Split(' ').ToList();
            List<string> countWords = new List<string>();
            foreach(string word in words)
            {
                countWords.Add(Regex.Match(word, @"\w{3,}").Value);
            }         
            int WordsCount = countWords.Count;
            textBoxWords.Text = $"Брой думи с 3 или повече букви: {WordsCount} ,общ брой букви на думите: {charCount} ,редове: {lineCount}";
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                double pow = Math.Pow(j, j);
                progressBar1.PerformStep();
            }
        }

        private void shortestWordBtn_Click(object sender, EventArgs e)
        {
            string content=sr.ReadToEnd();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '!','?' };
            List<string> list=content.Split(delimiterChars).ToList();
            string shortestWord=list.OrderBy(n => n.Length).Where(n=>n.Length>=3).FirstOrDefault();
            textBoxShortestWord.Text = shortestWord;
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                double pow = Math.Pow(j, j);
                progressBar1.PerformStep();
            }
        }

        private void longestWordBtn_Click(object sender, EventArgs e)
        {
            string content = sr.ReadToEnd();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '!', '?' };
            List<string> list = content.Split(delimiterChars).ToList();
            string longestWord = list.OrderByDescending(n => n.Length).Where(n => n.Length >= 3).FirstOrDefault();
            textBoxLongestWord.Text = longestWord;
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                double pow = Math.Pow(j, j);
                progressBar1.PerformStep();
            }
        }

        private void averageCountBtn_Click(object sender, EventArgs e)
        {
            string content = sr.ReadToEnd();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '!', '?' };
            var list = content.Split(delimiterChars).ToList();
            var averageCount = list.Average(n => n.Length);
            textBoxAverageCount.Text = $"Средна дължина на думите(букви): {averageCount.ToString("#.##")}";
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                double pow = Math.Pow(j, j);
                progressBar1.PerformStep();
            }
        }

        private void fiveMostCommonBtn_Click(object sender, EventArgs e)
        {
            string content=sr.ReadToEnd();
            string[] splitWords = content.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var commonWords = splitWords.ToList().GroupBy(e => e).Select(g => new { Value = g.Key, Count = g.Count() }).OrderByDescending(e => e.Count).Where(l=>l.Value.Length>=3).Take(5);
            foreach (var x in commonWords)
            {
                textBox5MostCommon.Text += $"Дума: \"{x.Value}\" среща се - \"{x.Count}\" пъти. "; 
            }
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                double pow = Math.Pow(j, j);
                progressBar1.PerformStep();
            }
        }

        private void fiveLeastCommonBtn_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Thread.Sleep(10000);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           ts.Hours, ts.Minutes, ts.Seconds,
           ts.Milliseconds / 10);

            string content = sr.ReadToEnd();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '!', '?' };

            string[] splitWords = content.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            var commonWords = splitWords.ToList().GroupBy(e => e).Select(g => new { Value = g.Key, Count = g.Count() }).OrderBy(e => e.Count).Where(l => l.Value.Length >= 3).Take(5);
            foreach (var x in commonWords)
            {
                textBox5LeastCommon.Text += $"Дума: \"{x.Value}\" среща се - \"{x.Count}\" пъти. ";
            }
            textBox5LeastCommon.Text += ts;
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                double pow = Math.Pow(j, j);
                progressBar1.PerformStep();
            }
            
        }
    }
}