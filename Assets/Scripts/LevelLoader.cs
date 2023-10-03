using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private GameManager gameMan;
    // Start is called before the first frame update
    private void Start()
    {
        gameMan = GetComponent<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "flag next")
        {
            gameMan.LoadLevel();
        }

        if (collision.gameObject.tag == "flag end")
        {
            gameMan.LoadEnd();
        }
    }
}
