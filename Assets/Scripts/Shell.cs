using UnityEngine;

public class Shell : MonoBehaviour
{
    [Tooltip("爆炸冲力")] public float explosionForce = 300f;
    [Tooltip("爆炸范围")] public float explosionRadius = 3f;
    [Tooltip("爆炸特效")] public GameObject explosionEffect;
    [Tooltip("爆炸特效销毁的延迟时间")] public float explosionTimeUp = 1.5f;

    private void OnCollisionEnter()
    {
        Transform tf = transform;
        Vector3 position = tf.position;
        GameObject effect = Instantiate(explosionEffect, position, tf.rotation);
        Destroy(gameObject);
        Destroy(effect, explosionTimeUp);

        Collider[] colliders = Physics.OverlapSphere(position, explosionRadius);
        if (colliders.Length <= 0) return;
        foreach (Collider col in colliders)
        {
            #if UNITY_EDITOR
            Debug.Log(col.gameObject.name);
            #endif
            Rigidbody rb = col.GetComponent<Rigidbody>();
            if (rb != null) rb.AddExplosionForce(explosionForce, position, explosionRadius);
        }
    }
}