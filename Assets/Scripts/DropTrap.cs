using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTrap : MonoBehaviour
{
    public Player player;
    public float plX;
    public GameObject fakeWall;
    public bool isFake = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float diffX = Mathf.Abs(player.gameObject.transform.position.x - transform.position.x);


        if (diffX < plX  && player.gameObject.transform.position.y < transform.position.y)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;
        }
    }
}
