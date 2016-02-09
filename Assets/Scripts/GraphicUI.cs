using UnityEngine;
using System.Collections;

public class GraphicUI : MonoBehaviour {
	
	public Texture bitMap;
	public Texture backBut;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button (new Rect(10,10,50,40),backBut, GUIStyle.none))
			Application.LoadLevel ("Main");

		if (GUI.Button (new Rect (Screen.width / 2 - bitMap.width / 2, Screen.height - bitMap.height / 2 - 50, bitMap.width, bitMap.height), bitMap, GUIStyle.none))
			Application.OpenURL ("http://www.lumistories.com");
	}
}
