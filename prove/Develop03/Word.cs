public class Word
{
    private string _verseText; // this is a word text eg. "for";
    private bool _isHidden;

    public Word(string text) 
    {
        _verseText = text;
        _isHidden = false;
    }

    public void Hide()
    {   
        // To hide letter in a word in a scripture verse.
        // Check if the word is hidden, if word not hidden hide.
        // _verseText = "for" , _ishidden = false
        //TODO _verseText = "___" , _ishidden = True
        // Update _ishidden to true after hiding. 
        if (_isHidden == false)
        {
            foreach (char letter in _verseText)
            {     
                _verseText = "_";
            }

            _isHidden = true;
        }
    }

    public void Show()
    {
        foreach(char letter in _verseText)
        {   
            _isHidden = false;
        }
    }

    public bool IsHidden()
    {
        // Needs to check if the word is hidden. If hidden return true. Other wise False.
        if (_isHidden == true)
        {
            foreach (char letter in _verseText)
            {
                _isHidden = true;
            }   
        return _isHidden;
        }

        else
        {
            foreach (char letter in _verseText)
            {
                _isHidden = false;
            }
        }
        return _isHidden;
          
    }


    public string GetDisplayVerseText()
    {   
        return _verseText;
    }

}