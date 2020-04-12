using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Sound : MonoBehaviour,
                                            ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;



    void Start()
    {

        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play audio when target is found
            this.GetComponent<AudioSource>().Play(); // Bplay.
        }
        else
        {
            // Stop audio when target is lost
            this.GetComponent<AudioSource>().Stop();
        }
    }
}