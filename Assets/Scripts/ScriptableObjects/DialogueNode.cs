using UnityEngine;
//a single dialogue node in a dialogue tree
[CreateAssetMenu(fileName = "DialogueNode", menuName = "Scriptable Objects/DialogueNode")]
public class DialogueNode : ScriptableObject
{
    public int nodeID; //unique ID for the node
    public string dialogueText; //text for the node
    //public DialogueNode[] nextNodes; //array of next nodes in the dialogue tree
    public DialogueChoice[] choices; //array of choices for the node
    public bool isEndNode; //whether or not the node is an end node
}
