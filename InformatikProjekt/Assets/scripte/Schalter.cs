using UnityEngine;
using System.Collections;

public class Schalter : MonoBehaviour {
	public GameObject Mauer;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision col){
		if(Mauer.active == true /*&& col.gameObject.tag == "Player"*/){
			Mauer.SetActive(false);
		}
		//if(Mauer.active == false && col.gameObject.tag == "Player"){
			//Mauer.SetActive(true);
		//}
	}
}
