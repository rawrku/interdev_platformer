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
    public void LoadGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void LoadEnd()
    {
        SceneManager.LoadScene("end");
    }
}
