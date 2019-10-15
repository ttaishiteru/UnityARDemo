using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnButtonUp : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    public GameObject player;

    private float speed = 10f;
    private bool isDown = false;
    // Start is called before the first frame update
    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        isDown = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        isDown = false;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        isDown = false;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDown)
        {
            //AudioClip run = (AudioClip)Resources.Load("run", typeof(AudioClip));
            //AudioSource.PlayClipAtPoint(run, transform.position);

            Animator animator = player.GetComponent<Animator>();
            animator.Play("run");
            player.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        }
    }
    public void OnButtonJump()
    {
        AudioClip jump = (AudioClip)Resources.Load("jump", typeof(AudioClip));
        AudioSource.PlayClipAtPoint(jump, player.transform.position);

        Animator animator = player.GetComponent<Animator>();
        animator.Play("jump");
    }
    public void OnButtonHit()
    {
        AudioClip hit = (AudioClip)Resources.Load("hit", typeof(AudioClip));
        AudioSource.PlayClipAtPoint(hit, player.transform.position);

        Animator animator = player.GetComponent<Animator>();
        animator.Play("hit");
    }
    public void OnButtonLay()
    {
        AudioClip lay = (AudioClip)Resources.Load("laydown", typeof(AudioClip));
        AudioSource.PlayClipAtPoint(lay, player.transform.position);

        Animator animator = player.GetComponent<Animator>();
        animator.Play("laydown");
    }
}
