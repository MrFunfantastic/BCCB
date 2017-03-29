using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	#pragma warning disable 0649
	[SerializeField] GameObject player;
	[SerializeField] LayerMask ground;
	Rigidbody2D playerBody;
	float speed = 0.1f;
	float jumpForce = 250;

	void Start () 
	{	
		playerBody = player.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Move();
		LiveCheck();
	}

	void Move ()
	{
		player.transform.Translate (new Vector3(speed,0f,0f));
	}

	public void Jump ()
	{
		bool grounded = Physics2D.OverlapPoint(new Vector2(player.transform.position.x,player.transform.position.y - .3f));
		if (grounded == true)
		{
			playerBody.AddForce(new Vector2(0f,jumpForce));
		}
	}

	void LiveCheck ()
	{
		bool touchedWall = Physics2D.OverlapPoint(new Vector2(player.transform.position.x + .3f,player.transform.position.y)); 
		if (touchedWall == true)
		{
			speed = 0f;
			Debug.Log("YOU LOST");
		}
	}
}
