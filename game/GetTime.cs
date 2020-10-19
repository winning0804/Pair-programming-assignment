using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTime : MonoBehaviour
{
	private int hour;
	private int minute;
	private int second;

	//已用 time
	float timeSpeed = 0.0f;

	//显示time区域的文本
	Text text_timeSpeed;

		// Use this for initialization
		void Start ()
		{
			text_timeSpeed = GetComponent<Text>();
		}

		// Update is called once per frame
		void Update ()
		{
			timeSpeed += Time.deltaTime;
			hour = (int)timeSpeed / 3600;
			minute = ((int)timeSpeed - hour * 3600) / 60;
			second = (int)timeSpeed - hour * 3600 - minute * 60;
			//text_timeSpeed.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
			
			text_timeSpeed.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
		}
		
}
