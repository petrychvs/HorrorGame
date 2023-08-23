using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batter : MonoBehaviour {
	
	public float distans = 2f;
	//public Fonarik test;
	public batterplaers test2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.E)) 
		{
			Ray ray = Camera.main.ScreenPointToRay (new Vector2 (Screen.width / 2, Screen.height / 2));
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, distans)) 
			{
				if (hit.collider.GetComponent<Batter12>()) {
					Batter12 batter = hit.collider.GetComponent<Batter12> ();
					//test.Energy += 25;
					test2.batter1 += 1;
					Destroy (batter.gameObject);

				}
	}
   }
}
}
