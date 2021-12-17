using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTestSecond : MonoBehaviour
{
    public Swipe swipeControls;
    public Transform player;
    private Vector3 desiredPosition;

     private void Start()
    {
        desiredPosition = player.transform.position;
    }

    void Update()
    {
        if(swipeControls.SwipeLeft)
            desiredPosition += Vector3.right;
        if(swipeControls.SwipeRight)
            desiredPosition += Vector3.left;
        if(swipeControls.SwipeUp)
            desiredPosition += Vector3.back;
        if(swipeControls.SwipeDown)
            desiredPosition += Vector3.forward;

        player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 3f * Time.deltaTime);

    }
}
