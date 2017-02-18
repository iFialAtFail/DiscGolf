using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class DiscPhysics : MonoBehaviour
{
    //
    //
    //
    //
    //During flight, the disc will go through a minimum of two phases.
    //Phase 1: Release
    //Phase 2: HighSpeed
    //Phase 3: LowSpeed
    //
    //
    //
    //
    //
    //
    public Rigidbody disc;
    public Throwable throwable;
    public float floatForce = 2;
    public float floatTime = 2;
    public float verticalLimit = 5;
    float time;

    // Use this for initialization
    void Awake()
    {
        //        throwable.onDetachFromHand.AddListener(new UnityEngine.Events.UnityAction(detachedFromHand));
    }

    void FixedUpdate()
    {
        //time += Time.fixedDeltaTime;
        //if (time < floatTime)
        //{
        //    disc.AddForce(Vector3.up * floatForce);
        //}
        //else { disc.AddForce(Vector3.down * 10); }
        floatAlgorithm();
    }



    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name + " collider hit");
        time = 0;
    }

    private void floatAlgorithm()
    {
        
        if (disc.velocity.y < verticalLimit)
        {
            float force = disc.velocity.magnitude * Time.fixedDeltaTime * floatForce;
            disc.AddRelativeForce(Vector3.up * force);
        }
    }

    private void highSpeedTurnAlgorithm()
    {

    }

    private void lowSpeedTurn()
    {

    }
}
