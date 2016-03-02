using Fungus;
using UnityEngine;

public class ClickablePrecise : Clickable2D
{
	private Vector3 lastClickPoint = Vector3.zero;

	protected override void OnMouseDown()
	{
		SetLastlickPoint();
		base.OnMouseDown();
	}

	private void SetLastlickPoint()
	{
		if (!clickEnabled)
		{
			return;
		}

		var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		Physics.Raycast(ray, out hit);
		lastClickPoint = hit.point;
	}

	public Vector3 GetLastClickPoint()
	{
		return lastClickPoint;
	}
}
