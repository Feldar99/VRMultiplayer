using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedLeverGroup : MonoBehaviour {

	[SerializeField]
	private DoorKnob doorknob;
	private UnlockLever[] levers;

	// Use this for initialization
	void Start ()
	{
	    levers = GetComponentsInChildren<UnlockLever>();
	}
	
	// Update is called once per frame
	void Update () {
		foreach (UnlockLever lever in levers) {
			if (!lever.UnlockedPosition) {
				return;
			}
		}

	doorknob.Locked = false;

	}
}
