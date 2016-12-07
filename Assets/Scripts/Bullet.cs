using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        var health = collision.transform.parent.GetComponent<Health>();
        if (health != null)
            health.TakeDamage(10);

        Destroy(gameObject);
    }
}
