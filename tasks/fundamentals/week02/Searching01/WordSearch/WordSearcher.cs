namespace WordSearch;

public class WordSearcher
{

    public static string? Find(string[] words, string word) {

        for (int i = 0; i < words.Length; i++) {
            if (words[i] == word) {
                return words[i];
            }
        }
        
        return null;

    }

    public static int? FindIndex(string[] words, string word) {

        for (int i = 0; i < words.Length; i++) {
            if (words[i] == word) {
                return i;
            }
        }
        return null;
    }

}
