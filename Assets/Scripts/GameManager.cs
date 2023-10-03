using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool dead;

    public void Start()
    {
        // if there is already an extisitng object of this type in the scene
        if (FindObjectsOfType<GameManager>().Length > 1)
        {
            // then destory this current one so there is not 2
            Destroy(gameObject);
        }
        else
        {
            // otherwise if there is NOT, then carry it onto the next scene
            DontDestroyOnLoad(gameObject);
        }
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void LoadEnd(bool isDead)
    {
        SceneManager.LoadScene("End");
        dead = isDead;
        
    }
}
