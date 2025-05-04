using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public Transform target;
    public Vector3 New;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        New = new Vector3(target.position.x, transform.position.y,-10);
        if (target.position.x>= transform.position.x)
            transform.position = Vector3.MoveTowards(transform.position, New, 5f*Time.deltaTime);
    }
}
