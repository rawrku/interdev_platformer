using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartContoller : MonoBehaviour
{
    public int health = 3;

    public Image[] hearts;

    public Sprite fullHeart;
    public Sprite emptyHeart;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");

    }

    // Update is called once per frame
    void Update()
    {
       
        foreach (Image img in hearts)
        {
            img.sprite = emptyHeart;
        }

        for (int i = 0; i < health; i++)
        {
            hearts[i].sprite = fullHeart;
        }

        if (player.transform.position.y <= -8f)
        {
            player.transform.position = new Vector3(-7f, -1.5f, player.transform.position.z);
            health -= 1;
        }
        
    }
}
