﻿using UnityEngine;
using System.Collections;

public class FlyingPlatformsController : MonoBehaviour {

    public Vector3 Axis;

    public float Angle;

    public bool SwitchedOn = false;
    
	// Update is called once per frame
	void Update () {
        if(SwitchedOn)
        {
            transform.Rotate(Axis, Angle);
        }
	}
}
