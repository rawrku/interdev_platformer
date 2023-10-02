using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private HeartContoller heartScript;
    public GameObject Player;

    public void Start()
    {
        heartScript = Player.GetComponent<HeartContoller>();
    }

    public void Update()
    {
        if (heartScript.health == 0)
        {
            //blah blah load end game scene
        }
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }
}
