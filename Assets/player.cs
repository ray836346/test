using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class player : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	public Text winText;
	private float score;


	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody>();
		score = 0;
		winText.text = "";
	}
	
	// Update is called once per frame
	//移動
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 move = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (move * speed);
	}

	//碰撞時方快消失
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("pick")) {
			other.gameObject.SetActive(false);
			score = score+1;
			if(score>=3){   //皆消失後即勝利
				winText.text = "勝利";
			}
		}
	}


}
