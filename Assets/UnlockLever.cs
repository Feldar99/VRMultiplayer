using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class UnlockLever : MonoBehaviour {
	[SerializeField]
	private DoorKnob doorknob ;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (GetComponents<NVRLever> ().LeverEngaged) {
			doorknob.Locked = false;
		}
	}
}
