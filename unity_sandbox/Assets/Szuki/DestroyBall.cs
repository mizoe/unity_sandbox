using UnityEngine;
using System.Collections;

public class DestroyBall : MonoBehaviour
{

    void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);
    }
}
