using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parachute : MonoBehaviour
{
    [SerializeField] private float drag = 0f;
    [SerializeField] private float parachuteDrag = 10f;
    [SerializeField] GameObject parachute;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.drag = drag;
        parachute.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, -transform.up, 5f))
        {
            rb.drag = parachuteDrag;
            parachute.SetActive(true);
        }
    }
}
