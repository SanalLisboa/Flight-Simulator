using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle_stop : MonoBehaviour {
public GameObject explosion;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private ParticleSystem _psystem;

    void Awake()
    {
        _psystem = GetComponent<ParticleSystem>();
        }

    void OnTriggerEnter(Collider col)
    {


        _psystem.Stop();

    }
}
