using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	private float speed = 1500f;
	public float rotationSpeed = 15f;
    private bool isWaitAudio;

    public float stepTime = 0.2f;

	public WheelJoint2D backWheel;
	public WheelJoint2D frontWheel;

	public Rigidbody2D rb;

    //ini buat backsound
    public AudioSource backSound;
    public AudioClip clip;
    public bool isInputActive = true;


	private float movement = 0f;
	private float rotation = 0f;

	public Quaternion originalRotationValue;


    void Start()
    {
		originalRotationValue = transform.rotation;
        isWaitAudio = false;
		backSound.Play ();
    }
	void Update ()
	{
        
		movement = -Input.GetAxisRaw("Vertical") * speed;
		rotation = Input.GetAxisRaw("Horizontal");



        if (!isWaitAudio)
        {
            isWaitAudio = true;
            //backSound.PlayOneShot(clip);
            StartCoroutine(resetWaitAudio());
        }
	}
    
	void FixedUpdate ()
	{
		if (movement == 0f)
		{
			backWheel.useMotor = false;
			frontWheel.useMotor = false;
		} else
		{
			backWheel.useMotor = true;
			frontWheel.useMotor = true;

			JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
			backWheel.motor = motor;
			frontWheel.motor = motor;
		}

		rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
    }
    

    IEnumerator resetWaitAudio()
    {
        yield return new WaitForSeconds(stepTime);
        isWaitAudio = false;
    }

}
