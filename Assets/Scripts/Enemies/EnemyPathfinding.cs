using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathfinding : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;

    private Rigidbody2D rb;
    private Vector2 moveDir;
    private Knockback knockback;

    private void Awake() {
        knockback = GetComponent<Knockback>();
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update() {
        if (knockback.GettingKnockedBack) { return; }

        transform.position = Vector2.MoveTowards(transform.position, PlayerController.Instance.transform.position,  moveSpeed * Time.fixedDeltaTime);
    }


    public void MoveTo(Vector2 targetPosition)
    {
        moveDir = targetPosition;
    }
}
