using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_missile : MonoBehaviour {
    public float moveforce = 0f;
    private Rigidbody rbody;
    public GameObject missiles;
    public Transform Eagle;
    public float shootRate = 0f;
    public float shootForce = 0f;
    int flag = 0;
    // Use this for initialization
    void Start () {
        rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey("d"))
        {

            GameObject go = (GameObject)Instantiate(
                missiles, Eagle.position, Eagle.rotation);

            flag = 1;

        }
        if (flag == 1)
        {
            missiles.transform.Translate(Vector3.back * Time.deltaTime * 5);
            flag = 0;
        }
        }
}
