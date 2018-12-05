using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1 : MonoBehaviour {
    public Rigidbody rigidbody;

    // Use this for initialization
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void Start () {
        rigidbody.position = new Vector3(0, 0, 100f);
        rigidbody.velocity = Vector3.back * 10f;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
