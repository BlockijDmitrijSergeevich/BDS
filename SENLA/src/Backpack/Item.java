package Backpack;

import java.util.ArrayList;

public class Item {
    public String name;
    private float weight;
    private int cost;
    public Item(String name, int cost, float weight)
    {
        this.name = name;
        if(cost <= 0 || weight <= 0)
            throw new IllegalArgumentException();
        this.weight = weight;
        this.cost = cost;
    }
    public float getWeight()
    {
        return weight;
    }
    public int getCost()
    {
        return cost;
    }
    public void setWeight(float value)
    {
        if(value <= 0)
            throw new IllegalArgumentException();
        weight = value;
    }
    public void setCost(int value)
    {
        if(value <= 0)
            throw new IllegalArgumentException();
        cost = value;
    }
    public Item copy()
    {
        return new Item(name, cost, weight);
    }

    static public Item[] ToArray(ArrayList<Item> items)
    {
        Item[] result = new Item[items.size()];
        for(int i = 0; i < result.length; i++)
        {
            result[i] = items.get(i).copy();
        }
        return result;
    }

    @Override
    public String toString() {
        return "Name: " + name + " Weight: " + weight + " Cost: " + cost;
    }
}
