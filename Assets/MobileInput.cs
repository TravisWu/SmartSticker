using UnityEngine;
using System.Collections;

public class MobileInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.tag == "Player")
                    {
                        GameObject receiver = hit.transform.gameObject;

                        if (touch.phase == TouchPhase.Began)
                            receiver.SendMessage("OnTouchDown", SendMessageOptions.DontRequireReceiver);
                        if (touch.phase == TouchPhase.Ended)
                            receiver.SendMessage("OnTouchUp", SendMessageOptions.DontRequireReceiver);
                    }
                }
            }
        }
	}
}
