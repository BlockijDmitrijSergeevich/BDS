package Palindrom;

public class Validation {
    public static void Palindrom(int num){
        for (int i = 0; i <= num; i++)
        {
            if(IsPalindrome(Integer.toString(i))== true){
                IOC.PrintInt(i);
            }
        }
    }
    public static Boolean IsPalindrome(String s){
        String tmp = new StringBuilder(s).reverse().toString();
        return s.equals(tmp);
    }
}
