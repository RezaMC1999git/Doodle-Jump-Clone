using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public Transform PlaceHolder;
    public int numberOfPlatforms = 200;
    public float levelWidth = 3;
    public float minY = 0.2f;
    public float maxY = 1.5f;
    private void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY,maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            GameObject P =  Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            P.transform.parent = PlaceHolder;
        }
    }
}
