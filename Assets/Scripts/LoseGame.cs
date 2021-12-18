using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{
     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("Player") ||
            collision.gameObject.name.Equals("SecondPlayer"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
            
    }
}
