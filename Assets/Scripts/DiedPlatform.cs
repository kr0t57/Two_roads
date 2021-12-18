using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiedPlatform : MonoBehaviour
{
    public float TimeDie = 0.4f;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("Player") ||
            collision.gameObject.name.Equals("SecondPlayer"))
        {
            Invoke("DiePlatform", TimeDie);
        }
    }

    void DiePlatform()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
}
