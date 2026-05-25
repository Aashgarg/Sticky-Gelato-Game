using UnityEngine;
// controls game flow, customer switching and the day switching
public class GameManager : MonoBehaviour
{
    [SerializeField] private int totalDays; //the total number of days in the game
    [SerializeField] private DayData[] dayData; //the data for each day in the game
    public int currentDay; //the current day of the game
    private Customer currentCustomer; //the current customer in the game
    private int currentCustomerIndex; //the index of the current customer in the dayData array
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartDay()
    {
        curentDay++;
        customers = dayData[currentDay].customers;
        currentCustomerIndex = 0;
    }

    void EndDay()
    {
        currentDay++;
        if (currentDay >= totalDays)
        {
            //end game
        }
        else
        {
            StartDay();
        }
    }

    void NextCustomer()
    {
        currentCustomerIndex++;
        if (currentCustomerIndex >= dayData[currentDay].customers.Length)
        {
            EndDay();
        }
        else
        {
            currentCustomer = dayData[currentDay].customers[currentCustomerIndex];
        }
    }
}
