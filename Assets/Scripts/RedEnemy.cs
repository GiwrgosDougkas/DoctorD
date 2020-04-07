using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemy : MonoBehaviour
{

    public GameObject enemy;
    float randX;
    Vector2 wheretoSpawn;
    public float spawnRate = 2f;

    float spawnTimer = 12f;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnTimer && Score.scoreValue>12)
        {


            randX = Random.Range(-5f, 5f);
            wheretoSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, wheretoSpawn, Quaternion.identity);
            timer = 0f;
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

