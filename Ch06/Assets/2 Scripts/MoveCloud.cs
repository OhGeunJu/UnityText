using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    public float moveSpeed;
    public float maxWidth;

    int directoin = 1;

    void Update()
    {
        if(transform.position.x > maxWidth)
        {
            directoin = -1;
        }
        if(transform.position.x < -maxWidth)
        {
            directoin = 1;
        }
        
        transform.Translate(moveSpeed*directoin, 0, 0);
    }
}
