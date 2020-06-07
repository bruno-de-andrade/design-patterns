using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
    public partial class Sentence
    {
        private readonly string[] _words;
        private readonly WordToken[] _wordTokens;

        public Sentence(string plainText)
        {
            _words = plainText.Split(' ');
            _wordTokens = new WordToken[_words.Length];
            
            for (int index = 0; index < _words.Length; index++) 
            { 
                _wordTokens[index] = new WordToken(); 
            }
        }

        public WordToken this[int index]
        {
            get
            {
                return _wordTokens[index];
            }
        }

        public override string ToString()
        {
            var words = new List<string>();

            for (var index = 0; index < _words.Length; index++)
            {
                words.Add(_wordTokens[index].Capitalize ? _words[index].ToUpperInvariant() : _words[index]);
            }

            return string.Join(' ', words);
        }
    }
}
