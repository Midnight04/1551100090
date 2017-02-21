using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {


	void OntriggreExit(Collider other)
	{
	
		Destroy (other.gameObject);
	}
}
