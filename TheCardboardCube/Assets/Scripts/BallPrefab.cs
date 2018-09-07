using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class BallPrefab : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Object.Destroy(gameObject, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
