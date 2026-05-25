using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Scriptable Objects/CharacterData")]
public class CharacterData : ScriptableObject
{
    public string characterName; //name of the character
    public Sprite characterSprite; //sprite of the character
    public int storylineID; //when the character appears in shop on the specific day of the storyline
    public DialogueTree dialogueTree; //the dialogue tree for the character
}
