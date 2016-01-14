using UnityEngine;
using System.Collections;

public class GraphicUI : MonoBehaviour {
	public Texture bitMap;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button (new Rect (10, 10, 150, 50), bitMap))
			Application.OpenURL ("http://lumistories.azurewebsites.net");
	}
}
