using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestBehaviour : MonoBehaviour {

    public GameObject loot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("touch");
        Destroy(gameObject);
        GameObject r = Instantiate(loot);
        r.GetComponent<CapsuleCollider>().isTrigger = true;
        r.transform.position = this.transform.position + Vector3.up;
    }
}
