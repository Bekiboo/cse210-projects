using System;

public class Word
{
    private string _word;
    private bool isHidden = false;

    public Word(string word)
    {
        _word = word;
    }

    public void HideWord()
    {
        isHidden = true;
    }

    public string GetWordString()
    {
        if (isHidden)
        {
            int wordLength = _word.Length;
            string blankWord = "";

            while (wordLength > 0)
            {
                blankWord += "_";
                wordLength--;
            }

            return blankWord;
        }
        else
        {
            return _word;
        }
    }
    public bool IsHidden()
    {
        return isHidden;
    }
}