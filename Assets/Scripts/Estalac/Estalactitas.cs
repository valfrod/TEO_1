using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estalactitas : MonoBehaviour {

    //[SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private Rigidbody rb;
    public Transform Estalactita2, Estalactita3;

    void FallDown()
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "WaterBomb")
        {
            FallDown();
        }
        if (col.gameObject.tag == "Stoper")
        {
            Estalactita2.GetComponent<Rigidbody>().isKinematic = false;
            Estalactita3.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

}
