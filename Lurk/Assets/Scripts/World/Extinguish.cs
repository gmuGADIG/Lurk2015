using UnityEngine;
using System.Collections;

public class Extinguish : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	/* 1. Like flammable.cs, this script requires that any object you attach it to have a Trigger collider. See flammable.cs for more on that.
	 * 	Otherwise, there's not really anything to using it.
	 */
	void OnTriggerEnter2D(Collider2D col){
		Flammable lighter = col.gameObject.GetComponent<Flammable>();
		if(lighter && lighter.lit == true) {
			lighter.lit = false;
			return;
		}
	}
}
