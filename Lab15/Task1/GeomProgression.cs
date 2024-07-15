using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class GeomProgression : ISeries
    {
        int start = 1;
        int next = 1;
        int step = 1;

        int Start
        {
            get { return start; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Первый член геометрической прогресси не может быть равен 0");
                }
                start = value;
            }
        }
        int Step
        {
            get { return step; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Шаг прогресси не может быть равен 0");
                }
                step = value;
            }
        }

        public int GetNext()
        {
            next *= Step;
            return next;
        }

        public void Reset()
        {
            next = Start;
        }

        public void SetStart(int x)
        {
            Start = x;
            next = Start;
        }

        public void SetStep(int q)
        {
            Step = q;
        }
    }
}
