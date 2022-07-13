using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum Weapon
{
    Rifle, Shotgun, Minigun
}

public class Player : MonoBehaviour, IEntity
{
    private EntityDimension playerDimension = EntityDimension.PLAYER;
    public PlayerMovement playerMovement;
    private int health = 3;
    private Weapon weapon;

    public Weapon GetCurrentWeapon()
    {
        return this.weapon;
    }

    public void SetCurrentWeapon(Weapon weapon)
    {
        this.weapon = weapon;
    }
    
    public GameObject GetDeathEffect()
    {
        throw new System.NotImplementedException();
    }

    public EntityDimension GetDimension()
    {
        return playerDimension;
    }

    public float GetHealth()
    {
        throw new System.NotImplementedException();
    }

    public float GetMoveSpeed()
    {
        throw new System.NotImplementedException();
    }

    public void Move(float scale)
    {
        playerMovement.Move(scale);
    }

    public void SetDimenion(EntityDimension dimension)
    {
       //activeDimension = dimension;
    }

    public void SetTarget(Transform _target)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        LevelController.Instance.AddEntityToList(this, EntityDimension.PLAYER);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            LevelController.Instance.SetLevelActive(false); 
            //Destroy(this.GameObject());
            //here game over
        }
    }
}
