package String;

public class validation {
    public  static int CountLenth(String input)
    {
        int count = 0;
        if(input.length() != 0){
            count++;
            for (int i = 0; i < input.length(); i++) {
                if(input.charAt(i) == ' '){
                    count++;
                }
            }
        }
        return count;
    }

    public static void sort(String[] array) {
        for (int i = 1; i < array.length; i++) {

            for (int j = 1; j < array.length - i + 1; j++) {
                if (isGreaterThan(array[j - 1], array[j])) {
                    String tmp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = tmp;
                }
            }
        }
    }
    public static boolean isGreaterThan(String a, String b) {
        return a.compareTo(b) > 0;
    }

    public static String Regist(String s){
        char[] result = s.toCharArray();
        if(Character.isAlphabetic(result[0]))result[0]=Character.toUpperCase(result[0]);
        String res=""+result[0];
        for(int i=1;i<result.length;i++)
        {
            if(Character.isAlphabetic(result[i]) && !Character.isAlphabetic(result[i-1]))result[i]=Character.toUpperCase(result[i]);
            res+=result[i];
        }
        return res;
    }
}
