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

    // La m�thode appel�e lorsque le bouton est cliqu� ou que la barre d'espace est press�e
    void OnButtonClicked()
    {
        Debug.Log("Bouton activ� par la barre d'espace ou un clic !");
        // Ajouter votre logique ici, par exemple, changer de sc�ne ou lancer une action.
    }
}
