﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixingScalePrefabs : MonoBehaviour {


	public GameObject[] rPlats;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < rPlats.Length; ++i) 
		{
			rPlats [i].transform.SetParent (null, false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
