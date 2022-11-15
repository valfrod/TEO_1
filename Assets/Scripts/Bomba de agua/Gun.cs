using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform firepoint;


    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(projectile, firepoint.position, firepoint.rotation);
        }
    }
}
