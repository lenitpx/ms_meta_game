﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// [CustomPropertyDrawer( typeof( StringStringDictionary ) )]
// [CustomPropertyDrawer( typeof( ObjectColorDictionary ) )]
// [CustomPropertyDrawer( typeof( StringColorArrayDictionary ) )]
[CustomPropertyDrawer( typeof( ExpressionDictionary ) )]
[CustomPropertyDrawer( typeof( ActorDictionary ) )]
public class AnySerializableDictionaryPropertyDrawer : SerializableDictionaryPropertyDrawer { }

// [CustomPropertyDrawer( typeof( ColorArrayStorage ) )]
public class AnySerializableDictionaryStoragePropertyDrawer : SerializableDictionaryStoragePropertyDrawer { }
