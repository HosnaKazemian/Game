using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLight : MonoBehaviour
{
    [SerializeField] public Light light;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("tunnel"))
            light.intensity = 200f;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("tunnel"))
            light.intensity = 0f;
    }
}