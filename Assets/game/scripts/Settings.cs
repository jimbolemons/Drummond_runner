using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{

    public GameObject settingsObject;

    static public float score = 0;        // Score gained every frame
    static public int bonus = 0;
    static public int lives = 10;        // Number of times you can get hit before you lose
    private float scoreTimer = .25f;

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