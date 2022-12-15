using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public LayerMask ground;
    public float speed;
    public float jumpSpeed = 5;
    public GameManager gm;

    float xMove;
    int jumpCount;
    public float distanceCheckAmount = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x);

    }

    // Update is called once per frame
    void Update()
    {

    
        float xMove = Input.GetAxis("Horizontal");
        

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0, jumpSpeed, 0);
    
        }


    }
    public bool GroundCheck()
    {
        Collider2D col = GetComponent<Collider2D>();
        bool onGround = Physics2D.Raycast(transform.position, Vector2.down, distanceCheckAmount, ground);

        return onGround;
    }
}
