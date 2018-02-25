using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoofPrefab;

    private bool collected = false;

    void Update()
    {
        gameObject.transform.Rotate(new Vector3(32f, 32f, 32f) * Time.deltaTime);
    }

    public void OnCoinClicked()
    {
        if (!collected)
        {
            collected = true; // To avoid multiple clicks and so earn more coins ;)

            // Instantiate the CoinPoof Prefab where this coin is located
            // Make sure the poof animates vertically
            Instantiate(coinPoofPrefab, gameObject.transform.position, Quaternion.Euler(-90f, 0f, 0f));

            // Destroy this coin. Check the Unity documentation on how to use Destroy
            Destroy(gameObject, 0.5f);
        }
    }
}
