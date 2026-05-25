using UnityEngine;
//Stores data for gelato flavors
[CreateAssetMenu(fileName = "FlavorData", menuName = "Scriptable Objects/FlavorData")]
public class FlavorData : ScriptableObject
{
    public string flavorName; //can be None, Vanilla, Chocolate, Strawberry, Pistachio, Lemon, or Mint
    public Sprite flavorIcon;
    public Color flavorColor;
}
