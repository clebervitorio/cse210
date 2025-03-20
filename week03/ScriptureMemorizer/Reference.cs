    // Class to represent a scripture reference
    class Reference
    {
        public string Book { get; private set; }
        public string Chapter { get; private set; }
        public string Verse { get; private set; }
 
        public Reference(string book, string chapter, string verse)
        {
            Book = book;
            Chapter = chapter;
            Verse = verse;
        }
 
        public override string ToString()
        {
            return $"{Book} {Chapter}:{Verse}";
        }
    }
