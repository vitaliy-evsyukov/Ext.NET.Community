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
    public partial class GridPagingScroller
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridScroller.Builder<GridPagingScroller, GridPagingScroller.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GridPagingScroller()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GridPagingScroller component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GridPagingScroller.Config config) : base(new GridPagingScroller(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GridPagingScroller component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// This is a number above 0 and less than 1 which specifies at what percentage to begin fetching the next page. For example if the pageSize is 100 and the percentageFromEdge is the default of 0.35, the paging scroller will prefetch pages when scrolling up between records 0 and 34 and when scrolling down between records 65 and 99. Defaults to: 0.35
			/// </summary>
            public virtual GridPagingScroller.Builder PercentageFromEdge(double percentageFromEdge)
            {
                this.ToComponent().PercentageFromEdge = percentageFromEdge;
                return this as GridPagingScroller.Builder;
            }
             
 			/// <summary>
			/// This is the time in milliseconds to buffer load requests when scrolling the PagingScrollbar. Defaults to: 200
			/// </summary>
            public virtual GridPagingScroller.Builder ScrollToLoadBuffer(int scrollToLoadBuffer)
            {
                this.ToComponent().ScrollToLoadBuffer = scrollToLoadBuffer;
                return this as GridPagingScroller.Builder;
            }
             
 			/// <summary>
			/// The zone which causes a refresh of the rendered viewport. As soon as the edge of the rendered grid is this number of rows from the edge of the viewport, the view is moved.
			/// </summary>
            public virtual GridPagingScroller.Builder NumberFromEdge(int numberFromEdge)
            {
                this.ToComponent().NumberFromEdge = numberFromEdge;
                return this as GridPagingScroller.Builder;
            }
             
 			/// <summary>
			/// The number of extra rows to render on the trailing side of scrolling outside the NumberFromEdge buffer as scrolling proceeds.
			/// </summary>
            public virtual GridPagingScroller.Builder TrailingBufferZone(int trailingBufferZone)
            {
                this.ToComponent().TrailingBufferZone = trailingBufferZone;
                return this as GridPagingScroller.Builder;
            }
             
 			/// <summary>
			/// The number of extra rows to render on the leading side of scrolling outside the NumberFromEdge buffer as scrolling proceeds.
			/// </summary>
            public virtual GridPagingScroller.Builder LeadingBufferZone(int leadingBufferZone)
            {
                this.ToComponent().LeadingBufferZone = leadingBufferZone;
                return this as GridPagingScroller.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual GridPagingScroller.Builder VariableRowHeight(bool variableRowHeight)
            {
                this.ToComponent().VariableRowHeight = variableRowHeight;
                return this as GridPagingScroller.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public GridPagingScroller.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GridPagingScroller(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public GridPagingScroller.Builder GridPagingScroller()
        {
            return this.GridPagingScroller(new GridPagingScroller());
        }

        /// <summary>
        /// 
        /// </summary>
        public GridPagingScroller.Builder GridPagingScroller(GridPagingScroller component)
        {
            return new GridPagingScroller.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GridPagingScroller.Builder GridPagingScroller(GridPagingScroller.Config config)
        {
            return new GridPagingScroller.Builder(new GridPagingScroller(config));
        }
    }
}