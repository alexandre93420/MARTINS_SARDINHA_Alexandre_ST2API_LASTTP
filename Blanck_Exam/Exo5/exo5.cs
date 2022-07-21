using System;

namespace exo5
{
    class exo5
    {
       public static void Main(string[] args)  
        {
            string test = "Marta appreciated deepperpendicular right trapezoids";
            bool a = IsSmooth(test);
            Console.Write(a);

        }
        public static bool IsSmooth(string sentence)
        {
            string word, nextWord ; 
            char lastLetter, firstLetter;
            //Make all the sentence at same case and delete all char corresponding to a white space at extremums of the string.
            sentence = sentence.Trim().ToLower();
            //We have now a sentence with space, we create a tab now with all words of the sentence separated by space.
            string[] words = sentence.Split(' ');

            foreach (var x in words)
            {
                Console.WriteLine($"Substring: {x}");
            }

            // one exit condition in the case where whe have only one.
            if (sentence.Length <= 1)
            {
                return false;
            }

            if (words.Length == 1)
            {
                return false;
            }



            //Pb d'index avec foreach

           /* foreach (var w in words)
            {
                
                //start now with the previous word in our case the first word in the tab index 0
                word = w;
                //we use now the method parse to have the real unicode char and we use in parameter the method substring of our word in the tab with the method lenght and -1 for the position.
                lastLetter = Char.Parse(word.Substring(word.Length - 1));
                //the following word as the same is the word at index +1 in the tab.
                nextWord = words[w + 1];
                Console.Write(nextWord);
                //as the same of the last char we have the first char of the word with substring index 0 to  1.
                firstLetter = Char.Parse(nextWord.Substring(0, 1));

                if (lastLetter != firstLetter)
                {
                    return false;
                }
            
            }*/

            for (int i = 0; i < words.Length - 1; i++)
            {
                //start now with the previous word in our case the first word in the tab index 0
                word = words[i];

                // Here I test if a word is composed with only letters beacause if not, it's not a word.
                foreach (char c in word)
                {
                    if(Char.IsLetter(c) == false )
                    {
                        return false;
                    }
                }
                //we use now the method parse to have the real unicode char and we use in parameter the method substring of our word in the tab with the method lenght and -1 for the position.
                lastLetter = Char.Parse(word.Substring(word.Length - 1));
                //the following word as the same is the word at index +1 in the tab.
                nextWord = words[i + 1];
                //as the same of the last char we have the first char of the word with substring index 0 to  1.
                firstLetter = Char.Parse(nextWord.Substring(0, 1));

                if (lastLetter != firstLetter)
                {
                    return false;
                }
            }

            return true;
        }
    }
}