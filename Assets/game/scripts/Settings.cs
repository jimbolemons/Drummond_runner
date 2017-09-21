using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject settingsObject;    

    GUIText textbox;

    private void Start()
    {
<<<<<<< Updated upstream
=======
		
>>>>>>> Stashed changes
        textbox = settingsObject.GetComponent<GUIText>();
    }

    void Update()
    {
<<<<<<< Updated upstream
=======
		//sets the text box to display the players score, speed, and amount of lifes
>>>>>>> Stashed changes
        textbox.text = "Score: " + cubemoverGen2.score + "\nLives: " + cubemoverGen2.life + "\nSpeed: " + cubemoverGen2.speed;
    }
}