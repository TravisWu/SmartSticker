using UnityEngine;
using System.Collections;

public class GraphicUI : MonoBehaviour {
	
	void Back () {
		Application.LoadLevel ("Main");
	}

	void OpenBrowser () {
		Application.OpenURL ("http://www.lumistories.com");
	}
}


