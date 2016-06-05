using UnityEngine;
using System.Collections;

public class cannon : MonoBehaviour {

	void Update () {
		if (Input.GetKey("w"))

			transform.Rotate(Vector3.forward);

		if (Input.GetKey("s"))

			transform.Rotate(Vector3.back);
	}

}
