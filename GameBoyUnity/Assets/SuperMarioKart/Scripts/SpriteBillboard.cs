using UnityEngine;
using System.Collections;
using System.Collections.Generic;

	public class SpriteBillboard : MonoBehaviour
	{
		public CameraDirection cameraDirection;
		
		public List<RotationSprite> sprites = new List<RotationSprite>();
		public RotationSprite rotationSprite;

		private SpriteRenderer _sprite;
		private Transform _billboard;

		private Transform _t;
		

		void Start()
		{
			_t = transform;
			_sprite = GetComponentInChildren<SpriteRenderer>();
			_billboard = _sprite.transform;
		}

		void Update()
		{

			Vector3 targetPoint = new Vector3(cameraDirection.transform.position.x, _t.position.y, cameraDirection.transform.position.z) - transform.position;
			_billboard.rotation = Quaternion.LookRotation(-targetPoint, Vector3.up);

			// Change this with your own sprite animation stuff
			Vector3 Angle = cameraDirection.Angle;
			_sprite.sprite = rotationSprite.GetSpriteFromRotation(Angle.x);
		}
	}
