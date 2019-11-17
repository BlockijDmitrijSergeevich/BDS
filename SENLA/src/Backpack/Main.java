package Backpack;
import java.util.Scanner;
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        Task6.task();
    }
}
enum Action
{
    Add, Calculate, Nothing
}

class Input
{
    static Scanner scanner = new Scanner(System.in);
    static public Action CheckAction() {
        if (scanner.hasNextInt()) {
            switch (scanner.nextInt()) {
                case 1:
                    return Action.Add;
                case 2:
                    return Action.Calculate;
                default:
                    return Action.Nothing;
            }
        }
        scanner.next();
        return Action.Nothing;
    }
    static public Item NextItem()
    {
        try {
            System.out.println("Input name: ");
            String name = scanner.next();
            System.out.println("Input cost: ");
            int cost = scanner.nextInt();
            System.out.println("Input weight: ");
            float weight = scanner.nextFloat();
            return new Item(name, cost, weight);
        }
        catch (Exception e)
        {
            return null;
        }
    }
    static float InputWeight()
    {
        System.out.println("Input max weight");
        while (!scanner.hasNextInt())
        {
            scanner.next();
            System.out.println("Input error");
        }
        return scanner.nextFloat();
    }

}

class Task6 {
    static void PrintArray(ArrayList<Item> items)
    {
        for(Item i : items)
            System.out.println(i);
    }
    static void PrintBackpack(Backpack backpack)
    {
        if(backpack != null)
            System.out.println("Backpack:\n" + backpack);
    }
    static void PrintMenu()
    {
        System.out.println("1. Add item\n2. Calculate");
    }
    public static boolean task() {
        float maxWeight = Input.InputWeight();
        ArrayList<Item> items = new ArrayList<>();
        Backpack backpack = null;
        while (true) {
            PrintMenu();
            Action action = Input.CheckAction();
            switch (action) {
                case Add:
                    Item i = Input.NextItem();
                    if (i != null)
                        items.add(i);
                    break;
                case Calculate:
                    backpack = new Backpack(items, maxWeight);
                    PrintBackpack(backpack);
                    return true;
                case Nothing:
                    continue;
            }
            PrintArray(items);
        }
    }

}