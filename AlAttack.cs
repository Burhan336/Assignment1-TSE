using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlAttack : MonoBehaviour
{

    public GameObject MonsterUpFront;
    public GameObject AIMonster;
    public GameObject Rocks;
    public AudioSource AttackSound;
    public Animator camera_anim;

    // This method is called when a collider triggers the event
    void OnTriggerEnter(Collider triggerInfo)
    {
        // Check if the triggered object's name is "EnemyAI"
        if (triggerInfo.gameObject.name == "EnemyAI")
        {
            print("yes");
            AIMonster.SetActive(false);
            MonsterUpFront.SetActive(true);
            AttackSound.Play();
            camera_anim.enabled = true;
            camera_anim.Play("camera_anim2", 0, 0.0f);
            StartCoroutine(TimeTaken());
        }

        // Check if the triggered object's name is "Event8.1"
        if (triggerInfo.gameObject.name == "Event8.1")
        {
            AIMonster.SetActive(false);
            Rocks.SetActive(true);
        }
    }

    // Coroutine to handle time delay
    IEnumerator TimeTaken()
    {
        yield return new WaitForSeconds(1);
        MonsterUpFront.SetActive(false);
        camera_anim.enabled = false;
        gameObject.transform.position = new Vector3(501, 7, 484);
        obj.obj.SetText("Escape Doctor");
        obj.hint.SetText("Don't Get Caught");
        obj.trigger = true;
        obj.AIMonster.transform.position = new Vector3(509, 8, 503);
    }

    // Single-line comment describing the purpose of the class or method
    // ...
    // ...

    /*
     * Multi-line comment
     * You can add detailed explanations or describe the functionality of the code here.
     * ...
     * ... This is a multi line comment which can be edited
     */

     

}





