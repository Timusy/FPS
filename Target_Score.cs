using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Score : MonoBehaviour
{
    public int PointsToAdd;
    public void DeductPoints(int damageAmount)
    {
        ScoreCard.GlobalScoreCard += PointsToAdd;
    }
}
