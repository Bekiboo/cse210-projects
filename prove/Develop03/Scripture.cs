using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private string _text;
    private int remainingWords;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = SplitText();
    }

    // split the text into words
    public List<Word> SplitText()
    {
        // split the text into words
        string[] words = _text.Split(' ');
        // create a list of words
        List<Word> listOfWords = new List<Word>();
        // loop through the words
        foreach (string word in words)
        {
            // create a new word
            Word newWord = new Word(word);
            // add the word to the list
            listOfWords.Add(newWord);

            remainingWords++;
        }

        return listOfWords;
    }

    public string GetScriptureString()
    {
        string currentText = "";

        foreach (Word word in _words)
        {
            currentText += word.GetWordString() + " ";
        }
        return _reference.GetReferenceString() + " " + currentText;
    }

    public void HideRandomWords()
    {
        // First checks if there are less than 3 words to hide
        if (remainingWords <= 3)
        {
            foreach (Word word in _words)
            {
                word.HideWord();
            }
            remainingWords = 0;
            Console.Clear();
            Console.WriteLine(GetScriptureString());
            return;
        }

        Random random = new Random();

        for (int i = 0; i < 3; i++)
        {
            int randomIndex = random.Next(0, _words.Count);
            if (_words[randomIndex].IsHidden() == true)
            {
                i--;
                continue;
            }
            else
            {
                _words[randomIndex].HideWord();
                remainingWords--;
            }
        }
    }

    public int GetRemainingWords()
    {
        return remainingWords;
    }
}