using UnityEngine;

public class MoveInput : IMoveInput

{
    public Vector3 GetDirection()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction.z = 1f;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction.z = -1f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction.x = -1f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction.x = 1f;
        }

        return direction;
    }
}
