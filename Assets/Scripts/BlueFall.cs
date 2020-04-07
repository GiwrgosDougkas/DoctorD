using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFall : MonoBehaviour
{
    public GameObject enemy;
    public static bool first1 = true;
    public static bool first2 = true;
    public static bool first3 = true;
    public static bool second1 = true;
    public static bool third1 = true;
    float randX;
    Vector2 wheretoSpawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Score.scoreValue == 5 && first1 == true)
        {
            first1 = false;

            randX = Random.Range(-7f, 7f);
            wheretoSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, wheretoSpawn, Quaternion.identity);

        }

        if (Score.scoreValue == 16 && first2 == true)
        {
            first2 = false;

            randX = Random.Range(-7f, 7f);
            wheretoSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, wheretoSpawn, Quaternion.identity);

        }

        if (Score.scoreValue == 18 && first3 == true)
        {
            first3 = false;

            randX = Random.Range(-7f, 7f);
            wheretoSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, wheretoSpawn, Quaternion.identity);

        }

        if (Score.scoreValue == 21 && second1 == true)
        {
            second1 = false;

            randX = Random.Range(-7f, 7f);
            wheretoSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, wheretoSpawn, Quaternion.identity);

        }

        if (Score.scoreValue == 32 && third1 == true)
        {
            third1 = false;

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

            Score.scoreValue++;


        }
        else if (col.gameObject.name.Equals("GrassThinSprite"))
        {
            Heart.heartValue--;

            Destroy(enemy);
        }
    }
}
