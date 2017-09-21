using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject settingsObject;    

    GUIText textbox;

    private void Start()
    {
        textbox = settingsObject.GetComponent<GUIText>();
    }

    void Update()
    {
        textbox.text = "Score: " + cubemoverGen2.score + "\nLives: " + cubemoverGen2.life + "\nSpeed: " + cubemoverGen2.speed;
    }
}