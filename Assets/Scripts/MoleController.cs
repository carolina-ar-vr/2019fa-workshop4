using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleController : MonoBehaviour
{
    // Editor references
    [SerializeField] private Animator anim;

    // Time until this mole should transition from down to up, or up to down, depending on current state
    private float stateTimeLeft;

    // Set to true after being tapped (hit by ray cast from TouchCaster)
    public bool wasHit { get; private set; }

    private bool _isUp = false;
    // Represents if the mole should be in its up state
    // NOTE: setting this value is equivalent to calling a function, and will modify other state!
    public bool IsUp
    {
        get { return _isUp; }
        private set
        {
            _isUp = value;
            anim.SetBool("up", value);
            if (value)
            {
                stateTimeLeft = Random.Range(2.0f, 6.0f); 
            }
            else 
            {
                stateTimeLeft = Random.Range(2.0f, 4.0f);
            }
        }
    }

    // Called by Unity once when this object is first instantiated
    void Start()
    {
        ResetState();
    }

    // Update is called once per frame
    void Update()
    {
        // If game manager says we are not in progress
            // reset our state so we stay down
            // exit this method


        // decrease our state time counter


        // if we got hit
            // reset our hit toggle/flag
            // if we are up
                // make us go down
                // give a point
            // else, we are down
                // take away a point


        // if our state time counter is depleted
            // toggle our up state
    }

    private void ResetState()
    {
        //sets was hit to be false
        wasHit = false;

        //set is up to be false since it initializes in down positon
        IsUp = false; 
    }

    public void Whack()
    {
        wasHit = true;
    }
}
