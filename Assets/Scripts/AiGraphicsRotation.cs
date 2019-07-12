using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AiGraphicsRotation : MonoBehaviour
{
    public AIPath aiPath;
    private float x;
    
    // Start is called before the first frame update
    void Start()
    {
        x = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f)
            transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
        else if (aiPath.desiredVelocity.x <= -0.01f)
            transform.localScale = new Vector3(-x, transform.localScale.y, transform.localScale.z);
        
    }
}
