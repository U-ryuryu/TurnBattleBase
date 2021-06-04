using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 戦闘を管理
public class BattleManager : MonoBehaviour
{
    public UnitManager player;
    public UnitManager enemy;

    // PlayerがEnemyに攻撃する
    public void OnAttackButton()
    {
        player.Attack(enemy);
        EnemyTurn();
    }

    // EnemyがPlayerに攻撃する
    void EnemyTurn()
    {
        enemy.Attack(player);
    }
}
