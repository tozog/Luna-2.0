using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstaclesLevel2: MonoBehaviour {

	public int maxObjects = 15;

		//Bad game objects
	public GameObject dead_bush;
	public GameObject desert_skeleton;
	public GameObject skeleton;

		//Generic game objects
	public GameObject tombstone;
	public GameObject stone;

		//How far we can move the objects from one another.
	private float horizontalMin = 20;
	private float horizontalMax = 30;
	private float verticalMin = -1;
	private float verticalMax = 1;

		private Vector2 originPosition;

		// Use this for initialization
		void Start () {
			originPosition = transform.position;
			Spawn();
		}

		private void Spawn () {
			for (int i=0; i < maxObjects; i++) {
				float RandomObj = Random.Range(0, 5);
				if (RandomObj == 0) {
					Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
					Instantiate(dead_bush, randomPosition, Quaternion.identity);
					originPosition = randomPosition;
				}
				else if (RandomObj == 1) {
					Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
					Instantiate(desert_skeleton, randomPosition, Quaternion.identity);
					originPosition = randomPosition;
				}
				else if (RandomObj == 2) {
					Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
					Instantiate(skeleton, randomPosition, Quaternion.identity);
					originPosition = randomPosition;
				}
				else if (RandomObj == 3) {
					Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
					Instantiate(tombstone, randomPosition, Quaternion.identity);
					originPosition = randomPosition;
				}
				else if (RandomObj == 4) {
					Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
					Instantiate(stone, randomPosition, Quaternion.identity);
					originPosition = randomPosition;
				}
			}
		}
	}
