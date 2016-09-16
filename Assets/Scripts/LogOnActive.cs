using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LogOnActive : MonoBehaviour 
{
	[SerializeField]
	private Text UItext;
	
	void OnEnable() {
		print("script was enabled");
		UItext.text = gameObject.name;
	}
}
