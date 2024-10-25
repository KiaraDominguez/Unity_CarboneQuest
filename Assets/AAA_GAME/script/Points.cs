using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ButtonClicked(int score,List <bool> answers);

    public GameObject btn_go;
    public int score = 0;
    public List<bool> answers = new List<bool>();

    private void Start()
    {
        Button btn = btn_go.GetComponent<UnityEngine.UI.Button>();

        btn.onClick.AddListener(SendMessageToReact);
    }
    

    void SendMessageToReact()
    {
        #if UNITY_WEBGL == true && UNITY_EDITOR == false 
            ButtonClicked(score, answers);
        #endif
    }
}
