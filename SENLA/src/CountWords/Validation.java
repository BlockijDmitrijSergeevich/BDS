package CountWords;

public class Validation {
    public static int searchWord(String message, String word) {
        message = message.toLowerCase();
        word = word.toLowerCase();
        int i = message.indexOf(word);
        int count = 0;
        while (i >= 0) {
            count++;
            i = message.indexOf(word, i + 1);
        }
        return count;
    }
}
