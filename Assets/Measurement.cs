using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Measurement : MonoBehaviour {
   Vector3 previous;
    private float speed = 5.0f;
    private Rigidbody _rigidbody;
    float transAmount;
  void Update()
    {
        transAmount = ((transform.position - previous).magnitude) / Time.deltaTime;
        previous = transform.position;
    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 90), "Measurements");

        GUI.Label(new Rect(20, 40, 80, 20),"Speed=" + transAmount + "m/s");
    }
}
