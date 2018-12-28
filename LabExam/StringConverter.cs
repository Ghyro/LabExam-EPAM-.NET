using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam
{
    public class StringConverter
    {
        public string Convert(string s, int n)
        {
            if (s is null || string.IsNullOrEmpty(s))
            {
                throw new ArgumentNullException(nameof(s));
            }

            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            string result = s;

            for (int i = 0; i < n; i++)
            {
                var ever = string.Join(string.Empty, s.Where((ch, j) => (j + 1) % 2 == 0));

                var odd = string.Join(string.Empty, s.Where((ch, j) => (j + 1) % 2 != 0));

                result = string.Concat(odd, ever);
            }

            return result;
        }
    }
}
