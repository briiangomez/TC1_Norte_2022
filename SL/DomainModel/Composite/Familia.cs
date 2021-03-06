///////////////////////////////////////////////////////////
//  Familia.cs
//  Implementation of the Class Familia
//  Generated by Enterprise Architect
//  Created on:      20-may.-2022 21:18:05
//  Original author: gasto
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Patrones;
namespace Patrones {
	/// <summary>
	/// This class (a) defines behaviour for components having children, (b) stores
	/// child components, and (c) implements child-related operations in the Component
	/// interface.
	/// </summary>
	public class Familia : Component {

        public string Name { get; set; }

        private List<Patrones.Component> childrens = new List<Component>();

		public Familia(string name, Component firstComponent){
			this.Name = name;
			childrens.Add(firstComponent);
		}

		/// 
		/// <param name="component"></param>
		public override void Add(Component component){
			childrens.Add(component);
		}

        public override int CountChild()
        {
			return childrens.Count;
        }

        /// 
        /// <param name="component"></param>
        public override void Remove(Component component){
			//Verificar que para eliminar tengo al menos 2 elementos...

			if(childrens.Count>1)
            {
				//Component component1 = childrens.Find(o => o.IdComponent == component.IdComponent);

				//if (component1 != null)
				//	childrens.Remove(component1);

				childrens.RemoveAll(o => o.IdComponent == component.IdComponent);				
            }
		}
	}//end Familia

}//end namespace Patrones