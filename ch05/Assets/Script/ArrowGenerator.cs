using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrow;
    public float span = 1.0f;
    float delta = 0f;

    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            GameObject go = Instantiate(arrow);
            int px = Random.Range(-8, 9);
            go.transform.position = new Vector3(px, 7, 0);

            delta = 0;
        }
    }
}
