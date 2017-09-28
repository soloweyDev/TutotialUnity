using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 10.0f;

    public void Hit(float damag)
    {
        Debug.Log("damag - " + damag + ", heatlth - " + health);
        health -= damag;
        Debug.Log(heatlth - " + health);
    }
}
