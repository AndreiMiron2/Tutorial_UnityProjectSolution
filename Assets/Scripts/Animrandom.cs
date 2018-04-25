using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animrandom : MonoBehaviour {

	  public float time_min = 600f;
 public float time_max = 800f;
 public Sprite[] sprites = new Sprite[0];
 public Image image;
 
 void Start() {
      StartCoroutine("ShowRandomImage");
 }
 
 public IEnumerator ShowRandomImage() {
      while(true) {
			yield return new WaitForSeconds(30);
           image.sprite = sprites[Random.Range(0, sprites .Length)];
           image.enabled = true;
           yield return new WaitForSeconds(10);
          image.enabled = false;
           yield return new WaitForSeconds(Random.Range(time_min, time_max));
       }
      
      
 }
}