using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    [SerializeField] private float damage = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * (speed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.GetComponent<Health>();
        health.DealDamage(damage);
    }
}