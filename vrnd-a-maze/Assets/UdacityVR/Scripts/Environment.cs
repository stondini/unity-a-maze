using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour {

    public GameObject treePrefab;

    public GameObject pillarPrefab;

    public float nextStormTime;

	void Start () {
        // Place trees
        PlaceTrees();
        // Place pillas
        PlacePillars();

        nextStormTime = Time.fixedTime + Random.Range(16.0f, 60.0f); // From 16 seconds to 60 seconds
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.fixedTime >= nextStormTime) {
            nextStormTime = Time.fixedTime + Random.Range(16.0f, 60.0f); // From 16 seconds to 60 seconds
            gameObject.GetComponent<AudioSource>().Play();
        }
	}

    private void PlaceTrees() {
        Quaternion rotation = Quaternion.Euler(-90.0f, 0f, 0f);
        float delta = 3.0f;
        for (int i = 0; i < 6; i++)
        {
            // Left green
            Instantiate(treePrefab, new Vector3(32f - (i * delta), 0f, 120f), rotation);
            Instantiate(treePrefab, new Vector3(32f, 0f, 123f + (i * delta)), rotation);
            Instantiate(treePrefab, new Vector3(29f - (i * delta), 0f, 138f), rotation);

            // Right green
            Instantiate(treePrefab, new Vector3(-32f + (i * delta), 0f, 120f), rotation);
            Instantiate(treePrefab, new Vector3(-32f, 0f, 123f + (i * delta)), rotation);
            Instantiate(treePrefab, new Vector3(-29f + (i * delta), 0f, 138f), rotation);
        }

        // The trees circle
        int nbTrees = 32;
        float centerX = -25f;
        float centerZ = 0f;
        float radius = 12.0f;
        for (int i = 0; i < nbTrees; i++)
        {
            // Create the entry and exit
            if ((i >= 11 && i <= 12) || (i >= 26 && i <= 27)) {
                continue;
            }
            float angle = (i * 2f * Mathf.PI) / (float)nbTrees;
            float x = centerX + (radius * Mathf.Cos(angle));
            float z = centerZ + (radius * Mathf.Sin(angle));
            Instantiate(treePrefab, new Vector3(x, 0f, z), rotation);
        }
    }

    private void PlacePillars()
    {
        Quaternion rotation = Quaternion.Euler(-90.0f, 0f, 90f);
        float delta = 7.0f;
        for (int i = 0; i < 6; i++)
        {
            Instantiate(pillarPrefab, new Vector3(-3.6f, 0f, 24f + (i * delta)), rotation);
            Instantiate(pillarPrefab, new Vector3(3.6f, 0f, 24f + (i * delta)), rotation);
        }
    }
}
