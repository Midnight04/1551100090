using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomrotator : MonoBehaviour {
	public float tumble;
	void start ()
	{
		GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
	}

}
		