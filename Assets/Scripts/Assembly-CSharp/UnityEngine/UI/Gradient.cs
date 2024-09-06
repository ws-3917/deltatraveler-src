using System.Collections.Generic;

namespace UnityEngine.UI
{
	[AddComponentMenu("UI/Effects/Gradient")]
	public class Gradient : BaseMeshEffect
	{
		public enum Type
		{
			Horizontal = 0,
			Vertical = 1
		}

		public enum Blend
		{
			Override = 0,
			Add = 1,
			Multiply = 2
		}

		[SerializeField]
		private Type _gradientType;

		[SerializeField]
		private Blend _blendMode = Blend.Multiply;

		[SerializeField]
		[Range(-1f, 1f)]
		private float _offset;

		[SerializeField]
		private UnityEngine.Gradient _effectGradient = new UnityEngine.Gradient
		{
			colorKeys = new GradientColorKey[2]
			{
				new GradientColorKey(Color.black, 0f),
				new GradientColorKey(Color.white, 1f)
			}
		};

		public Blend BlendMode
		{
			get
			{
				return _blendMode;
			}
			set
			{
				_blendMode = value;
			}
		}

		public UnityEngine.Gradient EffectGradient
		{
			get
			{
				return _effectGradient;
			}
			set
			{
				_effectGradient = value;
			}
		}

		public Type GradientType
		{
			get
			{
				return _gradientType;
			}
			set
			{
				_gradientType = value;
			}
		}

		public float Offset
		{
			get
			{
				return _offset;
			}
			set
			{
				_offset = value;
			}
		}

		public override void ModifyMesh(VertexHelper helper)
		{
			if (!IsActive() || helper.currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			helper.GetUIVertexStream(list);
			int count = list.Count;
			switch (GradientType)
			{
			case Type.Horizontal:
			{
				float num6 = list[0].position.x;
				float num7 = list[0].position.x;
				float num8 = 0f;
				for (int num9 = count - 1; num9 >= 1; num9--)
				{
					num8 = list[num9].position.x;
					if (num8 > num7)
					{
						num7 = num8;
					}
					else if (num8 < num6)
					{
						num6 = num8;
					}
				}
				float num10 = 1f / (num7 - num6);
				UIVertex vertex2 = default(UIVertex);
				for (int j = 0; j < helper.currentVertCount; j++)
				{
					helper.PopulateUIVertex(ref vertex2, j);
					vertex2.color = BlendColor(vertex2.color, EffectGradient.Evaluate((vertex2.position.x - num6) * num10 - Offset));
					helper.SetUIVertex(vertex2, j);
				}
				break;
			}
			case Type.Vertical:
			{
				float num = list[0].position.y;
				float num2 = list[0].position.y;
				float num3 = 0f;
				for (int num4 = count - 1; num4 >= 1; num4--)
				{
					num3 = list[num4].position.y;
					if (num3 > num2)
					{
						num2 = num3;
					}
					else if (num3 < num)
					{
						num = num3;
					}
				}
				float num5 = 1f / (num2 - num);
				UIVertex vertex = default(UIVertex);
				for (int i = 0; i < helper.currentVertCount; i++)
				{
					helper.PopulateUIVertex(ref vertex, i);
					vertex.color = BlendColor(vertex.color, EffectGradient.Evaluate((vertex.position.y - num) * num5 - Offset));
					helper.SetUIVertex(vertex, i);
				}
				break;
			}
			}
		}

		private Color BlendColor(Color colorA, Color colorB)
		{
			switch (BlendMode)
			{
			default:
				return colorB;
			case Blend.Add:
				return colorA + colorB;
			case Blend.Multiply:
				return colorA * colorB;
			}
		}
	}
}
