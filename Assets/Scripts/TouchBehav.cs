using UnityEngine;
using System.Collections;

public class TouchBehav : MonoBehaviour {

    Animation anim;
    public AnimationClip idle;
    public AnimationClip idleSit;
    public AnimationClip itching;
    public AnimationClip meow;
    // Use this for initialization
    bool interact;
	void Start () {
        interact = false;
        anim = transform.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!interact)
            IdleAnim();
        else
            InterAnim();

	}

    void OnTouchDown()
    {
        //Debug.Log("Touched Down");
        interact = true;
    }

    void OnTouchUp()
    {
        //Debug.Log("Touched Up");
        interact = false;
    }

    void IdleAnim()
    {
        anim.CrossFade(idle.name);
        
    }

    void InterAnim()
    {
		anim.Play(itching.name);
    }
}
