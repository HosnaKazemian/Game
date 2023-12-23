using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 7f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * vertical * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * horizontal * -1 * speed * Time.deltaTime);

        if (25 < Mathf.Abs(transform.position.x))
        {
            transform.position = new Vector3(20.93f, 5.903496f, 4.1f);
        }
    }
}