using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatformC : MonoBehaviour {

	public int maxPlatforms;

	public GameObject platform;
	public GameObject Luna;

	private float horizontalMin = 8.0f;
	private float horizontalMax = 15.0f;
	private float verticalMin = 0.0f;
	private float verticalMax = 4.5f;
	private float posMin = 250.0f;
	private float posMax = 275.0f;

	private Vector2 originPosition;

	// Use this for initialization
	void Start () {
		originPosition = transform.position;
		Spawn();
	}

	// Update is called once per frame
	void Update () {
		if(Luna.transform.position.x >= posMin && Luna.transform.position.x <= posMax) {
			posMin += 250.0f;
			posMax += 250.0f;
			Spawn();
		}
	}

	void Spawn() {
		for (int i = 0; i < maxPlatforms; i++) {
			if (i < 4) {
				Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(0, verticalMax));
				Instantiate (platform, randomPosition, Quaternion.identity);
				originPosition.x = randomPosition.x;
				originPosition.y = 0;
			} else {
				Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate (platform, randomPosition, Quaternion.identity);
				originPosition.x = randomPosition.x;
				originPosition.y = 0;
			}
		}
	}
}
