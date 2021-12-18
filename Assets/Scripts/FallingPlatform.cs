using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    Rigidbody rb;
    public float TimeFall = 0.4f;
    public float TimeDestroy = 3f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("Player") ||
            collision.gameObject.name.Equals("SecondPlayer"))
        {
            Invoke("FallPlatform", TimeFall);
            Destroy(gameObject, TimeDestroy);
        }
    }

    void FallPlatform()
    {
        rb.useGravity = true;
    }
}
