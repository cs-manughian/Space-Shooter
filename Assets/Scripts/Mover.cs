using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
    public float speed;

    void Start ()
    {
        // transform.forward is the z-axis
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
}