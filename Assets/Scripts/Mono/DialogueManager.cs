using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    DialogueNode dialogueNode; //the current dialogue node
    Customer currentCustomer; //the current customer in the game
    private bool isDialogueActive; //whether the dialogue is currently active
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartDialogue(DialogueTree dialogueTree)
    {
        dialogueNode = dialogueTree.rootNode;
        isDialogueActive = true;
    }

    void SelectChoice(int choiceIndex)
    {
        if (choiceIndex < 0 || choiceIndex >= dialogueNode.choices.Length)
        {
            Debug.LogError("Invalid choice index");
            return;
        }

        DialogueChoice selectedChoice = dialogueNode.choices[choiceIndex];
        dialogueNode = selectedChoice.nextNode;

        if (dialogueNode.isEndNode)
        {
            EndDialogue();
        }
    }

    void EndDialogue()
    {
        isDialogueActive = false;
        dialogueNode = null;
    }
}
