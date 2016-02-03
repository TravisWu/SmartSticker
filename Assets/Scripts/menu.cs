using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {


	void OnClick()
	{
		Application.LoadLevel ("VR");
	}

	void Browse()
	{
		Application.LoadLevel ("Gallery");
	}
}