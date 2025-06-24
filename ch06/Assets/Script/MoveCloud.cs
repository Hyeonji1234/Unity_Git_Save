using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    // Start is called before the first frame update
    public float avgSpeed = 0.05f;
    float range = 0.02f;
    public float maxwidth = 10f;

    float moveSpeed;
    int direction = 1;
    // Update is called once per frame
    private void Start()
    {
        moveSpeed = avgSpeed;
    }


    void Update()
    {
        if(transform.position.x > maxwidth)
        {
            //moveSpeed = Random.Range(avgSpeed*direction, 0, 0);
            direction = -1;
        }
        if(transform.position.x < -maxwidth)
        {
            //moveSpeed = Random.Range(avgSpeed*direction, 0, 0);
            direction = 1;
        }
        transform.Translate(moveSpeed*direction,0,0);
    }
}
