using UnityEngine;
using System.Collections;

public class steuerung : MonoBehaviour {
	public bool rechts=false;
	public bool links=false;
	public float speed=0f;

	public void clickupL (){
		links = false;
		
	}
	public void clickdownL (){
		links = true;
		
	}
	public void clickupR (){
		rechts = false;

	}
	public void clickdownR (){
		rechts = true;
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (rechts == true) {
			gameObject.transform.position += new Vector3 (speed, 0, 0);
		}
		if (links == true) {
			gameObject.transform.position -= new Vector3 (speed, 0, 0);
		}
	
	}
}
