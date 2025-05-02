using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public float maxWidth = 10f;

    int directoin = 1;

    void Update()
    {
        if (transform.position.x > maxWidth)
        {
            directoin = -1;
        }
        if (transform.position.x < -maxWidth)
        {
            directoin = 1;
        }

        transform.Translate(moveSpeed * directoin, 0, 0);
    }
}
