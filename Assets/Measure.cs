using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Measure : MonoBehaviour {

    Vector3 previous;
    private float speed = 5.0f;
    private Rigidbody _rigidbody;
    float transAmount;
    float rotation;
    float torque;
    void Update()
    {
        transAmount = ((transform.position - previous).magnitude) / Time.deltaTime;
        previous = transform.position;
        rotation = transform.rotation.x*100;
        torque = transAmount * rotation;
        if (torque < 0)
            torque = torque * -1;
        else
            torque = torque;
    }

    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 100, 90), "Measurements");

        GUI.Label(new Rect(20, 40, 80, 20), "Speed=" + transAmount + "m/s");
        GUI.Label(new Rect(20, 60, 90, 20), "Pitch="+rotation );
        GUI.Label(new Rect(20, 80, 110, 20), "Torque=" + torque);

    }
}
