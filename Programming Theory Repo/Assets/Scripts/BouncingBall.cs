using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : Ball //INHERITANCE
{
    public float bounce;

    private void Start() 
    {
        transform.localScale = new Vector3(waist, waist, waist);


    }

    public override void Move()
    {
        base.Move();
    }
}
