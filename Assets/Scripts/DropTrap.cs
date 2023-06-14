using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTrap : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.gameObject.transform.position.x >=-5.2f && player.gameObject.transform.position.y<-2.1f)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;
        }
    }
}
