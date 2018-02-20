using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour {

    public GameObject treePrefab;

	void Start () {
        // Place trees
        PlaceTrees();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void PlaceTrees() {
        Quaternion treeRotation = Quaternion.Euler(-90.0f, 0f, 0f);
        float treeDelta = 3.0f;
        for (int i = 0; i < 6; i++)
        {
            // Left green
            Instantiate(treePrefab, new Vector3(32f - (i * treeDelta), 0, 120), treeRotation);
            Instantiate(treePrefab, new Vector3(32f, 0, 123 + (i * treeDelta)), treeRotation);
            Instantiate(treePrefab, new Vector3(29f - (i * treeDelta), 0, 138), treeRotation);

            // Right green
            Instantiate(treePrefab, new Vector3(-32f + (i * treeDelta), 0, 120), treeRotation);
            Instantiate(treePrefab, new Vector3(-32f, 0, 123 + (i * treeDelta)), treeRotation);
            Instantiate(treePrefab, new Vector3(-29f + (i * treeDelta), 0, 138), treeRotation);
        }
    }
}
