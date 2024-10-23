using System.IO;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public Player player;

    // M�thode pour sauvegarder les donn�es du joueur dans un fichier JSON
    public void SavePlayerData()
    {
        // Cr�er un objet PlayerData � partir des donn�es du joueur actuel
        PlayerData data = new PlayerData(player);

        // Convertir l'objet en format JSON
        string json = JsonUtility.ToJson(data, true); // Le param�tre `true` rend le JSON format� avec des indentations

        // Sp�cifier le chemin o� le fichier JSON sera sauvegard� (ici dans le dossier "persistentDataPath")
        string path = Application.persistentDataPath + "/playerData.json";

        // Sauvegarder le fichier JSON sur le disque
        File.WriteAllText(path, json);

        Debug.Log("Player data saved to: " + path);
    }
}
