using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1")){
            Instantiate(Resources.Load("Projectile"), transform.position, transform.rotation);
        }
    }
}
