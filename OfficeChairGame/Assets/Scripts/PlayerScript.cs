using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float direction;
    public float _speed = 10f;
    public Transform target;
    Transform me;

	// Use this for initialization
	void Start ()
    {
        me = this.transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float Speed = direction * _speed * Time.deltaTime;
        me.position = Vector3.MoveTowards(this.transform.position, target.position, Speed);
	}
}
