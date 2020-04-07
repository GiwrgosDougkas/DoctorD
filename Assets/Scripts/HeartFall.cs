using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartFall : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector2 wheretoSpawn;   
    public static bool first = true;
    public static bool second = true;   
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if ( Score.scoreValue==20 && first==true)
        {
            first = false;

            randX = Random.Range(-7f, 7f);
            wheretoSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, wheretoSpawn, Quaternion.identity);
           
        }

        if (Score.scoreValue == 50 && second == true)
        {
            second = false;

            randX = Random.Range(-7f, 7f);
            wheretoSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, wheretoSpawn, Quaternion.identity);

        }
    }
    

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Untitled"))
        {
            Destroy(enemy);

            Heart.heartValue++;


        }
        else if (col.gameObject.name.Equals("GrassThinSprite"))
        {

            Destroy(enemy);
        }
    }
}
