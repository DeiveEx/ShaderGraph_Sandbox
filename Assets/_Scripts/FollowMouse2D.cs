﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse2D : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		pos.z = 0;
		transform.position = pos;
	}
}
