 using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Circle2 : MonoBehaviour {
    Image fillImg;
   public float timeAmt = 10;
    float time;
    public Text timeText; 
	public string LevelToLoad;
	

    // Use this for initialization
    void Start () {
        fillImg = this.GetComponent<Image>();
        time = timeAmt;
    }
    
    // Update is called once per frame
    void Update () {
        if(time  > 0){
            time -= Time.deltaTime;
			int hours = (int) (time/3600)%24;
		int minutes = (int) (time /60) % 60;
		int seconds = (int)(time % 60);
		
		
		string timeString = string.Format("{0:0}:{1:00}:{2:00}",hours,minutes,seconds);
			timeText.text = timeString;
			
           
			fillImg.fillAmount = time / timeAmt;
             
			
			if (time <= 0)
		
	{ 
			Application.LoadLevel (LevelToLoad); 
			
		} 
			
        }
    }
}