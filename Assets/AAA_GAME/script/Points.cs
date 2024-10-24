using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Points : MonoBehaviour
{
    public DialogueManager manager;
    public int score = 0;

    public void PlusOne()
    {
        score+=1;
        manager.DisplayNextDialogueLine();
    }
}
