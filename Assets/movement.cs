using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float speed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");

        this.transform.Translate(Vector3.left * x * -speed * Time.deltaTime);

        
        if (x > 0)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = true;
        }
        else if (x<0)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = false;
        }
	}
}
