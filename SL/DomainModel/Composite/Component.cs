///////////////////////////////////////////////////////////
//  Component.cs
//  Implementation of the Class Component
//  Generated by Enterprise Architect
//  Created on:      20-may.-2022 21:18:02
//  Original author: gasto
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Patrones {
	/// <summary>
	/// This class (a) declares the interface for objects in the composition, (b)
	/// implements default behaviour for the interface common to all classes, as
	/// appropriate, (c) declares an interface for accessing and managing its child
	/// components, and (d) optionally defines an interface for accessing a component's
	/// parent in the recursive structure and implements it if that's appropriate.
	/// </summary>
	public abstract class Component {

        public Guid IdComponent { get; set; }

        public Component(){

		}

		/// 
		/// <param name="component"></param>
		public abstract void Add(Component component);

		/// 
		/// <param name="component"></param>
		public abstract void Remove(Component component);

		public abstract int CountChild();

	}//end Component

}//end namespace Patrones