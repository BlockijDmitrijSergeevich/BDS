package Palindrom;
import java.util.Scanner;

public class Mane {
    public static void main(String args[]){
        try {
            Scanner sc = new Scanner(System.in);
            IOC.PrintLn("Введите значение до которого проверять: ");
            int number = sc.nextInt();
            Validation.Palindrom(number);
        }catch (Exception ex)
        {
            IOC.PrintLn(ex.getMessage());
        }
    }
}
