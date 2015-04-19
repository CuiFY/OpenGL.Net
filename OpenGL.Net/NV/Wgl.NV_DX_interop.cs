
// Copyright (C) 2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Wgl
	{
		/// <summary>
		/// Value of WGL_ACCESS_READ_ONLY_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public const uint ACCESS_READ_ONLY_NV = 0x00000000;

		/// <summary>
		/// Value of WGL_ACCESS_READ_WRITE_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public const uint ACCESS_READ_WRITE_NV = 0x00000001;

		/// <summary>
		/// Value of WGL_ACCESS_WRITE_DISCARD_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public const uint ACCESS_WRITE_DISCARD_NV = 0x00000002;

		/// <summary>
		/// Binding for wglDXSetResourceShareHandleNV.
		/// </summary>
		/// <param name="dxObject">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="shareHandle">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXSetResourceShareHandleNV(IntPtr dxObject, IntPtr shareHandle)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDXSetResourceShareHandleNV != null, "pwglDXSetResourceShareHandleNV not implemented");
			retValue = Delegates.pwglDXSetResourceShareHandleNV(dxObject, shareHandle);
			CallLog("wglDXSetResourceShareHandleNV({0}, {1}) = {2}", dxObject, shareHandle, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDXOpenDeviceNV.
		/// </summary>
		/// <param name="dxDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static IntPtr DXOpenDeviceNV(IntPtr dxDevice)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglDXOpenDeviceNV != null, "pwglDXOpenDeviceNV not implemented");
			retValue = Delegates.pwglDXOpenDeviceNV(dxDevice);
			CallLog("wglDXOpenDeviceNV({0}) = {1}", dxDevice, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDXCloseDeviceNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXCloseDeviceNV(IntPtr hDevice)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDXCloseDeviceNV != null, "pwglDXCloseDeviceNV not implemented");
			retValue = Delegates.pwglDXCloseDeviceNV(hDevice);
			CallLog("wglDXCloseDeviceNV({0}) = {1}", hDevice, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDXRegisterObjectNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="dxObject">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static IntPtr DXRegisterObjectNV(IntPtr hDevice, IntPtr dxObject, UInt32 name, Int32 type, Int32 access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglDXRegisterObjectNV != null, "pwglDXRegisterObjectNV not implemented");
			retValue = Delegates.pwglDXRegisterObjectNV(hDevice, dxObject, name, type, access);
			CallLog("wglDXRegisterObjectNV({0}, {1}, {2}, {3}, {4}) = {5}", hDevice, dxObject, name, type, access, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDXUnregisterObjectNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hObject">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXUnregisterObjectNV(IntPtr hDevice, IntPtr hObject)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDXUnregisterObjectNV != null, "pwglDXUnregisterObjectNV not implemented");
			retValue = Delegates.pwglDXUnregisterObjectNV(hDevice, hObject);
			CallLog("wglDXUnregisterObjectNV({0}, {1}) = {2}", hDevice, hObject, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDXObjectAccessNV.
		/// </summary>
		/// <param name="hObject">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXObjectNV(IntPtr hObject, Int32 access)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDXObjectAccessNV != null, "pwglDXObjectAccessNV not implemented");
			retValue = Delegates.pwglDXObjectAccessNV(hObject, access);
			CallLog("wglDXObjectAccessNV({0}, {1}) = {2}", hObject, access, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDXLockObjectsNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="hObjects">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXLockObjectNV(IntPtr hDevice, Int32 count, IntPtr[] hObjects)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_hObjects = hObjects)
				{
					Debug.Assert(Delegates.pwglDXLockObjectsNV != null, "pwglDXLockObjectsNV not implemented");
					retValue = Delegates.pwglDXLockObjectsNV(hDevice, count, p_hObjects);
					CallLog("wglDXLockObjectsNV({0}, {1}, {2}) = {3}", hDevice, count, hObjects, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDXUnlockObjectsNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="hObjects">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXUnlockObjectsNV(IntPtr hDevice, Int32 count, IntPtr[] hObjects)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_hObjects = hObjects)
				{
					Debug.Assert(Delegates.pwglDXUnlockObjectsNV != null, "pwglDXUnlockObjectsNV not implemented");
					retValue = Delegates.pwglDXUnlockObjectsNV(hDevice, count, p_hObjects);
					CallLog("wglDXUnlockObjectsNV({0}, {1}, {2}) = {3}", hDevice, count, hObjects, retValue);
				}
			}

			return (retValue);
		}

	}

}
