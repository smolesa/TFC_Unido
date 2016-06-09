using UnityEngine;
using System.Collections;

public class BarreraCamara : MonoBehaviour {
	public bool collision = false;
	void OnTriggerEnter() {
		collision = true;
    }
		void OnTriggerExit() {
		collision = false;
    }
}
