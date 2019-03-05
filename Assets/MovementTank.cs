using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTank : MonoBehaviour {
    float time = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (time < 2)
        {
            transform.Translate(0, 0, time);
            
        }
        if(time>2&&time<2.75f)
        {
            transform.Rotate(Vector3.up, time);
        }
       
        if (time > 2.75f&& time<3.45f)
        {
            transform.Translate(0, 0, time);

        }
        if (time > 3.45f && time < 3.94f)
        {
            transform.Rotate(Vector3.up, time);
        }
        time = time + 0.01f;
        if(time>3.95f)
        {
            time = 0;
        }
    }
}
