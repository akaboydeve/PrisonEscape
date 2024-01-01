using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GateManager : MonoBehaviour
{
    private Vector2 targetPosition;

    public void OpenGate()
    {
        this.gameObject.GetComponent<Collider2D>().enabled = false;
        this.gameObject.GetComponent<Rigidbody2D>().simulated = false;
        // Initialize targetPosition here or in another appropriate method
        targetPosition = new Vector2(transform.position.x, transform.position.y + 100);

        transform.Translate(Vector2.MoveTowards(transform.position, targetPosition, 1 * Time.deltaTime) - (Vector2)transform.position);
        Destroy(gameObject, 2f);
    }
}
