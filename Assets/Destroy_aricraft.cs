﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_aricraft : MonoBehaviour {
    public GameObject explosion;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
        transform.DetachChildren();
        Destroy(this.gameObject);
    }
}
