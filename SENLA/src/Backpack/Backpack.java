package Backpack;

import java.util.ArrayList;

public class Backpack {
    private float maxWeight;
    Item[] items;

    private ArrayList<Item> copyItems(ArrayList<Item> items)
    {
        ArrayList<Item> newItems = new ArrayList<>(items.size());
        for (Item i: items) {
            newItems.add(i.copy());
        }
        return  newItems;
    }
    private ArrayList<Item> sortItems(ArrayList<Item> items)
    {
        ArrayList<Item> sortedItems = copyItems(items);
        for (int i = 0; i < sortedItems.size(); i++)
        {
            float k = sortedItems.get(i).getCost() / sortedItems.get(i).getWeight();
            int index = i;
            for(int j = 0; j < sortedItems.size(); j++)
            {
                float temp = sortedItems.get(j).getCost() / sortedItems.get(j).getWeight();
                if(temp > k)
                {
                    k = temp;
                    index = j;
                }
            }
            Item temp = sortedItems.get(index).copy();
            sortedItems.set(index, sortedItems.get(i).copy());
            sortedItems.set(i, temp);
        }
        return sortedItems;
    }
    public Backpack(ArrayList<Item> items, float maxWeight)
    {
        this.maxWeight = maxWeight;
        ArrayList<Item> sortedItems = sortItems(items);
        ArrayList<Item> result = new ArrayList<>();
        float totalWeight = 0;
        for (int i = 0; i < sortedItems.size() && totalWeight < maxWeight; i++)
        {
            if(totalWeight + sortedItems.get(i).getWeight() <= maxWeight) {
                result.add(sortedItems.get(i).copy());
                totalWeight += sortedItems.get(i).getWeight();
            }
        }
        this.items = Item.ToArray(result);
    }
    public float getMaxWeight()
    {
        return maxWeight;
    }
    @Override
    public String toString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        float totalWeight = 0;
        for(Item item : items)
        {
            totalWeight += item.getWeight();
            stringBuilder.append(item.name + ' ' + item.getWeight() + ' ' + item.getCost() + '\n');
        }
        stringBuilder.append("Total weight:" + totalWeight);
        return stringBuilder.toString();
    }
}
