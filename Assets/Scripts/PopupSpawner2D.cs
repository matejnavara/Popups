using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupSpawner2D : MonoBehaviour
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
        float randomPosX = Random.Range(-700f, 300f);
        float randomPosY = Random.Range(-350f, 130f);
        GameObject popup = Instantiate(popupPrefab, transform.position, transform.rotation);
        popup.transform.SetParent(transform, false);
        popup.transform.localPosition = new Vector3(randomPosX, randomPosY, 0);
        respawnTimer = Random.Range(0.3f, 1.3f);
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
