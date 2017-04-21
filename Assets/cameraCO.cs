using UnityEngine;
using System.Collections;

//攝影機追蹤

public class cameraCO : MonoBehaviour {

	private Vector3 offset;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
		offset = transform.position - player.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = player.transform.position + offset;

	}
}


