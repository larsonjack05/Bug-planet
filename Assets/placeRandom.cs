using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class placeRandom : MonoBehaviour {

    float x;
    float y;
    float z;
    Vector3 pos;
     // drag your explosion prefab here


    // Use this for initialization
    void Start () {
        x = Random.Range(-25, 26);
        y = 5;
        z = Random.Range(-25, 26);
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }

    

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "World" || col.gameObject.name == "Time")
        {
            
                
               
                x = Random.Range(-25, 26);
                y = 5;
                z = Random.Range(-25, 26);
                pos = new Vector3(x, y, z);
                transform.position = pos;

            

        }

        if (col.gameObject.name == "Player")
        {



            Debug.Log("you caught");
            SceneManager.LoadScene("you lost", LoadSceneMode.Additive);
            //SceneManager.UnloadSceneAsync("SampleScene");

            Time.timeScale = 0.0f;



        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
