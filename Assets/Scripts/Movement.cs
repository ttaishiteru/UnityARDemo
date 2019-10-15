using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*for TEST*/
public class Movement : MonoBehaviour
{   
    private Animator animator;
    private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //Vector3 e_rot = transform.eulerAngles;
            //e_rot.x = -90;
            //e_rot.y = 0;
            //e_rot.z = 0;
            //transform.eulerAngles = e_rot;
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            animator.Play("run");
        }
    }
}
