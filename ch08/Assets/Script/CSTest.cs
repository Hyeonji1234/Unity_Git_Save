using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSTest : MonoBehaviour
{
    public float dropSpeed = -0.03f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, dropSpeed, 0);

        if (transform.position.y < -2f)
        {
            transform.position = new Vector3(0,4,0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision enter");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
    }
}
