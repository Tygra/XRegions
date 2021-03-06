﻿namespace XRegions
{
	/// <summary>
	/// Holds the plugin's permission list.
	/// </summary>
	public static class XRegionsPermissions
	{
		/// <summary>
		/// Gets the permission used to access the define command.
		/// </summary>
		public static readonly string DefineRegions = "xregions.define";

		/// <summary>
		/// Gets the permission used to modify an XRegion's actions.
		/// </summary>
		public static readonly string ModifyActions = "xregions.setaction";

		/// <summary>
		/// Gets the permission used to modify an XRegion's item ban list.
		/// </summary>
		public static readonly string ModifyBannedItems = "xregions.setbanneditems";

		/// <summary>
		/// Gets the permission used to modify an XRegion's projectile ban list.
		/// </summary>
		public static readonly string ModifyBannedProjectiles = "xregions.setbannedprojectiles";

		/// <summary>
		/// Gets the permission used to modify an XRegion's temporary group.
		/// </summary>
		public static readonly string SetRegionGroup = "xregions.setgroup";
	}
}
