﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models

{
	public class MatchupEntryModel
	{
		/// <summary>
		/// Represents one team in the matchup.
		/// </summary>
		public TeamModel TeamCompeting { get; set; }
		/// <summary>
		/// represents the score for this particular team
		/// </summary>
		public double Score { get; set; }

		/// <summary>
		/// Represents the matchthis team came from as the winner.
		/// </summary>
		public MatchupModel ParentMatchup { get; set; }
        
	

    }
}
