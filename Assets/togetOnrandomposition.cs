using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togetOnrandomposition : MonoBehaviour {
    float x;
    float y;
    float z;
    Vector3 pos;
    // Use this for initialization
    void Start () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            
            x = Random.Range(-25, 26);
            y = 5;
            z = Random.Range(-25, 26);
            pos = new Vector3(x, y, z);
            transform.position = pos;

        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
