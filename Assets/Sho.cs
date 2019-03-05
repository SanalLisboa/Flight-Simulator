using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sho : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        }
    }
