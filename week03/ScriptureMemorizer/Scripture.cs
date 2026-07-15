using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');

        foreach (string wordText in words)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            List<Word> availableWords = new List<Word>();

            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    availableWords.Add(word);
                }
            }

            if (availableWords.Count == 0)
            {
                return;
            }

            int randomIndex = random.Next(availableWords.Count);

            availableWords[randomIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            displayText += " " + word.GetDisplayText();
        }

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}