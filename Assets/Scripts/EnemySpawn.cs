using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject enemy;
    float randX;
    Vector2 wheretoSpawn;
    public float spawnRate = 2f;
    public Rigidbody2D target;
    float spawnTimer = 5f;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnTimer) {

            
            randX = Random.Range(-7f, 7f);
            wheretoSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, wheretoSpawn, Quaternion.identity);
            timer = 0f;
        }
        if (Score.scoreValue >=2)
        {

            target.gravityScale = 0.25f;
        }

        if (Score.scoreValue >= 10)
        {

            target.gravityScale = 0.31f;
        }

        if (Score.scoreValue >= 15)
        {

            target.gravityScale = 0.35f;
        }

        if (Score.scoreValue >= 20)
        {

            target.gravityScale = 0.38f;
        }
        if (Score.scoreValue >= 30)
        {

            target.gravityScale = 0.4f;
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
            if (Heart.heartValue > 0){

                Heart.heartValue--;
            }
            
            Destroy(enemy);
        }
    }
}
