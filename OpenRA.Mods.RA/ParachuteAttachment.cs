#region Copyright & License Information
/*
 * Copyright 2007-2011 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made 
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using OpenRA.Traits;

namespace OpenRA.Mods.RA 
{
	class ParachuteAttachmentInfo : TraitInfo<ParachuteAttachment>
	{
		public readonly string ParachuteSprite = "parach";
		public readonly int2 Offset = new int2(0,0);
	}
	
	class ParachuteAttachment {}
}