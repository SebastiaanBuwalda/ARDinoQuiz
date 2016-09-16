using UnityEngine;
using System.Collections;

public class ActivateObjectOnActive : MonoBehaviour {

	[SerializeField]
	private GameObject objectToActivate;



	void OnEnable()
	{
		objectToActivate.SetActive (true);
	}

	void OnDisable()
	{
		objectToActivate.SetActive (false);
	}
}
