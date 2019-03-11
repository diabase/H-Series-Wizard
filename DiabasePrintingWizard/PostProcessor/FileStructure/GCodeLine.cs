namespace DiabasePrintingWizard
{
    class GCodeLine
    {
        public string Content { get; set; }

        public double Feedrate { get; set; }        // in mm/s

        public GCodeLine(string content) => Content = content;
        public GCodeLine(string content, double feedrate)
        {
            Content = content;
            Feedrate = feedrate;
        }

        public bool UpdateFValue(char chr, double newValue)
        {
            bool found = false;
            string expression = "";
            FindParameter(chr, ref found, ref expression, true);

            if (found && expression != "")
            {
                this.Content = this.Content.Replace($"{chr}{expression}", $"{chr}" + newValue);
                return true;
            }
            return false;
        }

        public int? GetIValue(char chr)
        {
            bool found = false;
            string expression = "";
            FindParameter(chr, ref found, ref expression, false);

            if (found && expression != "")
            {
                return int.TryParse(expression, out int result) ? new int?(result) : null;
            }
            return null;
        }

        public double? GetFValue(char chr)
        {
            bool found = false;
            string expression = "";
            FindParameter(chr, ref found, ref expression, true);

            if (found && expression != "")
            {
                return double.TryParse(expression, out double result) ? new double?(result) : null;
            }
            return null;
        }

        private void FindParameter(char chr, ref bool found, ref string expression, bool decimalNumber)
        {
            bool inComment = false;
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
                    if (c == '-' || char.IsDigit(c) || (decimalNumber && c == '.'))
                    {
                        expression += c;
                    }
                    else if (c != '+')
                    {
                        break;
                    }
                }
            }
        }
    }
}