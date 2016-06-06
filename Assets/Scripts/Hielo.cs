using UnityEngine;
using System.Collections;

public class Hielo : MonoBehaviour {
	public AudioClip Hieloroto;
	private AudioSource audio;
	void OnCollisionEnter(Collision collision){
		if (GameObject.Find ("balaCannon(Clone)") != null) {
			if (collision.gameObject.name == "balaCannon(Clone)") {
				audio = GetComponent<AudioSource>();
				audio.clip = Hieloroto;
				audio.Play();
				Destroy (gameObject,3f);

			}
		}
	}
}