using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupSpawner : MonoBehaviour
{
    public GameObject popupPrefab;
    public int totalPopups = 0;

    private GameManager gm;
    private float respawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        respawnTimer = Random.Range(0.5f, 2.0f);
    }

    void SpawnPopup()
    {
        totalPopups += 1;
        float randomPosX = Random.Range(-5.9f, 5.9f);
        float randomPosY = Random.Range(-2.8f, 3.4f);
        float newPosZ = -((float)totalPopups/100);
        GameObject newPopup = Instantiate(popupPrefab, new Vector3(randomPosX, randomPosY, newPosZ), popupPrefab.transform.rotation);
        respawnTimer = Random.Range(0.2f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        respawnTimer -= Time.deltaTime;
 
         if (respawnTimer <= 0.0f) {
            SpawnPopup();
         }
    }
}
