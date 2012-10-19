namespace Regexdit
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("ordinary characters");
			System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("\\a");
			System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("\\b");
			System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("\\t");
			System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("\\r");
			System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("\\v");
			System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("\\f");
			System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("\\n");
			System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("\\e");
			System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("\\040");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("\\x20");
			System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("\\cC");
			System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("\\u0020");
			System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("\\");
			System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("Character Escapes", new System.Windows.Forms.TreeNode[] {
            treeNode568,
            treeNode569,
            treeNode570,
            treeNode571,
            treeNode572,
            treeNode573,
            treeNode574,
            treeNode575,
            treeNode576,
            treeNode577,
            treeNode578,
            treeNode579,
            treeNode580,
            treeNode581});
			System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("$number");
			System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("${name}");
			System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("$$");
			System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("$&");
			System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("$`");
			System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("$\'");
			System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("$+");
			System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("$_");
			System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("Substitutions", new System.Windows.Forms.TreeNode[] {
            treeNode583,
            treeNode584,
            treeNode585,
            treeNode586,
            treeNode587,
            treeNode588,
            treeNode589,
            treeNode590});
			System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode(".");
			System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("[aeiou]");
			System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("[^aeiou]");
			System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("[0-9a-fA-F]");
			System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("\\p{name}");
			System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("\\P{name}");
			System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("\\w");
			System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("\\W");
			System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("\\s");
			System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("\\S");
			System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("\\d");
			System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("\\D");
			System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("Character Classes", new System.Windows.Forms.TreeNode[] {
            treeNode592,
            treeNode593,
            treeNode594,
            treeNode595,
            treeNode596,
            treeNode597,
            treeNode598,
            treeNode599,
            treeNode600,
            treeNode601,
            treeNode602,
            treeNode603});
			System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("^");
			System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("$");
			System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("\\A");
			System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("\\Z");
			System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("\\z");
			System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("\\G");
			System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("\\b");
			System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("\\B");
			System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("Atomic Zero-Width Assertions ", new System.Windows.Forms.TreeNode[] {
            treeNode605,
            treeNode606,
            treeNode607,
            treeNode608,
            treeNode609,
            treeNode610,
            treeNode611,
            treeNode612});
			System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("*");
			System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("+");
			System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("?");
			System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("{n}");
			System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("{n,}");
			System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("{n,m}");
			System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("*?");
			System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("+?");
			System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("??");
			System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("{n}?");
			System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("{n,}?");
			System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("{n,m}?");
			System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("Quantifiers", new System.Windows.Forms.TreeNode[] {
            treeNode614,
            treeNode615,
            treeNode616,
            treeNode617,
            treeNode618,
            treeNode619,
            treeNode620,
            treeNode621,
            treeNode622,
            treeNode623,
            treeNode624,
            treeNode625});
			System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("(   )");
			System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("(?<name>   )");
			System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("(?<name1-name2> )");
			System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("(?:   )");
			System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("(?imnsx-imnsx:   )");
			System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("(?=   )");
			System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("(?!   )");
			System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("(?<=   )");
			System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("(?<!   )");
			System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("(?>   )");
			System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("Grouping Constructs ", new System.Windows.Forms.TreeNode[] {
            treeNode627,
            treeNode628,
            treeNode629,
            treeNode630,
            treeNode631,
            treeNode632,
            treeNode633,
            treeNode634,
            treeNode635,
            treeNode636});
			System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("\\number");
			System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("\\k<name>");
			System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("Backreference Constructs", new System.Windows.Forms.TreeNode[] {
            treeNode638,
            treeNode639});
			System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("|");
			System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("(?(expression)yes|no)");
			System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("(?(name)yes|no)");
			System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("Alternation Constructs", new System.Windows.Forms.TreeNode[] {
            treeNode641,
            treeNode642,
            treeNode643});
			System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("(?imnsx-imnsx)");
			System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("(?# )");
			System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("# [to end of line]");
			System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("Miscellaneous Constructs", new System.Windows.Forms.TreeNode[] {
            treeNode645,
            treeNode646,
            treeNode647});
			this.label1 = new System.Windows.Forms.Label();
			this.InputTextTextbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.RegularExpressionTextbox = new System.Windows.Forms.TextBox();
			this.MatchTextbox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ReplaceWithTextbox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.LanguageElementTreeview = new System.Windows.Forms.TreeView();
			this.regularExpressionOptionsListBox = new System.Windows.Forms.CheckedListBox();
			this.textBoxTooltip = new System.Windows.Forms.TextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input Text";
			// 
			// InputTextTextbox
			// 
			this.InputTextTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.InputTextTextbox.Location = new System.Drawing.Point(6, 25);
			this.InputTextTextbox.Multiline = true;
			this.InputTextTextbox.Name = "InputTextTextbox";
			this.InputTextTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.InputTextTextbox.Size = new System.Drawing.Size(308, 72);
			this.InputTextTextbox.TabIndex = 1;
			this.InputTextTextbox.WordWrap = false;
			this.InputTextTextbox.Enter += new System.EventHandler(this.InputTextTextbox_Enter);
			this.InputTextTextbox.Leave += new System.EventHandler(this.InputTextTextbox_Leave);
			this.InputTextTextbox.TextChanged += new System.EventHandler(this.InputTextTextbox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Regular Expression";
			// 
			// RegularExpressionTextbox
			// 
			this.RegularExpressionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.RegularExpressionTextbox.Location = new System.Drawing.Point(6, 116);
			this.RegularExpressionTextbox.Name = "RegularExpressionTextbox";
			this.RegularExpressionTextbox.Size = new System.Drawing.Size(308, 20);
			this.RegularExpressionTextbox.TabIndex = 3;
			this.RegularExpressionTextbox.Enter += new System.EventHandler(this.RegularExpressionTextbox_Enter);
			this.RegularExpressionTextbox.Leave += new System.EventHandler(this.RegularExpressionTextbox_Leave);
			this.RegularExpressionTextbox.TextChanged += new System.EventHandler(this.RegularExpressionTextbox_TextChanged);
			// 
			// MatchTextbox
			// 
			this.MatchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.MatchTextbox.Location = new System.Drawing.Point(6, 196);
			this.MatchTextbox.Multiline = true;
			this.MatchTextbox.Name = "MatchTextbox";
			this.MatchTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.MatchTextbox.Size = new System.Drawing.Size(308, 300);
			this.MatchTextbox.TabIndex = 5;
			this.MatchTextbox.WordWrap = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Result Text";
			// 
			// ReplaceWithTextbox
			// 
			this.ReplaceWithTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ReplaceWithTextbox.Location = new System.Drawing.Point(6, 155);
			this.ReplaceWithTextbox.Name = "ReplaceWithTextbox";
			this.ReplaceWithTextbox.Size = new System.Drawing.Size(308, 20);
			this.ReplaceWithTextbox.TabIndex = 7;
			this.ReplaceWithTextbox.Enter += new System.EventHandler(this.ReplaceWithTextbox_Enter);
			this.ReplaceWithTextbox.Leave += new System.EventHandler(this.ReplaceWithTextbox_Leave);
			this.ReplaceWithTextbox.TextChanged += new System.EventHandler(this.ReplaceWithTextbox_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Replace With";
			// 
			// LanguageElementTreeview
			// 
			this.LanguageElementTreeview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.LanguageElementTreeview.Location = new System.Drawing.Point(3, 100);
			this.LanguageElementTreeview.Name = "LanguageElementTreeview";
			treeNode568.Name = "Node0";
			treeNode568.Text = "ordinary characters";
			treeNode568.ToolTipText = "Characters other than . $ ^ { [ ( | ) * + ? \\ match themselves.";
			treeNode569.Name = "Node1";
			treeNode569.Text = "\\a";
			treeNode569.ToolTipText = "Matches a bell (alarm) \\u0007.";
			treeNode570.Name = "Node2";
			treeNode570.Text = "\\b";
			treeNode570.ToolTipText = "Matches a backspace \\u0008 if in a [] character class; otherwise, see the note fo" +
				"llowing this table.";
			treeNode571.Name = "Node3";
			treeNode571.Text = "\\t";
			treeNode571.ToolTipText = "Matches a tab \\u0009.";
			treeNode572.Name = "Node4";
			treeNode572.Text = "\\r";
			treeNode572.ToolTipText = "Matches a carriage return \\u000D.";
			treeNode573.Name = "Node5";
			treeNode573.Text = "\\v";
			treeNode573.ToolTipText = "Matches a vertical tab \\u000B.";
			treeNode574.Name = "Node6";
			treeNode574.Text = "\\f";
			treeNode574.ToolTipText = "Matches a form feed \\u000C.";
			treeNode575.Name = "Node7";
			treeNode575.Text = "\\n";
			treeNode575.ToolTipText = "Matches a new line \\u000A.";
			treeNode576.Name = "Node8";
			treeNode576.Text = "\\e";
			treeNode576.ToolTipText = "Matches an escape \\u001B.";
			treeNode577.Name = "Node9";
			treeNode577.Text = "\\040";
			treeNode577.ToolTipText = resources.GetString("treeNode577.ToolTipText");
			treeNode578.Name = "Node10";
			treeNode578.Text = "\\x20";
			treeNode578.ToolTipText = "Matches an ASCII character using hexadecimal representation (exactly two digits)." +
				"";
			treeNode579.Name = "Node11";
			treeNode579.Text = "\\cC";
			treeNode579.ToolTipText = "Matches an ASCII control character; for example, \\cC is control-C.";
			treeNode580.Name = "Node12";
			treeNode580.Text = "\\u0020";
			treeNode580.ToolTipText = "Matches a Unicode character using hexadecimal representation (exactly four digits" +
				").";
			treeNode581.Name = "Node13";
			treeNode581.Text = "\\";
			treeNode581.ToolTipText = "When followed by a character that is not recognized as an escaped character, matc" +
				"hes that character. For example, \\* is the same as \\x2A.";
			treeNode582.Name = "CharacterEscapesNode";
			treeNode582.Text = "Character Escapes";
			treeNode582.ToolTipText = "Most of the important regular expression language operators are unescaped single " +
				"characters";
			treeNode583.Name = "Node14";
			treeNode583.Text = "$number";
			treeNode583.ToolTipText = "Substitutes the last substring matched by group number number (decimal).";
			treeNode584.Name = "Node15";
			treeNode584.Text = "${name}";
			treeNode584.ToolTipText = "Substitutes the last substring matched by a (?<name> ) group.";
			treeNode585.Name = "Node16";
			treeNode585.Text = "$$";
			treeNode585.ToolTipText = "Substitutes a single \"$\" literal.";
			treeNode586.Name = "Node17";
			treeNode586.Text = "$&";
			treeNode586.ToolTipText = "Substitutes a copy of the entire match itself.";
			treeNode587.Name = "Node18";
			treeNode587.Text = "$`";
			treeNode587.ToolTipText = "Substitutes all the text of the input string before the match.";
			treeNode588.Name = "Node19";
			treeNode588.Text = "$\'";
			treeNode588.ToolTipText = "Substitutes all the text of the input string after the match.";
			treeNode589.Name = "Node20";
			treeNode589.Text = "$+";
			treeNode589.ToolTipText = "Substitutes the last group captured.";
			treeNode590.Name = "Node21";
			treeNode590.Text = "$_";
			treeNode590.ToolTipText = "Substitutes the entire input string.";
			treeNode591.Name = "SubstitutionsNode";
			treeNode591.Text = "Substitutions";
			treeNode591.ToolTipText = "Substitutions are allowed only within replacement patterns";
			treeNode592.Name = "Node33";
			treeNode592.Text = ".";
			treeNode592.ToolTipText = "Matches any character except \\n. If modified by the Singleline option, a period c" +
				"haracter matches any character";
			treeNode593.Name = "Node34";
			treeNode593.Text = "[aeiou]";
			treeNode593.ToolTipText = "Matches any single character included in the specified set of characters";
			treeNode594.Name = "Node35";
			treeNode594.Text = "[^aeiou]";
			treeNode594.ToolTipText = "Matches any single character not in the specified set of characters";
			treeNode595.Name = "Node36";
			treeNode595.Text = "[0-9a-fA-F]";
			treeNode595.ToolTipText = "Use of a hyphen (–) allows specification of contiguous character ranges";
			treeNode596.Name = "Node37";
			treeNode596.Text = "\\p{name}";
			treeNode596.ToolTipText = "Matches any character in the named character class specified by {name}. Supported" +
				" names are Unicode groups and block ranges. For example, Ll, Nd, Z, IsGreek, IsB" +
				"oxDrawing.";
			treeNode597.Name = "Node38";
			treeNode597.Text = "\\P{name}";
			treeNode597.ToolTipText = "Matches text not included in groups and block ranges specified in {name}.";
			treeNode598.Name = "Node39";
			treeNode598.Text = "\\w";
			treeNode598.ToolTipText = resources.GetString("treeNode598.ToolTipText");
			treeNode599.Name = "Node40";
			treeNode599.Text = "\\W";
			treeNode599.ToolTipText = resources.GetString("treeNode599.ToolTipText");
			treeNode600.Name = "Node41";
			treeNode600.Text = "\\s";
			treeNode600.ToolTipText = resources.GetString("treeNode600.ToolTipText");
			treeNode601.Name = "Node42";
			treeNode601.Text = "\\S";
			treeNode601.ToolTipText = resources.GetString("treeNode601.ToolTipText");
			treeNode602.Name = "Node43";
			treeNode602.Text = "\\d";
			treeNode602.ToolTipText = "Matches any decimal digit. Equivalent to \\p{Nd} for Unicode and [0-9] for non-Uni" +
				"code, ECMAScript behavior.";
			treeNode603.Name = "Node44";
			treeNode603.Text = "\\D";
			treeNode603.ToolTipText = "Matches any nondigit. Equivalent to \\P{Nd} for Unicode and [^0-9] for non-Unicode" +
				", ECMAScript behavior.";
			treeNode604.Name = "CharacterClassesNode";
			treeNode604.Text = "Character Classes";
			treeNode604.ToolTipText = "A character class is a set of characters that will find a match if any one of the" +
				" characters included in the set matches";
			treeNode605.Name = "Node45";
			treeNode605.Text = "^";
			treeNode605.ToolTipText = "Specifies that the match must occur at the beginning of the string or the beginni" +
				"ng of the line. For more information, see the Multiline option in Regular Expres" +
				"sion Options";
			treeNode606.Name = "Node46";
			treeNode606.Text = "$";
			treeNode606.ToolTipText = resources.GetString("treeNode606.ToolTipText");
			treeNode607.Name = "Node47";
			treeNode607.Text = "\\A";
			treeNode607.ToolTipText = "Specifies that the match must occur at the beginning of the string (ignores the M" +
				"ultiline option).";
			treeNode608.Name = "Node48";
			treeNode608.Text = "\\Z";
			treeNode608.ToolTipText = "Specifies that the match must occur at the end of the string or before \\n at the " +
				"end of the string (ignores the Multiline option).";
			treeNode609.Name = "Node49";
			treeNode609.Text = "\\z";
			treeNode609.ToolTipText = "Specifies that the match must occur at the end of the string (ignores the Multili" +
				"ne option).";
			treeNode610.Name = "Node50";
			treeNode610.Text = "\\G";
			treeNode610.ToolTipText = "Specifies that the match must occur at the point where the previous match ended. " +
				"When used with Match.NextMatch(), this ensures that matches are all contiguous.";
			treeNode611.Name = "Node51";
			treeNode611.Text = "\\b";
			treeNode611.ToolTipText = resources.GetString("treeNode611.ToolTipText");
			treeNode612.Name = "Node52";
			treeNode612.Text = "\\B";
			treeNode612.ToolTipText = "Specifies that the match must not occur on a \\b boundary";
			treeNode613.Name = "Node4";
			treeNode613.Text = "Atomic Zero-Width Assertions ";
			treeNode613.ToolTipText = "Causes a match to succeed or fail depending on the current position in the string" +
				"";
			treeNode614.Name = "Node53";
			treeNode614.Text = "*";
			treeNode614.ToolTipText = "Specifies zero or more matches; for example, \\w* or (abc)*. Equivalent to {0,}.";
			treeNode615.Name = "Node54";
			treeNode615.Text = "+";
			treeNode615.ToolTipText = "Specifies one or more matches; for example, \\w+ or (abc)+. Equivalent to {1,}.";
			treeNode616.Name = "Node55";
			treeNode616.Text = "?";
			treeNode616.ToolTipText = "Specifies zero or one matches; for example, \\w? or (abc)?. Equivalent to {0,1}.";
			treeNode617.Name = "Node56";
			treeNode617.Text = "{n}";
			treeNode617.ToolTipText = "Specifies exactly n matches; for example, (pizza){2}.";
			treeNode618.Name = "Node57";
			treeNode618.Text = "{n,}";
			treeNode618.ToolTipText = "Specifies at least n matches; for example, (abc){2,}.";
			treeNode619.Name = "Node58";
			treeNode619.Text = "{n,m}";
			treeNode619.ToolTipText = "Specifies at least n, but no more than m, matches.";
			treeNode620.Name = "Node59";
			treeNode620.Text = "*?";
			treeNode620.ToolTipText = "Specifies the first match that consumes as few repeats as possible (equivalent to" +
				" lazy *).";
			treeNode621.Name = "Node60";
			treeNode621.Text = "+?";
			treeNode621.ToolTipText = "Specifies as few repeats as possible, but at least one (equivalent to lazy +).";
			treeNode622.Name = "Node61";
			treeNode622.Text = "??";
			treeNode622.ToolTipText = "Specifies zero repeats if possible, or one (lazy ?).";
			treeNode623.Name = "Node62";
			treeNode623.Text = "{n}?";
			treeNode623.ToolTipText = "Equivalent to {n} (lazy {n}).";
			treeNode624.Name = "Node63";
			treeNode624.Text = "{n,}?";
			treeNode624.ToolTipText = "Specifies as few repeats as possible, but at least n (lazy {n,}).";
			treeNode625.Name = "Node64";
			treeNode625.Text = "{n,m}?";
			treeNode625.ToolTipText = "Specifies as few repeats as possible between n and m (lazy {n,m}).";
			treeNode626.Name = "Node5";
			treeNode626.Text = "Quantifiers";
			treeNode626.ToolTipText = resources.GetString("treeNode626.ToolTipText");
			treeNode627.Name = "Node69";
			treeNode627.Text = "(   )";
			treeNode627.ToolTipText = resources.GetString("treeNode627.ToolTipText");
			treeNode628.Name = "Node70";
			treeNode628.Text = "(?<name>   )";
			treeNode628.ToolTipText = resources.GetString("treeNode628.ToolTipText");
			treeNode629.Name = "Node71";
			treeNode629.Text = "(?<name1-name2> )";
			treeNode629.ToolTipText = resources.GetString("treeNode629.ToolTipText");
			treeNode630.Name = "Node72";
			treeNode630.Text = "(?:   )";
			treeNode630.ToolTipText = "Noncapturing group.";
			treeNode631.Name = "Node73";
			treeNode631.Text = "(?imnsx-imnsx:   )";
			treeNode631.ToolTipText = resources.GetString("treeNode631.ToolTipText");
			treeNode632.Name = "Node74";
			treeNode632.Text = "(?=   )";
			treeNode632.ToolTipText = resources.GetString("treeNode632.ToolTipText");
			treeNode633.Name = "Node75";
			treeNode633.Text = "(?!   )";
			treeNode633.ToolTipText = "Zero-width negative lookahead assertion. Continues match only if the subexpressio" +
				"n does not match at this position on the right. For example, \\b(?!un)\\w+\\b match" +
				"es words that do not begin with un.";
			treeNode634.Name = "Node76";
			treeNode634.Text = "(?<=   )";
			treeNode634.ToolTipText = resources.GetString("treeNode634.ToolTipText");
			treeNode635.Name = "Node77";
			treeNode635.Text = "(?<!   )";
			treeNode635.ToolTipText = "Zero-width negative lookbehind assertion. Continues match only if the subexpressi" +
				"on does not match at the position on the left.";
			treeNode636.Name = "Node78";
			treeNode636.Text = "(?>   )";
			treeNode636.ToolTipText = resources.GetString("treeNode636.ToolTipText");
			treeNode637.Name = "Node6";
			treeNode637.Text = "Grouping Constructs ";
			treeNode637.ToolTipText = "Grouping constructs allow you to capture groups of subexpressions and to increase" +
				" the efficiency of regular expressions with noncapturing lookahead and lookbehin" +
				"d modifiers";
			treeNode638.Name = "Node83";
			treeNode638.Text = "\\number";
			treeNode638.ToolTipText = "Backreference. For example, (\\w)\\1 finds doubled word characters.";
			treeNode639.Name = "Node84";
			treeNode639.Text = "\\k<name>";
			treeNode639.ToolTipText = resources.GetString("treeNode639.ToolTipText");
			treeNode640.Name = "Node7";
			treeNode640.Text = "Backreference Constructs";
			treeNode640.ToolTipText = "optional parameters that add backreference modifiers to a regular expression";
			treeNode641.Name = "Node86";
			treeNode641.Text = "|";
			treeNode641.ToolTipText = "Matches any one of the terms separated by the | (vertical bar) character; for exa" +
				"mple, cat|dog|tiger. The leftmost successful match wins";
			treeNode642.Name = "Node87";
			treeNode642.Text = "(?(expression)yes|no)";
			treeNode642.ToolTipText = resources.GetString("treeNode642.ToolTipText");
			treeNode643.Name = "Node88";
			treeNode643.Text = "(?(name)yes|no)";
			treeNode643.ToolTipText = resources.GetString("treeNode643.ToolTipText");
			treeNode644.Name = "Node85";
			treeNode644.Text = "Alternation Constructs";
			treeNode644.ToolTipText = "special characters that modify a regular expression to allow either/or matching";
			treeNode645.Name = "Node90";
			treeNode645.Text = "(?imnsx-imnsx)";
			treeNode645.ToolTipText = resources.GetString("treeNode645.ToolTipText");
			treeNode646.Name = "Node91";
			treeNode646.Text = "(?# )";
			treeNode646.ToolTipText = "Inline comment inserted within a regular expression. The comment terminates at th" +
				"e first closing parenthesis character";
			treeNode647.Name = "Node92";
			treeNode647.Text = "# [to end of line]";
			treeNode647.ToolTipText = resources.GetString("treeNode647.ToolTipText");
			treeNode648.Name = "Node89";
			treeNode648.Text = "Miscellaneous Constructs";
			treeNode648.ToolTipText = "subexpressions that modify a regular expression";
			this.LanguageElementTreeview.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode582,
            treeNode591,
            treeNode604,
            treeNode613,
            treeNode626,
            treeNode637,
            treeNode640,
            treeNode644,
            treeNode648});
			this.LanguageElementTreeview.ShowNodeToolTips = true;
			this.LanguageElementTreeview.Size = new System.Drawing.Size(259, 294);
			this.LanguageElementTreeview.TabIndex = 8;
			this.LanguageElementTreeview.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.LanguageElementTreeview_NodeMouseDoubleClick);
			this.LanguageElementTreeview.Enter += new System.EventHandler(this.LanguageElementTreeview_Enter);
			this.LanguageElementTreeview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.LanguageElementTreeview_AfterSelect);
			this.LanguageElementTreeview.Leave += new System.EventHandler(this.LanguageElementTreeview_Leave);
			// 
			// regularExpressionOptionsListBox
			// 
			this.regularExpressionOptionsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.regularExpressionOptionsListBox.CheckOnClick = true;
			this.regularExpressionOptionsListBox.FormattingEnabled = true;
			this.regularExpressionOptionsListBox.Items.AddRange(new object[] {
            "None",
            "IgnoreCase",
            "Multiline",
            "ExplicitCapture",
            "Singleline",
            "IgnorePatternWhitespace"});
			this.regularExpressionOptionsListBox.Location = new System.Drawing.Point(3, 0);
			this.regularExpressionOptionsListBox.Name = "regularExpressionOptionsListBox";
			this.regularExpressionOptionsListBox.Size = new System.Drawing.Size(262, 94);
			this.regularExpressionOptionsListBox.TabIndex = 9;
			this.regularExpressionOptionsListBox.ThreeDCheckBoxes = true;
			this.regularExpressionOptionsListBox.Leave += new System.EventHandler(this.regularExpressionOptionsListBox_Leave);
			this.regularExpressionOptionsListBox.Enter += new System.EventHandler(this.regularExpressionOptionsListBox_Enter);
			this.regularExpressionOptionsListBox.SelectedIndexChanged += new System.EventHandler(this.regularExpressionOptionsListBox_SelectedIndexChanged);
			this.regularExpressionOptionsListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.regularExpressionOptionsListBox_ItemCheck);
			// 
			// textBoxTooltip
			// 
			this.textBoxTooltip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxTooltip.Location = new System.Drawing.Point(0, 0);
			this.textBoxTooltip.Multiline = true;
			this.textBoxTooltip.Name = "textBoxTooltip";
			this.textBoxTooltip.Size = new System.Drawing.Size(265, 98);
			this.textBoxTooltip.TabIndex = 10;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.InputTextTextbox);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.RegularExpressionTextbox);
			this.splitContainer1.Panel1.Controls.Add(this.ReplaceWithTextbox);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.MatchTextbox);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(586, 499);
			this.splitContainer1.SplitterDistance = 317;
			this.splitContainer1.TabIndex = 11;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.LanguageElementTreeview);
			this.splitContainer2.Panel1.Controls.Add(this.regularExpressionOptionsListBox);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.textBoxTooltip);
			this.splitContainer2.Size = new System.Drawing.Size(265, 499);
			this.splitContainer2.SplitterDistance = 397;
			this.splitContainer2.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 499);
			this.Controls.Add(this.splitContainer1);
			this.MinimumSize = new System.Drawing.Size(422, 413);
			this.Name = "MainForm";
			this.Text = "Regexdit 1.0 - by Patware";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputTextTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RegularExpressionTextbox;
        private System.Windows.Forms.TextBox MatchTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReplaceWithTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView LanguageElementTreeview;
        private System.Windows.Forms.CheckedListBox regularExpressionOptionsListBox;
		private System.Windows.Forms.TextBox textBoxTooltip;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

