using UnityEngine;

[CreateAssetMenu(fileName = "DialogueTree", menuName = "Scriptable Objects/DialogueTree")]
public class DialogueTree : ScriptableObject
{
    public DialogueNode rootNode; //the starting node of the dialogue tree
    public DialogueNode[] dialogueNodes; //array of all dialogue nodes in the tree
}
