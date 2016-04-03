using UnityEngine;
using System.Collections;

public class PlayerHit : MonoBehaviour {

	public GameObject deathParticles;

	private Vector3 spawnPos;
	private Quaternion spawnRot;

	// Use this for initialization
	void Start () {
		spawnPos = transform.position;
		spawnRot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -20) {
			Respawn();
		}
	}

	void OnCollisionEnter (Collision enemy)
	{
		if (enemy.gameObject.CompareTag ("Enemy")) {
			Respawn();
		}
	}

	void Respawn ()
	{
		Instantiate (deathParticles, transform.position, Quaternion.identity);
		transform.position = spawnPos;
		transform.rotation = spawnRot;
	}
}
