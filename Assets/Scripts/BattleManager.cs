using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 戦闘を管理
public class BattleManager : MonoBehaviour
{
    public UnitManager player;
    public UnitManager enemy;

    // PlayerがEnemyに攻撃する
    public void OnAttackButton()
    {
        player.Attack(enemy);
        if (enemy.hp >0)
        {
            EnemyTurn();
        }
        else
        {
            BattleEnd();
        }
    }

    // EnemyがPlayerに攻撃する
    void EnemyTurn()
    {
        enemy.Attack(player);
        if (player.hp == 0)
        {
            BattleEnd();
        }
    }

    void BattleEnd()
    {
        Debug.Log("対戦終了");
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
}
