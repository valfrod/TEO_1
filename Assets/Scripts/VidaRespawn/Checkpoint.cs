using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    float PosI = 0f;
    float PosN = 0f;
    GameObject teon;

    private void OnTriggerEnter(Collider other)
    {
        teon = GameObject.Find("TEO");
        PosI = TeoState.position.x;
        PosN = this.transform.position.x;
        //print(teon.transform.position);
        if (other.tag == "Player")
        {
            if (this.tag == "hcheck")
            {
                TeoState.hposition = teon.transform.position;
                TeoState.SavePrefs();
                print("Ultimo checkpoint" + TeoState.hposition);
                print(PosI + "seg" + PosN);
            }
            else
            {
                TeoState.position = teon.transform.position;
                TeoState.SavePrefs();
                print("Ultimo checkpoint_nohcheck" + TeoState.position);
                print(PosI + "seg" + PosN);
            }
        }
    }
}
