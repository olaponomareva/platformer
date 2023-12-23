using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //скорость движения игрока
    public float speed;
    //цель,к которой движется враг
    public Transform target;
    //очки урона от атаки врагом игрока
    public int player;
    public int playerDamage = 2;

    void Update()
    {
        //меняет каждый кадр позицию NPC на новую
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //Разворачивает каждый кадр NPC лицом к цели
        transform.LookAt(target.position);
    }

    //При столкновении врага с игроком второму наносится урон
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(playerDamage);

    }




}
