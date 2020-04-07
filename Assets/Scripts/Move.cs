using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Move : MonoBehaviour
{
    public Animator animator;
    private bool facingRight;
    private Rigidbody2D rb;
    private float dirX;
    private float moveSpeed = 6.1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", CrossPlatformInputManager.GetAxis("Horizontal"));
         //dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
       // rb.velocity = new Vector2(dirX, 0f);

       rb.velocity = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal")*moveSpeed, 0.0f);
       //transform.position += (Vector3)horizontal * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("download")) {
            Destroy(col.gameObject);
            
            Score.scoreValue++;
            

        }
    }
}
