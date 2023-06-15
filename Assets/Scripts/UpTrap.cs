using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpTrap : MonoBehaviour
{
    public Player player;

    bool isTrig = false;
    public float plX;
    public bool keepGo = true;
    float y;

    private void Start()
    {
         y = transform.position.y;
        
    }

    void Update()
    {
        float diffX = Mathf.Abs(player.gameObject.transform.position.x - transform.position.x);
        float diffY = player.gameObject.transform.position.y - transform.position.y;


        if (diffX < plX && diffY < 2.5f)
            isTrig = true;

        if (isTrig)
        {
            if (keepGo)
            {
                transform.position += Vector3.up * Time.deltaTime * 5f;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, y + 0.6f , 0), Time.deltaTime * 1f);
            }
        }
            
        if(transform.position.y > 7)
        {
            Destroy(gameObject);
        }

    }
}
