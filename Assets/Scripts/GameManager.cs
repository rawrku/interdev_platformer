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
            SceneManager.LoadScene("Menu");
        }
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
