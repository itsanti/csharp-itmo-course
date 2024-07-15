using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class BracketChecker
    {
        static readonly Dictionary<char, char> brackets = new Dictionary<char, char> {
            {'(', ')'}, {'[', ']'}, {'{', '}'},
        };
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s) {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(brackets[c]);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0 || (stack.Count > 0 && stack.Peek() != c))
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }
}
