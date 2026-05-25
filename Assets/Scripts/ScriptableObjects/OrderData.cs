using UnityEngine;
//Stores data for gelato/coffee orders
[CreateAssetMenu(fileName = "OrderData", menuName = "Scriptable Objects/OrderData")]
public class OrderData : ScriptableObject
{
    public ContainerData containerData;
    public FlavorData[] flavorData; //array of flavors in the order
    public CoffeeData coffeeData; //coffee data for the order
    public bool whippedCream; //whether or not the order has whipped cream
}
