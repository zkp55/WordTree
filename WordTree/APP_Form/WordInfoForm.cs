﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordTree.Model;

namespace APP_Form
{
    public partial class WordInfoForm : Form
    {
        public WordInfoForm(Word targetWord)
        {
            InitializeComponent();
            label_Word.Text = targetWord.word;
            label_meanCN.Text = targetWord.Mean_cn;
            label_meanEN.Text = targetWord.Mean_en;
            label_Example.Text = targetWord.Sentence + "\n" + targetWord.Sentence_trans;
            label_phrase.Text = targetWord.Sentence_phrase; 
            label_etyma.Text = targetWord.Word_etyma;
            VoicePlayer.URL = "http://dict.youdao.com/dictvoice?type=1&audio=" + targetWord.word;
            VoicePlayer.Ctlcontrols.play();

        }

        private void button_Voice_Click(object sender, EventArgs e)
        {
            VoicePlayer.Ctlcontrols.play();
        }
    }
}
