using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class transform: MonoBehaviour {

	public void OnLoginButtonClick(int SceneNumber)
	{
		SceneManager.LoadScene(SceneNumber);
	}
}