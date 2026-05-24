namespace ScriptureMemorizer
{
    class Word
    {
        // Private fields
        private string _text;
        private bool _isHidden;

        // Constructor
        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        // Hide the word
        public void Hide()
        {
            _isHidden = true;
        }

        // Check if word is hidden
        public bool IsHidden()
        {
            return _isHidden;
        }

        // Return display text
        public string GetDisplayText()
        {
            if (_isHidden)
            {
                return new string('_', _text.Length);
            }

            return _text;
        }
    }
}