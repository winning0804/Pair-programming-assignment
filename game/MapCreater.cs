using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreater : MonoBehaviour {
	public static MapCreater instance;
	public GameObject[] numbers;
	private void Awake(){
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy(gameObject);
		}

		numbers [8] = null;
	}

	// Use this for initialization
	void Start () {
		Shuffle (numbers);
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				if (numbers [i * 3 + j] == null)
					continue;
				Instantiate (numbers [i * 3 + j], new Vector3 (i, j), Quaternion.identity);
			}
		}
	}

	// Update is called once per frame
	void Update () {

	}

	private void Shuffle(GameObject[] alpha) {
		for (int i = 0; i < alpha.Length; i++)
		{
			var temp = alpha[i];
			int randomIndex = Random.Range(i, alpha.Length);
			alpha[i] = alpha[randomIndex];
			alpha[randomIndex] = temp;
		}
	}
}
