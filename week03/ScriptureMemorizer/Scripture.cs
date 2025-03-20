// Class to represent a scripture, including text and reference
using ScriptureHider;

class Scripture
    {
        public Reference Reference { get; private set; }
        public List<Word> Words { get; private set; }

        public Scripture(string book, string chapter, string verse, string text)
        {
            Reference = new Reference(book, chapter, verse);
            Words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public bool HideRandomWords(int count)
        {
            var availableWords = Words.Where(word => !word.IsHidden).ToList();
            var random = new Random();

            if (availableWords.Count == 0) return false;

            for (int i = 0; i < count && availableWords.Count > 0; i++)
            {
                int index = random.Next(availableWords.Count);
                availableWords[index].Hide();
                availableWords.RemoveAt(index);
            }

            return true;
        }

        public override string ToString()
        {
            return $"{Reference}\n{string.Join(" ", Words)}";
        }
    }
