using UnityEngine;
//a single choice in a dialogue node
[CreateAssetMenu(fileName = "DialogueChoice", menuName = "Scriptable Objects/DialogueChoice")]
public class DialogueChoice : ScriptableObject
{
    public string choiceText; //text for the choice
    public DialogueNode nextNode; //the next node that this choice leads to
}
