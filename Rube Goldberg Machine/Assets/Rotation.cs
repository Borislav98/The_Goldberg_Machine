using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
    public float speed = 100000f;
    public bool rot = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BallTrigger") ;
        {
            rot =  true;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(rot == true )
        transform.Rotate(0, 2, 0);
	}
}