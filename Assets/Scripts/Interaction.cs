using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private Resources_ _resources;
    [SerializeField] private Camera _camera;

    void Update()
    {

        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit)) {
            if (hit.collider.TryGetComponent(out Clickable clickable)) {
                if (Input.GetMouseButtonDown(0)) {
                    clickable.Hit();
                }
            }
            else if (hit.collider.TryGetComponent(out Takeble takeble))
            {
                _resources.CollectCoins(1, takeble.transform.position);
                takeble.Take();
            }
        }

    }
}
