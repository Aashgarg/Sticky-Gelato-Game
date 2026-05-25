using UnityEngine;
//represents a customer in the game
public class Customer : MonoBehaviour
{
    [SerializeField] private CharacterData characterData; //the character data for the customer
    [SerializeField] private OrderData[] orderData; //the list of orders that are going to be given per day
    private int currentOrderIndex; //the index of the current order in the orderData array
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void enterShop()
    {
        //customer enters the shop
    }

    void getOrder()
    {
        if (currentOrderIndex >= orderData.Length)
        {
            //customer has no more orders
        }
        else
        {
            OrderData currentOrder = orderData[currentOrderIndex];
            currentOrderIndex++;
        }
    }

    void recieveOrder()
    {
        //customer receives the order
    }

    void leaveShop()
    {
        //customer leaves the shop
    }

    void onCustomerInteraction()
    {
        //customer interacts with the player
    }

    void openDialogue()
    {
        //customer opens dialogue with the player
    }
}
