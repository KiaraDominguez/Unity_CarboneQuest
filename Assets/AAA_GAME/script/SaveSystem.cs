using System.IO;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public Player player;

    // Méthode pour sauvegarder les données du joueur dans un fichier JSON
    public void SavePlayerData()
    {
        // Créer un objet PlayerData à partir des données du joueur actuel
        PlayerData data = new PlayerData(player);

        // Convertir l'objet en format JSON
        string json = JsonUtility.ToJson(data, true); // Le paramètre `true` rend le JSON formaté avec des indentations

        // Spécifier le chemin où le fichier JSON sera sauvegardé (ici dans le dossier "persistentDataPath")
        string path = Application.persistentDataPath + "/playerData.json";

        // Sauvegarder le fichier JSON sur le disque
        File.WriteAllText(path, json);

        Debug.Log("Player data saved to: " + path);
    }
}
