// // // using UnityEngine;

// // // public class Player : MonoBehaviour
// // // {
// // //     public Sprite[] sprites;
// // //     public float strength = 5f;
// // //     public float gravity = -9.81f;
// // //     public float tilt = 5f;

// // //     private SpriteRenderer spriteRenderer;
// // //     private Vector3 direction;
// // //     private int spriteIndex;

// // //     private void Awake()
// // //     {
// // //         spriteRenderer = GetComponent<SpriteRenderer>();
// // //     }

// // //     private void Start()
// // //     {
// // //         InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
// // //     }

// // //     private void OnEnable()
// // //     {
// // //         Vector3 position = transform.position;
// // //         position.y = 0f;
// // //         transform.position = position;
// // //         direction = Vector3.zero;
// // //     }

// // //     private void Update()
// // //     {
// // //         if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
// // //             direction = Vector3.up * strength;
// // //         }

// // //         // Apply gravity and update the position
// // //         direction.y += gravity * Time.deltaTime;
// // //         transform.position += direction * Time.deltaTime;

// // //         // Tilt the bird based on the direction
// // //         Vector3 rotation = transform.eulerAngles;
// // //         rotation.z = direction.y * tilt;
// // //         transform.eulerAngles = rotation;
// // //     }

// // //     private void AnimateSprite()
// // //     {
// // //         spriteIndex++;

// // //         if (spriteIndex >= sprites.Length) {
// // //             spriteIndex = 0;
// // //         }

// // //         if (spriteIndex < sprites.Length && spriteIndex >= 0) {
// // //             spriteRenderer.sprite = sprites[spriteIndex];
// // //         }
// // //     }

// // //     private void OnTriggerEnter2D(Collider2D other)
// // //     {
// // //         if (other.gameObject.CompareTag("Obstacle")) {
// // //             GameManager.Instance.GameOver();
// // //         } else if (other.gameObject.CompareTag("Scoring")) {
// // //             GameManager.Instance.IncreaseScore();
// // //         }
// // //     }

// // // }
// // using UnityEngine;

// // public class Player : MonoBehaviour
// // {
// //     public Sprite[] sprites;
// //     public float strength = 5f;
// //     public float gravity = -9.81f;
// //     public float tilt = 5f;

// //     private SpriteRenderer spriteRenderer;
// //     private Vector3 direction;
// //     private int spriteIndex;

// //     public AudioSource jumpSound;  // Drag the AudioSource component here in the Inspector
// //     public AudioSource deathSound; // Drag the AudioSource component here in the Inspector

// //     private void Awake()
// //     {
// //         spriteRenderer = GetComponent<SpriteRenderer>();
// //     }

// //     private void Start()
// //     {
// //         InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
// //     }

// //     private void OnEnable()
// //     {
// //         Vector3 position = transform.position;
// //         position.y = 0f;
// //         transform.position = position;
// //         direction = Vector3.zero;
// //     }

// //     private void Update()
// //     {
// //         if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
// //         {
// //             direction = Vector3.up * strength;
// //             jumpSound.Play(); // Play jump sound
// //         }

// //         // Apply gravity and update the position
// //         direction.y += gravity * Time.deltaTime;
// //         transform.position += direction * Time.deltaTime;

// //         // Tilt the bird based on the direction
// //         Vector3 rotation = transform.eulerAngles;
// //         rotation.z = direction.y * tilt;
// //         transform.eulerAngles = rotation;
// //     }

// //     private void AnimateSprite()
// //     {
// //         spriteIndex++;

// //         if (spriteIndex >= sprites.Length)
// //         {
// //             spriteIndex = 0;
// //         }

// //         if (spriteIndex < sprites.Length && spriteIndex >= 0)
// //         {
// //             spriteRenderer.sprite = sprites[spriteIndex];
// //         }
// //     }

// //     private void OnTriggerEnter2D(Collider2D other)
// //     {
// //         if (other.gameObject.CompareTag("Obstacle"))
// //         {
// //             deathSound.Play(); // Play death sound
// //             GameManager.Instance.GameOver();
// //         }
// //         else if (other.gameObject.CompareTag("Scoring"))
// //         {
// //             GameManager.Instance.IncreaseScore();
// //         }
// //     }
// // }
// using UnityEngine;

// public class Player : MonoBehaviour
// {
//     public Sprite[] sprites;
//     public float strength = 5f;
//     public float gravity = -9.81f;
//     public float tilt = 5f;

//     private SpriteRenderer spriteRenderer;
//     private Vector3 direction;
//     private int spriteIndex;

//     // Add references to AudioSource components
//     public AudioSource jumpSound;
//     public AudioSource deathSound;

//     private void Awake()
//     {
//         spriteRenderer = GetComponent<SpriteRenderer>();
//     }

//     private void Start()
//     {
//         InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
//     }

//     private void OnEnable()
//     {
//         Vector3 position = transform.position;
//         position.y = 0f;
//         transform.position = position;
//         direction = Vector3.zero;
//     }

//     private void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
//         {
//             direction = Vector3.up * strength;
//             PlayJumpSound(); // Play jump sound effect
//         }

//         // Apply gravity and update the position
//         direction.y += gravity * Time.deltaTime;
//         transform.position += direction * Time.deltaTime;

//         // Tilt the bird based on the direction
//         Vector3 rotation = transform.eulerAngles;
//         rotation.z = direction.y * tilt;
//         transform.eulerAngles = rotation;
//     }

//     private void AnimateSprite()
//     {
//         spriteIndex++;

//         if (spriteIndex >= sprites.Length)
//         {
//             spriteIndex = 0;
//         }

//         if (spriteIndex < sprites.Length && spriteIndex >= 0)
//         {
//             spriteRenderer.sprite = sprites[spriteIndex];
//         }
//     }

//     private void OnTriggerEnter2D(Collider2D other)
//     {
//         if (other.gameObject.CompareTag("Obstacle"))
//         {
//             PlayDeathSound(); // Play death sound effect
//             GameManager.Instance.GameOver();
//         }
//         else if (other.gameObject.CompareTag("Scoring"))
//         {
//             GameManager.Instance.IncreaseScore();
//         }
//     }

//     // Method to play jump sound
//     private void PlayJumpSound()
//     {
//         if (jumpSound != null)
//         {
//             jumpSound.Play();
//         }
//     }

//     // Method to play death sound
//     private void PlayDeathSound()
//     {
//         if (deathSound != null)
//         {
//             deathSound.Play();
//         }
//     }
// }
using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite[] sprites;
    public float strength = 5f;
    public float gravity = -9.81f;
    public float tilt = 5f;

    private SpriteRenderer spriteRenderer;
    private Vector3 direction;
    private int spriteIndex;

   
    public AudioSource jumpSound;
    public AudioSource deathSound;
    public AudioSource pointSound;
    public AudioSource backgroundMusic;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

       
        if (backgroundMusic != null)
        {
            backgroundMusic.loop = true; 
            backgroundMusic.Play();      
        }
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
            PlayJumpSound(); 
        }

        
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

       
        Vector3 rotation = transform.eulerAngles;
        rotation.z = direction.y * tilt;
        transform.eulerAngles = rotation;
    }

    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        if (spriteIndex < sprites.Length && spriteIndex >= 0)
        {
            spriteRenderer.sprite = sprites[spriteIndex];
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            PlayDeathSound(); 
            GameManager.Instance.GameOver();
        }
        else if (other.gameObject.CompareTag("Scoring"))
        {
            PlayPointSound(); 
            GameManager.Instance.IncreaseScore();
        }
    }

    private void PlayJumpSound()
    {
        if (jumpSound != null)
        {
            jumpSound.Play();
        }
    }

    private void PlayDeathSound()
    {
        if (deathSound != null)
        {
            deathSound.Play();
        }
    }

    private void PlayPointSound()
    {
        if (pointSound != null)
        {
            pointSound.Play();
        }
    }
}
