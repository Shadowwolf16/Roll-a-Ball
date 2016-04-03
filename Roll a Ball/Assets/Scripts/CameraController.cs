using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float smoothing;
	public GameObject player;

	private Vector3 offset;

	void Start ()
	{
		offset = transform.position - player.transform.position;
	}

	void LateUpdate () 
	{
		transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, smoothing);
	}
}
