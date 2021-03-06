﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Network;

namespace Xanatos {
	public class Vector3i {
		public int X, Y, Z;


		public float Length {
			get {
				return (float)Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
			}
		}

		public Vector3i() {
			X = 0;
			Y = 0;
			Z = 0;
		}

		public Vector3i(int X, int Y, int Z) {
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}

		public override bool Equals(object obj) {
			Vector3i other = obj as Vector3i;
			return (other != null) && (this.X == other.X) && (this.Y == other.Y) && (this.Z == other.Z);
		}

		public override int GetHashCode() {
			return (X << 22) & (Y << 11) & (Z);
		}

		internal void Write(NetOutgoingMessage Message) {
			Message.Write((Int32)X);
			Message.Write((Int32)Y);
			Message.Write((Int32)Z);
		}

		internal void Read(NetIncomingMessage Message) {
			X = Message.ReadInt32();
			Y = Message.ReadInt32();
			Z = Message.ReadInt32();
		}

		public static Vector3i operator +(Vector3i lhs, Vector3i rhs) {
			return new Vector3i(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
		}

		public static Vector3i operator -(Vector3i lhs, Vector3i rhs) {
			return new Vector3i(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
		}

		public static Vector3i operator *(Vector3i lhs, int rhs) {
			return new Vector3i(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs);
		}

		public static Vector3i operator *(Vector3i lhs, Vector3i rhs) {
			return new Vector3i(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z);
		}

		public static Vector3i operator /(Vector3i lhs, Vector3i rhs) {
			return new Vector3i(
				(int)Math.Floor(lhs.X * 1.0 / rhs.X),
				(int)Math.Floor(lhs.Y * 1.0 / rhs.Y),
				(int)Math.Floor(lhs.Z * 1.0 / rhs.Z)
			);
		}

	}
}
