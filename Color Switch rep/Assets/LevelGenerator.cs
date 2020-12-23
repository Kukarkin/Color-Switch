using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 5f;
    [SerializeField] private List<Transform> levelPartList;
    [SerializeField] private Transform levelPart_0;
    [SerializeField] private Transform levelPart_1;
    [SerializeField] private Transform player;
    //[SerializeField] public Player player;


    private Vector3 lastEndPosition;

    private void Start()
    {
        lastEndPosition = levelPart_0.Find("EndPosition").position;
        SpawnLevelPart();
        //Transform lastLevelPartTransform;
        //lastLevelPartTransform = SpawnLevelPart(levelPart_0.Find("EndPosition").position);
        //SpawnLevelPart(lastLevelPartTransform.Find("EndPosition").position);
        //SpawnLevelPart(lastLevelPartTransform.Find("EndPosition").position);
        //SpawnLevelPart(lastLevelPartTransform.Find("EndPosition").position);
    }

    private void Update()
    {
        //Debug.Log("pos:" + player.position);
        //Debug.Log("pos1:" + lastEndPosition);
        if (Vector3.Distance(player.position, lastEndPosition) <= PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransorm = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransorm;
    }
}
