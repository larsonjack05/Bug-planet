using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    float timeleft = 5.0f;
    public Text TextObject = null;
    
    Vector3 pos;
    // Use this for initialization
    void Start () {
		
	}

    //for collison
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "time")
        {
            timeleft += 10;   //To increase the time         
        }
    }

    // Update is called once per frame
    void Update () {
        timeleft -= Time.deltaTime;
        TextObject.text = timeleft.ToString();

        if (timeleft < 0) {
            TextObject.text = "YOU LOST";
            

        }
            
        }
    }

