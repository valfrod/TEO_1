using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    float PosI = 0f;
    float PosN = 0f;

    private void OnTriggerEnter(Collider other)
    {
        PosI = TeoState.position.x;
        PosN = this.transform.position.x;
        if (other.tag == "Player")
        {
            if (this.tag == "hcheck")
            {
                TeoState.hposition = this.transform.position;
                TeoState.SavePrefs();
                print("Ultimo checkpoint" + TeoState.hposition);
                print(PosI + "seg" + PosN);
            }
            else
            {
                TeoState.position = this.transform.position;
                TeoState.SavePrefs();
                print("Ultimo checkpoint_nohcheck" + TeoState.position);
                print(PosI + "seg" + PosN);
            }
        }
    }
}
