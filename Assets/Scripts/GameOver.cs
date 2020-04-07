using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("GrassThinSprite") && Heart.heartValue<=0)
        {
            
            SceneManager.LoadScene(0);
            

        }
    }
}
