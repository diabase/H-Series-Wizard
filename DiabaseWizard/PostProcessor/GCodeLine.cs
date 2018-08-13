using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabaseWizard
{
    class GCodeLine
    {
        public string Content { get; set; }

        public int Tool { get; set; }
        
        public double Feedrate { get; set; }

        public GCodeLine(string content) => Content = content;

        public int? GetIValue(char chr)
        {
            bool found = false, inComment = false;
            string expression = "";

            foreach (char c in Content)
            {
                if (c == ';')
                {
                    break;
                }

                if (c == '(')
                {
                    inComment = true;
                }
                else if (inComment)
                {
                    inComment = c != ')';
                }
                else if (c == chr)
                {
                    found = true;
                }
                else if (found && !char.IsWhiteSpace(c))
                {
                    if (c == '-' || char.IsDigit(c))
                    {
                        expression += c;
                    }
                    else if (c != '+')
                    {
                        break;
                    }
                }
            }

            if (found && expression != "")
            {
                return int.TryParse(expression, out int result) ? new int?(result) : null;
            }
            return null;
        }

        public double? GetFValue(char chr)
        {
            bool found = false, inComment = false;
            string expression = "";

            foreach (char c in Content)
            {
                if (c == ';')
                {
                    break;
                }

                if (c == '(')
                {
                    inComment = true;
                }
                else if (inComment)
                {
                    inComment = c != ')';
                }
                else if (c == chr)
                {
                    found = true;
                }
                else if (found && !char.IsWhiteSpace(c))
                {
                    if (c == '-' || char.IsDigit(c) || c == '.')
                    {
                        expression += c;
                    }
                    else if (c != '+')
                    {
                        break;
                    }
                }
            }

            if (found && expression != "")
            {
                return double.TryParse(expression, out double result) ? new double?(result) : null;
            }
            return null;
        }
    }
}