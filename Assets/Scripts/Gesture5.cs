using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gesture5 : MonoBehaviour {
	public string LevelToLoad;
	public GameObject Print; 

 
  PXCMHandData handData;
 PXCMHandData.GestureData data;

	
	
	
	void start(){
if (handData.IsGestureFired("two_fingers_pinch_open", out data)) {
			Print.GetComponent<TextMesh>().text = "Correct";
			Application.LoadLevel (LevelToLoad);
   

        }
	}
}
