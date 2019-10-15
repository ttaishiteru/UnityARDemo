using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*for TEST*/
public class PlayerController : MonoBehaviour
{   
    //private Animation anim;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetMouseButtonDown(0))
        {
            //string animName = "jump";
            //if (!anim.IsPlaying(animName))
            //{
            //    anim.Play(animName);
            //    anim.PlayQueued("idle");
            //}
            animator.Play("jump");
            //animator.Play("idle");
        }
    }
}
