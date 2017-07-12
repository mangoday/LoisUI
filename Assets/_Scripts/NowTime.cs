using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI를 사용하기 위한
using UnityEngine.UI;


//시간을 표현하는 기능
public class NowTime : MonoBehaviour {

	//현재 시간을 표현하는 변수
	string  nowTime;

	Text hourDisplay;

	string[] date;
	// Use this for initialization
	void Start () {
		
		
	}
	
	//현재 
	// Update is called once per frame
	void Update () {
		// nowTime = System.DateTime.Now.Hour.ToString();

		GameObject nowHout = transform.parent.GetChild(2).gameObject;

		hourDisplay = nowHout.GetComponent<Text>();

		// hourDisplay.text = nowTime;

		print(nowTime);

		 date = System.DateTime.Now.GetDateTimeFormats();

		 hourDisplay.text = date[1];

		 for(int i = 0 ; i <date.Length ; i++)
		 {
			 print(date[i]);
		 }

	}
}
