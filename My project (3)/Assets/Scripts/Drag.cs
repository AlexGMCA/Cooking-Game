using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
  //Creating a Vector3.
    Vector3 mousePositionOffset;

    void Update()
    {
      Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }

    //Finds the cords of the cursor so that it knows where to put the object being dragged.
    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

  //pick up function and setting gravity to 0 of picked up objects.
  private void OnMouseDown()
  {
    mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    GetComponent<Rigidbody2D>().gravityScale = 0;
    GetComponent<Rigidbody2D>().velocity = Vector3.zero;

  }

  //Setting gravity of objects dropped to 1.
  private void OnMouseUp()
  {
    GetComponent<Rigidbody2D>().gravityScale = 1;

  }

  //When the mouse drags calculate the change.
  private void OnMouseDrag()
  {
    transform.position = GetMouseWorldPosition() + mousePositionOffset;
  }
}
