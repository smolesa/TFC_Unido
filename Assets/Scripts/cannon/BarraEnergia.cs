using UnityEngine;
using System.Collections;

public class BarraEnergia : MonoBehaviour
{
    private cannon2 canon;
    void FixedUpdate()
    {
        canon = GameObject.Find("cannon").GetComponent<cannon2>();
        transform.localScale = new Vector3(canon.Potencia-10.3f, 1.3f, 0.1f);
    }
 }
