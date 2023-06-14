using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 3f;
    public float jumpForce = 10f;
    Rigidbody2D rigid;
    Vector2 jump;

    bool isJump=false;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        jump = new Vector2(0, jumpForce);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        

        transform.position += new Vector3(x, 0, 0) * Time.deltaTime * speed;

        if(Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            isJump = true;
            rigid.AddForce(jump);

        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            gameObject.transform.position = new Vector3(-8.8f, 2.7f, 0f);



        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bottom")
        {
            isJump = false;
        }
    }

}
