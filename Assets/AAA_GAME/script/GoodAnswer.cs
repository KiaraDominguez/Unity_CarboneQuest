using UnityEngine.UI;
using UnityEngine;

public class GoodAnswer : MonoBehaviour
{
    public Button myButton;
    public DialogueManager dialogueManager;

    void Update()
    {
        if (dialogueManager.isDialogueActive)
        {
            
            if (Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("Ok");
                
                if (myButton != null)
                {
                    myButton.onClick.Invoke();  
                }
            }
        }

    }

    // La méthode appelée lorsque le bouton est cliqué ou que la barre d'espace est pressée
    void OnButtonClicked()
    {
        Debug.Log("Bouton activé par la barre d'espace ou un clic !");
        // Ajouter votre logique ici, par exemple, changer de scène ou lancer une action.
    }
}
