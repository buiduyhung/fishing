using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MoveScript
{
    public override void move()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
