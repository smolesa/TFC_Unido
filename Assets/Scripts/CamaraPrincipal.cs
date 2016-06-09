using UnityEngine;
using System.Collections;

public class CamaraPrincipal : MonoBehaviour {
	private BarreraCamara barrera1;
	private BarreraCamara barrera2;
	void Awake (){
		barrera1 = GameObject.Find ("BarreraCamara1").GetComponent<BarreraCamara> ();
		barrera2 = GameObject.Find ("BarreraCamara2").GetComponent<BarreraCamara> ();
	}	
	
	void Update () {
		if (barrera1.collision == false){
		if (Input.GetKey("d")){
			transform.Translate(Vector3.right * Time.deltaTime * 30);
		}}
		if (Input.GetKey("a"))
		if (barrera2.collision == false){
		transform.Translate(Vector3.left * Time.deltaTime * 30);}
	}
	}

