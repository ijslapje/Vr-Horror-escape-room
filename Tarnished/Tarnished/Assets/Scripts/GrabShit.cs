﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class GrabShit : MonoBehaviour
{
    private Interactable interactable;

    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    private void OnHandHoverBegin(Hand hand)
    {
        hand.ShowGrabHint();
    }
    private void OnHandHoverEnd(Hand hand)
    {
        hand.HideGrabHint();
    }
    private void HandHoverUpdate(Hand hand)
    {
        GrabTypes grabType = hand.GetGrabStarting();
        bool isGrabEnding = hand.IsGrabEnding(gameObject);

        if (interactable.attachedToHand == null && grabType != GrabTypes.None)
        {
            hand.AttachObject(gameObject, grabType);

        }
        else if(isGrabEnding){
            hand.DetachObject(gameObject);
        }
    }
}