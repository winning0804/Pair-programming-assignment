using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//using UnityEditor.Sprites ;
public class menu : MonoBehaviour {
	//public GameObject Gmenue;
	public GameObject btnObj ;
	public GameObject caidan;
	Button btn;
	bool isshow=false ;
	// Use this for initialization
	void Start () {
		caidan.SetActive (isshow);
		btn = btnObj.GetComponent<Button>();
		btn.onClick.AddListener(delegate ()
			{
				isshow=!isshow;
				caidan.SetActive (isshow);
			});
	}
}
