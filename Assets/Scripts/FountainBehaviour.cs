using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FountainBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
    string levelToLoad="BoxBoyz";

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Value coins =" + GameVariables.coins);
        if(GameVariables.coins == 6)
        {
            
            SceneManager.LoadScene(levelToLoad);
        }  
    }
}
