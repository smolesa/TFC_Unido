using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ganar : MonoBehaviour {
	// Use this for initialization
	public GameObject[] Enemigo;
	// Update is called once per frame
	public void c_Ganar (){
		int n= 0;
		foreach (GameObject Enemigos in Enemigo){
			if (((Enemigos) != null)) {
				n ++;
			}
		}
		if (n == 0) {
			SceneManager.LoadScene (7);
			Debug.LogWarning ("GAME OVER");
		}
	}
	void Update () {
		c_Ganar();
	}
}