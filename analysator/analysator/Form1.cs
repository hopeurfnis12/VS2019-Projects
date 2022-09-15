using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace analysator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		

		private void Parse(string file)
		{
			var text = textBox1.Text;
			var lexer = new PascalLexer();
			foreach (var lex in lexer.Parse(text))
				Console.WriteLine(lex);
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog { Filter = "Pascal|*.pas" };
			if (ofd.ShowDialog() == DialogResult.OK)
				Parse(ofd.FileName);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}

	class PascalLexer
	{
		private HashSet<string> operators = new HashSet<string> { "begin", "end", "function" };//and so on ....

		public IEnumerable<Lexem> Parse(string source)
		{
			foreach (var lex in RawParse(source))
			{
				if (lex.Type == LexemType.MultilineComment || lex.Type == LexemType.String) //строки и комментарии возвращаем как есть
				{
					yield return lex;
					continue;
				}

				if (lex.Type == LexemType.Identificator && lex.Content == "") continue;//игнорируем пустые идентификаторы

				if (operators.Contains(lex.Content)) lex.Type = LexemType.Operator;//есть в списке операторов? значит оператор
				else
				if (!char.IsLetterOrDigit(lex.Content[0])) lex.Type = LexemType.Separator;//сепаратор?

				//здесь можно обнаруживать другие типы лексем - числа, операторы , скобки и т.д.
				//...

				yield return lex;
			}
		}

		private IEnumerable<Lexem> RawParse(string source)
		{
			var lexem = new Lexem();

			foreach (var c in source)
				switch (lexem.Type)
				{
					case LexemType.String:
						if (c == '\'')
						{
							yield return lexem;
							lexem = new Lexem();
						}
						else
							lexem.Content += c;
						break;

					case LexemType.MultilineComment:
						if (c == '}')
						{
							yield return lexem;
							lexem = new Lexem();
						}
						else
							lexem.Content += c;
						break;

					default:
						switch (c)
						{
							//space
							case ' ':
							case '\t':
							case '\r':
							case '\n':
								yield return lexem;
								lexem = new Lexem { Type = LexemType.Identificator };
								break;
							//start of string
							case '\'':
								yield return lexem;
								lexem = new Lexem { Type = LexemType.String };
								break;
							//start of comment
							case '{':
								yield return lexem;
								lexem = new Lexem { Type = LexemType.MultilineComment };
								break;
							//identificator
							default:
								if (!char.IsLetterOrDigit(c))
								{
									yield return lexem;
									yield return new Lexem { Content = c.ToString(), Type = LexemType.Identificator };
									lexem = new Lexem();
								}
								else
									lexem.Content += c;
								break;
						}
						break;
				}

			yield return lexem;
		}
	}

	class Lexem
	{
		public LexemType Type;
		public string Content = "";

		public override string ToString()
		{
			return string.Format("{0}: {1}", Type, Content);
		}
	}

	enum LexemType
	{
		Identificator = 0, String, MultilineComment, Operator, Separator;
	}
}