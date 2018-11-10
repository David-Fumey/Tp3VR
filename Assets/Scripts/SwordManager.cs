using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordManager : MonoBehaviour {

    float distance = 10;
    GameObject player;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindWithTag("Player"); // pour trouver le personnage
    }
    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(this.transform.position, player.transform.position);
        if (distance < 2)
        {
            this.transform.parent = player.transform;
            //this.transform.localPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            this.transform.localPosition = new Vector3(-0.72f, 2.14f, 1.08f);
            this.transform.localRotation = Quaternion.identity;
            this.transform.localRotation = Quaternion.Euler(110, 180, 90);
        }
    }
}
