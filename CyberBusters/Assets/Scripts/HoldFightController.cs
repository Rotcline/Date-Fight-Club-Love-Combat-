using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldFightController : MonoBehaviour
{
    private Animator anim;
    private float holdTime;
    public float speed=1;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)){
            anim.SetBool("Running",true);
            transform.rotation = Quaternion.Euler(0,90,0);
            transform.Translate( Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A)){
            anim.SetBool("Running",true);
            transform.rotation = Quaternion.Euler(0,270,0);
            transform.Translate( Vector3.forward* speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W)){
            anim.SetBool("Running",true);
            transform.rotation = Quaternion.Euler(0,180,0);
            transform.Translate( Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S)){
            anim.SetBool("Running", true);
            transform.rotation = Quaternion.Euler(0,0,0);
            transform.Translate( Vector3.forward* speed * Time.deltaTime);
        }

        if (!Input.GetKey(KeyCode.D) & !Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.W) & !Input.GetKey(KeyCode.S))
        {
            anim.SetBool("Running", false);
        }
        stopAnim("StrongSwordMid", 1f);
        stopAnim("MediumSwordMid", 0.7f);
        stopAnim("LowSwordMid", 0.7f);

        stopAnim("StrongSwordLow", 1f);
        stopAnim("MediumSwordLow", 0.7f);
        stopAnim("LowSwordLow", 0.7f);

        stopAnim("StrongSwordHigh", 1f);
        stopAnim("MediumSwordHigh", 0.7f);
        stopAnim("LowSwordHigh", 0.7f);

        stopAnim("StrongKickMid", 1f);
        stopAnim("MediumKickMid", 0.7f);
        stopAnim("LowKickMid", 0.7f);

        stopAnim("StrongKickLow", 1f);
        stopAnim("MediumKickLow", 0.7f);
        stopAnim("LowKickLow", 0.7f);

        stopAnim("StrongKickHigh", 1f);
        stopAnim("MediumKickHigh", 0.7f);
        stopAnim("LowKickHigh", 0.7f);


        if (Input.GetKey(KeyCode.DownArrow))
        {
            attackWithForce("KickLow", KeyCode.K);
            attackWithForce("SwordLow", KeyCode.L);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            attackWithForce("KickHigh", KeyCode.K);
            attackWithForce("SwordHigh", KeyCode.L);
        }
        else 
        {
            attackWithForce("SwordMid", KeyCode.L);
            attackWithForce("KickMid", KeyCode.K);
        }

    }

    void stopAnim(string animName, float timeToAnim)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= timeToAnim &
            anim.GetCurrentAnimatorStateInfo(0).IsName(animName))
        {
            anim.SetBool(animName, false);
        }
    }

    void attackWithForce(string animName, KeyCode kc)
    {
        if (Input.GetKeyDown(kc))
        {
            holdTime = Time.time;
        }
        if (Input.GetKeyUp(kc))
        {
            float timeHeld = Mathf.Abs(holdTime - Time.time);
            
            if (timeHeld > 0 & timeHeld < 0.1)
            {
                anim.SetBool("Low" + animName, true);
            }
            else if (timeHeld > 0.1 & timeHeld < 0.6)
            {
                anim.SetBool("Medium" + animName, true);
            }
            else if (timeHeld > 0.6)
            {
                anim.SetBool("Strong" + animName, true);
            }
        }
    }
}