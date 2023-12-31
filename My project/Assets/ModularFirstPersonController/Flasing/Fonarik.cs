﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Fonarik : MonoBehaviour
{
	public TextMeshProUGUI txt;
	public int Energy;
	public GameObject Light;
	public bool onLight;
	private double scet;
	public AudioClip OnOfFonarikSound;
	
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = Energy + "%";
		if (onLight == true) {
			scet += 0.5 * Time.deltaTime;
			if (scet >= 2) {
				Energy -= 1;
				scet = 0;
			}
		}
		if (Energy >= 100) {
			Energy = 100;
		}
		if (Energy <= 0) {
			onLight = false;
			Light.SetActive (false);
			Energy = 0;
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			GetComponent<AudioSource>().PlayOneShot(OnOfFonarikSound);
			if (onLight == false && Energy > 0) {
				Light.SetActive (true);
				onLight = true;

				

			}
			else 
			{
				Light.SetActive (false);
				onLight = false;
				
			}
		}
	}
}
