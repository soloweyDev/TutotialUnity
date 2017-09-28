using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject ammoPrefab;
    public int ammo = 10;

	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	        Instantiate(ammoPrefab);
	        ammo--;
	    }
		
	}
}
