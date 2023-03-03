using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldFightController : MonoBehaviour
{
    private Animator anim;
    private float holdTime;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f & anim.GetCurrentAnimatorStateInfo(0).IsName("StrongSwordMid"))
        {
            anim.SetBool("StrongSwordMid", false);
        }
        else if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.7f)
        {
            anim.SetBool("MediumSwordMid", false);
            anim.SetBool("LowSwordMid", false);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            holdTime = Time.time;
        }
        if (Input.GetKeyUp(KeyCode.L) & (Mathf.Abs(holdTime-Time.time)>0 & Mathf.Abs(holdTime-Time.time)<0.1))
        {
            anim.SetBool("LowSwordMid", true);
        }
        else if (Input.GetKeyUp(KeyCode.L) & (Mathf.Abs(holdTime-Time.time)>0.1 & Mathf.Abs(holdTime-Time.time)<0.6))
        {
            anim.SetBool("MediumSwordMid", true);
        }
        else if (Input.GetKeyUp(KeyCode.L) & (Mathf.Abs(holdTime-Time.time)>0.6))
        {
            anim.SetBool("StrongSwordMid", true);
        }
    }
}