using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockY : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        float yPos = pos.y;
        SetTransformX(yPos);
    }
    void SetTransformX(float n)
    {
        transform.position = new Vector3(transform.position.x, n, transform.position.z);
    }
}
