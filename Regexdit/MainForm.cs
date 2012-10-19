using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Regexdit
{
    public partial class MainForm : Form
    {
		private Control _currentControl = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InputTextTextbox_TextChanged(object sender, EventArgs e)
        {
			if (_currentControl == this.InputTextTextbox)
				go();
        }

        private void RegularExpressionTextbox_TextChanged(object sender, EventArgs e)
        {
			if (_currentControl == this.RegularExpressionTextbox)
            {
                checkOptions();
                go();
            }
        }
        private void ReplaceWithTextbox_TextChanged(object sender, EventArgs e)
        {
			if (_currentControl == ReplaceWithTextbox)
				go();
        }
        private void go()
        {
            if (this.ReplaceWithTextbox.Text.Trim().Length > 0)
                this.MatchTextbox.Text = getReplaces(this.InputTextTextbox.Text, this.RegularExpressionTextbox.Text, this.ReplaceWithTextbox.Text);
            else
                this.MatchTextbox.Text = getMatches(this.InputTextTextbox.Text, this.RegularExpressionTextbox.Text);

        }
        private void checkOptions()
        {
            Regex regex = new Regex(@"^\(?.*\)");

            //if there's a regex option portion
            if (regex.IsMatch(this.RegularExpressionTextbox.Text))
            {
                Match m = regex.Match(this.RegularExpressionTextbox.Text);

                if (this.RegularExpressionTextbox.SelectionStart < m.Value.Length)
                {
                    //The change was performed in the options portion
                    
                    int positionOfMinus = m.Value.IndexOf('-');
                    if (positionOfMinus==-1) positionOfMinus = m.Value.Length+1;

                    bool isChecked;

                    for(int i = 2;i<m.Value.Length;i++)
                    {
                        isChecked = i<positionOfMinus;

                        switch(m.Value.Substring(i,1))
                        {
                            case "i":
                                this.regularExpressionOptionsListBox.SetItemChecked(1,isChecked);
                                break;
                            case "m":
                                this.regularExpressionOptionsListBox.SetItemChecked(2,isChecked);
                                break;
                            case "n":
                                this.regularExpressionOptionsListBox.SetItemChecked(3,isChecked);
                                break;
                            case "s":
                                this.regularExpressionOptionsListBox.SetItemChecked(4,isChecked);
                                break;
                            case "x":
                                this.regularExpressionOptionsListBox.SetItemChecked(5,isChecked);
                                break;


                        }
                    }
                }
            }

        }
        private string getMatches(string inputText, string pattern)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                Regex regex = new Regex(pattern);

                MatchCollection matches = regex.Matches(inputText);

                foreach (Match match in matches)
                {
                    sb.AppendFormat("{0}: {1}", match.Index, match.Value);
                    sb.AppendLine();
                }
            }
            catch (Exception ex)
            {
                sb.Append(ex.Message);
            }

            return sb.ToString();
        }
        private string getReplaces(string inputText, string pattern, string replaceWith)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                Regex regex = new Regex(pattern);

                MatchEvaluator evaluator = new MatchEvaluator(ReplaceCC);

                sb.Append(regex.Replace(inputText, evaluator));

            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }
            return sb.ToString();
        }

        private string ReplaceCC(Match m)
        {
            return ReplaceWithTextbox.Text;
        }

        private string getOptionInlineCharacter(int index)
        {
            string option = "";

            switch (index)
            {
                case 1: //IgnoreCase
                    option = "i";
                    break;
                case 2:
                    option = "m";
                    break;
                case 3:
                    option = "n";
                    break;
                case 4:
                    option = "s";
                    break;
                case 5:
                    option = "x";
                    break;
            }

            return option;
        }

        private void regularExpressionOptionsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (ActiveControl.Name == this.regularExpressionOptionsListBox.Name)
            {
                StringBuilder optionsON = new StringBuilder();
                StringBuilder optionsOFF = new StringBuilder();
                string options = "";

                if ((e.Index == 0 && e.NewValue == CheckState.Unchecked) || (e.Index>0 && !this.regularExpressionOptionsListBox.GetItemChecked(0)))
                {
                    for (int i = 1; i < this.regularExpressionOptionsListBox.Items.Count; i++)
                    {
                        if (i == e.Index)
                        {
                            if (e.NewValue == CheckState.Checked)
                                optionsON.Append(getOptionInlineCharacter(i));
                            else
                                optionsOFF.Append(getOptionInlineCharacter(i));
                        }
                        else
                        {
                            if (this.regularExpressionOptionsListBox.GetItemChecked(i))
                                optionsON.Append(getOptionInlineCharacter(i));
                            else
                                optionsOFF.Append(getOptionInlineCharacter(i));
                        }
                    }

                    options = "(?" + optionsON.ToString() + "-" + optionsOFF.ToString() + ":)";
                }

                Regex regex = new Regex(@"^\(?.*\)");

                if (regex.IsMatch(this.RegularExpressionTextbox.Text))
                {
                    this.RegularExpressionTextbox.Text = regex.Replace(this.RegularExpressionTextbox.Text, options);
                }
                else
                {
                    this.RegularExpressionTextbox.Text = options + this.RegularExpressionTextbox.Text;
                }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LanguageElementTreeview_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                this.RegularExpressionTextbox.AppendText(e.Node.Text);
            }
        }

		private void LanguageElementTreeview_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.textBoxTooltip.Text = string.Format("{0}{1}{2}{3}", e.Node.Text, Environment.NewLine, Environment.NewLine, e.Node.ToolTipText);
		}

		private void RegularExpressionTextbox_Enter(object sender, EventArgs e)
		{
			_currentControl = RegularExpressionTextbox;
		}

		private void regularExpressionOptionsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void InputTextTextbox_Enter(object sender, EventArgs e)
		{
			_currentControl = InputTextTextbox;

		}

		private void ReplaceWithTextbox_Enter(object sender, EventArgs e)
		{
			_currentControl = ReplaceWithTextbox;

		}

		private void regularExpressionOptionsListBox_Enter(object sender, EventArgs e)
		{
			_currentControl = regularExpressionOptionsListBox;

		}

		private void LanguageElementTreeview_Enter(object sender, EventArgs e)
		{
			_currentControl = LanguageElementTreeview;

		}

		private void LanguageElementTreeview_Leave(object sender, EventArgs e)
		{
			_currentControl = null;
		}

		private void regularExpressionOptionsListBox_Leave(object sender, EventArgs e)
		{
			_currentControl = null;

		}

		private void InputTextTextbox_Leave(object sender, EventArgs e)
		{
			_currentControl = null;

		}

		private void RegularExpressionTextbox_Leave(object sender, EventArgs e)
		{
			_currentControl = null;

		}

		private void ReplaceWithTextbox_Leave(object sender, EventArgs e)
		{
			_currentControl = null;

		}



    }
}