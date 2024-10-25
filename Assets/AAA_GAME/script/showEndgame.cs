using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class showEndgame : MonoBehaviour
{
    public Button button;
    void Start()
    {
        button.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        button.interactable = true;
        button.gameObject.SetActive(true);
    }
}
