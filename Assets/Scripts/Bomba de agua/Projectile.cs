using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.forward * speed;
        Invoke("DestroyProjectile", lifeTime);
    }
    
    void OnCollisionEnter(Collision col)
    {
           if (col.gameObject.tag == "etca"){
            Destroy(gameObject, 0.1f);
        }
    }
    
    // Update is called once per frame
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
