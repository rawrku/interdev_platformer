using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class EndText : MonoBehaviour
{
    public TMP_Text endText;
    private GameManager gameMan;

    // Start is called before the first frame update
    void Start()
    {
        gameMan = FindObjectOfType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (gameMan.dead == true)
        {
            endText.text = "Oh no! You Lost and are felling through space!\nPress Space to restart!!";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameMan.LoadGame();
            }
        }
        else
        {
            endText.text = "You Won! You made it to the Space Station!\nPress Space to go on another mission!";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameMan.LoadGame();
            }
        }
    }
}
