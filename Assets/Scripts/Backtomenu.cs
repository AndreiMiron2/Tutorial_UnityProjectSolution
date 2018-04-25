﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backtomenu : MonoBehaviour {

public string LevelToLoad;
	public float timer = 4f;
	public Text timerSeconds; 
	// Use this for initialization 
	
	void Start ()
	{ 
		timerSeconds = GetComponent<Text> (); 
	} 
	// Update is called imeronce per frame 
	void Update () 
	{
		timer -= Time.deltaTime;
		
		
		int hours = (int) (timer/3600)%24;
		int minutes = (int) (timer /60) % 60;
		int seconds = (int)(timer % 60);
		
		
		string timerString = string.Format("{0:0}:{1:00}:{2:00}",hours,minutes,seconds);
		
		
		
		timerSeconds.text = timerString;
		if (timer <= 0)
		
	{ 
			Application.LoadLevel (LevelToLoad); 
			
		} 
	}
}﻿