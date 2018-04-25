using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gesture1 : MonoBehaviour {
	public string LevelToLoad;
	 public GameObject Print;

 
  PXCMHandData handData;
  PXCMHandData.GestureData data;

	
	
	
	void start(){
if (handData.IsGestureFired("wave", out data)) {
			Print.GetComponent<TextMesh>().text = "Correct";
			         
                      StartCoroutine (WaitForIt (3.0F)); 
 }
 }
     IEnumerator WaitForIt(float waitTime) {
         yield return new WaitForSeconds(waitTime);
			Application.LoadLevel (LevelToLoad);
	}
	}
        
	

