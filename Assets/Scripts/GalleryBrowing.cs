using UnityEngine;
using System.Collections;

public class GalleryBrowing : MonoBehaviour {

	int currentImage;
	bool browsing = false;

	public Texture backBut;
	public Texture bitMap_LumiereVR;

	void Update()
	{
		if (browsing) 
		{
			if (Input.GetMouseButtonDown (0)) {
				currentImage = 0;
				browsing = false;
			}
		}
	}

	void Back()
	{
		Application.LoadLevel ("Main");
	}

	void LumiereVR()
	{
		currentImage = 1;
		browsing = true;
	}

	void OnGUI(){
		if (GUI.Button (new Rect(10,10,80,4s0),backBut, GUIStyle.none))
			Application.LoadLevel ("Main");
		
		switch (currentImage) 
		{
		case 1:
			GUI.DrawTexture (new Rect (((Screen.width / 2) - (bitMap_LumiereVR.width / 2)), ((Screen.height / 2) - (bitMap_LumiereVR.height / 2)), bitMap_LumiereVR.width, bitMap_LumiereVR.height),
				bitMap_LumiereVR, ScaleMode.StretchToFill, true);
			break;
		default:
			break;
				
		}
	}
}
