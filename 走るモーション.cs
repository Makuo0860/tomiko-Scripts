using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class 走るモーション : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform cameraTransform;

    [Header("Speed")]
    [SerializeField] private float walkSpeed = 2f;
    [SerializeField] private float runSpeed = 5f;
    [SerializeField] private float crouchSpeed = 1f;
    [SerializeField] private float rotateSpeed = 720f;

    [Header("Gravity")]
    [SerializeField] private float gravity = -9.81f;

    private CharacterController controller;
    private Animator anim;

    private float velocityY;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

        if (cameraTransform == null)
        {
            cameraTransform = Camera.main.transform;
        }
    }

    void Update()
    {
        // カメラの前
        Vector3 forward = cameraTransform.forward;
        forward.y = 0;
        forward.Normalize();

        // カメラの右
        Vector3 right = cameraTransform.right;
        right.y = 0;
        right.Normalize();


        // =========================
        // しゃがみ・走り判定
        // =========================

        bool isCrouch = Input.GetKey(KeyCode.LeftShift);
        bool isRun = Input.GetKey(KeyCode.LeftControl) && !isCrouch;


        // =========================
        // W
        // =========================

        if (Input.GetKey(KeyCode.W))
        {
            float speed = walkSpeed;

            if (isCrouch)
            {
                speed = crouchSpeed;

                anim.SetBool("walk", false);
                anim.SetBool("run", false);
                anim.SetBool("squat", true);
                anim.SetBool("しゃがみ歩き", true);
            }
            else if (isRun)
            {
                speed = runSpeed;

                anim.SetBool("walk", false);
                anim.SetBool("run", true);
                anim.SetBool("squat", false);
                anim.SetBool("しゃがみ歩き", false);
            }
            else
            {
                anim.SetBool("walk", true);
                anim.SetBool("run", false);
                anim.SetBool("squat", false);
                anim.SetBool("しゃがみ歩き", false);
            }

            controller.Move(forward * speed * Time.deltaTime);
        }


        // =========================
        // S
        // =========================

        if (Input.GetKey(KeyCode.S))
        {
            float speed = walkSpeed;

            if (isCrouch)
            {
                speed = crouchSpeed;

                anim.SetBool("walk", false);
                anim.SetBool("run", false);
                anim.SetBool("squat", true);
                anim.SetBool("しゃがみ歩き", true);
            }
            else if (isRun)
            {
                speed = runSpeed;

                anim.SetBool("walk", false);
                anim.SetBool("run", true);
                anim.SetBool("squat", false);
                anim.SetBool("しゃがみ歩き", false);
            }
            else
            {
                anim.SetBool("walk", true);
                anim.SetBool("run", false);
                anim.SetBool("squat", false);
                anim.SetBool("しゃがみ歩き", false);
            }

            controller.Move(-forward * speed * Time.deltaTime);
        }


        // =========================
        // A
        // =========================

        if (Input.GetKey(KeyCode.A))
        {
            float speed = walkSpeed;

            if (isCrouch)
            {
                speed = crouchSpeed;

                anim.SetBool("walk", false);
                anim.SetBool("run", false);
                anim.SetBool("squat", true);
                anim.SetBool("しゃがみ歩き", true);
            }
            else if (isRun)
            {
                speed = runSpeed;

                anim.SetBool("walk", false);
                anim.SetBool("run", true);
                anim.SetBool("squat", false);
                anim.SetBool("しゃがみ歩き", false);
            }
            else
            {
                anim.SetBool("walk", true);
                anim.SetBool("run", false);
                anim.SetBool("squat", false);
                anim.SetBool("しゃがみ歩き", false);
            }

            controller.Move(-right * speed * Time.deltaTime);
        }


        // =========================
        // D
        // =========================

        if (Input.GetKey(KeyCode.D))
        {
            float speed = walkSpeed;

            if (isCrouch)
            {
                speed = crouchSpeed;

                anim.SetBool("walk", false);
                anim.SetBool("run", false);
                anim.SetBool("squat", true);
                anim.SetBool("しゃがみ歩き", true);
            }
            else if (isRun)
            {
                speed = runSpeed;

                anim.SetBool("walk", false);
                anim.SetBool("run", true);
                anim.SetBool("squat", false);
                anim.SetBool("しゃがみ歩き", false);
            }
            else
            {
                anim.SetBool("walk", true);
                anim.SetBool("run", false);
                anim.SetBool("squat", false);
                anim.SetBool("しゃがみ歩き", false);
            }

            controller.Move(right * speed * Time.deltaTime);
        }


        // =========================
        // 移動していないとき
        // =========================

        if (!Input.GetKey(KeyCode.W) &&
            !Input.GetKey(KeyCode.S) &&
            !Input.GetKey(KeyCode.A) &&
            !Input.GetKey(KeyCode.D))
        {
            anim.SetBool("walk", false);
            anim.SetBool("run", false);
            anim.SetBool("しゃがみ歩き", false);

            // Shiftを押していればしゃがみ状態
            anim.SetBool("squat", isCrouch);
        }


        // =========================
        // プレイヤーの向き
        // =========================

        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction -= forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction -= right;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += right;
        }

        if (direction != Vector3.zero)
        {
            direction.Normalize();

            Quaternion targetRotation =
                Quaternion.LookRotation(direction);

            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                rotateSpeed * Time.deltaTime
            );
        }


        // =========================
        // 重力
        // =========================

        if (controller.isGrounded)
        {
            velocityY = -2f;
        }
        else
        {
            velocityY += gravity * Time.deltaTime;
        }

        controller.Move(
            Vector3.up * velocityY * Time.deltaTime
        );
    }

    public bool IsRunning()
    {
        return Input.GetKey(KeyCode.LeftControl)
            && !Input.GetKey(KeyCode.LeftShift)
            && (
                Input.GetKey(KeyCode.W) ||
                Input.GetKey(KeyCode.S) ||
                Input.GetKey(KeyCode.A) ||
                Input.GetKey(KeyCode.D)
            );
    }

    public bool IsWalking()
    {
        return !Input.GetKey(KeyCode.LeftControl)
            && !Input.GetKey(KeyCode.LeftShift)
            && (
                Input.GetKey(KeyCode.W) ||
                Input.GetKey(KeyCode.S) ||
                Input.GetKey(KeyCode.A) ||
                Input.GetKey(KeyCode.D)
            );
    }

    public bool IsSquating()
    {
        return Input.GetKey(KeyCode.LeftShift)
            && (
                Input.GetKey(KeyCode.W) ||
                Input.GetKey(KeyCode.S) ||
                Input.GetKey(KeyCode.A) ||
                Input.GetKey(KeyCode.D)
            );
    }
}