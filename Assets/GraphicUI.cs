using UnityEngine;
using System.Collections;

public class GraphicUI : MonoBehaviour {
	public Texture bitMap;
	private float length;
	private float height;

	// Use this for initialization
	void Start () {
		length = 200f;
		height = 50f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button (new Rect(10,10,50,30),"Back"))
			Application.LoadLevel ("Main");

		if (GUI.Button (new Rect (Screen.width/2 - length/2, Screen.height - height/2 - 10, length, height), bitMap, GUIStyle.none))
			Application.OpenURL ("http://lumistories.azurewebsites.net");
	}
}
