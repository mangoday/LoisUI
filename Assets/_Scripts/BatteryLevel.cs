using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI를 사용하기 위한 네임스페이스
using UnityEngine.UI;



//ui에 배터리 양을 나타내는 아이콘을 만든다.
//초기 구현 모형은 단순 숫자를 나타낸다.
//1. 시스템에서 배터리의 남은 양을 값으로 받아온다.
//2. 받은 값을 캔버스 텍스트에 숫자로 표현한다.
public class BatteryLevel : MonoBehaviour {

	//배터리 잔량을 나타내는 변수
	float batteryLevelValue;
	Text batteryLevelDisplay;

	// Use this for initialization
	void Start () {
		// SystemInfo.batteryStatus
	}
	
	// Update is called once per frame
	void Update () {
		//시스템에서 값을 받아온다.
		batteryLevelValue = SystemInfo.batteryLevel;
		print(batteryLevelValue);

		//텍스트를 수정할 컴포넌트에 접근하여 값을 넣는다.
		GameObject batteryStatus = transform.parent.GetChild(1).gameObject;

		batteryLevelDisplay = batteryStatus.GetComponent<Text>();
		batteryLevelDisplay.text 
		= batteryLevelValue.ToString();
	}
}
