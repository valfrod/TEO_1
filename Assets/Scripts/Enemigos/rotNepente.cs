using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotNepente : MonoBehaviour
{
    public Vector3 rotSpeed;

    void Update()
    {
        if (transform.eulerAngles.z <= 360)
        {
            transform.Rotate(-rotSpeed * Time.deltaTime); //arriba
        }
        if (transform.eulerAngles.z >= 290)
        {
            transform.Rotate(rotSpeed * Time.deltaTime); //abajo
        }
    }
}
/*public float angle;

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * 60, angle));
    }*/