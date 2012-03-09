/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 2.0.0.beta - Community Edition (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-03-07
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TreeStore
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : TreeStoreBase.Builder<TreeStore, TreeStore.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TreeStore()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeStore component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeStore.Config config) : base(new TreeStore(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TreeStore component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TreeStore.Builder</returns>
            public virtual TreeStore.Builder Listeners(Action<TreeStoreListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TreeStore.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TreeStore.Builder</returns>
            public virtual TreeStore.Builder DirectEvents(Action<TreeStoreDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TreeStore.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeStore.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TreeStore(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TreeStore.Builder TreeStore()
        {
            return this.TreeStore(new TreeStore());
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeStore.Builder TreeStore(TreeStore component)
        {
            return new TreeStore.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeStore.Builder TreeStore(TreeStore.Config config)
        {
            return new TreeStore.Builder(new TreeStore(config));
        }
    }
}