/*********************************************************************
* Module 1. Programming Foundations
* Author: Santiago S�nchez Sobrino   Santiago.Sanchez@uclm.es
*         David Vallejo Fern�ndez    David.Vallejo@uclm.es
*
* You can redistribute and/or modify this file under the terms of the
* GNU General Public License ad published by the Free Software
* Foundation, either version 3 of the License, or (at your option)
* and later version. See <http://www.gnu.org/licenses/>.
*
* This file is distributed in the hope that it will be useful, but
* WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
* General Public License for more details.
*********************************************************************/


using UnrealBuildTool;
using System.Collections.Generic;

public class CppDesignPatternsTarget : TargetRules
{
	public CppDesignPatternsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "CppDesignPatterns" } );
	}
}
