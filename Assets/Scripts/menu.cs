using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {


	void OnClick()
	{
		Application.LoadLevel ("Intro");
	}

	void Scan()
	{
		Application.LoadLevel ("VR");
	}
}