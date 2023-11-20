public class Word
{
    private string _word;
    private bool _isBlankedOut;
    
    public Word(string word)
    {
        _word = word;
        _isBlankedOut = false;
    }

    public Word(string word, bool isBlankedOut)
    {
        _word = word;
        _isBlankedOut = isBlankedOut;
    }

    public void BlankOut()
    {
        _isBlankedOut = true;
    }

    public void ChangeWord()
    {
        if (_isBlankedOut)
        {
            string blankword = "";
            for (int i = 0; i < _word.Length; i++)
            {
                if (char.IsLetter(_word[i]))
                {
                    blankword += "_";
                }
                else
                {
                    blankword += _word[i];
                }
            }
            _word = blankword;
        }
    }

    public string GetWord()
    {
        return _word;
    }

    public bool GetIsBlankedOut()
    {
        return _isBlankedOut;
    }
}