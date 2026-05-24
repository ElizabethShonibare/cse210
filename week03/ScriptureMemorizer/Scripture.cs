using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    class Scripture
    {
        // Private fields
        private Reference _reference;
        private List<Word> _words;
        private Random _random;

        // Constructor
        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _random = new Random();

            // Convert text into Word objects
            _words = text
                .Split(' ')
                .Select(word => new Word(word))
                .ToList();
        }

        // Hide random words
        public void HideRandomWords(int numberToHide)
        {
            // Get visible words only
            List<Word> visibleWords = _words
                .Where(word => !word.IsHidden())
                .ToList();

            // Hide random visible words
            for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
            {
                int randomIndex = _random.Next(visibleWords.Count);

                visibleWords[randomIndex].Hide();

                visibleWords.RemoveAt(randomIndex);
            }
        }

        // Display scripture
        public string GetDisplayText()
        {
            string scriptureText = string.Join(" ",
                _words.Select(word => word.GetDisplayText()));

            return $"{_reference.GetDisplayText()} - {scriptureText}";
        }

        // Check if all words are hidden
        public bool IsCompletelyHidden()
        {
            return _words.All(word => word.IsHidden());
        }
    }
}