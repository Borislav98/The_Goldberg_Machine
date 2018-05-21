using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kinematic : MonoBehaviour {
    private const bool V = false;
    public GameObject Bal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Spinner")
        {
           Bal.GetComponent<Rigidbody>().isKinematic = V;
        }
    }
}
