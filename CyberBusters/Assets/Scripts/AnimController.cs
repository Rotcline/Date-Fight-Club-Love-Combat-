using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.7f)
        {
            anim.SetBool("MediumSwordMid", false);
            anim.SetBool("MediumSwordHigh", false);
            anim.SetBool("MediumSwordLow", false);

            anim.SetBool("MediumKickMid", false);
            anim.SetBool("MediumKickHigh", false);
            anim.SetBool("MediumKickLow", false);

        }
        if (Input.GetKey(KeyCode.L) & Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("MediumSwordLow", true);
        }
        else if (Input.GetKey(KeyCode.L) & Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("MediumSwordHigh", true);
        }
        else if (Input.GetKey(KeyCode.K) & Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("MediumKickLow", true);
        }
        else if (Input.GetKey(KeyCode.K) & Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("MediumKickHigh", true);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            anim.SetBool("MediumSwordMid", true);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            anim.SetBool("MediumKickMid", true);
        }
    }
}
