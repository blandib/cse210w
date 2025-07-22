using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
                     .Select(word => new Word(word))
                     .ToList();
    }

    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{wordsText}";
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide(); // Capitalization fix
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden()); // Capitalization fix
    }

    public List<Word> GetVisibleWords()
    {
        return _words.Where(w => !w.IsHidden()).ToList();
    }
    public void RevealOneHiddenWord()
    {
        var hiddenWords = _words.Where(w => w.IsHidden()).ToList();
        if (hiddenWords.Count > 0)
        {
            Random rand = new Random();
            int index = rand.Next(hiddenWords.Count);
            hiddenWords[index].Reveal();
        }
    }
}