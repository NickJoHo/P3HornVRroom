using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Rigidbody))]
public class BallBounceSound : MonoBehaviour
{
    public AudioClip bounceSound;   // Drag your sound here in Inspector
    public float minVelocity = 1f;  // Minimum speed to play sound
    public float maxVolume = 1f;    // Max volume cap

    private AudioSource audioSource;
    private Rigidbody rb;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();

        // Make sure it's 3D sound
        audioSource.spatialBlend = 1f;
    }

    void OnCollisionEnter(Collision collision)
    {
        float speed = rb.velocity.magnitude;

        if (speed > minVelocity)
        {
            // Adjust volume based on speed
            float volume = Mathf.Clamp(speed / 10f, 0f, maxVolume);

            audioSource.PlayOneShot(bounceSound, volume);
        }
    }
}