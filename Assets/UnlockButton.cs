using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class UnlockButton : MonoBehaviour {
	[SerializeField]
	private DoorKnob doorknob ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<NVRButton> ().ButtonIsPushed) {
			doorknob.Locked = false;
		}
		}
}
