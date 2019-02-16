using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Vector3 goal;
    private UnityEngine.AI.NavMeshAgent agent;
    public GameObject cameraParent;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;

        goal = transform.position;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        goal = transform.position
            + cameraParent.transform.right * Input.GetAxis("Horizontal")
            + cameraParent.transform.forward * Input.GetAxis("Vertical");

        agent.destination = goal;
    }
}
