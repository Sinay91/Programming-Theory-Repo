using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public float waist;

    private void Start()
    {
        transform.localScale = new Vector3(waist, waist, waist);
    }

    void Update()
    {
        Move();
    }

    public virtual void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
