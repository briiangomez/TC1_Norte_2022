///////////////////////////////////////////////////////////
//  Patente.cs
//  Implementation of the Class Patente
//  Generated by Enterprise Architect
//  Created on:      20-may.-2022 21:18:04
//  Original author: gasto
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Patrones;
namespace Patrones {
	/// <summary>
	/// This class (a) represents leaf objects in the composition, and (b) defines
	/// behaviour for primitive objects in the composition.
	/// </summary>
	public class Patente : Component {

        public string Name { get; set; }

        public string FormName { get; set; }

		//Si patentePadre es null es un item principal
		//Si es distinto tengo que asignarlo debajo de mi padre
        public Patente PatentePadre { get; set; }

        public Patente(){

		}

		/// 
		/// <param name="component"></param>
		public override void Add(Component component){
			throw new Exception("No se pueden agregar elementos sobre primitivos...");			
		}

        public override int CountChild()
        {
			//Es un primitivo, no tiene hijos...
			return 0;
        }
        /// 
        /// <param name="component"></param>
        public override void Remove(Component component){
			throw new Exception("No se pueden quitar elementos sobre primitivos...");
		}

	}//end Patente

}//end namespace Patrones