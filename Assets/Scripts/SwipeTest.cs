using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeTest : MonoBehaviour
{
    public Swipe swipeControls;
    public Transform player;
    private Vector3 desiredPosition;

    public Transform groundCheck;
    public LayerMask groundMask;

    public float fallingSpeed = 9.8f;
    public float groundDistance = 0.49f;
    bool isGrounded;


    private void Start()
    {
        desiredPosition = player.transform.position;
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded)
        {
            if (swipeControls.SwipeLeft)
                desiredPosition += Vector3.left;
            if (swipeControls.SwipeRight)
                desiredPosition += Vector3.right;
            if (swipeControls.SwipeUp)
                desiredPosition += Vector3.forward;
            if (swipeControls.SwipeDown)
                desiredPosition += Vector3.back;

            player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 3f * Time.deltaTime);
        }
        else
        {
            desiredPosition += Vector3.down * fallingSpeed * Time.deltaTime;
            player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 100 * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("Ground3"))
        {
            this.transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.Equals("Ground3"))
        {
            this.transform.parent = null;
        }
    }
}
