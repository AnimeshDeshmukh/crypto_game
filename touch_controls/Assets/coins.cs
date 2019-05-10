using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour {
    public float delay = 5f;
    public GameObject coin;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", delay, 1f*delay);
	}
	
	// Update is called once per frame
	void Spawn () {
        Instantiate(coin, new Vector2(Random.Range(-2, 2), 10), Quaternion.identity);
	}
}
