using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformX : MonoBehaviour
{
    float dirX;
    float speed = 2f;

    bool movingRight = true;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 7f)
        {
            movingRight = false;
        }
        else if(transform.position.x < 2.45f)
        {
            movingRight = true;
        }

        if (movingRight)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,
                transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime,
                transform.position.y, transform.position.z);
        }
    }
}
