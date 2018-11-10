using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    AudioSource aud;
    public GameObject worldObject;
    void Start()
    {
        worldObject = GameObject.Find("World");
        aud = gameObject.GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        worldObject.SendMessage("AddCoin");
        Renderer objRenderer;
        Collider objCollider;
        objRenderer = GetComponent<Renderer>();
        objCollider = GetComponent<Collider>();
        objRenderer.enabled = false;
        objCollider.enabled = false;
        if (aud)
        {
            aud.Play();
        }
    }
}
