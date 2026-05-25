using UnityEngine;

[CreateAssetMenu(fileName = "DayData", menuName = "Scriptable Objects/DayData")]
public class DayData : ScriptableObject
{
    public int dayNumber; //the number of the day
    public Customer[] customers; //the list of customers that will appear on this day
    
}
