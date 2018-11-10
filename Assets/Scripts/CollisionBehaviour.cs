using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("On it");
        Animator persoAnimator = gameObject.GetComponent<Animator>();
        persoAnimator.SetTrigger("HitTrigger");
    }
}
