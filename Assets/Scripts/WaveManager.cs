using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;
    public List<WaveSpawner> waves;

    public UnityEvent onChanged;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Dupe detected, ignoring this", gameObject);
        }
    }

    public void AddWave(WaveSpawner other)
    {
        waves.Add(other);
        onChanged.Invoke();
    }

    public void RemoveWave(WaveSpawner other)
    {
        waves.Remove(other);
        onChanged.Invoke();
    }
}
