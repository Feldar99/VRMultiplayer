using UnityEngine;
using System.Collections;

namespace NewtonVR
{
    public class LittleButton : MonoBehaviour {

        public bool ButtonIsPushed = false;

		public void OnCollisionEnter(Collision col) {
			if (col.gameObject.CompareTag("Little")) {
				ButtonIsPushed = true;
			}
		}
		

    }
}