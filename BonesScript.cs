using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// This script is responsible for handling the interaction with bones in the game.
public class BonesScript : MonoBehaviour
{
    // This public GameObject variable represents the bone that will be interacted with.
    public GameObject bone;

    // OnTriggerEnter is a method that's called when another object enters a trigger collider attached to this object.
    // A trigger collider is a type of physics collider that doesn't react physically to collisions but instead triggers events.
    private void OnTriggerEnter(Collider other)
    {
        // Check the collision with another object
        
        // If this method is called, it means another object has entered this object's trigger collider.
        // The 'other' parameter represents the other object that this object is colliding with.
        
        // This line makes the bone active in the scene.
        // SetActive(true) means the bone object will be active in the scene.
        bone.SetActive(true);
        
        // This line deactivates the current object in the scene.
        // It's not destroyed, but simply made invisible and non-interactive.
        gameObject.SetActive(false);
    }
}
