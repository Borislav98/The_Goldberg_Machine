using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knematic2 : MonoBehaviour {

    private const bool V = false;
    public GameObject Bouncy;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Spinner")
        {
            Bouncy.GetComponent<Rigidbody>().isKinematic = V;
        }
    }
}