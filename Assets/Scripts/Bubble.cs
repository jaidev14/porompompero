using UnityEngine;

public class Bubble : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite popSprite;
    public Sprite bubbleSprite;
    public ParticleSystem explodeParticles;
    private AudioSource audioSource;
    public AudioClip explode;
    public AudioClip implode;
    private bool exploded = false;

    void Start() {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        audioSource = this.GetComponent<AudioSource>();
    }

    private void OnMouseDown() {
        if (exploded) {
            Implode();
        } else {
            Explode();
        }
    }

    public void Explode() {
        spriteRenderer.sprite = popSprite;
        Instantiate(explodeParticles, transform);
        audioSource.clip = explode;
        audioSource.pitch = Random.Range(0.8f, 1.2f);
        audioSource.Play();
        exploded = true;
    }
    public void Implode() {
        spriteRenderer.sprite = bubbleSprite;
        Instantiate(explodeParticles, transform);
        audioSource.clip = implode;
        audioSource.pitch = Random.Range(0.8f, 1.2f);
        audioSource.Play();
        exploded = false;
    }

    public void Restart() {
        spriteRenderer.sprite = bubbleSprite;
        exploded = false;
    }
}
