using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleAnimator : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        //работает если игрок в зоне досягаемости
        if (anim.GetBool("IsOpening"))
        {
            anim.SetBool("IsOpening", false);
            anim.SetBool("IsClosing", true);
        }
        else if (anim.GetBool("IsClosing"))
        {
            anim.SetBool("IsClosing", false);
            anim.SetBool("IsOpening", true);
        }
    }
}
