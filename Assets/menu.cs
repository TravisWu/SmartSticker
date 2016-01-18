using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

		
		public Texture background;
		
		void OnGUI()
		{
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),background);
			if (GUI.Button(new Rect(Screen.width / 2-80, Screen.height /2, 150, 25),"Scan")) 
			{
				Application.LoadLevel("VR");
			}
			
		}
	}