using UnityEngine;
using System.Collections;

public class RotateTowardsTransform : MonoBehaviour {

	[SerializeField]
	private Transform target;

	void Update () 
	{
		transform.LookAt(target);
		print(Vector3.Distance(this.transform.position,target.transform.position));
	}
}
