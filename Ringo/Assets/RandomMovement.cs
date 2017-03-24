using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour {

    Rigidbody2D body;

	void Start () {
        body = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
        body.AddForce(new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)));
    }
}
