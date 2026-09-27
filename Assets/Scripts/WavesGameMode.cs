using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{
    [SerializeField] Life playerLife;
    [SerializeField] Life playerBaseLife;
    // Start is called before the first frame update
    void Start()
    {
        playerLife.onDeath.AddListener(OnPlayerOrBaseDied);
        playerBaseLife.onDeath.AddListener(OnPlayerOrBaseDied);
        EnemiesManager.instance.onChanged.AddListener(CheckWinCondition);
        WaveManager.instance.onChanged.AddListener(CheckWinCondition);
    }

    // Update is called once per frame
    void CheckWinCondition()
    {
        if (EnemiesManager.instance.enemies.Count <= 0 && WaveManager.instance.waves.Count <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }

    void OnPlayerOrBaseDied()
    {
        SceneManager.LoadScene("LoseScreen");
    }

    void OnDestroy()
    {
        playerLife.onDeath.RemoveListener(OnPlayerOrBaseDied);
        playerBaseLife.onDeath.RemoveListener(OnPlayerOrBaseDied);

        EnemiesManager.instance.onChanged.RemoveListener(CheckWinCondition);
        WaveManager.instance.onChanged.RemoveListener(CheckWinCondition);
    }
}
