﻿using UnityEngine;
using System.Collections;

public class Escape : MonoBehaviour 
{
    void Update()
	{
        if (Input.GetKey("escape"))
			
            Application.LoadLevel("MainMenu");
        
    }
}