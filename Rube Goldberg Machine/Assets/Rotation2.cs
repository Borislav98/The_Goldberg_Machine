using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation2 : MonoBehaviour
{
    public bool rot = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BallTrigger")
        {
            rot = true;
        }

        else if (collision.gameObject.name == "BallTrigger2")
        {
            rot = false;
        }


    }
    


    void Start()
    {

    }

 
    void Update()
    {
        if (rot == true)
            transform.Rotate(0, 20, 0);
        if (rot == false)
         transform.Rotate(0, 0, 0);
        
    }
}