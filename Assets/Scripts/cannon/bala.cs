using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour {
	private cannon2 canon;
	void Awake (){
		canon = GameObject.Find ("cannon").GetComponent<cannon2> ();
	}
	void FixedUpdate () {
		transform.Translate (Vector3.right * canon.Potenciaf * Time.deltaTime);
	}
	void OnCollisionEnter(Collision otherObj) {
		Destroy(gameObject, 6f);
		canon.Potenciaf = canon.Potenciaf/2f;
	}

}
