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

using System.Collections.Generic;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class Paging<T>
    {
        private List<T> data;
        private int totalRecords;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Paging() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Paging(IEnumerable<T> data, int totalRecords)
        {
            this.data = new List<T>(data);
            this.totalRecords = totalRecords;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public List<T> Data
        {
            get { return data; }
            set { data = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public int TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
    }
}