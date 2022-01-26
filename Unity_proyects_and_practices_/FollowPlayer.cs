using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {


    public Transform playerPosition;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



        this.transform.position = new Vector3(this.playerPosition.position.x + 5.0f,
            this.playerPosition.position.y,
            this.playerPosition.position.z);

	}
}
