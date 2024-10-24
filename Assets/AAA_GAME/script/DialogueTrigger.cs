using Cinemachine;
using Platformer.Mechanics;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueCharacter
{
    public string name;
    public Sprite icon;
    //Contient nom et photo du personnage qui parle
}

[System.Serializable]
public class DialogueLine
{
    public DialogueCharacter character;
    [TextArea(3, 10)]
    public string line;
    //va utiliser la class DialogueCharacter
}
[System.Serializable]
public class Dialogue
{
    public List<DialogueLine> dialogueLines = new List<DialogueLine>();
    //Liste des lignes de dialogue pour la conversation
}
public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public bool asAnswer = false;

    public void TriggerDialogue()
    {
        DialogueManager.Instance.StartDialogue(dialogue);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!asAnswer)
        {
            TriggerDialogue();
            GameObject player = GameObject.FindWithTag("Player");
            PlayerController playerControl =player.GetComponent<PlayerController>();
            playerControl.enabled = false;

        }
        asAnswer = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("sort du collider");
    }
}
