using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
    public float forward = 0;
    float left = 0;
	private Vector3 moveDirection;

	void Start(){
		Time.timeScale=0;
	}

	void Update () 
	{
			if(Input.anyKey){
				Time.timeScale=1;
			}
        	moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")).normalized;
        
    }

	void FixedUpdate () 
	{
		GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime);
	}
}