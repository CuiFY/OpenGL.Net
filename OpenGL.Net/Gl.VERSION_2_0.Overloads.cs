﻿
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

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Replaces the source code in a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the handle of the shader object whose source code is to be replaced.
		/// </param>
		/// <param name="string">
		/// Specifies an array of pointers to strings containing the source code to be loaded into the shader.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void ShaderSource(UInt32 shader, String[] @string)
		{
			Int32[] length = new Int32[@string.Length];

			for (int i = 0; i < @string.Length; i++)
				length[i] = @string[i].Length;

			ShaderSource(shader, @string, length);
		}
	}
}