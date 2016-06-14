using UnityEngine;
using System.Collections;

public class camaraBala : MonoBehaviour {
	public Transform bala;
	// Use this for initialization
	void Start () {
		transform.LookAt (bala);
	}
	// Update is called once per frame
	void Update () {
		transform.LookAt (bala);
	}
}
