using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

namespace Xanatos
{
	enum Collision
	{
		None = -1,
		Inside = 0,
		Top = 1,
		Bottom = 2,
		Left = 3,
		Right = 4,
		Back = 5,
		Front = 6
	}
	class AABBCollision
	{
		/// <summary>
		/// returns true if line (L1, L2) intersects with the box (B1, B2) 
		/// returns intersection point in Hit
		/// </summary>
		/// <param name="B1"></param>
		/// <param name="B2"></param>
		/// <param name="L1"></param>
		/// <param name="L2"></param>
		/// <returns></returns>
		public static Collision CheckLineBox(Vector3d B1, Vector3d B2, Vector3d L1, Vector3d L2, out Vector3d Hit)
		{
			Hit = new Vector3d();
			if (L2.X < B1.X && L1.X < B1.X) return Collision.None;
			if (L2.X > B2.X && L1.X > B2.X) return Collision.None;
			if (L2.Y < B1.Y && L1.Y < B1.Y) return Collision.None;
			if (L2.Y > B2.Y && L1.Y > B2.Y) return Collision.None;
			if (L2.Z < B1.Z && L1.Z < B1.Z) return Collision.None;
			if (L2.Z > B2.Z && L1.Z > B2.Z) return Collision.None;
			if (L1.X > B1.X && L1.X < B2.X &&
				L1.Y > B1.Y && L1.Y < B2.Y &&
				L1.Z > B1.Z && L1.Z < B2.Z) {
				Hit = L1;
				return Collision.Inside;
			}

			float bestDist = 100;
			Collision bestSide = Collision.None;
			float d = 0;

			bool Valid;

			Hit = GetIntersection(L1.X - B1.X, L2.X - B1.X, L1, L2, out Valid);
			if (Valid && InBox(Hit, B1, B2, 1)) {
				d = distance(L1, Hit);
				if (d < bestDist) {
					bestSide = Collision.Left;
					bestDist = d;
				}
			}

			Hit = GetIntersection(L1.X - B2.X, L2.X - B2.X, L1, L2, out Valid);
			if (Valid && InBox(Hit, B1, B2, 1)) {
				d = distance(L1, Hit);
				if (d < bestDist) {
					bestSide = Collision.Right;
					bestDist = d;
				}
			}

			Hit = GetIntersection(L1.Y - B1.Y, L2.Y - B1.Y, L1, L2, out Valid);
			if (Valid && InBox(Hit, B1, B2, 2)) {
				d = distance(L1, Hit);
				if (d < bestDist) {
					bestSide = Collision.Bottom;
					bestDist = d;
				}
			}

			Hit = GetIntersection(L1.Y - B2.Y, L2.Y - B2.Y, L1, L2, out Valid);
			if (Valid && InBox(Hit, B1, B2, 2)) {
				d = distance(L1, Hit);
				if (d < bestDist) {
					bestSide = Collision.Top;
					bestDist = d;
				}
			}

			Hit = GetIntersection(L1.Z - B1.Z, L2.Z - B1.Z, L1, L2, out Valid);
			if (Valid && InBox(Hit, B1, B2, 3)) {
				d = distance(L1, Hit);
				if (d < bestDist) {
					bestSide = Collision.Back;
					bestDist = d;
				}
			}

			Hit = GetIntersection(L1.Z - B2.Z, L2.Z - B2.Z, L1, L2, out Valid);
			if (Valid && InBox(Hit, B1, B2, 3)) {
				d = distance(L1, Hit);
				if (d < bestDist) {
					bestSide = Collision.Front;
					bestDist = d;
				}
			}

			return bestSide;
		}

		private static Vector3d GetIntersection(double fDst1, double fDst2, Vector3d P1, Vector3d P2, out bool Valid)
		{
			Vector3d Hit = new Vector3d();
			if ((fDst1 * fDst2) >= 0.0f) {
				Valid = false;
				return new Vector3d();
			}
			if (fDst1 == fDst2) {
				Valid = false;
				return new Vector3d();
			}
			Hit += (P2);
			Hit -= (P1);
			Hit *= (-fDst1 / (fDst2 - fDst1));
			Hit += (P1);
			Valid = true;
			return Hit;
		}

		private static bool InBox(Vector3d Hit, Vector3d B1, Vector3d B2, int Axis)
		{
			if (Axis == 1 && Hit.Z > B1.Z && Hit.Z < B2.Z && Hit.Y > B1.Y && Hit.Y < B2.Y) return true;
			if (Axis == 2 && Hit.Z > B1.Z && Hit.Z < B2.Z && Hit.X > B1.X && Hit.X < B2.X) return true;
			if (Axis == 3 && Hit.X > B1.X && Hit.X < B2.X && Hit.Y > B1.Y && Hit.Y < B2.Y) return true;
			return false;
		}

		private static float distance(Vector3d a, Vector3d b)
		{
			return (float)Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.Z - b.Z, 2));
		}
	}
}
