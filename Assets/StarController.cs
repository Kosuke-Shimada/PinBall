﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {

   private float rotSpeed = 1.0f;

        void Start () {

         this.transform.Rotate (0, Random.Range (0, 360), 0);
                
        }
        void Update () {

              this.transform.Rotate (0, this.rotSpeed, 0);

	}

}
