using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public bool question_1 ;
    public bool question_2 ;
    public bool question_3 ;
    public bool question_4 ;
    public bool question_5 ;

    // Constructeur pour initialiser les données du joueur
    public PlayerData(PlayerData player)
    {
        question_1 = player.question_1;
        question_2 = player.question_2;
        question_3 = player.question_3;
        question_4 = player.question_4;
        question_5 = player.question_5;
    }
}
