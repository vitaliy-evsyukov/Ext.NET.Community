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
using System.Web.UI;
using System.Drawing;

namespace Ext.Net
{
    [Meta]
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(ProgressBarPager), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:ProgressBarPager runat=\"server\" />")]
    public partial class ProgressBarPager : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        public ProgressBarPager()
        {
        }
        
        /// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                baseList.Add(new ClientScriptItem(typeof(ProgressBarPager), "Ext.Net.Build.Ext.Net.ux.progressbarpager.progressbarpager.js", "/ux/progressbarpager/progressbarpager.js"));

                return baseList;
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.ux.ProgressBarPager";
            }
        }

        /// <summary>
        /// The default progress bar width.  Default is 225.
        /// </summary>
        [ConfigOption("width")]
        [Category("3. ProgressBarPager")]
        [DefaultValue(255)]
        [NotifyParentProperty(true)]
        [Description("The default progress bar width.  Default is 225.")]
        public virtual int ProgBarWidth
        {
            get
            {
                return this.State.Get<int>("ProgBarWidth", 255);
            }
            set
            {
                this.State.Set("ProgBarWidth", value);
            }
        }

        /// <summary>
        /// The text to display while the store is loading.  Default is 'Loading...'
        /// </summary>
        [ConfigOption]
        [Category("3. ProgressBarPager")]
        [Localizable(true)]
        [DefaultValue("Loading...")]
        [NotifyParentProperty(true)]
        [Description("The text to display while the store is loading.  Default is 'Loading...'")]
        public virtual string DefaultText
        {
            get
            {
                return this.State.Get<string>("DefaultText", "Loading...");
            }
            set
            {
                this.State.Set("DefaultText", value);
            }
        }

        //private Fx defaultAnimCfg;

        //// <summary>
        ///// The text to display while the store is loading.  Default is 'Loading...'
        ///// </summary>
        //[ClientConfig(JsonMode.Object)]
        //[Category("3. ProgressBarPager")]
        //[NotifyParentProperty(true)]
        //[Description("The text to display while the store is loading.  Default is 'Loading...'")]
        //[PersistenceMode(PersistenceMode.InnerProperty)]
        //public virtual Fx DefaultAnimCfg
        //{
        //    get
        //    {
        //        return this.State.Get<Fx>("DefaultAnimCfg", null);
        //    }
        //    set
        //    {
        //        this.State.Set("DefaultAnimCfg", value);
        //    }
        //}
    }
}
