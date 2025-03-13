public class Promptgenerator
{

    public string _date { get; private set; }
    public string _promptText { get; private set; }
    public string _entryText { get; private set; }

    public Promptgenerator(string dateText, string promptText, string entryText)
    {
        _date = dateText;
        _promptText = promptText;
        _entryText = entryText;
    }
}