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
        anim = GetComponent<Animation>();
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
        interact = true;
    }

    void OnTouchUp()
    {
        interact = false;
    }

    void IdleAnim()
    {
        anim.Play(idle.name);
        anim.Play(itching.name);
        anim.Play(idleSit.name);
    }

    void InterAnim()
    {
        anim.Play(meow.name);
    }
}
