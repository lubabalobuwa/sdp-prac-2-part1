using System;

namespace Problems
{
    public class Program
    {
        public string reverse(string input){
            return "HEY";
        }

        public string Prefix(string input)
        {
            if (input == null){
                return null;
            }
            if (input == String.Empty){
                return "0,0:";
            }
            int counter =0;
            string output ="";
            string[] words = input.Split();

            foreach(String s in words){
                if(s==""){

                }else{
                    counter++;
                }
            }

            int lngth = input.Length;
            int NumberOfWords = counter;
            output = $"{lngth},{NumberOfWords}:{input}";
            return output;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Prefix("Hello"));
        }
    }
}
