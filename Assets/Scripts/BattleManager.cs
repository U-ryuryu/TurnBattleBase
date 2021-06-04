using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 戦闘を管理
public class BattleManager : MonoBehaviour
{
    public UnitManager player;
    public UnitManager enemy;

    void Start()
    {
        player.Attack(enemy);
        enemy.Attack(player);
    }
}
