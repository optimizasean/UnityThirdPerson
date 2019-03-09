﻿using UnityEngine;
using System.Collections;

public class SlidingJet : MonoBehaviour {
    public float speed = 3.0f;
    public float maxZ = 16.0f;
    public float minZ = -16.0f;

    private int _direction = 1;

    // Update is called once per frame
    void Update() {
        transform.Translate(0, 0, _direction * speed * Time.deltaTime);

        bool bounced = false;
        if (transform.position.z > maxZ || transform.position.z < minZ) {
            _direction = -_direction;
            bounced = true;
        }
        if (bounced) {
            transform.Translate(0, 0, _direction * speed * Time.deltaTime);
        }
    }
}
