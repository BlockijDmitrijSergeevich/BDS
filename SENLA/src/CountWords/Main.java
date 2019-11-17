package CountWords;
import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        try{
            Scanner sc = new Scanner(System.in);
            IOC.PrintLn("Ввдите предложение: ");
            String message = sc.nextLine();
            IOC.PrintLn("Введите слово для проверки");
            String word = sc.nextLine();
            int countWord = Validation.searchWord(message, word);
            IOC.PrintInt(countWord);

        }catch (Exception ex)
        {
            IOC.PrintLn(ex.getMessage());
        }
    }
}
