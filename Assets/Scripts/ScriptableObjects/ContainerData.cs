using UnityEngine;
//Stores data for gelato cup/cone
[CreateAssetMenu(fileName = "ContainerData", menuName = "Scriptable Objects/ContainerData")]
public class ContainerData : ScriptableObject
{
    public string containerType;
    public Sprite containerSprite;
    public int containerCapacity; //how many scoops can fit in the container
}
