using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
    //
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform firepoint;
    //[SerializeField] private float chargeTime;
    [SerializeField] private float chargeSpeed;
    private bool isCharging;    
    /*[SerializeField] private GameObject chargedProjectile;
    [SerializeField] private float sizeGrow;
    public float scaleChange = 0.01f;
    [SerializeField] private GameObject growth; */

    bool cooldown = false;

    // Start is called before the first frame update
    void Update()
    {
        /*if (Input.GetKey(KeyCode.J) && chargeTime >= 2)
        {
            isCharging = true;
            if (isCharging == true)
            {
                chargeTime += Time.deltaTime * chargeSpeed;
            }
        }*/
        if (Input.GetKeyDown(KeyCode.J) && !cooldown)
        {
            Instantiate(projectile, firepoint.position, firepoint.rotation);
            //chargeTime = 0;
            cooldown = true;
            StartCoroutine(TimeOut());
        // } else if(Input.GetKeyUp(KeyCode.J) && chargeTime >= 2 )
        // {
            //ReleaseCharge();
        }

    }


    void ReleaseCharge()
    {
        /*Instantiate(chargedProjectile, firepoint.position, firepoint.rotation);
        isCharging = false;*/
        //chargeTime = 0;
        cooldown = true;
        StartCoroutine(TimeOut());
    }

    IEnumerator TimeOut()
    {
        yield return new WaitForSeconds(2);
        cooldown = false;
    }
}
