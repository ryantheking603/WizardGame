using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChanger : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) {
            animator.SetBool("WalkBack", true);
            animator.SetBool("WalkForward", false);
            animator.SetBool("WalkLeft", false);
            animator.SetBool("WalkRight", false);
        }
        else if (Input.GetKey("s")) {
            animator.SetBool("WalkForward", true);
            animator.SetBool("WalkBack", false);
            animator.SetBool("WalkLeft", false);
            animator.SetBool("WalkRight", false);
        }
        else if (Input.GetKey("a")) {
            animator.SetBool("WalkLeft", true);
            animator.SetBool("WalkForward", false);
            animator.SetBool("WalkBack", false);
            animator.SetBool("WalkRight", false);
        }
        else if (Input.GetKey("d")) {
            animator.SetBool("WalkRight", true);
            animator.SetBool("WalkForward", false);
            animator.SetBool("WalkBack", false);
            animator.SetBool("WalkLeft", false);
        }
        else {
            animator.SetBool("WalkForward", false);
            animator.SetBool("WalkBack", false);
            animator.SetBool("WalkLeft", false);
            animator.SetBool("WalkRight", false);
        }
    }
}
