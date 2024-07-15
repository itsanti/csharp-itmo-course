using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ArithProgression : ISeries
    {
        int start = 0;
        int next = 0;
        int step = 1;

        int Step {
            get { return step; }
            set {
                if ( value == 0 )
                {
                    throw new ArgumentException("Шаг прогресси не может быть равен 0");
                }
                step = value;
            }
        }

        public int GetNext()
        {
            next += Step;
            return next;
        }

        public void Reset()
        {
            next = start;
        }

        public void SetStart(int x)
        {
            start = x;
            next = start;
        }

        public void SetStep(int d)
        {
            Step = d;
        }
    }
}
