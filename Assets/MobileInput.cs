using UnityEngine;
using System.Collections;

public class MobileInput : MonoBehaviour {
    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update () {

#if UNITY_EDITOR
        if (Input.GetMouseButton(0) || Input.GetMouseButtonUp(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Player")
                {
                    GameObject receiver = hit.transform.gameObject;

                    if (Input.GetMouseButton(0))
                        receiver.SendMessage("OnTouchDown", SendMessageOptions.DontRequireReceiver);
                    if (Input.GetMouseButtonUp(0))
                        receiver.SendMessage("OnTouchUp", SendMessageOptions.DontRequireReceiver);
                }
            }
        }
#endif
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

                        if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
                            receiver.SendMessage("OnTouchDown", SendMessageOptions.DontRequireReceiver);
                        if (touch.phase == TouchPhase.Ended)
                            receiver.SendMessage("OnTouchUp", SendMessageOptions.DontRequireReceiver);
                    }
                }
            }
        }
	}
}
