using UnityEngine.UI;
using UnityEngine;

public class CheckAnswer : MonoBehaviour
{
    public bool answer = false;
    public DialogueTrigger dialogueTrigger;

    private void Start()
    {

    }
    public void VraiButtonWasclicked()
    {
        answer = true;
        DialogueManager.Instance.DisplayNextDialogueLine();
        dialogueTrigger.CheckQuestion();

    }
    public void FauxButtonWasclicked()
    {
        answer = false;
        DialogueManager.Instance.DisplayNextDialogueLine();
        dialogueTrigger.CheckQuestion();

    }
}
