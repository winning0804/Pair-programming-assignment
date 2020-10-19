using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndMove : MonoBehaviour {

	private void OnMouseDown(){
		var mx = Input.mousePosition.x;
		var my = Input.mousePosition.y;

		var mousePosWorld = Camera.main.ScreenToWorldPoint(new Vector3(mx, my));

		int i = Mathf.RoundToInt(mousePosWorld.x);
		int j = Mathf.RoundToInt(mousePosWorld.y);



		Move(i * 3 + j, (i - 1) * 3 + j);
		Move(i * 3 + j, (i + 1) * 3 + j);
		Move(i * 3 + j, i * 3 + j + 1);
		Move(i * 3 + j, i* 3 + j - 1);

		int cur = 1;
		bool flag = true;
		foreach(var num in MapCreater.instance.numbers) {
			if (num == null) Debug.Log("NULL");
			else Debug.Log(num.tag);
		}
		Debug.Log("sssssssssss");

		if (flag) Debug.Log("win");

	}

	void Move(int pos, int nxtPos) {
		if (pos < 0 || pos >= 9) return;
		if (nxtPos < 0 || nxtPos >= 9) return;
		if (MapCreater.instance.numbers[nxtPos] != null) return;

		int i = nxtPos / 3;
		int j = nxtPos % 3;

		transform.position = new Vector3(i, j);
		MapCreater.instance.numbers[nxtPos] = MapCreater.instance.numbers[pos];
		MapCreater.instance.numbers[pos] = null;
	}

}
