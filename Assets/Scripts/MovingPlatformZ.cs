using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformZ : MonoBehaviour
{
    float dirZ;
    float speed = 2f;

    bool movingRight = true;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 7f)
        {
            movingRight = false;
        }
        else if (transform.position.z < 2.45f)
        {
            movingRight = true;
        }

        if (movingRight)
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y, transform.position.x + speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y, transform.position.x + speed * Time.deltaTime);
        }
    }
}
