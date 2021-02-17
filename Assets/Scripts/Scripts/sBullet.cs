﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sBullet : MonoBehaviour
{
    public float speed = 25;
    public string enemy;
    public float damage;
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(enemy))
        {
            //Debug.Log("Sending take damage");
            collision.gameObject.GetComponent<sAiController>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
