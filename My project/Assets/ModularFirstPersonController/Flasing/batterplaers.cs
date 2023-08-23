using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class batterplaers : MonoBehaviour {

	public TextMeshProUGUI Batter;
	public float batter1 = 0f;
	public Fonarik light;
	
	public GameObject lightObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Batter.text = "" + batter1;
		if (Input.GetKeyDown (KeyCode.R)&batter1>0f) {
			light.Energy += 25;
			batter1 = batter1 - 1f;
			
			
		}
	}
}
