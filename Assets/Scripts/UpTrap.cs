using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpTrap : MonoBehaviour
{
    public Player player;

    bool isTrig = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        if (player.gameObject.transform.position.x >= 4.6f && player.gameObject.transform.position.y < -2.1f)
            isTrig = true;

        if (isTrig)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -4.5f, 0), Time.deltaTime * 1f);

    }
}
