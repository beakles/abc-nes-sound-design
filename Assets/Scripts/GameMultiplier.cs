﻿using UnityEngine;

public class GameMultiplier : MonoBehaviour
{
    public static float gameMultiplier = 2.5f;
    public static float oneTimbre = 0.1f;
    public static int gameTempo = 375;

    // Update is called once per frame
    void Update()
    {
        MainCamera.ResizeCamera(gameMultiplier / 2);
        PlayerController.agility = gameMultiplier;

        if (PlayerShoot.maxOrbs <= 5)
        {
            PlayerShoot.maxOrbs = Mathf.FloorToInt(gameMultiplier);
        }
        else
        {
            PlayerShoot.maxOrbs = 5;
        }
    }
}
