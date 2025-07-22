using System;
public class Hider
{
    private Random _random;

    public Hider()
    {
        _random = new Random();
    }
    public void HideWords(Scripture scripture, int count)
    {
        var visibleWords = scripture.GetVisibleWords();
        Random rand = new Random();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Prevent re-hiding
        }
    }
}