using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepController : AnimalController
{
    [SerializeField, Tooltip("金のヒツジかどうか")] bool gold = false;

    public override void OnHitFence(GameManager gameManager)
    {
        gameManager.AddCombo(false);
        gameManager.UpdateGage(false);
        Destroy(gameObject);

    }

    public override void OnGoal(GameManager gameManager)
    {
        gameManager.AddScore(gold);
        gameManager.AddCombo(true);
        gameManager.UpdateGage(true);
    }
}
