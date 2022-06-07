using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntity
{
    public GameObject GetDeathEffect();
    public float GetHealth();
    public int GetDimension();
    public float GetMoveSpeed();
    public bool IsDead()
    {
        return GetHealth() <= 0;
    }
    public void Move(float _speed);
    public void SetTarget(Transform _target);

}
