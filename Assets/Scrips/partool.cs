using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partool : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}    

