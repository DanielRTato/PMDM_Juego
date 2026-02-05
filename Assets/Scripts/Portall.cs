using UnityEngine;

public class Portall : MonoBehaviour
{
    public Transform destination;

    // Cooldown para evitar teletransportes en cadena
    private static float lastTeleportTime = -1f;
    private const float teleportCooldown = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        // Verificar cooldown
        if (Time.time - lastTeleportTime < teleportCooldown)
            return;

        if (!other.CompareTag("Player"))
            return;
        
        // Marcar el tiempo del teletransporte
        lastTeleportTime = Time.time;

        // Calcular posición de destino (un poco adelante para no caer en otro trigger)
        Vector3 destPos = destination.position + (destination.forward * 1.5f);

        // Intentar con Rigidbody primero (tu jugador usa Rigidbody)
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            other.transform.SetPositionAndRotation(destPos, destination.rotation);
            Physics.SyncTransforms();
            return;
        }

        // Si tiene CharacterController
        CharacterController cc = other.GetComponent<CharacterController>();
        if (cc != null)
        {
            cc.enabled = false;
            other.transform.SetPositionAndRotation(destPos, destination.rotation);
            Physics.SyncTransforms();
            cc.enabled = true;
            return;
        }

        other.transform.SetPositionAndRotation(destPos, destination.rotation);
    }
}
