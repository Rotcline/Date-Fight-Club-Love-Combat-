using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightController : MonoBehaviour
{
    private Animator anim;
    private bool Held = false;
    private float speed = 0.5f;
    private Queue<string> actions;
    private string currAction;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Must check actions taken
        // Movement
        if (Input.GetKey(KeyCode.D)){
            if (Input.GetKey(KeyCode.LeftControl)) 
                actions.Enqueue("DashRight");    
            else 
                transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A)){
            if (Input.GetKey(KeyCode.LeftControl))
                actions.Enqueue("DashLeft");
            else 
                transform.position += Vector3.left* speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.W)){
            if (Input.GetKey(KeyCode.LeftControl))
                actions.Enqueue("DashFoward");
            else
                transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S)){
            if (Input.GetKey(KeyCode.LeftControl))
                actions.Enqueue("DashBack");
            else
                transform.position += Vector3.back* speed * Time.deltaTime;
        }
        // Add combat action to queue
        if (Input.GetKey(KeyCode.L)) {
            
        }
        else if (Input.GetKey(KeyCode.K)) {

        }
        // Check if there's a current action, if normalizedTime is equal to or larger than 1, the animation has run it's course. 
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f) {
            anim.SetBool(currAction, false);
            // If there's no current action activate following queued action
            if (actions.Count > 0) {
                currAction = actions.Dequeue();
                anim.SetBool(currAction, true);
                switch (currAction)
                {
                    case "LowKickLow":
                    anim.SetBool("LowKickLow", true);  
                    break;
                    case "LowKickMid":
                    anim.SetBool("LowKickMid", true);
                    break;
                    case "LowKickHigh":
                    anim.SetBool("LowKickHigh", true);
                    break;
                    case "MediumKickLow":
                    anim.SetBool("MediumKickLow", true);
                    break;
                    case "MediumKickMid":
                    anim.SetBool("MediumKickMid", true);
                    break;
                    case "MediumKickHigh":
                    anim.SetBool("MediumKickHigh", true);
                    break;
                    case "StrongKickLow":
                    anim.SetBool("StrongKickLow", true);
                    break;
                    case "StrongKickMid":
                    anim.SetBool("StrongKickMid", true);
                    break;
                    case "StrongKickHigh":
                    anim.SetBool("StrongKickHigh", true);
                    break;
                    case "LowSwordLow":
                    anim.SetBool("LowSwordLow", true);
                    break;
                    case "LowSwordMid":
                    anim.SetBool("LowKickLow", true);
                    break;
                    case "LowSwordHigh":
                    anim.SetBool("LowSwordHigh", true);
                    break;
                    case "MediumSwordLow":
                    anim.SetBool("MediumSwordLow", true);
                    break;
                    case "MediumSwordMid":
                    anim.SetBool("MediumSwordMid", true);
                    break;
                    case "MediumSwordHigh":
                    anim.SetBool("MediumSwordHigh", true);
                    break;
                    case "StrongSwordLow":
                    anim.SetBool("StrongSwordLow", true);
                    break;
                    case "StrongSwordMid":
                    anim.SetBool("StrongSwordMid", true);
                    break;
                    case "StrongSwordHigh":
                    anim.SetBool("StrongSwordHigh", true);
                    break;
                    case "DashRight":
                    anim.SetBool("DashRight", true);
                    break;
                    case "DashLeft":
                    anim.SetBool("DashLeft", true);
                    break;
                    case "DashFoward":
                    anim.SetBool("DashFoward", true);
                    break;
                    case "DashBack":
                    anim.SetBool("DashBack", true);
                    break;
                }
            }
        } 
    }

    void LowKickLow() {

    }

    void LowKickMid() {

    }

    void LowKickHigh() {

    }

    void MediumKickLow() {

    }

    void MediumKickMid() {

    }
    
    void MediumKickHigh() {

    }

    void StrongKickLow() {

    }

    void StrongKickMid() {

    }

    void StrongKickHigh() {

    }

    void LowSwordLow() {
        
    }

    void LowSwordMid() {

    }

    void LowSwordHigh() {

    }

    void MediumSwordLow() {

    }

    void MediumSwordMid() {

    }

    void MediumSwordHigh() {

    }

    void StrongSwordLow() {

    }

    void StrongSwordMid() {

    }

    void StrongSwordHigh() {

    }
}
