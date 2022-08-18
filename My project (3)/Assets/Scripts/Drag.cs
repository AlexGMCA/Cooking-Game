using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    Vector3 mousePositionOffset;

    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

  private void OnMouseDown()
  {
    mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    GetComponent<Rigidbody2D>().gravityScale = 0;
    GetComponent<Rigidbody2D>().velocity = Vector3.zero;

  }

  private void OnMouseUp()
  {
    GetComponent<Rigidbody2D>().gravityScale = 1;

  }

  private void OnMouseDrag()
  {
    transform.position = GetMouseWorldPosition() + mousePositionOffset;
  }
}
