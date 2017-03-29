using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {

	#pragma warning disable 0649
	[SerializeField] GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3(player.transform.position.x,player.transform.position.y,-10f);
	}
}
