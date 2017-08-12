
// Copyright (C) 2011-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

#ifndef GLO_TRANSFORM_STATE
#define GLO_TRANSFORM_STATE

// Projection matrix
uniform mat4 glo_Projection;

// The model matrix
uniform mat4 glo_Model;

// The model-view matrix
uniform mat4 glo_ModelView;

// The model-view-projection matrix
uniform mat4 glo_ModelViewProjection;

// Normal transformation matrix
uniform mat3 glo_NormalMatrix;

// Inverse projection matrix
uniform mat4 glo_InverseProjection;

// Inverse of the model-view matrix
uniform mat4 glo_InverseModelView;

// Inverse of glo_ModelViewProjection
uniform mat4 glo_InverseModelViewProjection;

// Projection near/far planes distances
// - x: near plane distance
// - y: far plane distance.
uniform vec2 glo_DepthDistances;

#endif