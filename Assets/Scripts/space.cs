using UnityEngine;
using System.Collections;

public class space : MonoBehaviour 
{
	public string LevelToLoad;
    void Update()
	{
        if (Input.GetKey("space"))
			
            Application.LoadLevel(LevelToLoad);
        
    }
}