using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    public float avgSpeed;
    float range = 0.02f;
    public float maxWidth;
    float moveSpeed;
    int directoin = 1;

    private void Start() {
        moveSpeed = avgSpeed;
    }

    void Update()
    {
        if(transform.position.x > maxWidth)
        {
            moveSpeed = Random.Range(avgSpeed - range, avgSpeed + range);
            directoin = -1;
        }
        if(transform.position.x < -maxWidth)
        {
            moveSpeed = Random.Range(avgSpeed - range, avgSpeed + range);
            directoin = 1;
        }
        
        transform.Translate(moveSpeed*directoin, 0, 0);
    }
}
'pip install -U <name>'
pip install -U playwright kaleido nbformat pandas plotly
playwright install