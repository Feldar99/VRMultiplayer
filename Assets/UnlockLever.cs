﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class UnlockLever : MonoBehaviour {
	
	[SerializeField]
	private bool shouldBeEngaged;
	public bool UnlockedPosition;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        Debug.Log(GetComponentInChildren<NVRLever>());
        Debug.Log(GetComponentInChildren<NVRLever>().LeverEngaged);
		UnlockedPosition = (shouldBeEngaged == GetComponentInChildren<NVRLever>().LeverEngaged);
	}
}
