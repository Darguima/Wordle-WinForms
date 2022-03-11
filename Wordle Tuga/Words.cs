using System;
using System.Collections.Generic;

using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace Wordle_Tuga
{
    public struct WordsStruct
    {
        public List<String> four;
        public List<String> five;
        public List<String> six;
        public List<String> seven;
    }

    internal class Words
    {
        Random rnd = new Random();

        private readonly List<String> four = new List<String>();
        private readonly List<String> five = new List<String>();
        private readonly List<String> six = new List<String>();
        private readonly List<String> seven = new List<String>();

        public List<String> getWordsList(int amountOfLetters)
        {
            switch (amountOfLetters)
            {
                case 4: return four;
                case 5: return five;
                case 6: return six;
                case 7: return seven;

                default: return new List<string>();
            }
        }

        public bool wordExists(string word)
        {
            return this.getWordsList(word.Length).Contains(word.ToLower());
        }

        public string randomWord(int amountOfLetters)
        {
            var getWordsList = this.getWordsList(amountOfLetters);

            return getWordsList[rnd.Next(0, getWordsList.Count)].ToUpper();
        }

        public Words()
        {
            var assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream("Wordle_Tuga.Resources.dictionary.json"))
            using (StreamReader reader = new StreamReader(stream))
            {
                var words = JsonConvert.DeserializeObject<WordsStruct>(reader.ReadToEnd());

                four = words.four;
                five = words.five;
                six = words.six;
                seven = words.seven;
            }
        }
    }
}
