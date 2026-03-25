using FSM.Scripts;
using UnityEngine;

public class FsmStateMovement : FsmState
{
    protected  Transform Transform;
    protected float Speed;

    public FsmStateMovement(Fsm fsm, Transform transform, float speed) : base(fsm)
    {
        Transform = transform;
        Speed = speed;
    }

    public override void Enter()
    {
        Debug.Log($"Movement ({this.GetType().Name}) [ENTER]");
    }

    public override void Exit()
    {
        Debug.Log($"Movement ({this.GetType().Name}): [EXIT]");
    }

    public override void Update()
    {
        Debug.Log($"Movement ({this.GetType().Name}): [UPDATE]");

        var inputDirection = ReadInput();

        if(inputDirection.sqrMagnitude == 0f)
        {
            Fsm.SetState<FsmStateIdle>();
        }

        Move(inputDirection);
    }

    protected Vector2 ReadInput()
    {
        var inputHorizontal = Input.GetAxis("Horizontal");
        var inputVertical = Input.GetAxis("Vertical");
        var inputDirection = new Vector2(inputHorizontal, inputVertical);

        return inputDirection;
    }

    protected virtual void Move(Vector2 inputDirection)
    {
        Transform.position += new Vector3(inputDirection.x, 0f, inputDirection.y) * (Speed * Time.deltaTime);
    }
}
