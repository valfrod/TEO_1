using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TeoPJ : MonoBehaviour
{
    
    int type = 1;
    bool regenerar = true;

    // Start is called before the first frame update
    void Start()
    {
        //this.transform.position = TeoState.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (TeoState.vidas == 0)
        {
            this.transform.position = TeoState.hposition;
            Physics.SyncTransforms();
            TeoState.vidas = 4;
            Debug.Log("Respawn.0");
        }
        else if (TeoState.resp == 1)
        {
            this.transform.position = TeoState.position;
            Physics.SyncTransforms();
            TeoState.resp = 0;
        }

        if (TeoState.vidas <= 4 && regenerar && TeoState.vidas != 0)
        {
            regenerar = false;
            StartCoroutine(Regen());
        }
    }

    IEnumerator Regen()
    {
        yield return new WaitForSeconds(2);
        TeoState.vidas += 1;
        GameManager.gmInstance.manageHearts(type);
        regenerar = true;
    }

}

