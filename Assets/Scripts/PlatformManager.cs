using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour {

    public float minZ;
    public float maxZ;
    public float minY;
    public float maxY;

    public bool moveZ;
    public bool moveY;

    GameObject player;
    bool invertMoveZ = false;
    bool invertMoveY = false;
    bool playerIn = false;

	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        if (playerIn)
        {
            updatePlayer();
        }
		if(!invertMoveZ && moveZ)
        {
            moveRight();
        }
        else if(moveZ)
        {
            moveLeft();
        }

        if(!invertMoveY && moveY)
        {
            moveUp();
        }

        else if (moveY)
        {
            moveDown();
        }
        
	}

    void moveLeft()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 0.04f);

        if (this.transform.position.z >= maxZ)
        {
            invertMoveZ = false;
        }
    }

    void moveRight()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 0.04f);
        
        if (this.transform.position.z <= minZ)
        {
            invertMoveZ = true;
        }
    }

    void moveUp()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.04f, this.transform.position.z);

        if(this.transform.position.y >= maxY)
        {
            invertMoveY = true;
        }
    }

    void moveDown()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.04f, this.transform.position.z);

        if (this.transform.position.y <= minY)
        {
            invertMoveY = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        playerIn = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerIn = false;
    }

    void updatePlayer()
    {
        player.transform.position = new Vector3(player.transform.position.x, this.transform.position.y, this.transform.position.z);
    }
}
