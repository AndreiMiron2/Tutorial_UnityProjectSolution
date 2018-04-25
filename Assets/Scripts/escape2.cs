using UnityEngine;
using System.Collections;

public class escape2 : MonoBehaviour 
{
    void Update()
	{
        if (Input.GetKey("escape"))
			
            Application.LoadLevel("PracticePage");
        
    }
}