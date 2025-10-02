using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverPointGenerator : MonoBehaviour
{
    [SerializeField] GameObject hoverPoint;
    private GameObject currentPoint;

    public void RespawnHoverPoint()
    {
        if (currentPoint != null)
        {
            Destroy(currentPoint);
        }

        Vector2 spawnPos = new Vector2(Random.Range(-7f, 7f), Random.Range(-3f, 3f));
        currentPoint = Instantiate(hoverPoint, spawnPos, Quaternion.identity);
    }

    void Start()
    {
        RespawnHoverPoint(); // ç≈èâÇÃèoåª
    }

}
