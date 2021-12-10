using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private List<Material> shaders;
    [SerializeField] private float _maxHealth = 1f;
    [SerializeField] private float _currentHealth = 0f;
    [SerializeField] private float _TimerTime = 2f;
    [SerializeField] private float _poisonDamage = 0.05f;

    [SerializeField] private bool _onCoolDown = false;
    [SerializeField] private bool _gameOver = false;
    private void Start()
    {
        _currentHealth = _maxHealth;
        foreach (Material m in GetComponent<Renderer>().materials)
        {
            shaders.Add(m);
        }
    }

    void Update()
    {
        
        if (_onCoolDown && !_gameOver) return;
        StartCoroutine(HealthTimer());
        _onCoolDown = true;
    }

    IEnumerator HealthTimer()
    {
        yield return new WaitForSeconds(_TimerTime);
        _currentHealth -= _poisonDamage; 
         for (int i = 0; i < shaders.Count; i++)
         {
             shaders[i].SetFloat("_Amount", _currentHealth);
         }

         if (_currentHealth >= 0)
         {
             Debug.Log("GameOver");
             _gameOver = true;
         }
         _onCoolDown = false;
    }
}
    
            
