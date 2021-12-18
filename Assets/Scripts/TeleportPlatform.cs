using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlatform : MonoBehaviour
{
    public GameObject pointTeleport;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("Player") ||
            collision.gameObject.name.Equals("SecondPlayer"))
            {
                collision.gameObject.transform.localPosition = pointTeleport.gameObject.transform.localPosition;
            }
    }
}
