using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNotRepeatingCharacter
{
    class Program
    {
        static Stopwatch watch = new Stopwatch();
        public static char FirstNotRepeatingCharacter(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (var i = 0; i <= s.Length - 1; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                   dict[s[i]]++;
                    
                }
                else
                {
                    dict.Add(s[i], 1);
                }
            }
            watch.Restart();

            foreach (var pair in dict)
            {
                if (pair.Value == 1)
                {
                    return pair.Key;
                }
            }

            //Slower 
            //if (dict.ContainsValue(1))
            //{
            //    return dict.First(x => x.Value == 1).Key;
            //}

            watch.Stop();


            return '_';

        }
        static void Main(string[] args)
        {
            //string s = "abacced";
            string s = "jgiiodfmptlxojzwjrjdxwjcylaohphukwjhzxfmzllitcdarhuiodcgsrpbtdzhkkdziofwrcqtrsoimnuivwxefbokjixyjcvwjgiiodfmptlxohphukwjhzxfmzllitcdarhuiodcgsrpbtdzhkkdziofwrcqtrsoimnuivwxefbokjixyjcvwjgiiodfmptlxojzwjrjdxwjcylaohphukwjhzxfmzojzwjrjdxwjcylaohphukwjhzxfmzllitcdarhuiodcgbtdzhkkdziofwrcqtrsoimnuivwxefbokjixyjc@vwjgi";
            Console.Write(FirstNotRepeatingCharacter(s));
            Console.Write(Environment.NewLine);
            Console.Write(watch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
