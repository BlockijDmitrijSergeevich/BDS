package String;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        try {
            int i;
            Scanner sc = new Scanner(System.in);
            Scanner sc2 = new Scanner(System.in);
            IOC.PrintLn("1 - подсчитывать количество слов в предложении\n2 - вывести слова в отсортированном виде\n3 - делать первую букву каждого слова заглавной");
            i = sc2.nextInt();
            switch (i){
                case 1:
                    IOC.PrintLn("Введите слова одной строкой через пробел");
                    String input = sc.nextLine();
                    int count = (validation.CountLenth(input));
                    IOC.PrintLn("Количество слов " + count);
                    System.out.println("Вы ввели " + count + " слов(а)");
                    break;
                case 2:
                    BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
                    ArrayList<String> list = new ArrayList<String>();
                    while (true) {
                        String s = reader.readLine();
                        if (s.isEmpty()) break;
                        list.add(s);
                    }

                    String[] array = list.toArray(new String[list.size()]);
                    validation.sort(array);

                    for (String x : array) {
                        IOC.PrintLn(x);
                    }
                    break;
                case 3:
                    String s = sc.nextLine();
                    IOC.PrintLn(validation.Regist(s));
                    break;
            }
        } catch (Exception ex) {
            IOC.PrintLn(ex.getMessage());
        }
    }
}

