// XmlNodeType.cs
// Script#/Libraries/Web
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System.Runtime.CompilerServices;

namespace System.Xml {

    [IgnoreNamespace]
    [Imported]
    [NumericValues]
    public enum XmlNodeType {

        Element = 1,

        Attribute = 2,

        Text = 3,

        CDATA = 4,

        EntityReference = 5,

        Entity = 6,

        ProcessingInstruction = 7,

        Comment = 8,

        Document = 9,

        DocumentType = 10,

        DocumentFragment = 11,

        Notation = 12
    }
}
