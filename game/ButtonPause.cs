using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class ButtonPause : MonoBehaviour{
	//the ButtonPauseMenu
	public GameObject ingameMenu;


	public void OnPause(){//点击“暂停”时执行此方法
		Time.timeScale = 0;
	ingameMenu.SetActive(true);
	}

	public void OnResume(){
	//点击“回到游戏”时执行此方法
	Time.timeScale = 1f;
	ingameMenu.SetActive(false);
	}

	public void OnRestart(int SceneNumber){//点击“重新开始”时执行此方法
	//Loading Scene0
		SceneManager.LoadScene(SceneNumber);
		Time.timeScale = 1f;
	}
}
