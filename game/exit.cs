﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class exit: MonoBehaviour {
	public void Quit(){
		UnityEditor.EditorApplication.isPlaying = false;
	}
}