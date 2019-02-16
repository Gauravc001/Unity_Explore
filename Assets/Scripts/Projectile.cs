using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // public bool enter = true;
    // public bool stay = true;
    // public bool exit = true;
    // public float moveSpeed;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 10);
        Destroy(this.gameObject, 1.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            // Kills the enemy game object
            Destroy(other.gameObject);
        }
    }

    // stayCount allows the OnTriggerStay to be displayed less often
    // than it actually occurs.
    // private float stayCount = 0.0f;
    // private void OnTriggerStay(Collider other)
    // {
    //     if (stay)
    //     {
    //         if (stayCount > 0.25f)
    //         {
    //             Debug.Log("staying");
    //             stayCount = stayCount - 0.25f;
    //         }
    //         else
    //         {
    //             stayCount = stayCount + Time.deltaTime;
    //         }
    //     }
    // }

    // private void OnTriggerExit(Collider other)
    // {
    //     if (exit)
    //     {
    //         Debug.Log("exit");
    //     }
    // }

    void OnDestroy()
    {
        // Kills the game object
        Destroy(this.gameObject);

        Debug.Log("Projectile Destroyed");
    }

}
