﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Goodwin
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            Hide();
        }

        private void ViewQuotesBtn_Click(object sender, EventArgs e)
        {
            ViewQuotes viewViewQuotes = new ViewQuotes();
            viewViewQuotes.Tag = this;
            viewViewQuotes.Show(this);
            Hide();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            Hide();
        }

        private void ExitMainBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
