using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed = 10.0F;
    public float jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float facedircetion = Input.GetAxisRaw("Horizontal");

        if(horizontalMove != 0)
        {
            rb.velocity = new Vector2(horizontalMove * speed *Time.deltaTime, rb.velocity.y);
        }
        if(facedircetion != 0)
        {
            transform.localScale = new Vector3(facedircetion, 1, 1);
        }
        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce * Time.deltaTime);
        }
    }
}
