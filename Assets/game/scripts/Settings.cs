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
		//sets the text box to display the players score, speed, and amount of lifes
        textbox.text = "Score: " + cubemoverGen2.score + "\nLives: " + cubemoverGen2.life + "\nSpeed: " + cubemoverGen2.speed;
    }
}