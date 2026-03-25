using System;
using UnityEngine;

public class Character : MonoBehaviour, ICharacter
{
    public event Action OnDeath;

    [SerializeField]
    private float speed = 2.5f;

    public void Move(Vector3 direction, float deltaTime)
    {
        this.transform.position += direction * (deltaTime * this.speed);
    }

    public Vector3 GetPosition()
    {
        return this.transform.position;
    }

    [ContextMenu("Death")]
    public void Death()
    {
        this.OnDeath?.Invoke();
    }
}
