using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string playerName = "kiki";
    public int health;
    public int level;
    // Constructeur pour initialiser les données du joueur
    public PlayerData(PlayerData player)
    {
        playerName = player.playerName;
        health = player.health;
        level = player.level;
    }
}
