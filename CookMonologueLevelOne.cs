public class CookMonologueLevelOne : PreLevelCookMonologBase
{
    string[] cookPhrasesStings = {"Hey!", "Well, let's start cutting vegetables and fruits?",
        "Just click on the touch in time, and you will succeed!", "I believe in you =)" };

    private void Start()
    {
        StartCoroutine(phrasesCook(cookPhrasesStings[0], cookPhrasesStings[1], cookPhrasesStings[2], cookPhrasesStings[3]));
    }
}
