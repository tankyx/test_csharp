using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_2
{
    class Program
    {
        static Dictionary<String, Char> ascii_map = new Dictionary<String, Char>();

        static void init_map()
        {
            ascii_map.Add("\n #  \n# # \n### \n# # \n# # ", 'A');
            ascii_map.Add("\n##  \n# # \n##  \n# # \n##  ", 'B');
            ascii_map.Add("\n ## \n#   \n#   \n#   \n ## ", 'C');
            ascii_map.Add("\n##  \n# # \n# # \n# # \n##  ", 'D');
            ascii_map.Add("\n### \n#   \n##  \n#   \n### ", 'E');
            ascii_map.Add("\n### \n#   \n##  \n#   \n#   ", 'F');
            ascii_map.Add("\n ## \n#   \n# # \n# # \n ## ", 'G');
            ascii_map.Add("\n# # \n# # \n### \n# # \n# # ", 'H');
            ascii_map.Add("\n### \n #  \n #  \n #  \n### ", 'I');
            ascii_map.Add("\n ## \n  # \n  # \n# # \n #  ", 'J');
            ascii_map.Add("\n# # \n# # \n##  \n# # \n# # ", 'K');
            ascii_map.Add("\n#   \n#   \n#   \n#   \n### ", 'L');
            ascii_map.Add("\n# # \n### \n### \n# # \n# # ", 'M');
            ascii_map.Add("\n### \n# # \n# # \n# # \n# # ", 'N');
            ascii_map.Add("\n #  \n# # \n# # \n# # \n #  ", 'O');
            ascii_map.Add("\n##  \n# # \n##  \n#   \n#   ", 'P');
            ascii_map.Add("\n #  \n# # \n# # \n ## \n  # ", 'Q');
            ascii_map.Add("\n##  \n# # \n##  \n# # \n# # ", 'R');
            ascii_map.Add("\n ## \n#   \n #  \n  # \n##  ", 'S');
            ascii_map.Add("\n### \n #  \n #  \n #  \n #  ", 'T');
            ascii_map.Add("\n# # \n# # \n# # \n# # \n### ", 'U');
            ascii_map.Add("\n# # \n# # \n# # \n# # \n #  ", 'V');
            ascii_map.Add("\n# # \n# # \n### \n### \n# # ", 'W');
            ascii_map.Add("\n# # \n# # \n #  \n# # \n# # ", 'X');
            ascii_map.Add("\n# # \n# # \n #  \n #  \n #  ", 'Y');
            ascii_map.Add("\n### \n  # \n #  \n#   \n### ", 'Z');
        }

        static Char getCharFromAscii(String ascii)
        {
            if (ascii_map.ContainsKey(ascii))
                return ascii_map[ascii];
            else
                return '?';
        }
        static void Main(string[] args)
        {
            init_map();

            Console.Write(getCharFromAscii("\n#   \n#   \n#   \n#   \n### "));
            Console.Write(getCharFromAscii("\n# # \n# # \n# # \n# # \n### "));
            Console.Write(getCharFromAscii("\n### \n  # \n #  \n#   \n### "));
        }
    }
}
