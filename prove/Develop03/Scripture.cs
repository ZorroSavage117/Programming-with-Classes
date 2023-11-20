public class Scripture
{
    private List<Word> scripture;
    private bool _isBlankedOut;
    private Random rand;

    public Scripture(string scripture_in)
    {
        scripture = new List<Word>();
        string[] words = scripture_in.Split(' ');
        foreach (string word in words)
        {
            scripture.Add(new Word(word));
        }

        rand = new Random();
        _isBlankedOut = false;
    }

    public void display()
    {
        foreach (Word word in scripture)
        {
            Console.Write(word.GetWord() + " ");
        }
        Console.WriteLine();
    }

    private void SetisBlankedOut()
    {
        foreach (Word word in scripture)
        {
            if (word.GetIsBlankedOut() == false)
            {
                _isBlankedOut = false;
                break;
            }
            else
            {
                _isBlankedOut = true;
            }
        }
    }

    public bool GetisBlankedOut()
    {
        return _isBlankedOut;
    }

    public void blankingOut()
    {
        int maxattempts = 2;

        for (int i = 0; i < maxattempts; i++)
        {
            int num = rand.Next(0, scripture.Count());
            if (scripture[num].GetIsBlankedOut() == false)
            {
                scripture[num].BlankOut();
                scripture[num].ChangeWord();
                break;
            }
        }

        SetisBlankedOut();
    }
}