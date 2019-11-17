package com.company;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int i = 0;
        try {
            IOC.Print("Введите целое число: ");
            if (!sc.hasNextInt()){
                throw new Exception("Введено не целое число");
            }
            if (sc.hasNextInt()) {
                i = sc.nextInt();
                if (i % 2 == 0) {
                    IOC.PrintLn(i + " четное");
                } else {
                    IOC.PrintLn("Вы ввели не четное целое число");
                }
            }

        }
        catch (Exception ex)
        {
            IOC.PrintLn(ex.getMessage());
        }
    }
}
