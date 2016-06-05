using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    void Example()
    {
        if (GetComponent<Rigidbody>())
            Debug.Log("Rigidbody attached to this transform");

    }
}
