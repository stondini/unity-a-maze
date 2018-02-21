using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour {

    public GameObject treePrefab;

    public GameObject pillarPrefab;

    /*
     * 
     * 
     */

	void Start () {
        // Place trees
        PlaceTrees();
        // Place pillas
        PlacePillars();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void PlaceTrees() {
        Quaternion rotation = Quaternion.Euler(-90.0f, 0f, 0f);
        float delta = 3.0f;
        for (int i = 0; i < 6; i++)
        {
            // Left green
            Instantiate(treePrefab, new Vector3(32f - (i * delta), 0, 120), rotation);
            Instantiate(treePrefab, new Vector3(32f, 0, 123 + (i * delta)), rotation);
            Instantiate(treePrefab, new Vector3(29f - (i * delta), 0, 138), rotation);

            // Right green
            Instantiate(treePrefab, new Vector3(-32f + (i * delta), 0, 120), rotation);
            Instantiate(treePrefab, new Vector3(-32f, 0, 123 + (i * delta)), rotation);
            Instantiate(treePrefab, new Vector3(-29f + (i * delta), 0, 138), rotation);
        }
    }

    private void PlacePillars()
    {
        Quaternion rotation = Quaternion.Euler(-90.0f, 0f, 90f);
        float delta = 7.0f;
        for (int i = 0; i < 6; i++)
        {
            Instantiate(pillarPrefab, new Vector3(-3.6f, 0, 24f + (i * delta)), rotation);
            Instantiate(pillarPrefab, new Vector3(3.6f, 0, 24f + (i * delta)), rotation);
        }
    }
}
