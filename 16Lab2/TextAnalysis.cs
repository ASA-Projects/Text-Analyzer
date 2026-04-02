
public class TextAnaylsis {

    private string _text;
    private string[] _textTokens;
    private Dictionary<string, int> _textTokenDictionary = new Dictionary<string, int>();
    private string Punctuations = ".,:;?!\\'\"";

    private int NUM_SENTENCES;
    private int NUM_WORDS;
    private int NUM_UNIQUE_WORDS;


    public int NumOfSentences {
        get { return NUM_SENTENCES; }
    }

    public int NumOfWords {
        get { return NUM_WORDS; }
    }

    public int NumOfUniqueWords {
        get { return NUM_UNIQUE_WORDS; }
    }

    public Dictionary<string, int> Words {
        get { return _textTokenDictionary; }
    }

    public TextAnaylsis(string text) {
        _text = text;
        Analyze();
    }

    private void Analyze() {

        string sentencePunctuations = ".;!?";

        foreach (char letter in _text) {
            if (sentencePunctuations.Contains(letter)) {
                NUM_SENTENCES++;
            }
        } // end foreach

        foreach (char punctuation in Punctuations) {
            if (_text.Contains(punctuation)) {
                _text = _text.Replace(punctuation, ' ');
            }
        }

        _textTokens = _text.Split();

        _textTokens = _textTokens.Where(token => !string.IsNullOrWhiteSpace(token)).ToArray();

        NUM_WORDS = _textTokens.Length;

        var uniqueWords = _textTokens.Distinct();

        NUM_UNIQUE_WORDS = uniqueWords.Count();

        foreach (string token in _textTokens) {
            if (!_textTokenDictionary.ContainsKey(token)) {
                _textTokenDictionary.Add(token, 1);
            }
            else {
                _textTokenDictionary[token] += 1;
            }
        }

    } // end method

} // end class
