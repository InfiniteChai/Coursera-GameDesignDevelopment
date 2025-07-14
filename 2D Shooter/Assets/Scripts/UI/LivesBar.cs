using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LivesBar : MonoBehaviour
{
    public GameObject lifeIconPrefab;
    public Health playerHealth;
    private GameObject[] lifeIcons;
    private int currentLives = 0;
	void Start()
	{
        lifeIcons = new GameObject[playerHealth.maximumLives];
        for (int i = 0; i < playerHealth.maximumLives; i++)
        {
            var lifeIcon = GameObject.Instantiate(lifeIconPrefab, transform);
            lifeIcon.GetComponent<RectTransform>().anchoredPosition = new Vector2(55 * i, 0);
            lifeIcon.SetActive(false);
            lifeIcons[i] = lifeIcon;
        }
	}

	void Update()
    {
        if (currentLives != playerHealth.currentLives) 
        {
            foreach (var lifeIcon in lifeIcons)
            {
                lifeIcon.SetActive(false);
            }  
            currentLives = playerHealth.currentLives;
            // 
            for (int i = 0; i < currentLives; i++)
            {
                lifeIcons[i].SetActive(true);                
            }
        }
        
    }
}
