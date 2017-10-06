using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    public class Estatistica
    {
        public Estatistica()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if (AvarageGrade >= 90)
                {
                    result= "A";
                }
                else if(AvarageGrade >= 80) {
                    result= "B";
                }
                else if (AvarageGrade >=70)
                {
                    result = "C";
                } else if (AvarageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    default:
                        result = "Failing";
                        break;
                }
                return result;
            }
        }

        public float AvarageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
