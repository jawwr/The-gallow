namespace the_gallows
{
    public class Gallow
    {
        private readonly string _word;
        private int _health;
        public string GetWord() => _word;
        public int GetHealth() => _health;
        public void Mistake() => _health--;

        public Gallow(string word)
        {
            _word = word;
            _health = word.Length;
        }
    }
}