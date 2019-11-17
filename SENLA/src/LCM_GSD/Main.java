package LCM_GSD;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        try{
        Scanner sc = new Scanner(System.in);
        IOC.PrintLn("Введите значение a и b: ");
        long x = sc.nextLong();
        long y = sc.nextLong();
        long resGcd = validation.gcd(x, y);
        long resLcm = validation.lcm(x, y);
        System.out.println(resGcd);
        System.out.println(resLcm);
    }
        catch (Exception ex)
        {
            IOC.PrintLn("Неверное значение");
        }
    }

}
