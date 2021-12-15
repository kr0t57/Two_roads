using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float ForceValue;
    private Rigidbody rb;
    void Start()
    {
        Physics.gravity = new Vector3(0, 0, 0);

        rb = GetComponent<Rigidbody>();

        SwipeDetection.SwipeEvent += OnSwipe;
    }

    private void OnSwipe(Vector2 direction)
    {
        Vector3 dir = 
            direction == Vector2.up ? Vector3.forward : 
            direction == Vector2.down ? Vector3.back : (Vector3)direction;

        Move(dir);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            Move(Vector3.left);
        else if(Input.GetKeyDown(KeyCode.D))
            Move(Vector3.right);
        else if(Input.GetKeyDown(KeyCode.S))
            Move(Vector3.back);
        else if(Input.GetKeyDown(KeyCode.W))
            Move(Vector3.forward);
    }

    private void Move(Vector3 direction)
    {
        rb.AddRelativeForce(direction * ForceValue);
    }
}
