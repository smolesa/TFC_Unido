using UnityEngine;
using System.Collections;

public class Hielo : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		if (GameObject.Find ("balaCannon(Clone)") != null) {
			if (collision.gameObject.name == "balaCannon(Clone)") {
				Destroy (gameObject);
			}
		}

	}
}