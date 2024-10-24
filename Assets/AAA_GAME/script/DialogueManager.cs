using Platformer.Mechanics;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;
    //permet d'acc�der au dialogue manager

    public TextMeshProUGUI characterName;
    public TextMeshProUGUI dialogueArea;
    //r�f�rence pour les composents Ui dans unity

    private Queue<DialogueLine> lines;
    // ont choisit une queue et non une liste parce que queue.Enqueue() ajouter des �l�ment a la fin de la queue et Dequeue retire le premier �l�ment
    // donc le premier �l�ment disparaitra plus vite que le dernier , plus facile pour lire

    public bool isDialogueActive;
    //dialogue active
    public float typingSpeed = 0.2f;
    //vitesse de frappe du text

    public CanvasGroup canvasGroup;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        lines = new Queue<DialogueLine>();

    }
    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void StartDialogue(Dialogue dialogue)
    {
        isDialogueActive = true;

        lines.Clear();

        foreach (DialogueLine dialogueLine in dialogue.dialogueLines)
        {
            lines.Enqueue(dialogueLine);
        }
        DisplayNextDialogueLine();
    }

    public void DisplayNextDialogueLine()
    {
        if (lines.Count == 0)
        {
            
            EndDialogue(); 
            return;
        }

        DialogueLine currentLine = lines.Dequeue();

        characterName.text = currentLine.character.name;

        StopAllCoroutines();
        StartCoroutine(TypeSentence(currentLine));

        
    }

    IEnumerator TypeSentence(DialogueLine dialogueLine)
    {
        dialogueArea.text = "";
        foreach (Char letter in dialogueLine.line.ToCharArray())
        {
            dialogueArea.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    void EndDialogue()
    {
        isDialogueActive = false;
        GameObject player = GameObject.FindWithTag("Player");
        PlayerController playerControl = player.GetComponent<PlayerController>();
        playerControl.enabled = true;
    }

    void Update()
    {
        if (!isDialogueActive)
        {
            canvasGroup.alpha = 0f;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }
        else
        {
            canvasGroup.alpha = 1f;
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        }

    }


}
